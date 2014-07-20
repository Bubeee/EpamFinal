using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Interfaces.Entities;
using Forum.Models;
using BLL;
using Ninject;

namespace Forum.Controllers
{
    public class CategoryController : ApiController
    {
        private CategoryService service;

        public CategoryController()
        {
            IKernel kernel = new StandardKernel(new ForumNinjectModule());
            service = kernel.Get<CategoryService>();
        }
        // GET api/Category
        public IQueryable<Category> GetCategories()
        {
            return service.GetAll();
        }

        // GET api/Category/5
        [ResponseType(typeof(Category))]
        public IHttpActionResult GetCategory(int id)
        {
            Category category = service.GetById(id);
            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        // PUT api/Category/5
        public IHttpActionResult PutCategory(int id, Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != category.Id)
            {
                return BadRequest();
            }

            service.Edit(category);

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST api/Category
        [ResponseType(typeof(Category))]
        public IHttpActionResult PostCategory(Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            service.Add(category);

            return CreatedAtRoute("DefaultApi", new { id = category.Id }, category);
        }

        // DELETE api/Category/5
        [ResponseType(typeof(Category))]
        public IHttpActionResult DeleteCategory(int id)
        {
            Category category = service.GetById(id);
            if (category == null)
            {
                return NotFound();
            }

            service.Delete(category);

            return Ok(category);
        }
    }
}