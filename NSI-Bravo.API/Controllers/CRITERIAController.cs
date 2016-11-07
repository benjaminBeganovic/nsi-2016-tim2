﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AngularJSAuthentication.API.Models;

namespace AngularJSAuthentication.API.Controllers
{
    [RoutePrefix("api/Criteria")]
    public class CRITERIAController : ApiController
    {
        private MyEntities db = new MyEntities();

        // GET: api/CRITERIA
        public IQueryable<CRITERIA> GetCRITERIA()
        {
            return db.CRITERIA;
        }

        // GET: api/CRITERIA/GetCriteria/5
       [HttpGet]
      
        [Route("GetCriteria/{id}")]
        [ResponseType(typeof(CRITERIA))]
        public IHttpActionResult GetCriteria(long id)
        {
            CRITERIA cRITERIA = db.CRITERIA.Find(id);
            if (cRITERIA == null)
            {
                return NotFound();
            }

            return Ok(cRITERIA);
        }

        // PUT: api/CRITERIA/UpdateCriteria/5
        [HttpPut]
        [Route("UpdateCriteria/{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult UpdateCriteria(long id, CRITERIA cRITERIA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cRITERIA.ID_CRITERIA)
            {
                return BadRequest();
            }
            cRITERIA.DATE_MODIFIED = DateTime.Now;
            db.Entry(cRITERIA).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CRITERIAExists(id))
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

        // POST: api/CRITERIA/PostCriteria
        [HttpPost]
        [Route("PostCriteria")]
        [ResponseType(typeof(CRITERIA))]
        public IHttpActionResult PostCriteria(CRITERIA cRITERIA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            cRITERIA.DATE_CREATED = DateTime.Now;
            db.CRITERIA.Add(cRITERIA);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (CRITERIAExists(cRITERIA.ID_CRITERIA))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = cRITERIA.ID_CRITERIA }, cRITERIA);
        }

        // DELETE: api/CRITERIA/5
        [HttpDelete]
        [Route("DeleteCriteria/{id}")]
        [ResponseType(typeof(CRITERIA))]
        public IHttpActionResult DeleteCRITERIA(long id)
        {
            CRITERIA cRITERIA = db.CRITERIA.Find(id);
            if (cRITERIA == null)
            {
                return NotFound();
            }

            db.CRITERIA.Remove(cRITERIA);
            db.SaveChanges();

            return Ok(cRITERIA);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CRITERIAExists(long id)
        {
            return db.CRITERIA.Count(e => e.ID_CRITERIA == id) > 0;
        }
    }
}