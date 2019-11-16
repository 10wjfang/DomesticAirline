using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DomesticAirline
{
    /// <summary>
    /// MyDomesticAirline 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class MyDomesticAirline : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet getDomesticAirlinesTime(string startCity, string lastCity, string theDate, string userID)
        {
            airlineWs.DomesticAirline ws = new airlineWs.DomesticAirline();
            return ws.getDomesticAirlinesTime(startCity, lastCity, theDate, userID);
        }
    }
}
