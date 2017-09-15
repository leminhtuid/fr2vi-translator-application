using System.Linq;
using System.Web.Services;
using System.Xml.Linq;

namespace Fr2EnTranslatorService
{
    /// <summary>
    /// Summary description for Fr2EnTranslatorService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Fr2EnTranslatorService : System.Web.Services.WebService
    {
        [WebMethod]
        public string TransFr2En(string input)
        {
            return XElement.Load(Server.MapPath("~/App_Data/fr-2-en.xml"))
                .Elements("word").Where(n => (string)n.Attribute("src") == input)
                .Select(n => n.Value)
                .FirstOrDefault();
        }
    }
}
