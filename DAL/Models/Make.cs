using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
    public class Make
    {
        [Required]
        [StringLength(255)]
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<Product> Products { get; set; }
        public Make()
        {
            Products = new List<Product>();
        }
    }
}
