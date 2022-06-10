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
using FastFoodAPI.Models;

namespace FastFoodAPI.Controllers.api
{
    public class SHOPsController : ApiController
    {
        private FastFoodAppEntities1 db = new FastFoodAppEntities1();

        // GET: api/SHOPs
        public IQueryable<SHOP> GetSHOP()
        {
            return db.SHOP;
        }

        // GET: api/SHOPs/5
        [ResponseType(typeof(SHOP))]
        public IHttpActionResult GetSHOP(string id)
        {
            SHOP sHOP = db.SHOP.Find(id);
            if (sHOP == null)
            {
                return NotFound();
            }

            return Ok(sHOP);
        }

        // PUT: api/SHOPs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSHOP(string id, SHOP sHOP)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sHOP.IDShop)
            {
                return BadRequest();
            }

            db.Entry(sHOP).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SHOPExists(id))
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

        // POST: api/SHOPs
        [ResponseType(typeof(SHOP))]
        public IHttpActionResult PostSHOP(SHOP sHOP)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SHOP.Add(sHOP);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (SHOPExists(sHOP.IDShop))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = sHOP.IDShop }, sHOP);
        }

        // DELETE: api/SHOPs/5
        [ResponseType(typeof(SHOP))]
        public IHttpActionResult DeleteSHOP(string id)
        {
            SHOP sHOP = db.SHOP.Find(id);
            if (sHOP == null)
            {
                return NotFound();
            }

            db.SHOP.Remove(sHOP);
            db.SaveChanges();

            return Ok(sHOP);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SHOPExists(string id)
        {
            return db.SHOP.Count(e => e.IDShop == id) > 0;
        }
    }
}