using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        bool success = false;
        
        String un = usernm.Text;
        String ps = passwd.Text;
        try
        {
            var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
            SqlConnection conn = new SqlConnection(consql);
            string sqlstr = string.Format("select PASSWD from TRD where ID = '{0}'",un);
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            
            String pa = null;

            if (un == null)
                Show.Text = "请输入账号";
            else if (ps == null)
                Show.Text = "请输入密码";
            else
            {
                if (dr.Read())
                {
                    pa = dr[0].ToString();
                    if (ps.Equals(pa.TrimEnd()))
                    {
                        success = true;
                    }
                    
                }
            }
            
            if (success)
            { 
                Session["id"] = un;
                Response.Redirect("temain.aspx");
            }
            else 
            {
                Show.Text = "账号或密码错误"; 
            }
            
            dr.Close();
            conn.Close();
        }
        
        catch (Exception)
        {
            Show.Text = "网络错误"; 
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Adminlo.aspx");
    }
}