using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class pages_tepage2 : System.Web.UI.Page
{
    string id;
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
        try
        {
            if (!IsPostBack)
            {
                if (Session["id"] != null)
                {

                    string id = Session["id"].ToString();
                    //查询两种方案的CLASSID
                    var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
                    SqlConnection conn = new SqlConnection(consql);
                    string sqlstr = string.Format("select * from TRM where ID='{0}'", id);
                    SqlCommand cmd = new SqlCommand(sqlstr, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    int classid1 = -1;
                    int classid2 = -1;
                    while (dr.Read())
                    {
                        if (!dr.IsDBNull(5))
                            classid1 = dr.GetInt32(5);
                        if (!dr.IsDBNull(6))
                            classid2 = dr.GetInt32(6);
                    }
                    dr.Close();
                    conn.Close();
                    //查询第一种方案
                    if (classid1 != -1)
                    {
                        string sql1 = string.Format("select * from CSM where CLASSID={0}", classid1);
                        SqlCommand comm1 = new SqlCommand(sql1, conn);
                        conn.Open();
                        SqlDataReader dr2 = comm1.ExecuteReader();
                        while (dr2.Read())
                        {
                            Label7.Text = dr2.GetString(1).ToString();
                            int classtime1 = dr2.GetInt32(2);
                            switch (classtime1)
                            {
                                case 0:
                                    Label8.Text = "星期一上午";
                                    break;
                                case 1:
                                    Label8.Text = "星期二上午";
                                    break;
                                case 2:
                                    Label8.Text = "星期三上午";
                                    break;
                                case 3:
                                    Label8.Text = "星期四上午";
                                    break;
                                case 4:
                                    Label8.Text = "星期五上午";
                                    break;
                                case 5:
                                    Label8.Text = "星期一下午";
                                    break;
                                case 6:
                                    Label8.Text = "星期二下午";
                                    break;
                                case 7:
                                    Label8.Text = "星期三下午";
                                    break;
                                case 8:
                                    Label8.Text = "星期四下午";
                                    break;
                                case 9:
                                    Label8.Text = "星期五下午";
                                    break;
                            }
                            Label9.Text = dr2.GetString(3).ToString();
                            Label10.Text = dr2.GetInt32(4).ToString();
                            Label11.Text = dr2.GetInt32(5).ToString();
                        }
                        dr2.Close();
                        conn.Close();
                    }
                    //查询第二种方案
                    if (classid2 != -1)
                    {
                        string sql2 = string.Format("select * from CSM where CLASSID={0}", classid2);
                        SqlCommand comm2 = new SqlCommand(sql2, conn);
                        conn.Open();
                        SqlDataReader dr3 = comm2.ExecuteReader();
                        while (dr3.Read())
                        {
                            Label12.Text = dr3.GetString(1).ToString();
                            int classtime1 = dr3.GetInt32(2);
                            switch (classtime1)
                            {
                                case 0:
                                    Label13.Text = "星期一上午";
                                    break;
                                case 1:
                                    Label13.Text = "星期二上午";
                                    break;
                                case 2:
                                    Label13.Text = "星期三上午";
                                    break;
                                case 3:
                                    Label13.Text = "星期四上午";
                                    break;
                                case 4:
                                    Label13.Text = "星期五上午";
                                    break;
                                case 5:
                                    Label13.Text = "星期一下午";
                                    break;
                                case 6:
                                    Label13.Text = "星期二下午";
                                    break;
                                case 7:
                                    Label13.Text = "星期三下午";
                                    break;
                                case 8:
                                    Label13.Text = "星期四下午";
                                    break;
                                case 9:
                                    Label13.Text = "星期五下午";
                                    break;
                            }
                            Label14.Text = dr3.GetString(3).ToString();
                            Label15.Text = dr3.GetInt32(4).ToString();
                            Label16.Text = dr3.GetInt32(5).ToString();
                        }
                        dr3.Close();
                        conn.Close();
                    }
                }
                else
                {
                    Response.Redirect("~/Default.aspx");
                }
            }
        }
        catch
        {
            Response.Write("<script>alert('网络错误！')</script>");
        }
    }
    
}