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
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class sysdiagramsController : ApiController
    {
        private SourceNetEntities db = new SourceNetEntities();

        // GET: api/sysdiagrams
        public IQueryable<sysdiagram> Getsysdiagrams()
        {
            return db.sysdiagrams;
        }

        // GET: api/sysdiagrams/5
        [ResponseType(typeof(sysdiagram))]
        public IHttpActionResult Getsysdiagram(int id)
        {
            sysdiagram sysdiagram = db.sysdiagrams.Find(id);
            if (sysdiagram == null)
            {
                return NotFound();
            }

            return Ok(sysdiagram);
        }

        // PUT: api/sysdiagrams/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putsysdiagram(int id, sysdiagram sysdiagram)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sysdiagram.diagram_id)
            {
                return BadRequest();
            }

            db.Entry(sysdiagram).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!sysdiagramExists(id))
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

        // POST: api/sysdiagrams
        [ResponseType(typeof(sysdiagram))]
        public IHttpActionResult Postsysdiagram(sysdiagram sysdiagram)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.sysdiagrams.Add(sysdiagram);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = sysdiagram.diagram_id }, sysdiagram);
        }

        // DELETE: api/sysdiagrams/5
        [ResponseType(typeof(sysdiagram))]
        public IHttpActionResult Deletesysdiagram(int id)
        {
            sysdiagram sysdiagram = db.sysdiagrams.Find(id);
            if (sysdiagram == null)
            {
                return NotFound();
            }

            db.sysdiagrams.Remove(sysdiagram);
            db.SaveChanges();

            return Ok(sysdiagram);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool sysdiagramExists(int id)
        {
            return db.sysdiagrams.Count(e => e.diagram_id == id) > 0;
        }
    }
}