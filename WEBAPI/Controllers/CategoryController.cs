using SOMON.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEBAPI.Controllers
{
    public class CategoryController : ApiController
    {
        private SOMONContext dc = new SOMONContext();
        public List<Category> GetCategories()
        {
            return dc.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            return dc.Categories.Where(c => c.Id == id).FirstOrDefault();
        }

        public IHttpActionResult PostTask(Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            dc.Categories.Add(category);
            dc.SaveChanges();

            return Ok(category);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dc.Dispose();
            }

            base.Dispose(disposing);
        } 
    }
}
