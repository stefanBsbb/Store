using Store.Abstractions;
using Store.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models.Abstractions
{
    public abstract class IProduct
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        [SemiInclude]
        public decimal Price { get; set; }
        [SemiInclude]
        public double Quantity { get; set; }

        [SemiInclude]
        public decimal TotalPrice { get; set; }


        public abstract void Accept(EntityVisitor visitor);
        public virtual int Discount()
        { return 0; }

    }
}
