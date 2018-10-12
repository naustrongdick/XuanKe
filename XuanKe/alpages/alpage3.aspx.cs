using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class pages_alpage2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ad"] == null)
        {
            Response.Redirect("~/Adminlo.aspx");
        }
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
            var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
            SqlConnection conn = new SqlConnection(consql);
            conn.Open();
            

            string aid = TextBox1.Text;
            int sex;
            sex = DropDownList1.SelectedIndex;
            string aps = TextBox3.Text;

            string aun = TextBox4.Text;
            string scmdStr = "";

            if (aid.Equals(string.Empty))
                Show.Text = "请输入账号";
            else if (aps.Equals(string.Empty))
                Show.Text = "请输入密码";
            else if (aun.Equals(string.Empty))
                Show.Text = "请输入用户名";
            else if (!jiancha(aid) || aid.Length < 5 || aid.Length > 20)
                Show.Text = "账号为5-20位字母或数字";
            else if (!jiancha(aps) || aps.Length < 5 || aps.Length > 20)
                Show.Text = "密码为5-20位字母或数字";
            else
            {
                scmdStr = string.Format("select ID from TRL where ID = '{0}'", aid);
                SqlCommand cmd = new SqlCommand(scmdStr, conn);
                int m = cmd.ExecuteNonQuery();
                if (m > 0)
                {
                    Show.Text = "该账号已存在！";
                    conn.Close();
                }
                else
                {

                    scmdStr = string.Format("insert into TRL(ID,PASSWD) values('{0}','{1}');insert into TRM(ID,NAME,SEX) values('{0}','{2}',{3})", aid, aps, aun, sex);
                    SqlCommand scmd = new SqlCommand(scmdStr, conn);
                    int n = scmd.ExecuteNonQuery();
                    if (n > 0)
                        Show.Text = "添加成功！";
                    else
                        Show.Text = "添加失败！";
                    conn.Close();
                }
            }
        }
        catch
        {
            Response.Write("<script>alert('网络错误！')</script>");
        }
    }
}