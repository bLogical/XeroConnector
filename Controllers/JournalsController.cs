using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XeroConnector.Helpers;
using XeroConnector.Model;

namespace XeroConnector.Controllers
{
    public class JournalsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Journal> Get()
        {
            var Journals = XeroApiHelper.XeroApi.Journals.Find();
            return XeroApiHelper.Convert<IEnumerable<Journal>>(Journals);
        }
        [HttpGet]
        public Journal GetById(Guid id)
        {
            var Journal = XeroApiHelper.XeroApi.Journals.Find(id);
            return XeroApiHelper.Convert<Journal>(Journal);
        }
    }
}
