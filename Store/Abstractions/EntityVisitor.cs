using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Abstractions
{
    public interface EntityVisitor
    {
        void Visit(Appliances appliances);
        void Visit(Food food);
        void Visit(Beverages beverages);
        void Visit(Clothes clothes);

    }
}
