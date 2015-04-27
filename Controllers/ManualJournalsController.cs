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
    public class ManualJournalsController : ApiController
    {
        [HttpGet]
        public IEnumerable<ManualJournal> Get()
        {
            var ManualJournals = XeroApiHelper.XeroApi.ManualJournals.Find();
            return XeroApiHelper.Convert<IEnumerable<ManualJournal>>(ManualJournals);
        }
        [HttpGet]
        public ManualJournal GetById(Guid id)
        {
            var ManualJournal = XeroApiHelper.XeroApi.ManualJournals.Find(id);
            return XeroApiHelper.Convert<ManualJournal>(ManualJournal);
        }
        [HttpPost]
        public void Create(ManualJournal ManualJournal)
        {
            var xeroObj = XeroApiHelper.Convert<Xero.Api.Core.Model.ManualJournal>(ManualJournal);
            XeroApiHelper.XeroApi.ManualJournals.Create(xeroObj);
        }
        [HttpPut]
        public void Update(ManualJournal ManualJournal)
        {
            var xeroObj = XeroApiHelper.Convert<Xero.Api.Core.Model.ManualJournal>(ManualJournal);
            XeroApiHelper.XeroApi.ManualJournals.Update(xeroObj);
        }
    }
}
