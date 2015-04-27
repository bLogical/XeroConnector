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
    public class PrepaymentsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Prepayment> Get()
        {
            var Prepayments = XeroApiHelper.XeroApi.Prepayments.Find();
            return XeroApiHelper.Convert<IEnumerable<Prepayment>>(Prepayments);
        }
        [HttpGet]
        public Prepayment GetById(Guid id)
        {
            var Prepayment = XeroApiHelper.XeroApi.Prepayments.Find(id);
            return XeroApiHelper.Convert<Prepayment>(Prepayment);
        }
    }
}
