using System.Collections.Generic;
using System.Data.Entity;
using WebDeveloper.Model;
using WebDeveloper.Model.DTO;
using WebDeveloper.Model.Entity;

namespace WebDeveloper.DataAccess
{
    public class WebDeveloperInitializer : DropCreateDatabaseAlways<WebContextDb>
    {
        protected override void Seed(WebContextDb context)
        {
            //var persons = new List<Person>
            //{
            //    new Person { FirstName = "Juan", MiddleName = "Jose", LastName = "Perez", ModifiedDate = System.DateTime.Now.Date },
            //    new Person { FirstName = "Jose", MiddleName = "Jose", LastName = "Perez", ModifiedDate = System.DateTime.Now.Date },
            //    new Person { FirstName = "Luis", MiddleName = "Ruben", LastName = "Perez", ModifiedDate = System.DateTime.Now.Date },
            //    new Person { FirstName = "Juan", MiddleName = "Martin", LastName = "Perez", ModifiedDate = System.DateTime.Now.Date },
            //    new Person { FirstName = "Manuel", MiddleName = "", LastName = "Perez", ModifiedDate = System.DateTime.Now.Date },
            //    new Person { FirstName = "Rolando", MiddleName = "Jose", LastName = "Perez", ModifiedDate = System.DateTime.Now.Date },
            //    new Person { FirstName = "Alex", MiddleName = "Jose", LastName = "Perez", ModifiedDate = System.DateTime.Now.Date },
            //    new Person { FirstName = "Abel", MiddleName = "Jose", LastName = "Perez", ModifiedDate = System.DateTime.Now.Date },
            //    new Person { FirstName = "Javier", MiddleName = "Jose", LastName = "Perez", ModifiedDate = System.DateTime.Now.Date }
            //};
            //persons.ForEach(c => context.Person.Add(c));
            //context.SaveChanges();

            var personas = new List<Persona>
            {
                new Persona { FirstName = "Juan", MiddleName = "Jose", LastName = "Perez", ModifiedDate = System.DateTime.Now.Date, Photo= @"~/Imagenes/1.jpg" },
                new Persona { FirstName = "Jose", MiddleName = "Jose", LastName = "Perez", ModifiedDate = System.DateTime.Now.Date, Photo= @"~/Imagenes/2.jpg"},
                new Persona { FirstName = "Luis", MiddleName = "Ruben", LastName = "Perez", ModifiedDate = System.DateTime.Now.Date, Photo= @"~/Imagenes/3.jpg" },
                new Persona { FirstName = "Juan", MiddleName = "Martin", LastName = "Perez", ModifiedDate = System.DateTime.Now.Date, Photo= @"~/Imagenes/4.jpg" },
                new Persona { FirstName = "Manuel", MiddleName = "", LastName = "Perez", ModifiedDate = System.DateTime.Now.Date, Photo= @"~/Imagenes/7.jpg" },
                new Persona { FirstName = "Rolando", MiddleName = "Jose", LastName = "Perez", ModifiedDate = System.DateTime.Now.Date, Photo= @"~/Imagenes/2.jpg" },
                new Persona { FirstName = "Alex", MiddleName = "Jose", LastName = "Perez", ModifiedDate = System.DateTime.Now.Date, Photo= @"~/Imagenes/3.jpg" },
                new Persona { FirstName = "Abel", MiddleName = "Jose", LastName = "Perez", ModifiedDate = System.DateTime.Now.Date, Photo= @"~/Imagenes/4.jpg"},
                new Persona { FirstName = "Javier", MiddleName = "Jose", LastName = "Perez", ModifiedDate = System.DateTime.Now.Date, Photo= @"~/Imagenes/5.jpg" }
            };
            personas.ForEach(c => context.Persona.Add(c));
            context.SaveChanges();
        }
    }
}
