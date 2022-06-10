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
    public class DonHangsController : ApiController
    {
        private FastFoodAppEntities1 db = new FastFoodAppEntities1();

        // GET: api/DonHangs
        public IQueryable<DonHang> GetDonHang()
        {
            return db.DonHang;
        }

        // GET: api/DonHangs/5
        [ResponseType(typeof(DonHang))]
        public IHttpActionResult GetDonHang(int id)
        {
            DonHang donHang = db.DonHang.Find(id);
            if (donHang == null)
            {
                return NotFound();
            }

            return Ok(donHang);
        }

        // PUT: api/DonHangs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDonHang(int id, DonHang donHang)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != donHang.ID)
            {
                return BadRequest();
            }

            db.Entry(donHang).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DonHangExists(id))
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

        // POST: api/DonHangs
        [Route("api/DonHangs/PostDonHang")]
        public IHttpActionResult PostDonHang(DonHang donHang)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DonHang.Add(donHang);

            return Ok(db.SaveChanges());
        }

        // DELETE: api/DonHangs/5
        [ResponseType(typeof(DonHang))]
        public IHttpActionResult DeleteDonHang(int id)
        {
            DonHang donHang = db.DonHang.Find(id);
            if (donHang == null)
            {
                return NotFound();
            }

            db.DonHang.Remove(donHang);
            db.SaveChanges();

            return Ok(donHang);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DonHangExists(int id)
        {
            return db.DonHang.Count(e => e.ID == id) > 0;
        }
    }
}