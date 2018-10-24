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
        try
        {
            if (Session["ad"] != null)
            {
                string id = Session["ad"].ToString();
                var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
                SqlConnection conn = new SqlConnection(consql);

                string sqlstr = string.Format("select NAME from ARM where ID = '{0}'", id);
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
            else
            {
                Response.Redirect("Adminlo.aspx");
            }
        }
        catch
        {
            Response.Write("<script>alert('网络错误！')</script>");
        }
    }
    protected void exit_Click(object sender, EventArgs e)
    {

        Session["ad"] = null;
        Session.Remove("ad");
        Response.Redirect("Adminlo.aspx");
    }

    
    
}