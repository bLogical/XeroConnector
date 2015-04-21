using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XeroConnector.Helpers;

namespace XeroConnector.Controllers
{
    public class OrganisationController : ApiController
    {
        [HttpGet]
        public Xero.Api.Core.Model.Organisation Get()
        {
            var Organisation = XeroApiHelper.XeroApi.Organisation;
            return Organisation;
        }
       
    }
}
