using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PhotoBoom.Models.Concrete;
using PhotoBoom.Models.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoBoom.Controllers
{
  public class PhotoController : Controller
  {
    private readonly IUnitOfWork _unitOfWork;
    private readonly IWebHostEnvironment _hostEnvironment;

    public PhotoController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
    {
      _unitOfWork = unitOfWork;
      _hostEnvironment = hostEnvironment;
    }

    public IActionResult MyPhotos()
    {
      var myPhotos = _unitOfWork.All<Photo>();

      if (!myPhotos.Any())
      {
        ViewBag.NoPhotos = "You Don't Have Any Photos Yet :(";
        return View();
      }

      return View(myPhotos);
    }

    [HttpGet]
    public IActionResult AddPhoto()
    {
      return View();
    }

    [HttpPost]
    public IActionResult AddPhoto(Photo photo)
    {
      if (ModelState.IsValid)
      {
        //Save image to wwwroot/img
        string wwwRootPath = _hostEnvironment.WebRootPath;
        string fileName = Path.GetFileNameWithoutExtension(photo.ImageFile.FileName);
        string extension = Path.GetExtension(photo.ImageFile.FileName);
        photo.ImageName = fileName = fileName + DateTime.Now.ToString("MMddyyyy") + extension;
        string path = Path.Combine(wwwRootPath + "/img/", fileName);
        using (var fileStream = new FileStream(path, FileMode.Create))
        {
          photo.ImageFile.CopyToAsync(fileStream);
        }
        //Insert record
        _unitOfWork.Add(photo);
        _unitOfWork.Save();

        //Insert tags to tag table
        foreach (var item in photo.TagString.Split(','))
        {
          Tag tag = new Tag()
          {
            Name = item,
            PhotoId = photo.Id,
            Photo = photo
          };
          _unitOfWork.Add(tag);
          _unitOfWork.Save();
          photo.Tags.Add(tag);
        }
        return RedirectToAction(nameof(MyPhotos));
      }
      return View(photo);
    }

    public IActionResult Details(int id)
    {
      var photo = _unitOfWork.FirstOrDefaultInclude<Photo>(x =>
      x.Id == id ,x=>x.Tags);
      //for diese symbol view 
      foreach (var item in photo.Tags)
      {
        if (item == photo.Tags.Last())
          item.Name= "#" + item.Name;
        else
          item.Name = "#" + item.Name + ", ";
      }
      return View(photo);
    }

    
    public IActionResult Delete(int id)
    {
      var photo = _unitOfWork.FirstOrDefault<Photo>(x => x.Id == id);

      //delete image from wwwroot/img
      var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "img", photo.ImageName);
      if (System.IO.File.Exists(imagePath))
        System.IO.File.Delete(imagePath);
      //delete the record
      _unitOfWork.Delete(photo);
      _unitOfWork.Save();
      return RedirectToAction(nameof(MyPhotos));

    }
   
  }
}
