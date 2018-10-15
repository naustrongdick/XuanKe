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
        int success = 0;

        String un = usernm.Text;
        String ps = passwd.Text;
        try
        {
            var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
            SqlConnection conn = new SqlConnection(consql);
            string sqlstr = string.Format("select PASSWD,STATUS,LASTTIME from TRL where ID = '{0}'", un);
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();


            if (un.Equals(string.Empty))
                Show.Text = "请输入账号";
            else if (ps.Equals(string.Empty))
                Show.Text = "请输入密码";
            else
            {
                if (dr.Read())
                {
                    if (ps.Equals(dr.GetString(0).TrimEnd()))
                    {
                        TimeSpan ts = DateTime.Now - dr.GetDateTime(2);
                        if (dr.GetBoolean(1) == false || ts.Minutes > 5)
                        {
                            success = 1;
                        }
                        else
                        {
                            success = -1;
                        }
                    }

                }
            }


            dr.Close();
            conn.Close();

            if (success == 1)
            {
                string sqlch = string.Format("update TRL set STATUS = 1,LASTTIME = '{0}' where ID = '{1}'", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), un);
                SqlCommand cdm = new SqlCommand(sqlch, conn);
                conn.Open();
                cdm.ExecuteNonQuery();
                conn.Close();
                Session["id"] = un;
                Response.Redirect("temain.aspx");

            }
            else if (success == 0)
            {
                Show.Text = "账号或密码错误";
            }
            else
            {
                Show.Text = "当前账号已登录，请安全退出或过会再尝试";
            }

        }
        catch
        {
            Response.Write("<script>alert('网络错误！')</script>");
        }
    }

    
}
