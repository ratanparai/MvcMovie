using System;
using Xunit;
using MvcMovie.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Test.Controllers
{
    public class HomeControllerTests
    {
        private readonly HomeController _homeController;
        public HomeControllerTests() 
        {
            _homeController = new HomeController();
        }

        [Fact]
        public void Index()
        {
            var result = _homeController.Index() as IActionResult;
            Assert.NotNull(result);

        }

        [Fact]
        public void About() 
        {
            var result = _homeController.About() as ViewResult;
            Assert.Equal("Your application description page." , result.ViewData["Message"]) ;
        }

    }
}
