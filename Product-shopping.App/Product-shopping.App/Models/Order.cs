using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Product_shopping.App.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Amount { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public DateTime? Orderdate { get; set; }
        public DateTime? Preferencedate { get; set; }

    }
}