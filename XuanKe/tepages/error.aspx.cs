using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class pages_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string dt = "";
        var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
        SqlConnection conn = new SqlConnection(consql);
        conn.Open();
        string sqlstr = string.Format("select DEADTIME from FaBu");
        SqlCommand cmd2 = new SqlCommand(sqlstr, conn);
        SqlDataReader dr2 = cmd2.ExecuteReader();
        while (dr2.Read())
        {
            dt = dr2.GetDateTime(0).ToString();
        }
        Label2.Text = "发布时间：" + dt;
        conn.Close();
    }
}