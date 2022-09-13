using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WAD_T2104E_NguyenVanViet_Practice.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}