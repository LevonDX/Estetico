using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetico.Data.Entities
{
    [NotMapped]
    public class EntityBase
    {
        public int ID { get; set; }

        public bool Deleted { get; set; }
    }
}
