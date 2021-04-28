using Customer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Customer.Controllers
{

    [RoutePrefix("api/customer")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CustomerController : ApiController
    {
        OnlineStoreEntities onlineStoreEntities = new OnlineStoreEntities();
         
        [HttpGet]
        [Route("all")]
        public IEnumerable<string> Get()
        {
            string id = Guid.NewGuid().ToString();
            ItemCategory item = new ItemCategory();
            item.categoryId = id;
            item.name = "name";
            onlineStoreEntities.ItemCategories.Add(item);
            onlineStoreEntities.SaveChanges();
            return new string[] { "value1", "value2" };
        }
    }
}
