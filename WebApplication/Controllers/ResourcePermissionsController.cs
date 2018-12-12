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
    public class ResourcePermissionsController : ApiController
    {
        private SourceNetEntities db = new SourceNetEntities();

        // GET: api/ResourcePermissions
        public IQueryable<ResourcePermission> GetResourcePermissions()
        {
            return db.ResourcePermissions;
        }

        // GET: api/ResourcePermissions/5
        [ResponseType(typeof(ResourcePermission))]
        public IHttpActionResult GetResourcePermission(int id)
        {
            ResourcePermission resourcePermission = db.ResourcePermissions.Find(id);
            if (resourcePermission == null)
            {
                return NotFound();
            }

            return Ok(resourcePermission);
        }

        // PUT: api/ResourcePermissions/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutResourcePermission(int id, ResourcePermission resourcePermission)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != resourcePermission.ResourcePermisCode)
            {
                return BadRequest();
            }

            db.Entry(resourcePermission).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResourcePermissionExists(id))
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

        // POST: api/ResourcePermissions
        [ResponseType(typeof(ResourcePermission))]
        public IHttpActionResult PostResourcePermission(ResourcePermission resourcePermission)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ResourcePermissions.Add(resourcePermission);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = resourcePermission.ResourcePermisCode }, resourcePermission);
        }

        // DELETE: api/ResourcePermissions/5
        [ResponseType(typeof(ResourcePermission))]
        public IHttpActionResult DeleteResourcePermission(int id)
        {
            ResourcePermission resourcePermission = db.ResourcePermissions.Find(id);
            if (resourcePermission == null)
            {
                return NotFound();
            }

            db.ResourcePermissions.Remove(resourcePermission);
            db.SaveChanges();

            return Ok(resourcePermission);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ResourcePermissionExists(int id)
        {
            return db.ResourcePermissions.Count(e => e.ResourcePermisCode == id) > 0;
        }
    }
}