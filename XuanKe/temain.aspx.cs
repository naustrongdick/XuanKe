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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] != null)
        {
            try
            {
                bool isok = false;
                TimeSpan ts = new TimeSpan();
                string id = Session["id"].ToString();
                var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
                SqlConnection conn = new SqlConnection(consql);
                conn.Open();
                string sqlstr = string.Format("select NAME from TRM where ID = '{0}';", Session["id"].ToString());
                SqlCommand cmd = new SqlCommand(sqlstr, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                string name = null;
                while (dr.Read())
                {
                    name = dr.GetString(0);
                }
                dr.Close();

                sqlstr = string.Format("select * from FaBu");
                SqlCommand cmd2 = new SqlCommand(sqlstr, conn);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    isok = dr2.GetBoolean(0);
                    ts = DateTime.Now - dr2.GetDateTime(1);
                }

                if (isok || ts.Seconds > 0)
                    mainbox.Attributes["src"] = "tepages/tepage2.aspx";

                conn.Close();
                hello.Text = "欢迎您，" + name;

            }
            catch
            {
                Response.Write("<script>alert('网络错误！')</script>");
            }
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
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
        try
        {
            var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
            SqlConnection conn = new SqlConnection(consql);

            string sqlstr = string.Format("select * from FaBu");
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            TimeSpan ts = new TimeSpan();
            while (dr.Read())
            {
                ts = DateTime.Now - dr.GetDateTime(1);
                if (dr.GetBoolean(0) || ts.Seconds > 0)
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
        catch
        {
            Response.Write("<script>alert('网络错误！')</script>");
        }
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
        try
        {
            var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
            SqlConnection conn = new SqlConnection(consql);
            string sqlstr = string.Format("update TRL set STATUS = 0,LASTTIME = '{0}' where ID = '{1}'", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), Session["id"].ToString());
            SqlCommand cdm = new SqlCommand(sqlstr, conn);
            conn.Open();
            cdm.ExecuteNonQuery();
            conn.Close();
        }
        catch
        {
            Response.Write("<script>alert('网络错误！')</script>");
        }
    }
}