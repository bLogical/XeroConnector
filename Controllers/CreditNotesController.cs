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
    public class CreditNotesController : ApiController
    {
        [HttpGet]
        public IEnumerable<CreditNote> Get()
        {
            var CreditNotes = XeroApiHelper.XeroApi.CreditNotes.Find();
            return XeroApiHelper.Convert<IEnumerable<CreditNote>>(CreditNotes);
        }
        [HttpGet]
        public CreditNote GetById(Guid id)
        {
            var CreditNote = XeroApiHelper.XeroApi.CreditNotes.Find(id);
            return XeroApiHelper.Convert<CreditNote>(CreditNote);
        }
        [HttpPost]
        public void Create(CreditNote CreditNote)
        {
            var xeroObj = XeroApiHelper.Convert<Xero.Api.Core.Model.CreditNote>(CreditNote);
            XeroApiHelper.XeroApi.CreditNotes.Create(xeroObj);
        }
        [HttpPut]
        public void Update(CreditNote CreditNote)
        {
            var xeroObj = XeroApiHelper.Convert<Xero.Api.Core.Model.CreditNote>(CreditNote);
            XeroApiHelper.XeroApi.CreditNotes.Update(xeroObj);
        }
    }
}
