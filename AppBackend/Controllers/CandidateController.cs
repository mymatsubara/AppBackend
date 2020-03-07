using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AppBackend.Models.DB;
using Newtonsoft.Json;

namespace AppBackend.Controllers
{
    public class CandidateController : ApiController
    {
        // GET api/candidate
        public IEnumerable<Candidate> Get()
        {
            using (LocalServerContainer dbx = new LocalServerContainer())
            {
                return dbx.Candidates.ToList();
            }
        }

        // GET api/candidate/5
        public Candidate Get(int id)
        {
            using (LocalServerContainer dbx = new LocalServerContainer())
            {
                return dbx.Candidates.Find(new object[] { id });
            }
        }

        // POST api/candidate
        public void Post([FromBody]string value)
        {
            using (LocalServerContainer dbx = new LocalServerContainer())
            {
                dbx.Candidates.Add(JsonConvert.DeserializeObject<Candidate>(value));
                dbx.SaveChanges();
            }
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            using (LocalServerContainer dbx = new LocalServerContainer())
            {
                dbx.Candidates.Remove(dbx.Candidates.Find(new object[] { id }));
                dbx.SaveChanges();
            }
        }
    }
}