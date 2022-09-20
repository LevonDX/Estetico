using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetico.Data.Entities
{
    public class City : EntityBase
    {
        public City()
        {
            Name = String.Empty;
            Country = new Country();
        }

        public string Name { get; set; }

        public virtual Country Country { get; set; }
    }
}
