using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using PhotoBoom.Controllers;
using PhotoBoom.Models.Concrete;
using PhotoBoom.Models.Repository;
using System.Collections.Generic;
using System.Linq;

namespace PhotoBoom.Test
{
  public class PhotoControllerTests
  {
    private readonly Mock<IUnitOfWork> _mockRepo;
    private readonly Mock<IWebHostEnvironment> web;
    private readonly PhotoController _controller;
    public PhotoControllerTests()
    {
      _mockRepo = new Mock<IUnitOfWork>();
      web = new Mock<IWebHostEnvironment>();
      _controller = new PhotoController(_mockRepo.Object, web.Object);
    }

    [Test]
    public void MyPhotosTest()
    {
      List<Photo> myPhotos = null;
      var mockRepository = new Mock<IUnitOfWork>();
      mockRepository.Setup(m => m.All<Photo>()).Returns(myPhotos.AsQueryable()).Verifiable();
      PhotoController photoController = new PhotoController(mockRepository.Object, web.Object);
      ViewResult result = photoController.MyPhotos() as ViewResult;
      Assert.IsNotNull(result);
      _mockRepo.Setup(repo => repo.All<Photo>())
        .Returns(new List<Photo>() { new Photo(), new Photo() }.AsQueryable());
      var resulttt = _controller.MyPhotos();
      Assert.IsNotNull(resulttt);
    }


    [Test]
    public void DetailsTest()
    {
      Photo photo = new Photo() { Id = 15, Title = "Test", ImageName = "hourglass05082021.svg" };
      var mockRepository = new Mock<IUnitOfWork>();
      mockRepository.Setup(x => x.FirstOrDefault<Photo>(x => x.Id == photo.Id)).Returns(photo).Verifiable();
      PhotoController photoController = new PhotoController(mockRepository.Object, web.Object);
      ViewResult result = photoController.Details(photo.Id) as ViewResult;
      Assert.IsNotNull(result);
    }

    [Test]
    public void DeleteTest()
    {
      var mockRepository = new Mock<IUnitOfWork>();
      PhotoController photoController = new PhotoController(mockRepository.Object, web.Object);
      ViewResult result = photoController.Delete(18) as ViewResult;
      Assert.IsNotNull(result);
    }

    [Test]
    public void AddPhotoTest()
    {
      var mockRepository = new Mock<IUnitOfWork>();
      PhotoController photoController = new PhotoController(mockRepository.Object, web.Object);
      Photo photo = new Photo
      {
        Id = 1212,
        Title = "test Title",
        ImageName = "test ImgName"
      };
      ViewResult result = photoController.AddPhoto(photo) as ViewResult;
      Assert.IsNotNull(result);
    }
  }
}