using Store.Abstractions;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class EntityTypeCounter : EntityVisitor
    {
        public int TotalAppliances { get; private set; }
        public int TotalBevereges { get; private set; }
        public int TotalClothes { get; private set; }
        public int TotalFood { get; private set; }


        public void Visit(Appliances appliances) { TotalAppliances++; }
        public void Visit(Beverages beverages) { TotalBevereges++; }
        public void Visit(Clothes clothes) { TotalClothes++; }
        public void Visit(Food food) { TotalFood++; }


    }
}
