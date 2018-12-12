using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ResourcesController : ApiController
    {
        private SourceNetEntities db = new SourceNetEntities();

        // GET: api/Resources
        public IQueryable<Resource> GetResources()
        {
            return db.Resources;
        }

        // GET: api/Resources/5
        [ResponseType(typeof(Resource))]
        public IHttpActionResult GetResource(int id)
        {
            Resource resource = db.Resources.Find(id);
            if (resource == null)
            {
                return NotFound();
            }

            return Ok(resource);
        }

        // PUT: api/Resources/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutResource(int id, Resource resource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != resource.resourceCode)
            {
                return BadRequest();
            }

            db.Entry(resource).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResourceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Resources
        [ResponseType(typeof(Resource))]
        public IHttpActionResult PostResource(Resource resource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Resources.Add(resource);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = resource.resourceCode }, resource);
        }

        // DELETE: api/Resources/5
        [ResponseType(typeof(Resource))]
        public IHttpActionResult DeleteResource(int id)
        {
            Resource resource = db.Resources.Find(id);
            if (resource == null)
            {
                return NotFound();
            }

            db.Resources.Remove(resource);
            db.SaveChanges();

            return Ok(resource);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ResourceExists(int id)
        {
            return db.Resources.Count(e => e.resourceCode == id) > 0;
        }
    }
}