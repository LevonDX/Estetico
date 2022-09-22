using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetico.Data.Entities
{
    public class Estate : EntityBase
    {
        public Estate()
        {
            Name = String.Empty;
            Description = String.Empty;

            Address = new Address();
        }

        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        
        [NotMapped]
        public string? Image
        {
            get
            {
                return Path.Combine("/property-images", ID + ".jpg");
            }
        }

        public virtual Address? Address { get; set; }
    }
}