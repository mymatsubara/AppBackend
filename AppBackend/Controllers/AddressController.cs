using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AppBackend.Models.DB;
using AppBackend.DBControllers;
using Newtonsoft.Json;
using AppBackend.ExtendedMethods;

namespace AppBackend.Controllers
{
    public class AddressController : ApiController
    {
        private DBController _dbController = DBController.Instance;
        private Type _addressType = typeof(Address);
        // GET api/<controller>
        public IEnumerable<Address> Get()
        {
            return _dbController.Get<Address>().ToList();
        }

        // GET api/<controller>/5
        public Address Get(int id)
        {
            return _dbController.Get<Address>(new object[] { id });
        }

        // POST api/<controller>
        public void Post(HttpRequestMessage request)
        {
            _dbController.Post<Address>(request.BodyToString());
        }

        // PUT api/<controller>
        public void Put(HttpRequestMessage request)
        {
            _dbController.Update<Address>(request.BodyToString());
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            _dbController.Delete<Address>(new object[] { id });
        }
    }
}