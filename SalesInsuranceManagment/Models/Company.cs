using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalesInsuranceManagment.Models
{
    public class Company
    {
        public Company()
        {
            this.Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(12)]
        public string Phone { get; set; }

        [MaxLength(25)]
        public string Email { get; set; }

        [MaxLength(300)]
        public string Notes { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}