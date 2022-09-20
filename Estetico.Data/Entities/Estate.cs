using System;
using System.Collections.Generic;
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
            Image = String.Empty;

            Address = new Address();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public virtual Address Address { get; set; }
    }
}