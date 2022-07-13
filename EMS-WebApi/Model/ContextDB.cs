using Microsoft.EntityFrameworkCore;
using EMS_WebApi.Model;

namespace EMS_WebApi.Model
{
    public class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Salary> Salary { get; set; }
        public DbSet<Employee_Dependent> Employee_Dependent { get; set; }
        public DbSet<Employee_Skill> Employee_Skill { get; set; }
        public DbSet<Employee_Qualification> Employee_Qualification { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Admins> Admins { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Qualification> Qualification { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Employee_Salary> Employee_Salary { get; set; }


    }
}
