using Store.Abstractions;
using Store.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Clothes : IProduct
    {
        [Required]
        [RegularExpression(@"^(\d*(?:M|X{0,2}[SL]))(?:$|\s+.*$)")]
        public string Size { get; set; }
        [Required]
        public string Color { get; set; }

        public override int Discount()
        {
            DayOfWeek currentDay = DateTime.Now.DayOfWeek;
            if (!(currentDay == DayOfWeek.Saturday) || !(currentDay == DayOfWeek.Sunday))
            {
                return 10;
            }
            return 0;
        }
        public override void Accept(EntityVisitor visitor)
        {
            visitor.Visit(this);
        }
        public Clothes(string name, string brand, decimal price, double quantity, string size, string color)
        {
            this.Size = size;
            this.Color = color;
            this.Brand = brand;
            this.Price = price;
            this.Name = name;
            this.Quantity = quantity;
            this.TotalPrice = Convert.ToDecimal(Quantity) * Price;
        }
    }
}
