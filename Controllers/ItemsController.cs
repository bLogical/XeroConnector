using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XeroConnector.Helpers;

namespace XeroConnector.Controllers
{
    public class ItemsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Xero.Api.Core.Model.Item> Get()
        {
            var Items = XeroApiHelper.XeroApi.Items.Find();
            return Items;
        }
        [HttpGet]
        public Xero.Api.Core.Model.Item Get(Guid id)
        {
            var Item = XeroApiHelper.XeroApi.Items.Find(id);
            return Item;
        }
        [HttpPost]
        public Xero.Api.Core.Model.Item Create(Xero.Api.Core.Model.Item Item)
        {
            return XeroApiHelper.XeroApi.Items.Create(Item);
        }
        [HttpPut]
        public Xero.Api.Core.Model.Item Update(Xero.Api.Core.Model.Item Item)
        {
            return XeroApiHelper.XeroApi.Items.Update(Item);
        }
    }
}
