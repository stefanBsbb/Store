using Store.Abstractions;
using Store.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Beverages : IProduct
    {
        public DateTime ExpirationDate { get; set; }


        public override int Discount()
        {
            if (this.ExpirationDate < DateTime.Now.AddDays(5))
            {
                return 10;
            }
            else if (this.ExpirationDate == DateTime.Now)
                return 50;
            return 0;
        }
        public override void Accept(EntityVisitor visitor)
        {
            visitor.Visit(this);
        }
        public Beverages(string name, string brand, decimal price, DateTime expirationDate)
        {
            this.ExpirationDate = expirationDate;
            this.Price = price;
            this.Brand = brand;
            this.Name = name;
        }
    }
}
