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
    public class MessageController : ApiController
    {
        private MessageService service;

        public MessageController()
        {
            IKernel kernel = new StandardKernel(new ForumNinjectModule());
            service = kernel.Get<MessageService>();
        }
        // GET api/Message
        public IQueryable<Message> GetMessages()
        {
            return service.GetAll();
        }

        // GET api/Message/5
        [ResponseType(typeof(Message))]
        public IHttpActionResult GetMessage(int id)
        {
            Message message = service.GetById(id);
            if (message == null)
            {
                return NotFound();
            }

            return Ok(message);
        }

        // PUT api/Message/5
        public IHttpActionResult PutMessage(int id, Message message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != message.Id)
            {
                return BadRequest();
            }

            service.Edit(message);
            
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST api/Message
        [ResponseType(typeof(Message))]
        public IHttpActionResult PostMessage(Message message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            service.Add(message);

            return CreatedAtRoute("DefaultApi", new { id = message.Id }, message);
        }

        // DELETE api/Message/5
        [ResponseType(typeof(Message))]
        public IHttpActionResult DeleteMessage(int id)
        {
            Message message = service.GetById(id);
            if (message == null)
            {
                return NotFound();
            }

            service.Delete(message);

            return Ok(message);
        }        
    }
}