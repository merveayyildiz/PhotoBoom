using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using PhotoBoom.Controllers;
using PhotoBoom.Models.Concrete;
using PhotoBoom.Models.Repository;

namespace PhotoBoom.Test
{
  public class PhotoControllerTests
  {
    private readonly IWebHostEnvironment _hostEnvironment;
    private readonly IUnitOfWork _unitOfWork;
    public PhotoControllerTests(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
    {
      _unitOfWork = unitOfWork;
      _hostEnvironment = hostEnvironment;
    }

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void MyPhotosTest()
    {
      PhotoController photoController = new PhotoController(_unitOfWork, _hostEnvironment);
      ViewResult result = photoController.MyPhotos() as ViewResult;
      Assert.IsNotNull(result);
    }

    [Test]
    public void stringToTagsStringTest()
    {
      PhotoController photoController = new PhotoController(_unitOfWork, _hostEnvironment);
      var expStr = "deneme,deneme";
      var result = photoController.stringToTagsString(expStr);
      Assert.AreEqual("#deneme, #deneme",result);
    }

    [Test]
    public void DetailsTest()
    {
      PhotoController photoController = new PhotoController(_unitOfWork, _hostEnvironment);
      ViewResult result = photoController.Details(11) as ViewResult;
      Assert.AreEqual("Details", result.ViewName);
      Assert.IsNotNull(result);
    }

    [Test]
    public void DeleteTest()
    {
      PhotoController photoController = new PhotoController(_unitOfWork, _hostEnvironment);
      ViewResult result = photoController.Delete(18) as ViewResult;
      Assert.AreEqual("Delete", result.ViewName);
      Assert.IsNotNull(result);
    }

    [Test]
    public void AddPhotoTest()
    {
      PhotoController photoController = new PhotoController(_unitOfWork, _hostEnvironment);
      Photo photo = new Photo
      {
        Id = 1212,
        Title = "test Title",
        Tags="tast Tag",
        ImageName="test ImgName"
      };
      ViewResult result = photoController.AddPhoto(photo) as ViewResult;
      Assert.IsNotNull(result);
    }
  }
}