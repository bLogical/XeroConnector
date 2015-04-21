using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XeroConnector.Helpers;

namespace XeroConnector.Controllers
{
    public class CreditNotesController : ApiController
    {
        [HttpGet]
        public IEnumerable<Xero.Api.Core.Model.CreditNote> Get()
        {
            var CreditNotes = XeroApiHelper.XeroApi.CreditNotes.Find();
            return CreditNotes;
        }
        [HttpGet]
        public Xero.Api.Core.Model.CreditNote Get(Guid id)
        {
            var CreditNote = XeroApiHelper.XeroApi.CreditNotes.Find(id);
            return CreditNote;
        }
        [HttpPost]
        public Xero.Api.Core.Model.CreditNote Create(Xero.Api.Core.Model.CreditNote CreditNote)
        {
            return XeroApiHelper.XeroApi.CreditNotes.Create(CreditNote);
        }
        [HttpPut]
        public Xero.Api.Core.Model.CreditNote Update(Xero.Api.Core.Model.CreditNote CreditNote)
        {
            return XeroApiHelper.XeroApi.CreditNotes.Update(CreditNote);
        }
    }
}
