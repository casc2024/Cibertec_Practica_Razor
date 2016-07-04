using System.Linq;
using WebDeveloper.Model.Entity;

namespace WebDeveloper.DataAccess
{
    public class PersonaData : BaseDataAccess<Persona>
    {
        public Persona GetClientById(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Persona.FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
