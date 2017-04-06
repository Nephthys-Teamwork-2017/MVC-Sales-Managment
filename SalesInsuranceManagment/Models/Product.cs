using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalesInsuranceManagment.Models
{
    public class Product
    {
        public Product()
        {
            this.AgentsProducts = new HashSet<AgentProduct>();
        }
        public int Id { get; set; }
        [MaxLength(10)]
        public string Code { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        public int CompanyId { get; set; }

        public virtual ICollection<AgentProduct> AgentsProducts { get; set; }
    }
}