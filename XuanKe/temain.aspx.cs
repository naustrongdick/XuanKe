using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Session["id"].ToString();
        var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
        SqlConnection conn = new SqlConnection(consql);

        string sqlstr = string.Format("select NAME from TRM where ID = '{0}'", id);
        SqlCommand cmd = new SqlCommand(sqlstr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        string name = null;
        while (dr.Read())
        {
            name = dr[0].ToString();
        }
        dr.Close();
        conn.Close();
        hello.Text = "欢迎您，" + name;
    }
    protected void exit_Click(object sender, EventArgs e)
    {
        WriteDateTime();
        Session.Clear();
        Response.Redirect("Default.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        mainbox.Attributes["src"] = "tepages/tepage1.aspx";
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
        SqlConnection conn = new SqlConnection(consql);

        string sqlstr = string.Format("select * from FaBu");
        SqlCommand cmd = new SqlCommand(sqlstr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            if (dr.GetBoolean(0))
            {
                mainbox.Attributes["src"] = "tepages/tepage2.aspx";
            }
            else
            {
                mainbox.Attributes["src"] = "tepages/error.aspx";
            }
        }
        dr.Close();
        conn.Close();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        mainbox.Attributes["src"] = "tepages/tepage3.aspx";
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        mainbox.Attributes["src"] = "tepages/tepage4.aspx";
    }

    public void WriteDateTime()
    {
        var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
        SqlConnection conn = new SqlConnection(consql);
        string sqlstr = string.Format("update TRL set STATUS = 0,LASTTIME = '{0}' where ID = '{1}'", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), id);
        SqlCommand cdm = new SqlCommand(sqlstr, conn);
        conn.Open();
        cdm.ExecuteNonQuery();
        conn.Close();
    }
}