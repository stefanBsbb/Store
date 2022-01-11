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
            IProduct clothe = new Clothes("T-Shirt", "BrandT", new decimal(15.99), 2, "M", "violet");
            IProduct appli = new Appliances("laptop", "BrandL", 2345, "ModelL", 1, new DateTime(2021, 03, 03), 1.125);
            IProduct food = new Food("apples", "BrandA", new decimal(1.5), 2.45, new DateTime(2022, 01, 11));
            IProduct bev = new Beverages("milk", "BrandM", new decimal(0.99), 3, new DateTime(2022, 02, 02));
            cart.AddRange(new List<IProduct> { clothe, bev, food, appli });
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
                sum = sum + item.TotalPrice;
            }
            return sum;
        }      


    }
}
