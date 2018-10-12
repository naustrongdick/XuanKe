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
    public string classna1;

    public DataTable dt = null;
    public string classna2;

    public void ClearDropList()
    {
        DropDownList1.Items.Clear();
        DropDownList3.Items.Clear();
        DropDownList5.Items.Clear();
        DropDownList7.Items.Clear();
        DropDownList9.Items.Clear();
        DropDownList2.Items.Clear();
        DropDownList4.Items.Clear();
        DropDownList6.Items.Clear();
        DropDownList8.Items.Clear();
        DropDownList10.Items.Clear();
    }

    public void AddDropList(string s)
    {
        DropDownList1.Items.Add(s);
        DropDownList3.Items.Add(s);
        DropDownList5.Items.Add(s);
        DropDownList7.Items.Add(s);
        DropDownList9.Items.Add(s);
        DropDownList2.Items.Add(s);
        DropDownList4.Items.Add(s);
        DropDownList6.Items.Add(s);
        DropDownList8.Items.Add(s);
        DropDownList10.Items.Add(s);
    }

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

    public void SelectDropList(ref DropDownList d,int i)
    {
            if (dt.Rows[i][0].ToString() == "100")
            {
                if (dt.Rows[i][1].ToString() == "100")
                    d.SelectedIndex = 1;
                else
                    d.SelectedIndex = 2;
            }
            else if (dt.Rows[i][1].ToString() == "100")
            {
                d.SelectedIndex = 3;
            }
            else
            {
                d.SelectedIndex = 0;
            }
    }

    public void SelectDropList2(ref DropDownList d, int i)
    {
        if (dt.Rows[i][0].ToString() == "100")
            d.SelectedIndex = 1;
        else
            d.SelectedIndex = 0;
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
        try
        {
            if (!IsPostBack)
            {
                if (Session["id"] != null)
                {
                    string id = null;
                    int class1 = 0;
                    int class2 = 0;

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
                        if (!dr.IsDBNull(1))
                            class2 = dr.GetInt32(1);
                        else
                            class2 = -1;
                    }
                    dr.Close();
                    

                    classna1 = GetClassName(class1);
                    classna2 = GetClassName(class2);

                    Ke.Text = string.Format("你要上的课有：\n1.{0}\n2.{1}", classna1, classna2);

                    sqlstr = string.Format("select DEADTIME from FaBu");
                    SqlCommand cdm = new SqlCommand(sqlstr, conn);
                    SqlDataReader dr2 = cdm.ExecuteReader();
                    string date = "";
                    while (dr2.Read())
                    {
                        date = dr2.GetDateTime(0).ToString();
                    }
                    dr2.Close();
                    Label1.Text = "选课截止时间：" + date;

                    if (classna1 == "无课程")
                    {
                        if (classna2 == "无课程")
                        {

                            ClearDropList();
                            AddDropList("尽可能不上课");
                            conn.Close();
                        }
                        else
                        {

                            ClearDropList();
                            AddDropList("尽可能不上课");
                            AddDropList(classna2);
                            sqlstr = string.Format("select CLASS{0} from YYB", class2);
                            SqlDataAdapter sda1 = new SqlDataAdapter(sqlstr, conn);
                            dt = new DataTable();
                            sda1.Fill(dt);
                            conn.Close();

                            SelectDropList2(ref DropDownList1, 0);
                            SelectDropList2(ref DropDownList2, 1);
                            SelectDropList2(ref DropDownList3, 2);
                            SelectDropList2(ref DropDownList4, 3);
                            SelectDropList2(ref DropDownList5, 4);
                            SelectDropList2(ref DropDownList6, 5);
                            SelectDropList2(ref DropDownList7, 6);
                            SelectDropList2(ref DropDownList8, 7);
                            SelectDropList2(ref DropDownList9, 8);
                            SelectDropList2(ref DropDownList10, 9);
                        }
                    }
                    else if (classna2 == "无课程")
                    {
                        ClearDropList();
                        AddDropList("尽可能不上课");
                        AddDropList(classna1);
                        sqlstr = string.Format("select CLASS{0} from YYB", class1);
                        SqlDataAdapter sda2 = new SqlDataAdapter(sqlstr, conn);
                        dt = new DataTable();
                        sda2.Fill(dt);
                        conn.Close();

                        SelectDropList2(ref DropDownList1, 0);
                        SelectDropList2(ref DropDownList2, 1);
                        SelectDropList2(ref DropDownList3, 2);
                        SelectDropList2(ref DropDownList4, 3);
                        SelectDropList2(ref DropDownList5, 4);
                        SelectDropList2(ref DropDownList6, 5);
                        SelectDropList2(ref DropDownList7, 6);
                        SelectDropList2(ref DropDownList8, 7);
                        SelectDropList2(ref DropDownList9, 8);
                        SelectDropList2(ref DropDownList10, 9);
                    }
                    else
                    {
                        ClearDropList();
                        AddDropList("尽可能不上课");
                        AddDropList("两节课都可以");
                        AddDropList(classna1);
                        AddDropList(classna2);
                        sqlstr = string.Format("select CLASS{0},CLASS{1} from YYB", class1, class2);
                        SqlDataAdapter sda3 = new SqlDataAdapter(sqlstr, conn);
                        dt = new DataTable();
                        sda3.Fill(dt);
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

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            WriteDateTime();

            string id = Session["id"].ToString();
            int class1 = 0;
            int class2 = 0;

            var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
            SqlConnection conn0 = new SqlConnection(consql);
            string sqlstr0 = string.Format("select CLASSID1,CLASSID2 from TRM where ID = '{0}'", id);
            SqlCommand cmd0 = new SqlCommand(sqlstr0, conn0);
            conn0.Open();
            SqlDataReader dr0 = cmd0.ExecuteReader();
            while (dr0.Read())
            {
                if (!dr0.IsDBNull(0))
                    class1 = dr0.GetInt32(0);
                else
                    class1 = -1;
                if (!dr0.IsDBNull(1))
                    class2 = dr0.GetInt32(1);
                else
                    class2 = -1;
            }
            dr0.Close();
            


            bool ok = false;
            
            SqlConnection conn = new SqlConnection(consql);
            string sqlstr = string.Format("select * from FaBu");
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TimeSpan ts = DateTime.Now - dr.GetDateTime(1);
                if (!(dr.GetBoolean(0) || ts.Seconds > 0))
                    ok = true;
            }
            dr.Close();

            if (ok)
            {
                int[] yy = new int[10];
                int i;
                bool first1 = true;
                bool first2 = true;
                string str1 = "";
                string str2 = "";
                yy[0] = DropDownList1.SelectedIndex;
                yy[1] = DropDownList2.SelectedIndex;
                yy[2] = DropDownList3.SelectedIndex;
                yy[3] = DropDownList4.SelectedIndex;
                yy[4] = DropDownList5.SelectedIndex;
                yy[5] = DropDownList6.SelectedIndex;
                yy[6] = DropDownList7.SelectedIndex;
                yy[7] = DropDownList8.SelectedIndex;
                yy[8] = DropDownList9.SelectedIndex;
                yy[9] = DropDownList10.SelectedIndex;
                if (classna1 == "无课程")
                {
                    if (classna2 == "无课程")
                        Label9.Text = "您没有需要预约的课程";
                    else
                    {
                        for (i = 0; i <= 9; i++)
                        {
                            if (yy[i] == 1)
                            {
                                if (!first1)
                                    str1 += " or";
                                str1 += string.Format(" CLASSTIME = {0}", i);
                                if (first1)
                                    first1 = false;
                            }
                            else
                            {
                                if (!first2)
                                    str2 += " or";
                                str2 += string.Format(" CLASSTIME = {0}", i);
                                if (first2)
                                    first2 = false;
                            }
                        }
                        if (!first1)
                        {
                            sqlstr = string.Format("update YYB set CLASS{0} = 100 where", class2) + str1;
                            SqlCommand cmd1 = new SqlCommand(sqlstr, conn);
                            int n = cmd1.ExecuteNonQuery();
                            if (n > 0)
                                Label9.Text = "提交成功！";
                            else
                                Label9.Text = "连接失败！";
                        }
                        if (!first2)
                        {
                            sqlstr = string.Format("update YYB set CLASS{0} = 0 where", class2) + str2;
                            SqlCommand cmd1 = new SqlCommand(sqlstr, conn);
                            int n = cmd1.ExecuteNonQuery();
                            if (n > 0)
                                Label9.Text = "提交成功！";
                            else
                                Label9.Text = "连接失败！";
                        }
                    }
                }
                else if (classna2 == "无课程")
                {
                    for (i = 0; i <= 9; i++)
                    {
                        if (yy[i] == 1)
                        {
                            if (!first1)
                                str1 += " or";
                            str1 += string.Format(" CLASSTIME = {0}", i);
                            if (first1)
                                first1 = false;
                        }
                        else
                        {
                            if (!first2)
                                str2 += " or";
                            str2 += string.Format(" CLASSTIME = {0}", i);
                            if (first2)
                                first2 = false;
                        }
                    }
                    if (!first1)
                    {
                        sqlstr = string.Format("update YYB set CLASS{0} = 100 where", class1) + str1;
                        SqlCommand cmd2 = new SqlCommand(sqlstr, conn);
                        int n = cmd2.ExecuteNonQuery();
                        if (n > 0)
                            Label9.Text = "提交成功！";
                        else
                            Label9.Text = "连接失败！";
                    }
                    if (!first2)
                    {
                        sqlstr = string.Format("update YYB set CLASS{0} = 0 where", class1) + str2;
                        SqlCommand cmd2 = new SqlCommand(sqlstr, conn);
                        int n = cmd2.ExecuteNonQuery();
                        if (n > 0)
                            Label9.Text = "提交成功！";
                        else
                            Label9.Text = "连接失败！";
                    }
                }
                else
                {
                    bool first3 = true;
                    bool first4 = true;
                    string str3 = "";
                    string str4 = "";
                    bool success = true;
                    for (i = 0; i <= 9; i++)
                    {
                        if (yy[i] == 0)
                        {
                            if (!first1)
                                str1 += " or";
                            str1 += string.Format(" CLASSTIME = {0}", i);
                            if (first1)
                                first1 = false;

                            if (!first2)
                                str2 += " or";
                            str2 += string.Format(" CLASSTIME = {0}", i);
                            if (first2)
                                first2 = false;
                        }
                        else if (yy[i] == 1)
                        {
                            if (!first3)
                                str3 += " or";
                            str3 += string.Format(" CLASSTIME = {0}", i);
                            if (first3)
                                first3 = false;

                            if (!first4)
                                str4 += " or";
                            str4 += string.Format(" CLASSTIME = {0}", i);
                            if (first4)
                                first4 = false;
                        }
                        else if (yy[i] == 2)
                        {
                            if (!first3)
                                str3 += " or";
                            str3 += string.Format(" CLASSTIME = {0}", i);
                            if (first3)
                                first3 = false;

                            if (!first2)
                                str2 += " or";
                            str2 += string.Format(" CLASSTIME = {0}", i);
                            if (first2)
                                first2 = false;
                        }
                        else if (yy[i] == 3)
                        {
                            if (!first4)
                                str4 += " or";
                            str4 += string.Format(" CLASSTIME = {0}", i);
                            if (first4)
                                first4 = false;

                            if (!first1)
                                str1 += " or";
                            str1 += string.Format(" CLASSTIME = {0}", i);
                            if (first1)
                                first1 = false;
                        }
                    }

                    if (!first1)
                    {
                        sqlstr = string.Format("update YYB set CLASS{0} = 0 where", class1) + str1;
                        SqlCommand cmd3 = new SqlCommand(sqlstr, conn);
                        int n1 = cmd3.ExecuteNonQuery();
                        if (n1 <= 0)
                            success = false;
                    }

                    string sqlstr2;
                    if (!first2)
                    {
                        sqlstr2 = string.Format("update YYB set CLASS{0} = 0 where", class2) + str2;
                        SqlCommand cmd4 = new SqlCommand(sqlstr2, conn);
                        int n2 = cmd4.ExecuteNonQuery();
                        if (n2 <= 0)
                            success = false;
                    }

                    string sqlstr3;
                    if (!first3)
                    {
                        sqlstr3 = string.Format("update YYB set CLASS{0} = 100 where", class1) + str3;
                        SqlCommand cmd5 = new SqlCommand(sqlstr3, conn);
                        int n3 = cmd5.ExecuteNonQuery();
                        if (n3 <= 0)
                            success = false;
                    }

                    string sqlstr4;
                    if (!first4)
                    {
                        sqlstr4 = string.Format("update YYB set CLASS{0} = 100 where", class2) + str4;
                        SqlCommand cmd6 = new SqlCommand(sqlstr4, conn);
                        int n4 = cmd6.ExecuteNonQuery();
                        if (n4 <= 0)
                            success = false;
                    }

                    
                    if (success)
                        Label9.Text = "提交成功！";
                    else
                        Label9.Text = "提交失败！";
                    
                }
            }
            else
            {
                Label9.Text = "当前时刻未开放预约";
            }
        }
        catch
        {
            Response.Write("<script>alert('网络错误！')</script>");
        }
    }
}