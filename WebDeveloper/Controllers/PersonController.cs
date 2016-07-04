using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;
using WebDeveloper.Model.DTO;

namespace WebDeveloper.Controllers
{
    
    [RoutePrefix("Person")]
    public class PersonController : Controller
    {
        private PersonData _person = new PersonData();

        
    
        // GET: Person
        [Route]
        public ActionResult Index()
        {
            var listPerson = _person.GetList();
         //   var a = Automapper.GetGeneric<Person, PersonModelView> (_person.GetList());
            
            return View();
        }
    }
}