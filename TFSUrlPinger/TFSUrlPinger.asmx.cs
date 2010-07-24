using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace TFSUrlPinger
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]    
    public class TFSUrlPinger : System.Web.Services.WebService
    {
        [SoapDocumentMethod("http://schemas.microsoft.com/TeamFoundation/2005/06/Services/Notification/03/Notify",
                            RequestNamespace = "http://schemas.microsoft.com/TeamFoundation/2005/06/Services/Notification/03")]
        [WebMethod]
        public void Notify(string eventXml)
        {
            foreach (string url in System.Configuration.ConfigurationManager.AppSettings["PingUrls"].Split(','))
            {
                try
                {
                    System.Net.WebRequest req = System.Net.HttpWebRequest.Create(url);
                    req.GetResponse();
                }
                catch
                {
                }
            }
        }
    }
}
