

using Microsoft.EntityFrameworkCore;
using workshop.wwwapi.Models;

namespace workshop.wwwapi
{ 
    public class EmployeeContext : DbContext
    {
        private string _connectionString;

        public EmployeeContext()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString");
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Department> Departments { get; set; }


    }
}
