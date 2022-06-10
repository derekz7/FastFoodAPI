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
    public class ChiTietDonHangsController : ApiController
    {
        private FastFoodAppEntities1 db = new FastFoodAppEntities1();

        // GET: api/ChiTietDonHangs
        public IQueryable<ChiTietDonHang> GetChiTietDonHang()
        {
            return db.ChiTietDonHang;
        }

        [HttpGet]
        [Route("api/ChiTietDonHangs/getCTdonHang")]
        public IEnumerable<ChiTietDonHang> getCTdonHang(int idDH)
        {
            var chiTietDonHang = db.ChiTietDonHang.Where(x => x.IDDonHang == idDH).ToList() ;
            if (chiTietDonHang == null)
            {
                return null;
            }

            return chiTietDonHang.ToList();
        }
        // GET: api/ChiTietDonHangs/5
        [ResponseType(typeof(ChiTietDonHang))]
        public IHttpActionResult GetChiTietDonHang(int id)
        {
            ChiTietDonHang chiTietDonHang = db.ChiTietDonHang.Find(id);
            if (chiTietDonHang == null)
            {
                return NotFound();
            }

            return Ok(chiTietDonHang);
        }

        // PUT: api/ChiTietDonHangs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutChiTietDonHang(int id, ChiTietDonHang chiTietDonHang)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != chiTietDonHang.ID)
            {
                return BadRequest();
            }

            db.Entry(chiTietDonHang).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChiTietDonHangExists(id))
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

        [Route("api/ChiTietDonHangs/PostCTDonHang")]
        public IHttpActionResult PostCTDonHang(ChiTietDonHang ctDOnHang)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            int lastindex = db.DonHang.Count() - 1;
            var Donhang = db.DonHang.ToList()[lastindex];
            ctDOnHang.IDDonHang = Donhang.ID;
            db.ChiTietDonHang.Add(ctDOnHang);
            return Ok(db.SaveChanges());
        }

        // DELETE: api/ChiTietDonHangs/5
        [ResponseType(typeof(ChiTietDonHang))]
        public IHttpActionResult DeleteChiTietDonHang(int id)
        {
            ChiTietDonHang chiTietDonHang = db.ChiTietDonHang.Find(id);
            if (chiTietDonHang == null)
            {
                return NotFound();
            }

            db.ChiTietDonHang.Remove(chiTietDonHang);
            db.SaveChanges();

            return Ok(chiTietDonHang);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ChiTietDonHangExists(int id)
        {
            return db.ChiTietDonHang.Count(e => e.ID == id) > 0;
        }
    }
}