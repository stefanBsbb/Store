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
        public string ProductionDate { get; set; }
        public string Weight { get; set; }



        public Appliances(string weight, string productionDate, string model, string name, int id, int price, string brand) 
        {
            this.Weight = weight;
            this.ProductionDate = productionDate;
            this.Model = model;
            this.Price = price;
            this.Name = name;
            this.Id = id;
        }
    }
}
