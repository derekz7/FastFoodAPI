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
        private FastFoodAppEntities1 db = new FastFoodAppEntities1();

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
        [Route("api/NguoiDungs/DangNhap")]
        public bool DangNhap(string username, string password)
        {
            NguoiDung nguoiDung = db.NguoiDung.Where(x => x.Username == username && password == x.matKhau).FirstOrDefault();
            if (nguoiDung == null)
            {
                return false;
            }
            return true;
        }



        [HttpGet]
        [Route("api/NguoiDungs/checkUsername")]
        public IHttpActionResult GetNDbyUsername(string username)
        {
            NguoiDung nguoiDung = db.NguoiDung.Where(x => x.Username == username).FirstOrDefault();
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

        [HttpGet]
        [Route("api/NguoiDungs/checkSDTexist")]
        public bool checkND(string sdt)
        {
            NguoiDung nguoiDung = db.NguoiDung.Where(x => x.SDT == sdt).FirstOrDefault();
            if (nguoiDung == null)
            {
                return false;
            }
            return true;
        }

        [HttpGet]
        [Route("api/NguoiDungs/checkUsernameExist")]
        public bool checkUsername(string username)
        {
            NguoiDung nguoiDung = db.NguoiDung.Where(x => x.Username == username).FirstOrDefault();
            if (nguoiDung == null)
            {
                return false;
            }
            return true;
        }

        // PUT: api/NguoiDungs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNguoiDung(string id, NguoiDung nguoiDung)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != nguoiDung.Username)
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

        [HttpPost]
        [Route("api/NguoiDungs/PostNguoiDung")]
        public IHttpActionResult PostNguoiDung(NguoiDung nguoiDung)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.NguoiDung.Add(nguoiDung);

            return Ok(db.SaveChanges());

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
            return db.NguoiDung.Count(e => e.Username == id) > 0;
        }
    }
}