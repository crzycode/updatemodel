using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using fashion_store.Models;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using fashion_store.Migrations;

namespace fashion_store.Models
{

    public class DBstore : DbContext
    {
        /* protected override void OnModelCreating(DbModelBuilder modelBuilder)
         {
             Database.SetInitializer<DBstore>(null);
             base.OnModelCreating(modelBuilder);

         }*/
        public DbSet<User> Users { get; set; }
        public DbSet<Login> Logins { get; set; }
        /* public DBstore() : base("DBstore")
                   {
                       Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DBstore>());
                   }*/
        /*    protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            }*/
        /*  protected override void OnModelCreating(DbModelBuilder modelBuilder)
           {
               modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

           }*/
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DBstore, Configuration>());
        }
    }
}