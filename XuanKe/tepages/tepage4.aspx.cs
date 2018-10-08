using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class pages_tepage4 : System.Web.UI.Page
{
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

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    bool jiancha(string s)
    {
        int i = 0;
        foreach (char a in s)
        {
            if (a >= 65 && a <= 90 || a >= 97 && a <= 122 || a >= 48 && a <= 57)
            {
                i++;
            }
            else
            {
                return false;
            }
            if (i == s.Length)
                return true;
        }
        return false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string id = Session["id"].ToString();
            var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
            SqlConnection conn = new SqlConnection(consql);
            string sqlstr = string.Format("select PASSWD from TRL where ID='{0}'", id);
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            string pwd = "";
            while (dr.Read())
            {
                pwd = dr.GetString(0).Trim();
            }
            dr.Close();

            string a;
            a = TextBox1.Text.TrimEnd();

            if (a.Equals(string.Empty))
            {
                Show.Text = "请输入旧密码";
            }
            else if (a != pwd)
                Show.Text = "旧密码错误，请重试！";
            else
            {
                if (!jiancha(TextBox2.Text.TrimEnd())|| TextBox2.Text.TrimEnd().Length<5|| TextBox2.Text.TrimEnd().Length >20)
                {
                    Show.Text = "新密码不合格";
                }
                else if (TextBox2.Text != TextBox3.Text)
                    Show.Text = "两次输入新密码不同，请重试！";
                else
                {
                    if (a == Convert.ToString(TextBox2.Text))
                        Show.Text = "新旧密码相同，请重试！";
                    else
                    {
                        SqlCommand scmd;
                        try
                        {
                            string password = TextBox2.Text;
                            string scmdStr = "update TRL set PASSWD='" + password + "'where ID=" + id + "";
                            scmd = new SqlCommand(scmdStr, conn);
                            scmd.ExecuteNonQuery();
                            Show.Text = "修改成功！";
                            conn.Close();
                        }

                        catch (Exception ex)
                        {
                            Show.Text = ex.ToString();
                        }
                    }
                }
            }
        }
        catch
        {
            Response.Write("<script>alert('网络错误！')</script>");
        }

    }
}