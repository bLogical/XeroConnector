using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using Xero.Api.Core;
using Xero.Api.Example.Applications.Private;
using Xero.Api.Infrastructure.OAuth;
using Xero.Api.Serialization;

namespace XeroConnector.Helpers
{
    static class XeroApiHelper
    {
        private static XeroCoreApi _xeroApi;
        
        public static XeroCoreApi XeroApi
        {
            get
            {
                if (_xeroApi == null)
                {
                    var xeroApiUri = WebConfigurationManager.AppSettings["XeroApiUri"];
                    var certificateThumbprint = WebConfigurationManager.AppSettings["CertificateThumbprint"];
                    var consumerKey = WebConfigurationManager.AppSettings["ConsumerKey"];
                    var consumerSecret = WebConfigurationManager.AppSettings["ConsumerSecret"];

                    // Private Application Sample
                    var cert = GetCertificate(certificateThumbprint);

                    _xeroApi = new XeroCoreApi(xeroApiUri,
                                                new PrivateAuthenticator(cert),
                                                new Consumer(consumerKey, consumerSecret),
                                                null,
                                                new DefaultMapper(),
                                                new DefaultMapper());

                }
                return _xeroApi;
            }
        }
        private static X509Certificate2 GetCertificate(string thumbprint)
        {
            X509Store certStore = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            certStore.Open(OpenFlags.ReadOnly);
            X509Certificate2Collection allCerts = certStore.Certificates;
            
            X509Certificate2Collection certCollection = certStore.Certificates.Find(
                                       X509FindType.FindByThumbprint,
                                      thumbprint,
                                       false);

            // Get the first cert with the thumbprint
            certStore.Close();
            return certCollection[0];
        }
        public static T Convert<T>(object obj) {

            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(obj));
        }
    }
}
