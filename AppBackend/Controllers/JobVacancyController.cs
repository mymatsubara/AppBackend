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
            string requestContent = request.Content.ReadAsStringAsync().Result;
            _dbController.Post<JobVacancy>(requestContent);
        }

        // DELETE api/jobvacancy/5
        public void Delete(int id)
        {
            _dbController.Delete<JobVacancy>(new object[] { id });
        }
    }
}