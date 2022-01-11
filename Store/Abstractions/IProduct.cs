using Store.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models.Abstractions
{
    public abstract class IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }

        public abstract void Accept(EntityVisitor visitor);
        public virtual int Discount()
        { return 0; }

    }
}
