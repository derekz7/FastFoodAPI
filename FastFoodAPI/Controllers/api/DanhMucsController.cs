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
    public class DanhMucsController : ApiController
    {
        private FastFoodAppEntities1 db = new FastFoodAppEntities1();

        // GET: api/DanhMucs
        public IQueryable<DanhMuc> GetDanhMuc()
        {
            return db.DanhMuc;
        }

        // GET: api/DanhMucs/5
        [ResponseType(typeof(DanhMuc))]
        public IHttpActionResult GetDanhMuc(string id)
        {
            DanhMuc danhMuc = db.DanhMuc.Find(id);
            if (danhMuc == null)
            {
                return NotFound();
            }

            return Ok(danhMuc);
        }

        // PUT: api/DanhMucs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDanhMuc(string id, DanhMuc danhMuc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != danhMuc.IDDanhMuc)
            {
                return BadRequest();
            }

            db.Entry(danhMuc).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DanhMucExists(id))
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

        // POST: api/DanhMucs
        [ResponseType(typeof(DanhMuc))]
        public IHttpActionResult PostDanhMuc(DanhMuc danhMuc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DanhMuc.Add(danhMuc);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (DanhMucExists(danhMuc.IDDanhMuc))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = danhMuc.IDDanhMuc }, danhMuc);
        }

        // DELETE: api/DanhMucs/5
        [ResponseType(typeof(DanhMuc))]
        public IHttpActionResult DeleteDanhMuc(string id)
        {
            DanhMuc danhMuc = db.DanhMuc.Find(id);
            if (danhMuc == null)
            {
                return NotFound();
            }

            db.DanhMuc.Remove(danhMuc);
            db.SaveChanges();

            return Ok(danhMuc);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DanhMucExists(string id)
        {
            return db.DanhMuc.Count(e => e.IDDanhMuc == id) > 0;
        }
    }
}