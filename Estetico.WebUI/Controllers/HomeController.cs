using Estetico.Data;
using Estetico.Data.Entities;
using Estetico.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Estetico.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var estates = _dbContext.Estates;

            HomePageViewModel homePageViewModel = new HomePageViewModel();

            foreach (Estate estate in estates)
            {
                PropertyViewModel propertyModel = new PropertyViewModel();
                propertyModel.ID = estate.ID;
                propertyModel.Price = estate.Price.ToString("C") + "/mo";
                propertyModel.Name = estate.Name;
                propertyModel.Address = "Villa Street, Key West, Miami";
                propertyModel.Image = estate.Image;

                homePageViewModel.Properties.Add(propertyModel);                             
            }

            return View(homePageViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
} 