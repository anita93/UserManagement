using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Models
{
    public class UserManagementContext : DbContext
    {
        public UserManagementContext(): base("UserManagementContext") 
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<UserManagementContext, Migrations.Configuration>("UserManagementContext"));

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

    }
}
