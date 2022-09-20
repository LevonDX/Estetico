using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetico.Data.Entities
{
    public class Address : EntityBase
    {
        public Address()
        {
            Street = String.Empty;
            Number = String.Empty;
            
            City = new City();
        }

        public string Street { get; set; }
        public string Number { get; set; }

        public virtual City City { get; set; }
    }
}
