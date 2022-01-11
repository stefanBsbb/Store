using Store.Abstractions;
using Store.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models.Abstractions
{
    public abstract class IProduct
    {
        [Required]
        [StringLength(20)]
        public string? Name { get; set; }

        [Required]
        [StringLength(20)]
        public string? Brand { get; set; }

        [Required]
        [SemiInclude]
        public decimal Price { get; set; }

        [Required]
        [SemiInclude]
        [Range(0, 200)]
        public double Quantity { get; set; }

        [SemiInclude]
        public decimal TotalPrice { get; set; }


        public abstract void Accept(EntityVisitor visitor);
        public virtual int Discount()
        { return 0; }

    }
}
