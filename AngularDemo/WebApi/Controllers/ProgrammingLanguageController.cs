using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class ProgrammingLanguageController : ApiController
    {

        [Route("api/ProgrammingLanguages")]
        public IEnumerable<ProgrammingLanguage> GetProgrammingLanguages()
        {
            return new List<ProgrammingLanguage>()
            {
                new ProgrammingLanguage()
            {
                Name = "SystemFlow",
                Type = "C#"
            },
            new ProgrammingLanguage()
            {
                Name = "CentralCodes",
                Type = "Javascript"
            },
            new ProgrammingLanguage()
            {
                Name = "DocMgmt",
                Type = "Angular"
            }
            };
        }

        [HttpGet]
        public ProgrammingLanguage Index()
        {
            return new ProgrammingLanguage()
            {
                Id = 1,
                Name = "C#",
                Type = "Dynamic"
            };
        }

        public string Post()
        {

            var request = Request.Content.ReadAsAsync(typeof(string));

            if (request.Result != null)
            {

            }

            var application = new ProgrammingLanguage();
            return (application != null)
                ? "Application received from client side : " + application.Name
                : "Application is null.";
        }

        [Route("ProgrammingLanguage/{id}"), HttpPut]
        public ProgrammingLanguage Update(int id, [FromBody]ProgrammingLanguage programmingLanguage)
        {
            programmingLanguage.Name += "- updated";
            programmingLanguage.Type += "- updated";
            return programmingLanguage;
        }
    }
}
