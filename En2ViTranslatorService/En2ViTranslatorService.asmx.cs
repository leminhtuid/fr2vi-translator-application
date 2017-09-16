using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Linq;

namespace En2ViTranslatorService
{
    /// <summary>
    /// Summary description for En2ViTranslatorService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class En2ViTranslatorService : System.Web.Services.WebService
    {
        [WebMethod]
        public string TransEn2Vi(string input)
        {
            return XElement.Load(Server.MapPath("~/App_Data/en-2-vi.xml"))
                .Elements("word").Where(n => (string)n.Attribute("src") == input)
                .Select(n => n.Value)
                .FirstOrDefault();
        }
    }
}
