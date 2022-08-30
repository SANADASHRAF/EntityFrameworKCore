using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore
{
    internal class context:DbContext
    {
        public DbSet<employee> employees { get; set; }
        public DbSet<department> departments { get; set; }
        public DbSet<branch> branches { get; set; }
        public DbSet<maneger> manegers { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Efcoree;Data Source=.");
           
            //lazy loading
            //if yoy were sure that it wont detect on performace
            //optionsBuilder.UseLazyLoadingProxies(true);

            base.OnConfiguring(optionsBuilder);
        }



        //for using flewent API
        #region flewent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<maneger>().ToTable("maneger");
            //if we have composite key
            modelBuilder.Entity<maneger>().HasKey(e => new { e.manegerid, e.date });

            //required
            modelBuilder.Entity<branch>().Property(e => e.id).IsRequired();

            //global query filter
            modelBuilder.Entity<employee>().HasQueryFilter(e => !e.deleted);
            base.OnModelCreating(modelBuilder);
        } 
        #endregion
    }
}
