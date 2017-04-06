namespace SalesInsuranceManagment
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using SalesInsuranceManagment.Models;

    public class InsManageSysDbContext : DbContext
    {
        
        public InsManageSysDbContext()
            : base("name=InsManageSysDbContext")
        {
        }

        public virtual DbSet<Agent> Agents { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Company> Companies { get; set; }

        public virtual DbSet<AgentProduct> AgentsProducts { get; set; }
    }

    
}