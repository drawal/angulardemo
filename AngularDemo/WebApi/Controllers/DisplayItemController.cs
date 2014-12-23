using Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class DisplayItemController : ApiController
    {
    //    // GET: api/DisplayItem
        public IEnumerable<DisplayItem> Get()
        {
            return LoadJsonData();
        }


        [Route("api/DisplayItems")]
        public IEnumerable<DisplayItem> GetDisplayItems()
        {
            return LoadJsonData();
        }
        private List<DisplayItem> LoadJsonData()
        {
            var jsonString = File.ReadAllText(System.Web.HttpContext.Current.Server.MapPath("~/testData.json"));
            JsonSerializer serializer = new JsonSerializer();

            TextReader tReader = File.OpenText(System.Web.HttpContext.Current.Server.MapPath("~/testData.json"));
            JsonReader jsonReader = new JsonTextReader(tReader);
            return serializer.Deserialize<List<DisplayItem>>(jsonReader);
        }

        // GET: api/DisplayItem/5
        public DisplayItem Get(int id)
        {
            return LoadJsonData().FirstOrDefault(t => t.Id == id);
        }

        // POST: api/DisplayItem
        public DisplayItem Post([FromBody]DisplayItem displayItem)
        {
            displayItem.Name += " - Created by Post.";
            return displayItem;
        }

        // PUT: api/DisplayItem/5
        public DisplayItem Put(int id, [FromBody]DisplayItem displayItem)
        {
            displayItem.Name += " - Updated by Put.";
            return displayItem;
        }

        // DELETE: api/DisplayItem/5
        public void Delete(int id)
        {
        }
    }
}
