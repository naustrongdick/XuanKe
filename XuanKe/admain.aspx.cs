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
    String id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Session["ad"].ToString();
        string name = null;
        string sex = null;
        string mobile = null;
        string email = null;


        var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
        SqlConnection conn = new SqlConnection(consql);

        string sqlstr = string.Format("select * from ARM where ID = '{0}'",id);
        SqlCommand cmd = new SqlCommand(sqlstr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            name = dr[1].ToString();
            if ("False".Equals(dr[2].ToString()))
            {
                sex = "男";
            }
            else
            {
                sex = "女";
            }
            mobile = dr[3].ToString();
            email = dr[4].ToString();
        }

        TextBox1.Text = id + "\r\n" + name + "\r\n" + sex + "\r\n" + mobile + "\r\n" + email;


        dr.Close();
        conn.Close();
    }
    protected void  exit_Click(object sender, EventArgs e)
    {
        var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
        SqlConnection conn = new SqlConnection(consql);
        string sqlstr = string.Format("update ARL set STATUS = 0,LASTTIME = '{0}' where ADMIN = '{1}'", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), id);
        SqlCommand cdm = new SqlCommand(sqlstr, conn);
        conn.Open();
        cdm.ExecuteNonQuery();
        conn.Close();
        Response.Redirect("Adminlo.aspx");
    }
}