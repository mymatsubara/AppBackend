using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AppBackend.Models.DB;
using AppBackend.DBControllers;

namespace AppBackend.Controllers
{
    public class AddressController : ApiController
    {
        private DBController _dbController = DBController.Instance;
        private Type _addressType = typeof(Address);
        // GET api/<controller>
        public IEnumerable<Address> Get()
        {
            return _dbController.Get<Address>();
        }

        // GET api/<controller>/5
        public Address Get(int id)
        {
            return _dbController.Get<Address>(new object[] { id });
        }

        // POST api/<controller>
        public void Post(HttpRequestMessage request)
        {
            string requestContent = request.Content.ReadAsStringAsync().Result;
            _dbController.Post<Address>(requestContent);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            _dbController.Delete<Address>(new object[] { id });
        }
    }
}