using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XeroConnector.Helpers;
using XeroConnector.Model.Setup;

namespace XeroConnector.Controllers
{
    public class OrganisationController : ApiController
    {
        [HttpGet]
        public Organisation Get()
        {
            var Organisation = XeroApiHelper.XeroApi.Organisation;
            return XeroApiHelper.Convert<Organisation>(Organisation); ;
        }
       
    }
}
