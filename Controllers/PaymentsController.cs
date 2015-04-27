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
    public class PaymentsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Payment> Get()
        {
            var Payments = XeroApiHelper.XeroApi.Payments.Find();
            return XeroApiHelper.Convert<IEnumerable<Payment>>(Payments);
        }
        [HttpGet]
        public Payment GetById(Guid id)
        {
            var Payment = XeroApiHelper.XeroApi.Payments.Find(id);
            return XeroApiHelper.Convert<Payment>(Payment);
        }
        [HttpPost]
        public void Create(Payment Payment)
        {
            var xeroObj = XeroApiHelper.Convert<Xero.Api.Core.Model.Payment>(Payment);
            XeroApiHelper.XeroApi.Payments.Create(xeroObj);
        }
        [HttpPut]
        public void Update(Payment Payment)
        {
            var xeroObj = XeroApiHelper.Convert<Xero.Api.Core.Model.Payment>(Payment);
            XeroApiHelper.XeroApi.Payments.Update(xeroObj);
        }
    }
}
