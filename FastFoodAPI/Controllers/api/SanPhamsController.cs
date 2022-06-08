using FastFoodAPI.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace FastFoodAPI.Controllers.api
{
    public class SanPhamsController : ApiController
    {
        private FastFoodAppEntities db = new FastFoodAppEntities();

        // GET: api/SanPhams
        public IQueryable<SanPham> GetSanPham()
        {
            return db.SanPham;
        }

        // GET: api/SanPhams/5
        [ResponseType(typeof(SanPham))]
        public IHttpActionResult GetSanPham(string id)
        {
            SanPham sanPham = db.SanPham.Find(id);
            if (sanPham == null)
            {
                return NotFound();
            }

            return Ok(sanPham);
        }
        
        [HttpGet]
        [Route("api/SanPhams/getSPbyName")]
        public IHttpActionResult GetSanPhambyName(string name)
        {
            SanPham sanPham = db.SanPham.Where(x => x.TenSP.Contains(name)).FirstOrDefault();
            if (sanPham == null)
            {
                return NotFound();
            }

            return Ok(sanPham);
        }

        [HttpGet]
        [Route("api/SanPhams/getSPbyDM")]
        public IEnumerable<SanPham> getSPbyDM(string idDM)
        {
       
           if(idDM == "DM001")
            {
                return db.SanPham.ToList();
            }
            else
            {
                return db.SanPham.Where(x => x.IDDanhMuc.Equals(idDM)).ToList();
            }

        }

        // PUT: api/SanPhams/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSanPham(string id, SanPham sanPham)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sanPham.IDSP)
            {
                return BadRequest();
            }

            db.Entry(sanPham).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SanPhamExists(id))
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

        // POST: api/SanPhams
        [ResponseType(typeof(SanPham))]
        public IHttpActionResult PostSanPham(SanPham sanPham)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SanPham.Add(sanPham);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (SanPhamExists(sanPham.IDSP))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = sanPham.IDSP }, sanPham);
        }

        // DELETE: api/SanPhams/5
        [ResponseType(typeof(SanPham))]
        public IHttpActionResult DeleteSanPham(string id)
        {
            SanPham sanPham = db.SanPham.Find(id);
            if (sanPham == null)
            {
                return NotFound();
            }

            db.SanPham.Remove(sanPham);
            db.SaveChanges();

            return Ok(sanPham);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SanPhamExists(string id)
        {
            return db.SanPham.Count(e => e.IDSP == id) > 0;
        }
    }
}