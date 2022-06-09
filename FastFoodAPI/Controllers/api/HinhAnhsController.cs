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
    public class HinhAnhsController : ApiController
    {
        private FastFoodAppEntities1 db = new FastFoodAppEntities1();

        // GET: api/HinhAnhs
        public IQueryable<HinhAnh> GetHinhAnh()
        {
            return db.HinhAnh;
        }

        // GET: api/HinhAnhs/5
        [ResponseType(typeof(HinhAnh))]
        public IHttpActionResult GetHinhAnh(int id)
        {
            HinhAnh hinhAnh = db.HinhAnh.Find(id);
            if (hinhAnh == null)
            {
                return NotFound();
            }

            return Ok(hinhAnh);
        }
        [HttpGet]
        [Route("api/HinhAnhs/getImageSP")]
        public IEnumerable<HinhAnh> Get(string idSP)
        {
            return db.HinhAnh.Where(x => x.IDSP == idSP);
        }
        // PUT: api/HinhAnhs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHinhAnh(int id, HinhAnh hinhAnh)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hinhAnh.idAnh)
            {
                return BadRequest();
            }

            db.Entry(hinhAnh).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HinhAnhExists(id))
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

        // POST: api/HinhAnhs
        [ResponseType(typeof(HinhAnh))]
        public IHttpActionResult PostHinhAnh(HinhAnh hinhAnh)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.HinhAnh.Add(hinhAnh);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = hinhAnh.idAnh }, hinhAnh);
        }

        // DELETE: api/HinhAnhs/5
        [ResponseType(typeof(HinhAnh))]
        public IHttpActionResult DeleteHinhAnh(int id)
        {
            HinhAnh hinhAnh = db.HinhAnh.Find(id);
            if (hinhAnh == null)
            {
                return NotFound();
            }

            db.HinhAnh.Remove(hinhAnh);
            db.SaveChanges();

            return Ok(hinhAnh);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HinhAnhExists(int id)
        {
            return db.HinhAnh.Count(e => e.idAnh == id) > 0;
        }
    }
}