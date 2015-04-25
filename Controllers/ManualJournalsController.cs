using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XeroConnector.Helpers;

namespace XeroConnector.Controllers
{
    public class ManualJournalsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Xero.Api.Core.Model.ManualJournal> Get()
        {
            var ManualJournals = XeroApiHelper.XeroApi.ManualJournals.Find();
            return ManualJournals;
        }
        [HttpGet]
        public Xero.Api.Core.Model.ManualJournal GetById(Guid id)
        {
            var ManualJournal = XeroApiHelper.XeroApi.ManualJournals.Find(id);
            return ManualJournal;
        }
        [HttpPost]
        public Xero.Api.Core.Model.ManualJournal Create(Xero.Api.Core.Model.ManualJournal ManualJournal)
        {
            return XeroApiHelper.XeroApi.ManualJournals.Create(ManualJournal);
        }
        [HttpPut]
        public Xero.Api.Core.Model.ManualJournal Update(Xero.Api.Core.Model.ManualJournal ManualJournal)
        {
            return XeroApiHelper.XeroApi.ManualJournals.Update(ManualJournal);
        }
    }
}
