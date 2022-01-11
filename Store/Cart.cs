using Store.Models;
using Store.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Cart : BaseCart
    {
        public override List<IProduct> cart { get; set; } = new List<IProduct>();

        public void AddItems()
        {
            Clothes clothe = new Clothes("T-Shirt", "BrandT", new decimal(15.99), "M", "violet");
            Appliances appli = new Appliances("laptop", "BrandL", 2345, "ModelL", new DateTime(2021, 03, 03), 1.125);
            Food food = new Food("apples", "BrandA", new decimal(1.5), new DateTime(2022, 01, 11));
            Beverages bev = new Beverages("milk", "BrandM", new decimal(0.99), new DateTime(2022, 02, 02));

            cart.AddRange(new List<IProduct> { clothe, clothe, bev, bev, bev, food, food, appli });
        }

        public DateTime GetPurchaseDate()
        {
            return DateTime.Now;
        }

        public decimal TotalSum()
        {
            decimal sum = 0;
            foreach (var item in cart)
            {
                sum = sum + item.Price;
            }
            return sum;
        }
        public double TotalDiscount() 
        {
            double totalDiscount = 0;
            var uniqueItemsList = cart.Distinct().ToList();
            foreach (var item in uniqueItemsList)
            {
                double a = Decimal.ToDouble(item.Price);
                double b = Convert.ToDouble(item.Discount());
                if (item.Discount() > 0)
                {
                    totalDiscount = a * (b/100);
                }
            }
            return totalDiscount;
        }

    }
}
