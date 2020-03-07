using System.Collections.Generic;
using System.Linq;
using AppBackend.Models.DB;
using System.Data.Entity;
using System.Data.Entity.Design.PluralizationServices;
using System.Globalization;
using Newtonsoft.Json;

namespace AppBackend.DBControllers
{
    public class DBController
    {
        private static DBController _instance;
        private LocalServerContainer _dbx;
        public static DBController Instance { 
            get 
            {
                if (_instance == null)
                    _instance = new DBController();
                return _instance;
            }
        }
        private DBController()
        {
            _dbx = new LocalServerContainer();
        }

        public IEnumerable<T> Get<T>() where T : class
        {
            return GetDbSetFor<T>().ToList();
        }

        public T Get<T>(object[] primaryKeys) where T : class
        {
            return GetDbSetFor<T>().Find(primaryKeys);
        }

        public void Post<T>(string jsonObject) where T : class
        {
            GetDbSetFor<T>().Add(JsonConvert.DeserializeObject<T>(jsonObject));
            _dbx.SaveChanges();
        }

        public void Delete<T>(object[] primaryKeys) where T : class
        {
            DbSet<T> dbSet = GetDbSetFor<T>();
            dbSet.Remove(dbSet.Find(primaryKeys));
            _dbx.SaveChanges();
        }

        private DbSet<T> GetDbSetFor<T>() where T : class
        {
            var pluralServ = PluralizationService.CreateService(CultureInfo.GetCultureInfo("en-US"));
            string pluralizedType = pluralServ.Pluralize(typeof(T).Name);
            return (DbSet<T>)_dbx.GetType().GetProperty(pluralizedType).GetValue(_dbx);
        }
    }
}