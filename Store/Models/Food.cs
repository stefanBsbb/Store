﻿using Store.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Food : IProduct
    {
        public DateTime ExpirationDate { get; set; }

        public string Name => throw new NotImplementedException();

        public string Brand => throw new NotImplementedException();

        public int Price => throw new NotImplementedException();

        public int Id => throw new NotImplementedException();

        int IProduct.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Food(DateTime expirationDate) 
        {
            this.ExpirationDate = expirationDate;
        }
    }
}
