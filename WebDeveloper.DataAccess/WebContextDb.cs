using System.Data.Entity;
using WebDeveloper.Model;
using WebDeveloper.Model.DTO;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebDeveloper.Model.Entity;

namespace WebDeveloper.DataAccess
{
    public class WebContextDb :DbContext
    {
        public WebContextDb() : base("name=WebDeveloperConnectionString") {
            Database.SetInitializer(new WebDeveloperInitializer());
        }

        //public DbSet<Person> Person { get; set; }
        public DbSet<Persona> Persona { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
