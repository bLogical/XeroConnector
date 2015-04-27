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
    public class ItemsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            var Items = XeroApiHelper.XeroApi.Items.Find();
            return XeroApiHelper.Convert<IEnumerable<Item>>(Items);
        }
        [HttpGet]
        public Item GetById(Guid id)
        {
            var Item = XeroApiHelper.XeroApi.Items.Find(id);
            return XeroApiHelper.Convert<Item>(Item);
        }
        [HttpPost]
        public void Create(Item Item)
        {
            var xeroObj = XeroApiHelper.Convert<Xero.Api.Core.Model.Item>(Item);
            XeroApiHelper.XeroApi.Items.Create(xeroObj);
        }
        [HttpPut]
        public void Update(Item Item)
        {
            var xeroObj = XeroApiHelper.Convert<Xero.Api.Core.Model.Item>(Item);
            XeroApiHelper.XeroApi.Items.Update(xeroObj);
        }
    }
}
