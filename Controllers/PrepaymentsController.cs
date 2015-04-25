using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XeroConnector.Helpers;

namespace XeroConnector.Controllers
{
    public class PrePrepaymentsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Xero.Api.Core.Model.Prepayment> Get()
        {
            var Prepayments = XeroApiHelper.XeroApi.Prepayments.Find();
            return Prepayments;
        }
        [HttpGet]
        public Xero.Api.Core.Model.Prepayment GetById(Guid id)
        {
            var Prepayment = XeroApiHelper.XeroApi.Prepayments.Find(id);
            return Prepayment;
        }
    }
}
