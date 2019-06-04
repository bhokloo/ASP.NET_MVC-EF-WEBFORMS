namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Diagnostics;

    public partial class Model : DbContext
    {
        public Model() : base("name=DbModel")
        {
            Debug.WriteLine("*****&&&&&&&&&&%%%%%%%%%%%%%%%%######)))))))))))))0&&&&&&&&&&&&&&&&&&&");
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<Model,Configuration>());
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Managers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Debug.WriteLine("***************************");
            modelBuilder.Entity<Employee>().MapToStoredProcedures(

                    x => x.Insert(p => p.HasName("Insert"))
                          .Update(c => c.HasName("Update"))

                );

            //modelBuilder.Entity<Manager>().Map(

            //        x => x.Requires("mname").HasValue("B"));
        }
    }
}
