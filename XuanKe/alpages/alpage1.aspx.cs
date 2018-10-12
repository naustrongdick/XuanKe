using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class pages_alpage1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["ad"] != null)
            {
                try
                {
                    DataTable dta = new DataTable();
                    var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
                    SqlConnection conn = new SqlConnection(consql);
                    conn.Open();
                    string sqlstr = string.Format("select CLASSID,CLASSNAME,CLASSTIME from CSM");
                    SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
                    da.Fill(dta);

                    DropDownList1.Items.Add("无课程");
                    DropDownList3.Items.Add("无课程");
                    DropDownList5.Items.Add("无课程");
                    DropDownList7.Items.Add("无课程");
                    DropDownList9.Items.Add("无课程");
                    DropDownList2.Items.Add("无课程");
                    DropDownList4.Items.Add("无课程");
                    DropDownList6.Items.Add("无课程");
                    DropDownList8.Items.Add("无课程");
                    DropDownList10.Items.Add("无课程");

                    for (int i = 0; i <= 9; i++)
                    {
                        DropDownList1.Items.Add(dta.Rows[i][1].ToString());
                        DropDownList3.Items.Add(dta.Rows[i][1].ToString());
                        DropDownList5.Items.Add(dta.Rows[i][1].ToString());
                        DropDownList7.Items.Add(dta.Rows[i][1].ToString());
                        DropDownList9.Items.Add(dta.Rows[i][1].ToString());
                        DropDownList2.Items.Add(dta.Rows[i][1].ToString());
                        DropDownList4.Items.Add(dta.Rows[i][1].ToString());
                        DropDownList6.Items.Add(dta.Rows[i][1].ToString());
                        DropDownList8.Items.Add(dta.Rows[i][1].ToString());
                        DropDownList10.Items.Add(dta.Rows[i][1].ToString());
                    }

                    DropDownList1.SelectedIndex = 0;
                    DropDownList3.SelectedIndex = 0;
                    DropDownList5.SelectedIndex = 0;
                    DropDownList7.SelectedIndex = 0;
                    DropDownList9.SelectedIndex = 0;
                    DropDownList2.SelectedIndex = 0;
                    DropDownList4.SelectedIndex = 0;
                    DropDownList6.SelectedIndex = 0;
                    DropDownList8.SelectedIndex = 0;
                    DropDownList10.SelectedIndex = 0;

                    for (int i = 0; i <= 9; i++)
                    {
                        if ((int)dta.Rows[i][2] == 0)
                            DropDownList1.SelectedIndex = (int)dta.Rows[i][0] + 1;
                        if ((int)dta.Rows[i][2] == 1)
                            DropDownList2.SelectedIndex = (int)dta.Rows[i][0] + 1;
                        if ((int)dta.Rows[i][2] == 2)
                            DropDownList3.SelectedIndex = (int)dta.Rows[i][0] + 1;
                        if ((int)dta.Rows[i][2] == 3)
                            DropDownList4.SelectedIndex = (int)dta.Rows[i][0] + 1;
                        if ((int)dta.Rows[i][2] == 4)
                            DropDownList5.SelectedIndex = (int)dta.Rows[i][0] + 1;
                        if ((int)dta.Rows[i][2] == 5)
                            DropDownList6.SelectedIndex = (int)dta.Rows[i][0] + 1;
                        if ((int)dta.Rows[i][2] == 6)
                            DropDownList7.SelectedIndex = (int)dta.Rows[i][0] + 1;
                        if ((int)dta.Rows[i][2] == 7)
                            DropDownList8.SelectedIndex = (int)dta.Rows[i][0] + 1;
                        if ((int)dta.Rows[i][2] == 8)
                            DropDownList9.SelectedIndex = (int)dta.Rows[i][0] + 1;
                        if ((int)dta.Rows[i][2] == 9)
                            DropDownList10.SelectedIndex = (int)dta.Rows[i][0] + 1;
                    }

                    DateTime dt = new DateTime();
                    bool isok = false;
                    string sqlstr2 = string.Format("select * from FaBu");
                    SqlCommand cmd = new SqlCommand(sqlstr2, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        isok = dr.GetBoolean(0);
                        dt = dr.GetDateTime(1);
                    }
                    TextBox1.Text = dt.ToString();

                    TimeSpan ts = DateTime.Now - dt;
                    if (isok || ts.Seconds > 0)
                        Button2.Text = "停止发布";
                    else
                        Button2.Text = "立刻发布";
                }
                catch
                {
                    Response.Write("<script>alert('网络错误！')</script>");
                }
            }
            else
            {
                Response.Redirect("~/Adminlo.aspx");
            }
        }
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        string strDate = TextBox1.Text;
        DateTime dt;
        int[] fb = new int[10];
        if (DateTime.TryParse(strDate, out dt))
        {
            fb[0] = DropDownList1.SelectedIndex;
            fb[1] = DropDownList2.SelectedIndex;
            fb[2] = DropDownList3.SelectedIndex;
            fb[3] = DropDownList4.SelectedIndex;
            fb[4] = DropDownList5.SelectedIndex;
            fb[5] = DropDownList6.SelectedIndex;
            fb[6] = DropDownList7.SelectedIndex;
            fb[7] = DropDownList8.SelectedIndex;
            fb[8] = DropDownList9.SelectedIndex;
            fb[9] = DropDownList10.SelectedIndex;

            int x = 0;
            for (int i = 9; i >= 1; i--)
            {
                if (fb[i] != 0)
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (fb[i] == fb[j])
                        {
                            x = fb[i];
                        }
                    }
                }
                else
                {
                    x = -1;
                }
            }
            if (x != 0 && x != -1)
            {
                Label9.Text = DropDownList1.Items[x].ToString() + "被选择了多次!";
            }
            else if (x == -1)
            {
                Label9.Text = "有一个时段未选课!";
            }
            else
            {
                string sqlstr = "";
                try
                {
                    var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
                    SqlConnection conn = new SqlConnection(consql);
                    conn.Open();
                    for (int i = 0; i <= 9; i++)
                    {
                        sqlstr += string.Format("update CSM set CLASSTIME = {0} where CLASSID = {1};", i, fb[i] - 1);
                    }

                    SqlCommand cmd1 = new SqlCommand(sqlstr, conn);
                    int n = cmd1.ExecuteNonQuery();
                    if (n > 0)
                        Label9.Text = "保存成功!";
                    else
                        Label9.Text = "保存失败，请重试";
                    conn.Close();
                }
                catch
                {
                    Response.Write("<script>alert('网络错误！')</script>");
                }
            }
        }
        else
        {
            Label9.Text = "日期格式错误！";
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
            SqlConnection conn = new SqlConnection(consql);
            conn.Open();
            if (Button2.Text == "停止发布")
            {
                DateTime dt = DateTime.Now.AddYears(1);
                string strsql = string.Format("update FaBu set ISOK = 0,DEADTIME='{0}';", dt.ToString());
                SqlCommand cmd = new SqlCommand(strsql, conn);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    Button2.Text = "立刻发布";
                    Label9.Text = "停止发布成功!";
                }
                else
                    Label9.Text = "停止发布失败!";
            }
            else
            {
                DateTime dt = DateTime.Now;
                string strsql = string.Format("update FaBu set ISOK = 1,DEADTIME='{0}';", dt.ToString());
                SqlCommand cmd = new SqlCommand(strsql, conn);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    Button2.Text = "停止发布";
                    Label9.Text = "发布成功!";
                }
                else
                    Label9.Text = "发布失败!";
            }
            conn.Close();
        }
        catch
        {
            Response.Write("<script>alert('网络错误！')</script>");
        }
    }
}