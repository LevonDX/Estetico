namespace Estetico.WebUI.Models
{
    public class PropertyViewModel
    {
        public PropertyViewModel()
        {
            Name = String.Empty;
            Address = String.Empty;
        }
        
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string? Image { get; set; }
        public string Price { get; set; }
    }
}
