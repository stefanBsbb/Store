using Store.Abstractions;
using Store.Attributes;
using Store.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Beverages : IProduct, IExpired
    {
        [DoNotInclude]
        [Required]
        public DateTime ExpirationDate { get; set; }


        public override int Discount()
        {
            DateTime.Now.ToString("yyyy,MM,dd");
            if (this.ExpirationDate.Day == DateTime.Now.Day)
            {
                return 50;
            }
            else if (this.ExpirationDate < DateTime.Now.AddDays(5))
                return 10;
            return 0;
        }
        public override void Accept(EntityVisitor visitor)
        {
            visitor.Visit(this);
        }

        public bool Expired()
        {
            if (this.ExpirationDate < DateTime.Now)
            {
                return true;
            }
            return false;
        }

        public Beverages(string name, string brand, decimal price, double quantity, DateTime expirationDate)
        {
            this.ExpirationDate = expirationDate;
            this.Price = price;
            this.Brand = brand;
            this.Name = name;
            this.Quantity = quantity;
            this.TotalPrice = Convert.ToDecimal(Quantity) * Price;
        }
    }
}
