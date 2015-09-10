using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using SelfHostedWebApi.Model;

namespace SelfHostedWebApi.Controllers {

    public class PersonController : ApiController {
        private static List<Person>  _Db = new List<Person>() {
            new Person() {Id = 1,Age = 24,FirstName = "Stefan",LastName = "Weibel"},
            new Person() {Id = 2, Age = 22,FirstName = "Thea",LastName = "Weibel"},
            new Person() {Id = 3, Age = 24,FirstName = "Søren",LastName = "Larsen"}
        };

        public IEnumerable<Person> Get() {
            return _Db;            
        }
        
        public Person Get(string name) {
            return _Db.FirstOrDefault((n) => n.FirstName.Contains(name) || n.LastName.Contains(name));
        }

        public IHttpActionResult Post(Person p) {
            if(p == null) {
                return BadRequest("Argument null");
            }

            var personExists = _Db.Any(p2 => p2.Id == p.Id);
            if(personExists) {
                return BadRequest("Exists");
            }
            _Db.Add(p);
            return Ok();
        }

        public IHttpActionResult Delete(int id) {
            Person person = _Db.FirstOrDefault(p => p.Id == id);
            if(person == null) {
                return NotFound();
            }
            _Db.Remove(person);
            return Ok();
        }
    }
}
