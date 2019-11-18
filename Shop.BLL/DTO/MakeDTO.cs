using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace Shop.BLL.DTO
{
    public class MakeDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public IList<Product> Products { get; set; }
        public MakeDTO()
        {
            Products = new List<Product>();
        }
    }
}
