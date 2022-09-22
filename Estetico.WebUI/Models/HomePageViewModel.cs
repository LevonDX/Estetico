namespace Estetico.WebUI.Models
{
    public class HomePageViewModel
    {
        public HomePageViewModel()
        {
            Properties = new List<PropertyViewModel>();
        }

        public List<PropertyViewModel> Properties { get; set; }
    }
}