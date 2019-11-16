using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DomesticAirline
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void searchBtn_Click(object sender, EventArgs e)
        {
            airlineWs.DomesticAirline ws = new airlineWs.DomesticAirline();
            DataSet data = ws.getDomesticAirlinesTime(this.startCity.Text, this.endCity.Text, "", "");
            this.GridView1.DataSource = data;
            this.GridView1.DataBind();
        }
    }
}