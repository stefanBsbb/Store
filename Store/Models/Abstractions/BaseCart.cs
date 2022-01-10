using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models.Abstractions
{
    public abstract class BaseCart
    {
        public virtual List<Products> Cart { get; set; }
    }
}
