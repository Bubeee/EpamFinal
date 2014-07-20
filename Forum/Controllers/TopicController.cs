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
    public class TopicController : ApiController
    {
        private TopicService service;

        public TopicController()
        {
            IKernel kernel = new StandardKernel(new ForumNinjectModule());
            service = kernel.Get<TopicService>();
        }

        // GET api/Topic
        public IQueryable<Topic> GetTopics()
        {
            return service.GetAll();
        }

        // GET api/Topic/5
        [ResponseType(typeof(Topic))]
        public IHttpActionResult GetTopic(int id)
        {
            Topic topic = service.GetById(id);
            if (topic == null)
            {
                return NotFound();
            }

            return Ok(topic);
        }

        // PUT api/Topic/5
        public IHttpActionResult PutTopic(int id, Topic topic)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != topic.Id)
            {
                return BadRequest();
            }

            service.Edit(topic);
            
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST api/Topic
        [ResponseType(typeof(Topic))]
        public IHttpActionResult PostTopic(Topic topic)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            service.Add(topic);

            return CreatedAtRoute("DefaultApi", new { id = topic.Id }, topic);
        }

        // DELETE api/Topic/5
        [ResponseType(typeof(Topic))]
        public IHttpActionResult DeleteTopic(int id)
        {
            Topic topic = service.GetById(id);
            if (topic == null)
            {
                return NotFound();
            }

            service.Delete(topic);

            return Ok(topic);
        }        
    }
}