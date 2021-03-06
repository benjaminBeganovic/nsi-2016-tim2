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
using System.Globalization;
using Newtonsoft.Json.Linq;
using AngularJSAuthentication.API.SSO;
using System.Web;

namespace AngularJSAuthentication.API.Controllers
{

    [RoutePrefix("api/CVtable")]
    public class CV_TABLEController : ApiController
    {
        private MyEntities db = new MyEntities();
        SSO.IdentityClient identity = new SSO.IdentityClient();
        AuthResponse response = new AuthResponse();

        //Route: http://localhost:26264/api/CVtable/GetAll
        [HttpGet]
        [Route("GetAll")]
        public IQueryable<CV_USER> GetCV_TABLE()
        {
            return db.CV_USER;
        }

        //Route: http://localhost:26264/api/CVtable/Get/5
        [HttpGet]
        [Route("Get/{id}")]
        [ResponseType(typeof(CV_USER))]
        public IHttpActionResult GetCV_TABLE(long id)
        {
            CV_USER cV_TABLE = db.CV_USER.Find(id);
            if (cV_TABLE == null)
            {
                return NotFound();
            }

            return Ok(cV_TABLE);
        }

        //Route: http://localhost:26264/api/CVtable/Update/5
        [HttpPut]
        [Route("Update/{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCV_TABLE(long id, CV_USER cV_TABLE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cV_TABLE.ID)
            {
                return BadRequest();
            }

            db.Entry(cV_TABLE).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CV_TABLEExists(id))
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

        //Route: http://localhost:26264/api/CVtable/Create
        [HttpPost]
        [Route("Create")]
        [ResponseType(typeof(CV_USER))]
        public IHttpActionResult PostCV_TABLE(CV_USER cV_TABLE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CV_USER.Add(cV_TABLE);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (CV_TABLEExists(cV_TABLE.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Ok(cV_TABLE);
            //return CreatedAtRoute("DefaultApi", new { id = cV_TABLE.ID_CV }, cV_TABLE);
        }

        //Route: http://localhost:26264/api/CVtable/Delete/5
        [HttpDelete]
        [Route("Delete/{id}")]
        [ResponseType(typeof(CV_USER))]
        public IHttpActionResult DeleteCV_TABLE(long id)
        {
            CV_USER cV_TABLE = db.CV_USER.Find(id);
            if (cV_TABLE == null)
            {
                return NotFound();
            }

            db.CV_USER.Remove(cV_TABLE);
            db.SaveChanges();

            return Ok(cV_TABLE);
        }
        //Route: http://localhost:26264/api/CVtable/Delete/5
        //Returns sum of CV_ITEM points(CV_ITEM.CRITERIA_ID_CRITERIA.POINTS)
        [HttpGet]
        [Route("Score/{id}")]
        [ResponseType(typeof(int))]
        public IHttpActionResult GetScore(long id)
        {
            if (HttpContext.Current.Request.Cookies.AllKeys.Contains("sid"))
            {
                try
                {
                    response = identity.Auth(HttpContext.Current.Request.Cookies.Get("sid").Value);
                }
                catch
                {
                    return BadRequest("Invalid token. Login in again!");
                }
                //if (!(response.Roles.Contains("CV_ADMIN") || response.Roles.Contains("ADMIN")))
                   // return BadRequest("You are not authorized for this action");
            }
            else
            {

                return BadRequest("You are not logged in. Please login and try again.");
            }

            int score = 0;
            try
            {
                //first find all CV_ITEMs with CV_TABLE_ID_CV==id, than sum points of criteria in all CV_ITEMs
                if(db.CV_ITEM.Where(o => o.CV_TABLE_ID_CV == id && o.CV_ITEM_STATUS.STATUS == "confirmed").Count()>0)
                    score = (int)db.CV_ITEM.Where(o => o.CV_TABLE_ID_CV == id && o.CV_ITEM_STATUS.STATUS == "confirmed").Sum(o => o.CRITERIA.POINTS);
            }
            catch (Exception)
            {
                return BadRequest("Error");
            }

            return Ok(score);
        }

        [HttpPost]
        [Route("GetByDateRange/{id}")]
        [ResponseType(typeof(List<CV_ITEM>))]
        public IHttpActionResult GetByDateRange([FromUri()]int id, [FromBody()] JObject dateRange)
        {
            List<CV_ITEM> items;
            DateTime from = (DateTime) dateRange.GetValue("from");
            DateTime to = (DateTime) dateRange.GetValue("to");
            try {
                 items = db.CV_ITEM.Where(c => c.CV_TABLE_ID_CV == id && c.DATE_CREATED >= from && c.DATE_CREATED <= to).ToList();
            }
            catch(Exception e)
            {
                return InternalServerError(e);
            }

         
            return Ok(items);
        }

        // Vraca sve profesore
        [HttpGet]
        [Route("GetAllProfessors")]
        public IHttpActionResult GetAllProfessors()
        {
            List<CV_USER> lista;
            try
            {
                lista = db.CV_USER.OrderBy(u => u.ID).ToList();
            }
            catch (Exception e) {
                return InternalServerError(e);
            }
            return Ok(lista);
        }

        [HttpPost]
        [Route("GetMyHistory")]
        [ResponseType(typeof(List<CV_ITEM>))]
        public IHttpActionResult GetMyHistory(HISTORY dateRange)
        {
            if (HttpContext.Current.Request.Cookies.AllKeys.Contains("sid"))
            {
                try
                {
                    response = identity.Auth(HttpContext.Current.Request.Cookies.Get("sid").Value);
                }
                catch
                {
                    return BadRequest("Invalid token. Login in again!");
                }
            }
            else
            {

                return BadRequest("You are not logged in. Please login and try again.");
            }

            var id = response.UserId;
            List<CV_ITEM> items;
            DateTime from = (DateTime)dateRange.from;
            DateTime to = (DateTime)dateRange.to;
            try
            {
                items = db.CV_ITEM.Where(c => c.CV_TABLE_ID_CV == id && c.DATE_CREATED >= from && c.DATE_CREATED <= to).ToList();
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }


            return Ok(items);
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CV_TABLEExists(long id)
        {
            return db.CV_USER.Count(e => e.ID == id) > 0;
        }
    }
}