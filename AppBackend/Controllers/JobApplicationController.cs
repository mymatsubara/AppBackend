using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AppBackend.DBControllers;
using AppBackend.Models.DB;

namespace AppBackend.Controllers
{
    public class JobApplicationController : ApiController
    {
        private DBController _dbController = DBController.Instance;
        // GET api/jobapplication
        public IEnumerable<JobApplication> Get()
        {
            return _dbController.Get<JobApplication>();
        }

        // GET api/jobapplication/5
        public JobApplication Get(int id)
        {
            return _dbController.Get<JobApplication>(new object[] { id });
        }

        // POST api/jobapplication
        public void Post(HttpRequestMessage request)
        {
            string requestContent = request.Content.ReadAsStringAsync().Result;
            _dbController.Post<JobApplication>(requestContent);
        }

        // DELETE api/jobapplication/5
        public void Delete(int id)
        {
            _dbController.Delete<JobApplication>(new object[] { id });
        }
    }
}