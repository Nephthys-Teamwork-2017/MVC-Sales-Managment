using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SalesInsuranceManagment.Models
{
    public class AgentProduct
    {
        [Key, Column(Order = 0)]
        public int AgentId { get; set; }
        [Key, Column(Order = 1)]
        public int ProductId { get; set; }


        public decimal Comission { get; set; }
    }
}