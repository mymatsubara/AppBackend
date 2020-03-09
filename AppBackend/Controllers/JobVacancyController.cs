using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AppBackend.DBControllers;
using AppBackend.ExtendedMethods;
using AppBackend.Models.DB;

namespace AppBackend.Controllers
{
    public class JobVacancyController : ApiController
    {
        private DBController _dbController = DBController.Instance;
        // GET api/jobvacancy
        public IEnumerable<JobVacancy> Get()
        {
            return _dbController.Get<JobVacancy>();
        }

        // GET api/jobvacancy/5
        public JobVacancy Get(int id)
        {
            return _dbController.Get<JobVacancy>(new object[] { id });
        }

        // POST api/jobvacancy
        public void Post(HttpRequestMessage request)
        {
            _dbController.Post<JobVacancy>(request.BodyToString());
        }

        // PUT api/jobvacancy
        public void Put(HttpRequestMessage request)
        {
            _dbController.Update<JobVacancy>(request.BodyToString());
        }

        // DELETE api/jobvacancy/5
        public void Delete(int id)
        {
            _dbController.Delete<JobVacancy>(new object[] { id });
        }
    }
}