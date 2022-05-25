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
    public class NguoiDungsController : ApiController
    {
        private FastFoodAppEntities db = new FastFoodAppEntities();

        // GET: api/NguoiDungs
        public IQueryable<NguoiDung> GetNguoiDung()
        {
            return db.NguoiDung;
        }

        // GET: api/NguoiDungs/5
        [ResponseType(typeof(NguoiDung))]
        public IHttpActionResult GetNguoiDung(string id)
        {
            NguoiDung nguoiDung = db.NguoiDung.Find(id);
            if (nguoiDung == null)
            {
                return NotFound();
            }

            return Ok(nguoiDung);
        }

        [HttpGet]
        [Route("api/NguoiDungs/check")]
        public IHttpActionResult GetNDLogin(string email, string sdt, string password)
        {
            NguoiDung nguoiDung = db.NguoiDung.Where(x => x.Email == email && password == x.matKhau || x.SDT == sdt && password == x.matKhau).FirstOrDefault();
            if(nguoiDung == null)
            {
                return NotFound();
            }
            return Ok(nguoiDung);
        }

        [HttpGet]
        [Route("api/NguoiDungs/checkemail")]
        public IHttpActionResult GetNDbyEmail(string email)
        {
            NguoiDung nguoiDung = db.NguoiDung.Where(x => x.Email == email).FirstOrDefault();
            if (nguoiDung == null)
            {
                return NotFound();
            }
            return Ok(nguoiDung);
        }

        [HttpGet]
        [Route("api/NguoiDungs/checksdt")]
        public IHttpActionResult GetNDbySDT(string sdt)
        {
            NguoiDung nguoiDung = db.NguoiDung.Where(x => x.SDT == sdt).FirstOrDefault();
            if (nguoiDung == null)
            {
                return NotFound();
            }
            return Ok(nguoiDung);
        }

        // PUT: api/NguoiDungs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNguoiDung(string id, NguoiDung nguoiDung)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != nguoiDung.ID)
            {
                return BadRequest();
            }

            db.Entry(nguoiDung).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NguoiDungExists(id))
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

        // POST: api/NguoiDungs
        [ResponseType(typeof(NguoiDung))]
        public IHttpActionResult PostNguoiDung(NguoiDung nguoiDung)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.NguoiDung.Add(nguoiDung);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (NguoiDungExists(nguoiDung.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = nguoiDung.ID }, nguoiDung);
        }

        // DELETE: api/NguoiDungs/5
        [ResponseType(typeof(NguoiDung))]
        public IHttpActionResult DeleteNguoiDung(string id)
        {
            NguoiDung nguoiDung = db.NguoiDung.Find(id);
            if (nguoiDung == null)
            {
                return NotFound();
            }

            db.NguoiDung.Remove(nguoiDung);
            db.SaveChanges();

            return Ok(nguoiDung);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NguoiDungExists(string id)
        {
            return db.NguoiDung.Count(e => e.ID == id) > 0;
        }
    }
}