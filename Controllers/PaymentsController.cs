using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XeroConnector.Helpers;

namespace XeroConnector.Controllers
{
    public class PaymentsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Xero.Api.Core.Model.Payment> Get()
        {
            var Payments = XeroApiHelper.XeroApi.Payments.Find();
            return Payments;
        }
        [HttpGet]
        public Xero.Api.Core.Model.Payment GetById(Guid id)
        {
            var Payment = XeroApiHelper.XeroApi.Payments.Find(id);
            return Payment;
        }
        [HttpPost]
        public Xero.Api.Core.Model.Payment Create(Xero.Api.Core.Model.Payment Payment)
        {
            return XeroApiHelper.XeroApi.Payments.Create(Payment);
        }
        [HttpPut]
        public Xero.Api.Core.Model.Payment Update(Xero.Api.Core.Model.Payment Payment)
        {
            return XeroApiHelper.XeroApi.Payments.Update(Payment);
        }
    }
}
