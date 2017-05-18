using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using productapp.Models;




namespace productapp.Controllers
{
    public class ProductsController : ApiController
    {
        public Product[] products= new Product[3];


        public ProductsController()
        {
            products[0] = new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 };
            products[1] = new Product { Id = 2, Name = "Yo-Yo", Category = "Toys", Price = 3.75M };
            products[2] = new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M };

           
        }

        public IEnumerable<Product> GetAllProducts()
        {

            return products;
        }


        public IHttpActionResult GetProduct(int ID)
        {
            var ptemp = from item in products where item.Id == ID && item != null select item;




            //var p = products.FirstOrDefault(x => x.Id == ID);

            if (ptemp.Count() ==0)
                return this.NotFound();
            else
            {
                Product p = ptemp.FirstOrDefault();
                return Ok(p);
            }


            
        }


    }
}
