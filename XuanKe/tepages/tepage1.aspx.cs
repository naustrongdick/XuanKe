using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class pages_Default : System.Web.UI.Page
{
    string id = null;
    int class1;
    int class2;
    string classna1;

    DataTable dt = null;
    string classna2;


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

    public void SelectDropList(ref DropDownList d,int i)
    {
            if (dt.Rows[i][0].ToString() == "100")
            {
                if (dt.Rows[i][1].ToString() == "100")
                    d.SelectedIndex = 0;
                else
                    d.SelectedIndex = 2;
            }
            else if (dt.Rows[i][1].ToString() == "100")
            {
                d.SelectedIndex = 3;
            }
            else
            {
                d.SelectedIndex = 1;
            }
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
            return dr.GetString(0).TrimEnd();
        }
        else
        {
            return "无课程";
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
            if (!dr.IsDBNull(0))
                class1 = dr.GetInt32(0);
            else
                class1 = -1;
            if (!dr.IsDBNull(0))
                class2 = dr.GetInt32(1);
            else
                class2 = -1;
        }
        dr.Close();

        classna1 = GetClassName(class1);
        classna2 = GetClassName(class2);

        Ke.Text=string.Format("你要上的课有：\n1.{0}\n2.{1}", GetClassName(class1), GetClassName(class2));

        DropDownList1.Items.Add(classna1);
        DropDownList1.Items.Add(classna2);
        DropDownList2.Items.Add(classna1);
        DropDownList2.Items.Add(classna2);
        DropDownList3.Items.Add(classna1);
        DropDownList3.Items.Add(classna2);
        DropDownList4.Items.Add(classna1);
        DropDownList4.Items.Add(classna2);
        DropDownList5.Items.Add(classna1);
        DropDownList5.Items.Add(classna2);
        DropDownList6.Items.Add(classna1);
        DropDownList6.Items.Add(classna2);
        DropDownList7.Items.Add(classna1);
        DropDownList7.Items.Add(classna2);
        DropDownList8.Items.Add(classna1);
        DropDownList8.Items.Add(classna2);
        DropDownList9.Items.Add(classna1);
        DropDownList9.Items.Add(classna2);
        DropDownList10.Items.Add(classna1);
        DropDownList10.Items.Add(classna2);

        sqlstr = string.Format("select CLASS{0},CLASS{1} from YYB",class1,class2);
        SqlDataAdapter sda = new SqlDataAdapter(sqlstr, conn);
        dt = new DataTable();
        sda.Fill(dt);
        conn.Close();

        SelectDropList(ref DropDownList1, 0);
        SelectDropList(ref DropDownList2, 1);
        SelectDropList(ref DropDownList3, 2);
        SelectDropList(ref DropDownList4, 3);
        SelectDropList(ref DropDownList5, 4);
        SelectDropList(ref DropDownList6, 5);
        SelectDropList(ref DropDownList7, 6);
        SelectDropList(ref DropDownList8, 7);
        SelectDropList(ref DropDownList9, 8);
        SelectDropList(ref DropDownList10, 9);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //1.先读取数据库FABU表中的值，若TRUE则选课已经结束，弹出提醒
        //2.若教师选了某个时段，将YYB中对应两节课的值设为100
        //  语句为string.Format("update YYB set CLASS{0} = 100,CLASS{1} = 100 where ID = '{2}'",class1,class2,时段号)
        //3.每次某个时段有人预约，YYB表中的对应count++
    }
}