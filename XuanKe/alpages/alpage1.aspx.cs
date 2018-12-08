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
    static int[] itv = new int[10];

    protected void Page_Load(object sender, EventArgs e)
    {
        ChangeColor();
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
                    string sqlstr = string.Format("select CLASSID,CLASSNAME,CLASSTIME,INTERVAL from CSM");
                    SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
                    da.Fill(dta);

                    for (int i = 0; i <= 9; i++)
                    {
                        itv[i] = (int)dta.Rows[i][3];
                    }


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
                    DropDownList11.Items.Add("无课程");
                    DropDownList13.Items.Add("无课程");
                    DropDownList15.Items.Add("无课程");
                    DropDownList17.Items.Add("无课程");
                    DropDownList19.Items.Add("无课程");
                    DropDownList12.Items.Add("无课程");
                    DropDownList14.Items.Add("无课程");
                    DropDownList16.Items.Add("无课程");
                    DropDownList18.Items.Add("无课程");
                    DropDownList20.Items.Add("无课程");

                    for (int i = 0; i <= 9; i++)
                    {
                        string csna = dta.Rows[i][1].ToString();
                        if ((int)dta.Rows[i][3] == 1)
                        {
                            csna += "(单/双周)";
                        }
                        DropDownList1.Items.Add(csna);
                        DropDownList3.Items.Add(csna);
                        DropDownList5.Items.Add(csna);
                        DropDownList7.Items.Add(csna);
                        DropDownList9.Items.Add(csna);
                        DropDownList2.Items.Add(csna);
                        DropDownList4.Items.Add(csna);
                        DropDownList6.Items.Add(csna);
                        DropDownList8.Items.Add(csna);
                        DropDownList10.Items.Add(csna);
                        DropDownList11.Items.Add(csna);
                        DropDownList13.Items.Add(csna);
                        DropDownList15.Items.Add(csna);
                        DropDownList17.Items.Add(csna);
                        DropDownList19.Items.Add(csna);
                        DropDownList12.Items.Add(csna);
                        DropDownList14.Items.Add(csna);
                        DropDownList16.Items.Add(csna);
                        DropDownList18.Items.Add(csna);
                        DropDownList20.Items.Add(csna);
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
                    DropDownList11.SelectedIndex = 0;
                    DropDownList13.SelectedIndex = 0;
                    DropDownList15.SelectedIndex = 0;
                    DropDownList17.SelectedIndex = 0;
                    DropDownList19.SelectedIndex = 0;
                    DropDownList12.SelectedIndex = 0;
                    DropDownList14.SelectedIndex = 0;
                    DropDownList16.SelectedIndex = 0;
                    DropDownList18.SelectedIndex = 0;
                    DropDownList20.SelectedIndex = 0;

                    for (int i = 0; i <= 9; i++)
                    {
                        if ((int)dta.Rows[i][2] == 0)
                        {
                            DropDownList1.SelectedIndex = (int)dta.Rows[i][0] + 1;
                            if ((int)dta.Rows[i][3] == 0)
                            {
                                DropDownList11.SelectedIndex = (int)dta.Rows[i][0] + 1;
                            }
                        }
                        if ((int)dta.Rows[i][2] == 1)
                        {
                            DropDownList2.SelectedIndex = (int)dta.Rows[i][0] + 1;
                            if ((int)dta.Rows[i][3] == 0)
                            {
                                DropDownList12.SelectedIndex = (int)dta.Rows[i][0] + 1;
                            }
                        }
                        if ((int)dta.Rows[i][2] == 2)
                        {
                            DropDownList3.SelectedIndex = (int)dta.Rows[i][0] + 1;
                            if ((int)dta.Rows[i][3] == 0)
                            {
                                DropDownList13.SelectedIndex = (int)dta.Rows[i][0] + 1;
                            }
                        }
                        if ((int)dta.Rows[i][2] == 3)
                        {
                            DropDownList4.SelectedIndex = (int)dta.Rows[i][0] + 1;
                            if ((int)dta.Rows[i][3] == 0)
                            {
                                DropDownList14.SelectedIndex = (int)dta.Rows[i][0] + 1;
                            }
                        }
                        if ((int)dta.Rows[i][2] == 4)
                        {
                            DropDownList5.SelectedIndex = (int)dta.Rows[i][0] + 1;
                            if ((int)dta.Rows[i][3] == 0)
                            {
                                DropDownList15.SelectedIndex = (int)dta.Rows[i][0] + 1;
                            }
                        }
                        if ((int)dta.Rows[i][2] == 5)
                        {
                            DropDownList6.SelectedIndex = (int)dta.Rows[i][0] + 1;
                            if ((int)dta.Rows[i][3] == 0)
                            {
                                DropDownList16.SelectedIndex = (int)dta.Rows[i][0] + 1;
                            }
                        }
                        if ((int)dta.Rows[i][2] == 6)
                        {
                            DropDownList7.SelectedIndex = (int)dta.Rows[i][0] + 1;
                            if ((int)dta.Rows[i][3] == 0)
                            {
                                DropDownList17.SelectedIndex = (int)dta.Rows[i][0] + 1;
                            }
                        }
                        if ((int)dta.Rows[i][2] == 7)
                        {
                            DropDownList8.SelectedIndex = (int)dta.Rows[i][0] + 1;
                            if ((int)dta.Rows[i][3] == 0)
                            {
                                DropDownList18.SelectedIndex = (int)dta.Rows[i][0] + 1;
                            }
                        }
                        if ((int)dta.Rows[i][2] == 8)
                        {
                            DropDownList9.SelectedIndex = (int)dta.Rows[i][0] + 1;
                            if ((int)dta.Rows[i][3] == 0)
                            {
                                DropDownList19.SelectedIndex = (int)dta.Rows[i][0] + 1;
                            }
                        }
                        if ((int)dta.Rows[i][2] == 9)
                        {
                            DropDownList10.SelectedIndex = (int)dta.Rows[i][0] + 1;
                            if ((int)dta.Rows[i][3] == 0)
                            {
                                DropDownList20.SelectedIndex = (int)dta.Rows[i][0] + 1;
                            }
                        }
                        if ((int)dta.Rows[i][2] == 10)
                        {
                            DropDownList11.SelectedIndex = (int)dta.Rows[i][0] + 1;
                        }
                        if ((int)dta.Rows[i][2] == 11)
                        {
                            DropDownList12.SelectedIndex = (int)dta.Rows[i][0] + 1;
                        }
                        if ((int)dta.Rows[i][2] == 12)
                        {
                            DropDownList13.SelectedIndex = (int)dta.Rows[i][0] + 1;
                        }
                        if ((int)dta.Rows[i][2] == 13)
                        {
                            DropDownList14.SelectedIndex = (int)dta.Rows[i][0] + 1;
                        }
                        if ((int)dta.Rows[i][2] == 14)
                        {
                            DropDownList15.SelectedIndex = (int)dta.Rows[i][0] + 1;
                        }
                        if ((int)dta.Rows[i][2] == 15)
                        {
                            DropDownList16.SelectedIndex = (int)dta.Rows[i][0] + 1;
                        }
                        if ((int)dta.Rows[i][2] == 16)
                        {
                            DropDownList17.SelectedIndex = (int)dta.Rows[i][0] + 1;
                        }
                        if ((int)dta.Rows[i][2] == 17)
                        {
                            DropDownList18.SelectedIndex = (int)dta.Rows[i][0] + 1;
                        }
                        if ((int)dta.Rows[i][2] == 18)
                        {
                            DropDownList19.SelectedIndex = (int)dta.Rows[i][0] + 1;
                        }
                        if ((int)dta.Rows[i][2] == 19)
                        {
                            DropDownList20.SelectedIndex = (int)dta.Rows[i][0] + 1;
                        }
                    }
                    ChangeColor();



                    DateTime dt2 = new DateTime();
                    DateTime dt1 = new DateTime();
                    bool isok = false;
                    string sqlstr2 = string.Format("select * from FaBu");
                    SqlCommand cmd = new SqlCommand(sqlstr2, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        isok = dr.GetBoolean(0);
                        dt1 = dr.GetDateTime(1);
                        dt2 = dr.GetDateTime(2);
                    }
                    TextBox1.Text = dt1.ToString();
                    TextBox2.Text = dt2.ToString();

                    TimeSpan ts = DateTime.Now - dt2;
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
        string strDate1 = TextBox1.Text;
        string strDate2 = TextBox2.Text;
        DateTime dt1;
        DateTime dt2;
        int[] fb = new int[20];
        if (DateTime.TryParse(strDate1, out dt1)&&DateTime.TryParse(strDate2,out dt2))
        {
            fb[0] = DropDownList1.SelectedIndex;
            fb[1] = DropDownList2.SelectedIndex;
            fb[2] = DropDownList3.SelectedIndex;
            fb[3] = DropDownList4.SelectedIndex;
            fb[4] = DropDownList5.SelectedIndex;
            //fb[5] = DropDownList6.SelectedIndex;
            fb[5] = 1;
            fb[6] = DropDownList7.SelectedIndex;
            fb[7] = DropDownList8.SelectedIndex;
            fb[8] = DropDownList9.SelectedIndex;
            fb[9] = DropDownList10.SelectedIndex;
            fb[10] = DropDownList11.SelectedIndex;
            fb[11] = DropDownList12.SelectedIndex;
            fb[12] = DropDownList13.SelectedIndex;
            fb[13] = DropDownList14.SelectedIndex;
            fb[14] = DropDownList15.SelectedIndex;
            //fb[15] = DropDownList16.SelectedIndex;
            fb[15] = 6;
            fb[16] = DropDownList17.SelectedIndex;
            fb[17] = DropDownList18.SelectedIndex;
            fb[18] = DropDownList19.SelectedIndex;
            fb[19] = DropDownList20.SelectedIndex;

            
            int[] ccc = new int[10];
            for (int i = 19; i >= 0; i--)
            {
                if (fb[i]!= 0)
                {
                    ccc[fb[i] - 1]++;
                }
            }

            int x = 0;
            int y = 0;
            for (int i = 9; i >= 0; i--)
            {
                if (i != 5 && i != 0)
                {
                    if (itv[i] == 0)
                    {
                        if (ccc[i] > 2)
                        {
                            x = i + 1;
                        }
                        if (ccc[i] == 0)
                        {
                            y = i + 1;
                        }
                    }
                    else
                    {
                        if (ccc[i] > 1)
                        {
                            x = i + 1;
                        }
                        if (ccc[i] == 0)
                        {
                            y = i + 1;
                        }
                    }
                }
            }
            if (x != 0 )
            {
                Response.Write("<script>alert('"+DropDownList1.Items[x].ToString() + "被选择了多次!')</script>");
            }
            else if (y != 0)
            {
                Response.Write("<script>alert('" + DropDownList1.Items[y].ToString() + "未被选择!')</script>");
            }
            else
            {
                int comp = DateTime.Compare(dt1, dt2);
                if (comp > 0)
                {
                    Response.Write("<script>alert('发布时间早于截止时间！')</script>");
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
                            if (fb[i] != 0)
                            {
                                sqlstr += string.Format("update CSM set CLASSTIME = {0} where CLASSID = {1};", i, fb[i] - 1);
                            }
                        }
                        for (int i = 10; i <= 19; i++)
                        {
                            if (fb[i] != 0 && itv[fb[i] - 1] == 1)
                            {
                                sqlstr += string.Format("update CSM set CLASSTIME = {0} where CLASSID = {1};", i, fb[i] - 1);
                            }
                        }
                        SqlCommand cmd1 = new SqlCommand(sqlstr, conn);
                        int n1 = cmd1.ExecuteNonQuery();

                        string sqlstr1 = string.Format("update FaBu set DEADTIME = '{0}',FABUTIME = '{1}';", dt1.ToString(), dt2.ToString());
                        SqlCommand cmd2 = new SqlCommand(sqlstr1, conn);
                        int n2 = cmd2.ExecuteNonQuery();

                        if (n1 > 0 && n2 > 0)
                            Response.Write("<script>alert('保存成功！')</script>");
                        else
                            Response.Write("<script>alert('保存失败，请重试！')</script>");
                        conn.Close();
                    }
                    catch
                    {
                        Response.Write("<script>alert('网络错误！')</script>");
                    }
                }
            }
        }
        else
        {
            Response.Write("<script>alert('日期格式错误！')</script>");
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
                string strsql = string.Format("update FaBu set ISOK = 0,FABUTIME='{0}';", dt.ToString());
                SqlCommand cmd = new SqlCommand(strsql, conn);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    TextBox2.Text = dt.ToString();
                    Button2.Text = "立刻发布";
                    Response.Write("<script>alert('停止发布成功！')</script>");
                }
                else
                    Response.Write("<script>alert('停止发布失败！')</script>");
            }
            else
            {
                DateTime dt = DateTime.Now;
                string strsql = string.Format("update FaBu set ISOK = 1,FABUTIME='{0}';", dt.ToString());
                SqlCommand cmd = new SqlCommand(strsql, conn);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    TextBox2.Text = dt.ToString();
                    Button2.Text = "停止发布";
                    Response.Write("<script>alert('发布成功！')</script>");
                }
                else
                    Response.Write("<script>alert('发布失败！')</script>");
            }
            conn.Close();
        }
        catch
        {
            Response.Write("<script>alert('网络错误！')</script>");
        }
    }

    public int GetInterval(int cid)
    {
        if (cid >= 0)
            return itv[cid];
        return -1;
    }

    void ChangeColor()
    {
        switch (GetInterval(DropDownList1.SelectedIndex - 1))
        {
            case 1:DropDownList1.BackColor= System.Drawing.Color.FromName("#FFFFCC");break;
            case 0: DropDownList1.BackColor = System.Drawing.Color.FromName("#CCCCFF"); break;
            case -1: DropDownList1.BackColor = System.Drawing.Color.FromName("#FFFFFF"); break;
        }
        switch (GetInterval(DropDownList2.SelectedIndex - 1))
        {
            case 1: DropDownList2.BackColor = System.Drawing.Color.FromName("#FFFFCC"); break;
            case 0: DropDownList2.BackColor = System.Drawing.Color.FromName("#CCCCFF"); break;
            case -1: DropDownList2.BackColor = System.Drawing.Color.FromName("#FFFFFF"); break;
        }
        switch (GetInterval(DropDownList3.SelectedIndex - 1))
        {
            case 1: DropDownList3.BackColor = System.Drawing.Color.FromName("#FFFFCC"); break;
            case 0: DropDownList3.BackColor = System.Drawing.Color.FromName("#CCCCFF"); break;
            case -1: DropDownList4.BackColor = System.Drawing.Color.FromName("#FFFFFF"); break;
        }
        switch (GetInterval(DropDownList4.SelectedIndex - 1))
        {
            case 1: DropDownList4.BackColor = System.Drawing.Color.FromName("#FFFFCC"); break;
            case 0: DropDownList4.BackColor = System.Drawing.Color.FromName("#CCCCFF"); break;
            case -1: DropDownList4.BackColor = System.Drawing.Color.FromName("#FFFFFF"); break;
        }
        switch (GetInterval(DropDownList5.SelectedIndex - 1))
        {
            case 1: DropDownList5.BackColor = System.Drawing.Color.FromName("#FFFFCC"); break;
            case 0: DropDownList5.BackColor = System.Drawing.Color.FromName("#CCCCFF"); break;
            case -1: DropDownList5.BackColor = System.Drawing.Color.FromName("#FFFFFF"); break;
        }
        switch (GetInterval(DropDownList6.SelectedIndex - 1))
        {
            case 1: DropDownList6.BackColor = System.Drawing.Color.FromName("#FFFFCC"); break;
            case 0: DropDownList6.BackColor = System.Drawing.Color.FromName("#CCCCFF"); break;
            case -1: DropDownList6.BackColor = System.Drawing.Color.FromName("#FFFFFF"); break;
        }
        switch (GetInterval(DropDownList7.SelectedIndex - 1))
        {
            case 1: DropDownList7.BackColor = System.Drawing.Color.FromName("#FFFFCC"); break;
            case 0: DropDownList7.BackColor = System.Drawing.Color.FromName("#CCCCFF"); break;
            case -1: DropDownList7.BackColor = System.Drawing.Color.FromName("#FFFFFF"); break;
        }
        switch (GetInterval(DropDownList8.SelectedIndex - 1))
        {
            case 1: DropDownList8.BackColor = System.Drawing.Color.FromName("#FFFFCC"); break;
            case 0: DropDownList8.BackColor = System.Drawing.Color.FromName("#CCCCFF"); break;
            case -1: DropDownList8.BackColor = System.Drawing.Color.FromName("#FFFFFF"); break;
        }
        switch (GetInterval(DropDownList9.SelectedIndex - 1))
        {
            case 1: DropDownList9.BackColor = System.Drawing.Color.FromName("#FFFFCC"); break;
            case 0: DropDownList9.BackColor = System.Drawing.Color.FromName("#CCCCFF"); break;
            case -1: DropDownList9.BackColor = System.Drawing.Color.FromName("#FFFFFF"); break;
        }
        switch (GetInterval(DropDownList10.SelectedIndex - 1))
        {
            case 1: DropDownList10.BackColor = System.Drawing.Color.FromName("#FFFFCC"); break;
            case 0: DropDownList10.BackColor = System.Drawing.Color.FromName("#CCCCFF"); break;
            case -1: DropDownList10.BackColor = System.Drawing.Color.FromName("#FFFFFF"); break;
        }
        switch (GetInterval(DropDownList11.SelectedIndex - 1))
        {
            case 1: DropDownList11.BackColor = System.Drawing.Color.FromName("#FFFFCC"); break;
            case 0: DropDownList11.BackColor = System.Drawing.Color.FromName("#CCCCFF"); break;
            case -1: DropDownList11.BackColor = System.Drawing.Color.FromName("#FFFFFF"); break;
        }
        switch (GetInterval(DropDownList12.SelectedIndex - 1))
        {
            case 1: DropDownList12.BackColor = System.Drawing.Color.FromName("#FFFFCC"); break;
            case 0: DropDownList12.BackColor = System.Drawing.Color.FromName("#CCCCFF"); break;
            case -1: DropDownList12.BackColor = System.Drawing.Color.FromName("#FFFFFF"); break;
        }
        switch (GetInterval(DropDownList13.SelectedIndex - 1))
        {
            case 1: DropDownList13.BackColor = System.Drawing.Color.FromName("#FFFFCC"); break;
            case 0: DropDownList13.BackColor = System.Drawing.Color.FromName("#CCCCFF"); break;
            case -1: DropDownList13.BackColor = System.Drawing.Color.FromName("#FFFFFF"); break;
        }
        switch (GetInterval(DropDownList14.SelectedIndex - 1))
        {
            case 1: DropDownList14.BackColor = System.Drawing.Color.FromName("#FFFFCC"); break;
            case 0: DropDownList14.BackColor = System.Drawing.Color.FromName("#CCCCFF"); break;
            case -1: DropDownList14.BackColor = System.Drawing.Color.FromName("#FFFFFF"); break;
        }
        switch (GetInterval(DropDownList15.SelectedIndex - 1))
        {
            case 1: DropDownList15.BackColor = System.Drawing.Color.FromName("#FFFFCC"); break;
            case 0: DropDownList15.BackColor = System.Drawing.Color.FromName("#CCCCFF"); break;
            case -1: DropDownList15.BackColor = System.Drawing.Color.FromName("#FFFFFF"); break;
        }
        switch (GetInterval(DropDownList16.SelectedIndex - 1))
        {
            case 1: DropDownList16.BackColor = System.Drawing.Color.FromName("#FFFFCC"); break;
            case 0: DropDownList16.BackColor = System.Drawing.Color.FromName("#CCCCFF"); break;
            case -1: DropDownList16.BackColor = System.Drawing.Color.FromName("#FFFFFF"); break;
        }
        switch (GetInterval(DropDownList17.SelectedIndex - 1))
        {
            case 1: DropDownList17.BackColor = System.Drawing.Color.FromName("#FFFFCC"); break;
            case 0: DropDownList17.BackColor = System.Drawing.Color.FromName("#CCCCFF"); break;
            case -1: DropDownList17.BackColor = System.Drawing.Color.FromName("#FFFFFF"); break;
        }
        switch (GetInterval(DropDownList18.SelectedIndex - 1))
        {
            case 1: DropDownList18.BackColor = System.Drawing.Color.FromName("#FFFFCC"); break;
            case 0: DropDownList18.BackColor = System.Drawing.Color.FromName("#CCCCFF"); break;
            case -1: DropDownList18.BackColor = System.Drawing.Color.FromName("#FFFFFF"); break;
        }
        switch (GetInterval(DropDownList19.SelectedIndex - 1))
        {
            case 1: DropDownList19.BackColor = System.Drawing.Color.FromName("#FFFFCC"); break;
            case 0: DropDownList19.BackColor = System.Drawing.Color.FromName("#CCCCFF"); break;
            case -1: DropDownList19.BackColor = System.Drawing.Color.FromName("#FFFFFF"); break;
        }
        switch (GetInterval(DropDownList20.SelectedIndex - 1))
        {
            case 1: DropDownList20.BackColor = System.Drawing.Color.FromName("#FFFFCC"); break;
            case 0: DropDownList20.BackColor = System.Drawing.Color.FromName("#CCCCFF"); break;
            case -1: DropDownList20.BackColor = System.Drawing.Color.FromName("#FFFFFF"); break;
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GetInterval(DropDownList1.SelectedIndex - 1) == 0)
        {
            if (DropDownList11.SelectedIndex != DropDownList1.SelectedIndex)
            {
                DropDownList11.SelectedIndex = DropDownList1.SelectedIndex;
            }
        }
        else if (GetInterval(DropDownList1.SelectedIndex - 1) == 1)
        {
            if (GetInterval(DropDownList11.SelectedIndex - 1) == 0)
            {
                DropDownList11.SelectedIndex = 0;
            }
        }
        else
        {
            if (GetInterval(DropDownList11.SelectedIndex - 1) == 0)
            {
                DropDownList11.SelectedIndex = 0;
            }
        }
        ChangeColor();
    }

    
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GetInterval(DropDownList2.SelectedIndex - 1) == 0)
        {
            if (DropDownList12.SelectedIndex != DropDownList2.SelectedIndex)
            {
                DropDownList12.SelectedIndex = DropDownList2.SelectedIndex;
            }
        }
        else if (GetInterval(DropDownList2.SelectedIndex - 1) == 1)
        {
            if (GetInterval(DropDownList12.SelectedIndex - 1) == 0)
            {
                DropDownList12.SelectedIndex = 0;
            }
        }
        else
        {
            if (GetInterval(DropDownList12.SelectedIndex - 1) == 0)
            {
                DropDownList12.SelectedIndex = 0;
            }
        }
        ChangeColor();
    }

    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GetInterval(DropDownList3.SelectedIndex - 1) == 0)
        {
            if (DropDownList13.SelectedIndex != DropDownList3.SelectedIndex)
            {
                DropDownList13.SelectedIndex = DropDownList3.SelectedIndex;
            }
        }
        else if (GetInterval(DropDownList3.SelectedIndex - 1) == 1)
        {
            if (GetInterval(DropDownList13.SelectedIndex - 1) == 0)
            {
                DropDownList13.SelectedIndex = 0;
            }
        }
        else
        {
            if (GetInterval(DropDownList13.SelectedIndex - 1) == 0)
            {
                DropDownList13.SelectedIndex = 0;
            }
        }
        ChangeColor();
    }



    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GetInterval(DropDownList4.SelectedIndex - 1) == 0)
        {
            if (DropDownList14.SelectedIndex != DropDownList4.SelectedIndex)
            {
                DropDownList14.SelectedIndex = DropDownList4.SelectedIndex;
            }
        }
        else if (GetInterval(DropDownList4.SelectedIndex - 1) == 1)
        {
            if (GetInterval(DropDownList14.SelectedIndex - 1) == 0)
            {
                DropDownList14.SelectedIndex = 0;
            }
        }
        else
        {
            if (GetInterval(DropDownList14.SelectedIndex - 1) == 0)
            {
                DropDownList14.SelectedIndex = 0;
            }
        }
        ChangeColor();
    }

    protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GetInterval(DropDownList5.SelectedIndex - 1) == 0)
        {
            if (DropDownList15.SelectedIndex != DropDownList5.SelectedIndex)
            {
                DropDownList15.SelectedIndex = DropDownList5.SelectedIndex;
            }
        }
        else if (GetInterval(DropDownList5.SelectedIndex - 1) == 1)
        {
            if (GetInterval(DropDownList15.SelectedIndex - 1) == 0)
            {
                DropDownList15.SelectedIndex = 0;
            }
        }
        else
        {
            if (GetInterval(DropDownList15.SelectedIndex - 1) == 0)
            {
                DropDownList15.SelectedIndex = 0;
            }
        }
        ChangeColor();
    }

    protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GetInterval(DropDownList6.SelectedIndex - 1) == 0)
        {
            if (DropDownList16.SelectedIndex != DropDownList6.SelectedIndex)
            {
                DropDownList16.SelectedIndex = DropDownList6.SelectedIndex;
            }
        }
        else if (GetInterval(DropDownList6.SelectedIndex - 1) == 1)
        {
            if (GetInterval(DropDownList16.SelectedIndex - 1) == 0)
            {
                DropDownList16.SelectedIndex = 0;
            }
        }
        else
        {
            if (GetInterval(DropDownList16.SelectedIndex - 1) == 0)
            {
                DropDownList16.SelectedIndex = 0;
            }
        }
        ChangeColor();
    }

    protected void DropDownList7_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GetInterval(DropDownList7.SelectedIndex - 1) == 0)
        {
            if (DropDownList17.SelectedIndex != DropDownList7.SelectedIndex)
            {
                DropDownList17.SelectedIndex = DropDownList7.SelectedIndex;
            }
        }
        else if (GetInterval(DropDownList7.SelectedIndex - 1) == 1)
        {
            if (GetInterval(DropDownList17.SelectedIndex - 1) == 0)
            {
                DropDownList17.SelectedIndex = 0;
            }
        }
        else
        {
            if (GetInterval(DropDownList17.SelectedIndex - 1) == 0)
            {
                DropDownList17.SelectedIndex = 0;
            }
        }
        ChangeColor();
    }

    protected void DropDownList8_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GetInterval(DropDownList8.SelectedIndex - 1) == 0)
        {
            if (DropDownList18.SelectedIndex != DropDownList8.SelectedIndex)
            {
                DropDownList18.SelectedIndex = DropDownList8.SelectedIndex;
            }
        }
        else if (GetInterval(DropDownList8.SelectedIndex - 1) == 1)
        {
            if (GetInterval(DropDownList18.SelectedIndex - 1) == 0)
            {
                DropDownList18.SelectedIndex = 0;
            }
        }
        else
        {
            if (GetInterval(DropDownList18.SelectedIndex - 1) == 0)
            {
                DropDownList18.SelectedIndex = 0;
            }
        }
        ChangeColor();
    }

    protected void DropDownList9_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GetInterval(DropDownList9.SelectedIndex - 1) == 0)
        {
            if (DropDownList19.SelectedIndex != DropDownList9.SelectedIndex)
            {
                DropDownList19.SelectedIndex = DropDownList9.SelectedIndex;
            }
        }
        else if (GetInterval(DropDownList9.SelectedIndex - 1) == 1)
        {
            if (GetInterval(DropDownList19.SelectedIndex - 1) == 0)
            {
                DropDownList19.SelectedIndex = 0;
            }
        }
        else
        {
            if (GetInterval(DropDownList19.SelectedIndex - 1) == 0)
            {
                DropDownList19.SelectedIndex = 0;
            }
        }
        ChangeColor();
    }

    protected void DropDownList10_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GetInterval(DropDownList10.SelectedIndex - 1) == 0)
        {
            if (DropDownList20.SelectedIndex != DropDownList10.SelectedIndex)
            {
                DropDownList20.SelectedIndex = DropDownList10.SelectedIndex;
            }
        }
        else if (GetInterval(DropDownList10.SelectedIndex - 1) == 1)
        {
            if (GetInterval(DropDownList20.SelectedIndex - 1) == 0)
            {
                DropDownList20.SelectedIndex = 0;
            }
        }
        else
        {
            if (GetInterval(DropDownList20.SelectedIndex - 1) == 0)
            {
                DropDownList20.SelectedIndex = 0;
            }
        }
        ChangeColor();
    }

    protected void DropDownList11_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GetInterval(DropDownList11.SelectedIndex - 1) == 0)
        {
            if (DropDownList1.SelectedIndex != DropDownList11.SelectedIndex)
            {
                DropDownList1.SelectedIndex = DropDownList11.SelectedIndex;
            }
        }
        else if (GetInterval(DropDownList11.SelectedIndex - 1) == 1)
        {
            if (GetInterval(DropDownList1.SelectedIndex - 1) == 0)
            {
                DropDownList1.SelectedIndex = 0;
            }
        }
        else
        {
            if (GetInterval(DropDownList1.SelectedIndex - 1) == 0)
            {
                DropDownList1.SelectedIndex = 0;
            }
        }
        ChangeColor();
    }

    protected void DropDownList12_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GetInterval(DropDownList12.SelectedIndex - 1) == 0)
        {
            if (DropDownList2.SelectedIndex != DropDownList12.SelectedIndex)
            {
                DropDownList2.SelectedIndex = DropDownList12.SelectedIndex;
            }
        }
        else if (GetInterval(DropDownList12.SelectedIndex - 1) == 1)
        {
            if (GetInterval(DropDownList2.SelectedIndex - 1) == 0)
            {
                DropDownList2.SelectedIndex = 0;
            }
        }
        else
        {
            if (GetInterval(DropDownList2.SelectedIndex - 1) == 0)
            {
                DropDownList2.SelectedIndex = 0;
            }
        }
        ChangeColor();
    }

    protected void DropDownList13_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GetInterval(DropDownList13.SelectedIndex - 1) == 0)
        {
            if (DropDownList3.SelectedIndex != DropDownList13.SelectedIndex)
            {
                DropDownList3.SelectedIndex = DropDownList13.SelectedIndex;
            }
        }
        else if (GetInterval(DropDownList13.SelectedIndex - 1) == 1)
        {
            if (GetInterval(DropDownList3.SelectedIndex - 1) == 0)
            {
                DropDownList3.SelectedIndex = 0;
            }
        }
        else
        {
            if (GetInterval(DropDownList3.SelectedIndex - 1) == 0)
            {
                DropDownList3.SelectedIndex = 0;
            }
        }
        ChangeColor();
    }

    protected void DropDownList14_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GetInterval(DropDownList14.SelectedIndex - 1) == 0)
        {
            if (DropDownList4.SelectedIndex != DropDownList14.SelectedIndex)
            {
                DropDownList4.SelectedIndex = DropDownList14.SelectedIndex;
            }
        }
        else if (GetInterval(DropDownList14.SelectedIndex - 1) == 1)
        {
            if (GetInterval(DropDownList4.SelectedIndex - 1) == 0)
            {
                DropDownList4.SelectedIndex = 0;
            }
        }
        else
        {
            if (GetInterval(DropDownList4.SelectedIndex - 1) == 0)
            {
                DropDownList4.SelectedIndex = 0;
            }
        }
        ChangeColor();
    }

    protected void DropDownList15_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GetInterval(DropDownList15.SelectedIndex - 1) == 0)
        {
            if (DropDownList5.SelectedIndex != DropDownList15.SelectedIndex)
            {
                DropDownList5.SelectedIndex = DropDownList15.SelectedIndex;
            }
        }
        else if (GetInterval(DropDownList15.SelectedIndex - 1) == 1)
        {
            if (GetInterval(DropDownList5.SelectedIndex - 1) == 0)
            {
                DropDownList5.SelectedIndex = 0;
            }
        }
        else
        {
            if (GetInterval(DropDownList5.SelectedIndex - 1) == 0)
            {
                DropDownList5.SelectedIndex = 0;
            }
        }
        ChangeColor();
    }

    protected void DropDownList16_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GetInterval(DropDownList16.SelectedIndex - 1) == 0)
        {
            if (DropDownList6.SelectedIndex != DropDownList16.SelectedIndex)
            {
                DropDownList6.SelectedIndex = DropDownList16.SelectedIndex;
            }
        }
        else if (GetInterval(DropDownList16.SelectedIndex - 1) == 1)
        {
            if (GetInterval(DropDownList6.SelectedIndex - 1) == 0)
            {
                DropDownList6.SelectedIndex = 0;
            }
        }
        else
        {
            if (GetInterval(DropDownList6.SelectedIndex - 1) == 0)
            {
                DropDownList6.SelectedIndex = 0;
            }
        }
        ChangeColor();
    }

    protected void DropDownList17_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GetInterval(DropDownList17.SelectedIndex - 1) == 0)
        {
            if (DropDownList7.SelectedIndex != DropDownList17.SelectedIndex)
            {
                DropDownList7.SelectedIndex = DropDownList17.SelectedIndex;
            }
        }
        else if (GetInterval(DropDownList17.SelectedIndex - 1) == 1)
        {
            if (GetInterval(DropDownList7.SelectedIndex - 1) == 0)
            {
                DropDownList7.SelectedIndex = 0;
            }
        }
        else
        {
            if (GetInterval(DropDownList7.SelectedIndex - 1) == 0)
            {
                DropDownList7.SelectedIndex = 0;
            }
        }
        ChangeColor();
    }

    protected void DropDownList18_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GetInterval(DropDownList18.SelectedIndex - 1) == 0)
        {
            if (DropDownList8.SelectedIndex != DropDownList18.SelectedIndex)
            {
                DropDownList8.SelectedIndex = DropDownList18.SelectedIndex;
            }
        }
        else if (GetInterval(DropDownList18.SelectedIndex - 1) == 1)
        {
            if (GetInterval(DropDownList8.SelectedIndex - 1) == 0)
            {
                DropDownList8.SelectedIndex = 0;
            }
        }
        else
        {
            if (GetInterval(DropDownList8.SelectedIndex - 1) == 0)
            {
                DropDownList8.SelectedIndex = 0;
            }
        }
        ChangeColor();
    }

    protected void DropDownList19_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GetInterval(DropDownList19.SelectedIndex - 1) == 0)
        {
            if (DropDownList9.SelectedIndex != DropDownList19.SelectedIndex)
            {
                DropDownList9.SelectedIndex = DropDownList19.SelectedIndex;
            }
        }
        else if (GetInterval(DropDownList19.SelectedIndex - 1) == 1)
        {
            if (GetInterval(DropDownList9.SelectedIndex - 1) == 0)
            {
                DropDownList9.SelectedIndex = 0;
            }
        }
        else
        {
            if (GetInterval(DropDownList9.SelectedIndex - 1) == 0)
            {
                DropDownList9.SelectedIndex = 0;
            }
        }
        ChangeColor();
    }

    protected void DropDownList20_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (GetInterval(DropDownList20.SelectedIndex - 1) == 0)
        {
            if (DropDownList10.SelectedIndex != DropDownList20.SelectedIndex)
            {
                DropDownList10.SelectedIndex = DropDownList20.SelectedIndex;
            }
        }
        else if (GetInterval(DropDownList20.SelectedIndex - 1) == 1)
        {
            if (GetInterval(DropDownList10.SelectedIndex - 1) == 0)
            {
                DropDownList10.SelectedIndex = 0;
            }
        }
        else
        {
            if (GetInterval(DropDownList10.SelectedIndex - 1) == 0)
            {
                DropDownList10.SelectedIndex = 0;
            }
        }
        ChangeColor();
    }
}