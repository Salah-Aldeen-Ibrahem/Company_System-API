using Company_CaseStudy.Models;
using Microsoft.EntityFrameworkCore;

namespace Company_CaseStudy.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Empolyee> Empolyees { get; set; }
        public DbSet<Department> Departmentes { get; set; }
        public DbSet<Contractet> Contracts { get; set; }
        public DbSet<Project> Projects { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empolyee>()
                .HasOne(c => c.Contract)
                .WithOne(e => e.Empolyee)
                .HasForeignKey<Contractet>(f => f.EmployeeId);
            modelBuilder.Entity<Empolyee>()
                .HasOne(d => d.Department)
                .WithMany(e => e.Empolyes)
                .HasForeignKey(f => f.DepId);


            modelBuilder.Entity<Department>()
                .HasData(
                new Department { Id = 1 , Name = "HR" , Location = "Cairo"},
                new Department { Id = 2 , Name = "IT" , Location = "October"},
                new Department { Id = 3 , Name = "Finance" , Location = "Fayoum" },
                new Department { Id = 4 , Name = "R&D" , Location = "Matria"}
                );
            modelBuilder.Entity<Project>()
                .HasData(

                  new Project
                  {
                      Id = 1,
                      ProjectName = "Employee Management System",
                      Budget = 50000,
                      StartDate = new DateTime(2025, 1, 10),
                      EndDate = new DateTime(2025, 6, 15)
        
                  },
                  new Project
                  {
                      Id = 2,
                      ProjectName = "Website Revamp",
                      Budget = 120000,
                      StartDate = new DateTime(2025, 2, 1),
                      EndDate = new DateTime(2025, 8, 30)
                     
                  },
                  new Project
                  {
                      Id = 3,
                      ProjectName = "Accounting Automation",
                      Budget = 75000,
                      StartDate = new DateTime(2025, 3, 5),
                      EndDate = new DateTime(2025, 9, 10)
                     
                  },
                  new Project
                  {
                      Id = 4,
                      ProjectName = "AI Research Initiative",
                      Budget = 200000,
                      StartDate = new DateTime(2025, 4, 1),
                      EndDate = new DateTime(2025, 12, 31)
                    
                  },
                  new Project
                  {
                      Id = 5,
                      ProjectName = "Cybersecurity Upgrade",
                      Budget = 100000,
                      StartDate = new DateTime(2025, 5, 20),
                      EndDate = new DateTime(2025, 10, 20)
                     
                  }
                );
        }
     
    }
}
