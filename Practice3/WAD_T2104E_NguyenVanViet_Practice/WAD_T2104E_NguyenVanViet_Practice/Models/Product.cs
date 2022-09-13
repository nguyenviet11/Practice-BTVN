using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WAD_T2104E_NguyenVanViet_Practice.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}