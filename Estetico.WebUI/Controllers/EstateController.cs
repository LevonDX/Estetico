using Estetico.Data;
using Estetico.Data.Entities;
using Estetico.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Estetico.WebUI.Controllers
{
    public class EstateController : Controller
    {
        private readonly ApplicationDbContext _DbContext;

        public EstateController(ApplicationDbContext dbContext)
        {
            _DbContext = dbContext;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> SingleProperty(int ID)
        {
           Estate? estate = await _DbContext.Estates.FindAsync(ID);

            PropertyViewModel model = new PropertyViewModel()
            {
                Name = estate.Name,
                Address = "Villa Street, Key West, Miami",
                Image = estate.Image,
                Price = estate.Price.ToString("C"),
                ID = estate.ID
            };
            
            
            return View(model);
        }
    }
}
