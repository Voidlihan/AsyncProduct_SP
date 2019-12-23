using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProducts
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public Guid Category { get; set; }
        public int Price { get; set; }
    }
}
