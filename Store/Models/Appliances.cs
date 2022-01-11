using Store.Abstractions;
using Store.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Appliances : IProduct
    {
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public double Weight { get; set; }


        public override int Discount()
        {
            DayOfWeek currentDay = DateTime.Now.DayOfWeek;
            if (this.Price > 999 && (currentDay == DayOfWeek.Saturday || currentDay == DayOfWeek.Sunday))
            {
                return 5;
            }
            return 0;
        }

        public override void Accept(EntityVisitor visitor)
        {
            visitor.Visit(this);
        }

        public Appliances(string name, string brand, decimal price, string model, DateTime productionDate, double weight)
        {
            this.Weight = weight;
            this.ProductionDate = productionDate;
            this.Model = model;
            this.Price = price;
            this.Brand = brand;
            this.Name = name;
        }
    }
}
