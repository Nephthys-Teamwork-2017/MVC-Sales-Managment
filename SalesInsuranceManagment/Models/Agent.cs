using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalesInsuranceManagment.Models
{
    public class Agent
    {
        public Agent()
        {
            this.AgentsProducts = new HashSet<AgentProduct>();
        }
        public int Id { get; set; }


        [MaxLength(10)]
        public string Code { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(15)]
        public string Phone { get; set; }

        public string Mail { get; set; }

        public virtual ICollection<AgentProduct> AgentsProducts { get; set; }
    }
}