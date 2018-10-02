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
    string id;
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

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["id"] != null)
            {

            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = Session["id"].ToString();
        var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
        SqlConnection conn = new SqlConnection(consql);
        string sqlstr = string.Format("select * from TRL where ID='{0}'", id);
        SqlCommand cmd = new SqlCommand(sqlstr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        string pwd = "1111";
        while (dr.Read())
        {
            pwd = dr.GetString(1).Trim();
        }
        dr.Close();
        
        string a;
        a = Convert.ToString(TextBox1.Text);

        if (a!= pwd)
            Show.Text = "旧密码错误，请重试！";
        else
        {
            if (TextBox2.Text != TextBox3.Text)
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
}