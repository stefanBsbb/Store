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
        public override List<Products> cart { get; set; } = new List<Products>();
    } 
}
