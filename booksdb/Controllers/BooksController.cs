using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using booksdb.Models;

namespace booksdb.Controllers
{
    
    public class BooksController : ApiController
    {
        BooksEntities db = new BooksEntities();
        List<Author> authors = new List<Author>();
        List<Author> authorsstr = new List<Author>();
        //DbContext
        // GET: api/Books

        //[Route("api/Books/Getall")]
        //[ActionName("Getall")]
        public IEnumerable<Author> Getall()
        {
            
         
            foreach (var item in db.Authors)
            {
               // jsonObject.FirstName = item.FirstName;
               // jsonObject.LastTime = item.LastName;

                authorsstr.Add(item);
                
            }


            return db.Authors.ToList(); ;
        }

        [HttpPost]
        //[Route("api/Books/PostPerson")]
         
        public string PostPerson(Person person)
        {
            
            db.Authors.Add(new Author { FirstName = person.fname, LastName = person.lname });
            db.SaveChanges();
            return "ok";
        }


        //string json = person.ToString(Newtonsoft.Json.Formatting.None);
        //RootObject p2 = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(json);
        //JsonSerializer serializer = new JsonSerializer();
        //RootObject p3 = (RootObject)serializer.Deserialize(new JTokenReader(person), typeof(RootObject));

        //[Route("api/Books/addauthor")]
        // [HttpPost]
        //void addauthor(RootObject json)
        //{
        //    //RootObject oMycustomclassname = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(json);

        //    db.Authors.Add(new Author { FirstName=json.fname, LastName=json.lname} );





        //}

        // GET: api/Books/5
        public Author Get(int id)
        {
            Author author = db.Authors.FirstOrDefault(x => x.AuthorID == id);
            if (author==null)
            {

            }
            return author;
        }

      
    }
}
