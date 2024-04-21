using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Butce.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Butce.DataAccessLayer.Concrete
{
    public class ButceContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= ");
        }
        public DbSet<AppControl> AppControls { get; set; }
        public DbSet<Approval> Approvals { get; set; }
        public DbSet<Budget> Budgets{ get; set; }
        public DbSet<Investment> Investments { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<MainCode> MainCodes { get; set; }
        public DbSet<MaintenanceandRepair> MaintenanceandRepairs { get; set; }
        public DbSet<Personal> Personals { get; set; }
        public DbSet<Planning> Plannings { get; set; }
        public DbSet<Proxy> Proxies { get; set; }
        public DbSet<Realization> Realizations  { get; set; }
        public DbSet<Refuse> Refuses { get; set; }
        public DbSet<Roles> Roless { get; set; }

    }
}
