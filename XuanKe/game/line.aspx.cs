using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class game_line : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                Loadgrade();
            }
        }
    }

    protected void Loadgrade()
    {
        string[,] gd = new string[5, 2];
        for (int a = 0; a <= 4; a++)
        {
            gd[a, 0] = "-";
            gd[a, 1] = "-";
        }
        string id = Session["id"].ToString();
        var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
        SqlConnection conn0 = new SqlConnection(consql);
        string sqlstr0 = string.Format("select top 5 TRM.NAME,LINE.TIME from TRM,LINE where TRM.ID = LINE.ID order by LINE.TIME;");
        SqlCommand cmd0 = new SqlCommand(sqlstr0, conn0);
        conn0.Open();
        SqlDataReader dr = cmd0.ExecuteReader();
        int i = 0;
        while (dr.Read())
        {
            gd[i, 0] = dr.GetString(0).Trim();
            gd[i, 1] = dr.GetDouble(1).ToString() + "秒";
            i++;
        }
        conn0.Close();
        Label1.Text = gd[0, 0];
        Label2.Text = gd[0, 1];
        Label3.Text = gd[1, 0];
        Label4.Text = gd[1, 1];
        Label5.Text = gd[2, 0];
        Label6.Text = gd[2, 1];
        Label7.Text = gd[3, 0];
        Label8.Text = gd[3, 1];
        Label9.Text = gd[4, 0];
        Label10.Text = gd[4, 1];
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = Session["id"].ToString();
        var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
        SqlConnection conn0 = new SqlConnection(consql);
        string sqlstr0 = string.Format("insert into LINE values({0},{1})", id,HiddenField1.Value);
        SqlCommand cmd0 = new SqlCommand(sqlstr0, conn0);
        conn0.Open();
        cmd0.ExecuteNonQuery();
        conn0.Close();
        Loadgrade();
    }
}