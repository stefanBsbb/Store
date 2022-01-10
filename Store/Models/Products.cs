using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public  class Products
    {
        public Appliances Appliances { get; set; }
        public Clothes Clothes { get; set; }
        public Beverages Beverages { get; set; }
        public Food Food { get; set; }
    }
}
