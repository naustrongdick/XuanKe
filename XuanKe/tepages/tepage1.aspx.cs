using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class pages_Default : System.Web.UI.Page
{
    string id = null;
    int class1;//教师要上的课程1编号
    int class2;//教师要上的课程2编号
    
    public void WriteDateTime()
    {
        //每次操作前调用一次这个函数
        //更新最后一次操作时间
        var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
        SqlConnection conn = new SqlConnection(consql);
        string sqlstr = string.Format("update TRL set STATUS = 0,LASTTIME = '{0}' where ID = '{1}'", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), id);
        SqlCommand cdm = new SqlCommand(sqlstr, conn);
        conn.Open();
        cdm.ExecuteNonQuery();
        conn.Close();
    }

    public string GetClassName(int i)
    {
        var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
        SqlConnection conn = new SqlConnection(consql);
        string sqlstr = string.Format("select CLASSNAME from CSM where CLASSID = {0}", i);
        SqlCommand cmd = new SqlCommand(sqlstr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            return dr.GetString(0);
        }
        else
        {
            return "课程不存在";
        }
        conn.Close();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        WriteDateTime();
        id = Session["id"].ToString();
        var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
        SqlConnection conn = new SqlConnection(consql);
        string sqlstr = string.Format("select CLASSID1,CLASSID2 from TRM where ID = '{0}'", id);
        SqlCommand cmd = new SqlCommand(sqlstr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            class1 = dr.GetInt32(0);
            class2 = dr.GetInt32(1);
        }
        conn.Close();

        Ke.Text=string.Format("你要上的课：\n1.{0}\n2.{1}",GetClassName(class1),GetClassName(class2));
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //1.先读取数据库FABU表中的值，若TRUE则选课已经结束，弹出提醒
        //2.若教师选了某个时段，将YYB中对应两节课的值设为100
        //  语句为string.Format("update YYB set CLASS{0} = 100,CLASS{1} = 100 where ID = '{2}'",class1,class2,时段号)
        //3.每次某个时段有人预约，YYB表中的对应count++
    }
}