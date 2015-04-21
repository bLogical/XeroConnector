using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XeroConnector.Helpers;

namespace XeroConnector.Controllers
{
    public class JournalsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Xero.Api.Core.Model.Journal> Get()
        {
            var Journals = XeroApiHelper.XeroApi.Journals.Find();
            return Journals;
        }
        [HttpGet]
        public Xero.Api.Core.Model.Journal Get(Guid id)
        {
            var Journal = XeroApiHelper.XeroApi.Journals.Find(id);
            return Journal;
        }
    }
}
