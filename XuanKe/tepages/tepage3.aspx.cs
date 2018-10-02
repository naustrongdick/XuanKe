using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class pages_tepage3 : System.Web.UI.Page
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

            string id = Session["id"].ToString();
            var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
            SqlConnection conn = new SqlConnection(consql);
            string sqlstr = string.Format("select * from TRM where ID='{0}'", id);
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TextBox1.Text = dr.GetString(1).ToString();
                if (dr.GetBoolean(2) == false)
                    TextBox2.Text = "男";
                else
                    TextBox2.Text = "女";
                TextBox3.Text = dr.GetString(4).ToString();
                TextBox4.Text = dr.GetString(3).ToString();
            }
            dr.Close();
            conn.Close();
        }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = Session["id"].ToString();
        var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
        SqlConnection conn = new SqlConnection(consql);
        conn.Open();
        SqlCommand scmd;
        try
        {
            string name = TextBox1.Text;
            int sex;
            if (TextBox2.ToString() == "男")
                sex = 1;
            else
                sex = 0;
            string email = TextBox3.Text;
            string tele = TextBox4.Text;
            string scmdStr = "update TRM set NAME='" + name + "',SEX=" + sex + ",MOBILE='" + tele + "',EMAIL='" + email + "'where ID=" + id + "";
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