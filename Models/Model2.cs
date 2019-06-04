using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Model2 : DbContext
    {
        public Model2() : base("name=demoEntities2")
        {

        }

        public DbSet<MyHoney1222> MyHoney1222s { get; set; }
        public DbSet<MyHoney> MyHoneys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MyHoney1222>().Map(

                    x => x.Requires("b").HasValue(1)).Ignore(x => x.b);


            modelBuilder.Entity<MyHoney1222>().MapToStoredProcedures();

            //modelBuilder.Entity<MyHoney>().HasRequired(e => e.manofall).WithMany().HasForeignKey(m => m.manid);

            //    x => x.Update(y => y.HasName("update"))
            //);
            base.OnModelCreating(modelBuilder);
          }

    }

}