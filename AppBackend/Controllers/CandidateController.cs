using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AppBackend.Models.DB;
using Newtonsoft.Json;
using AppBackend.DBControllers;
using System.Web;
using AppBackend.ExtendedMethods;

namespace AppBackend.Controllers
{
    public class CandidateController : ApiController
    {
        private DBController _dbController = DBController.Instance;
        // GET api/candidate
        public IEnumerable<Candidate> Get()
        {
            return _dbController.Get<Candidate>();
        }

        // GET api/candidate/5
        public Candidate Get(int id)
        {
            return _dbController.Get<Candidate>(new object[] { id });
        }

        // POST api/candidate
        public void Post(HttpRequestMessage request)
        {
            _dbController.Post<Candidate>(request.BodyToString());
        }

        // PUT api/candidate
        public void Put(HttpRequestMessage request)
        {
            _dbController.Update<Candidate>(request.BodyToString());
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            _dbController.Delete<Candidate>(new object[] { id });
        }
    }
}