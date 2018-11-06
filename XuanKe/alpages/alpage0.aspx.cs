using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;



class ClassMessage
{
    public int grade;
    public int order;
    public int isArranged;
    public int timeno;

    public ClassMessage(int i,int o)
    {
        var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
        SqlConnection conn = new SqlConnection(consql);
        string sqlstr = string.Format("select XueFen from CSM where CLASSID = {0}", i);
        SqlCommand cdm = new SqlCommand(sqlstr, conn);
        conn.Open();
        SqlDataReader dr = cdm.ExecuteReader();
        while (dr.Read())
        {
            this.grade = dr.GetInt32(0);
        }
        conn.Close();

        this.order = o;
        this.isArranged = 0;
    }
}


public partial class alpages_alpage0 : System.Web.UI.Page
{

    

    bool ChangeMode(string s)
    {
        if (s == "100")
            return true;
        else
            return false;
    }

    int ChangeMode2(bool b)
    {
        if (b)
            return 100;
        else
            return 0;
    }

    void LoadTable()
    {
        try
        {
            DataTable dta = new DataTable();
            var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
            SqlConnection conn = new SqlConnection(consql);
            conn.Open();
            string sqlstr = string.Format("select CLASSNAME,XueFen from CSM order by CLASSID");
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
            da.Fill(dta);

            Label2.Text = dta.Rows[0][0].ToString();
            Label3.Text = dta.Rows[1][0].ToString();
            Label4.Text = dta.Rows[2][0].ToString();
            Label5.Text = dta.Rows[3][0].ToString();
            Label6.Text = dta.Rows[4][0].ToString();
            Label7.Text = dta.Rows[5][0].ToString();
            Label8.Text = dta.Rows[6][0].ToString();
            Label9.Text = dta.Rows[7][0].ToString();
            Label10.Text = dta.Rows[8][0].ToString();
            Label11.Text = dta.Rows[9][0].ToString();



            sqlstr = string.Format("select * from YYB order by CLASSTIME");
            SqlDataAdapter db = new SqlDataAdapter(sqlstr, conn);
            DataTable dt = new DataTable();
            db.Fill(dt);

            CheckBox1.Checked = ChangeMode(dt.Rows[0][1].ToString());
            CheckBox2.Checked = ChangeMode(dt.Rows[0][2].ToString());
            CheckBox3.Checked = ChangeMode(dt.Rows[0][3].ToString());
            CheckBox4.Checked = ChangeMode(dt.Rows[0][4].ToString());
            CheckBox5.Checked = ChangeMode(dt.Rows[0][5].ToString());
            CheckBox6.Checked = ChangeMode(dt.Rows[0][6].ToString());
            CheckBox7.Checked = ChangeMode(dt.Rows[0][7].ToString());
            CheckBox8.Checked = ChangeMode(dt.Rows[0][8].ToString());
            CheckBox9.Checked = ChangeMode(dt.Rows[0][9].ToString());
            CheckBox10.Checked = ChangeMode(dt.Rows[0][10].ToString());
            CheckBox11.Checked = ChangeMode(dt.Rows[1][1].ToString());
            CheckBox12.Checked = ChangeMode(dt.Rows[1][2].ToString());
            CheckBox13.Checked = ChangeMode(dt.Rows[1][3].ToString());
            CheckBox14.Checked = ChangeMode(dt.Rows[1][4].ToString());
            CheckBox15.Checked = ChangeMode(dt.Rows[1][5].ToString());
            CheckBox16.Checked = ChangeMode(dt.Rows[1][6].ToString());
            CheckBox17.Checked = ChangeMode(dt.Rows[1][7].ToString());
            CheckBox18.Checked = ChangeMode(dt.Rows[1][8].ToString());
            CheckBox19.Checked = ChangeMode(dt.Rows[1][9].ToString());
            CheckBox20.Checked = ChangeMode(dt.Rows[1][10].ToString());
            CheckBox21.Checked = ChangeMode(dt.Rows[2][1].ToString());
            CheckBox22.Checked = ChangeMode(dt.Rows[2][2].ToString());
            CheckBox23.Checked = ChangeMode(dt.Rows[2][3].ToString());
            CheckBox24.Checked = ChangeMode(dt.Rows[2][4].ToString());
            CheckBox25.Checked = ChangeMode(dt.Rows[2][5].ToString());
            CheckBox26.Checked = ChangeMode(dt.Rows[2][6].ToString());
            CheckBox27.Checked = ChangeMode(dt.Rows[2][7].ToString());
            CheckBox28.Checked = ChangeMode(dt.Rows[2][8].ToString());
            CheckBox29.Checked = ChangeMode(dt.Rows[2][9].ToString());
            CheckBox30.Checked = ChangeMode(dt.Rows[2][10].ToString());
            CheckBox31.Checked = ChangeMode(dt.Rows[3][1].ToString());
            CheckBox32.Checked = ChangeMode(dt.Rows[3][2].ToString());
            CheckBox33.Checked = ChangeMode(dt.Rows[3][3].ToString());
            CheckBox34.Checked = ChangeMode(dt.Rows[3][4].ToString());
            CheckBox35.Checked = ChangeMode(dt.Rows[3][5].ToString());
            CheckBox36.Checked = ChangeMode(dt.Rows[3][6].ToString());
            CheckBox37.Checked = ChangeMode(dt.Rows[3][7].ToString());
            CheckBox38.Checked = ChangeMode(dt.Rows[3][8].ToString());
            CheckBox39.Checked = ChangeMode(dt.Rows[3][9].ToString());
            CheckBox40.Checked = ChangeMode(dt.Rows[3][10].ToString());
            CheckBox41.Checked = ChangeMode(dt.Rows[4][1].ToString());
            CheckBox42.Checked = ChangeMode(dt.Rows[4][2].ToString());
            CheckBox43.Checked = ChangeMode(dt.Rows[4][3].ToString());
            CheckBox44.Checked = ChangeMode(dt.Rows[4][4].ToString());
            CheckBox45.Checked = ChangeMode(dt.Rows[4][5].ToString());
            CheckBox46.Checked = ChangeMode(dt.Rows[4][6].ToString());
            CheckBox47.Checked = ChangeMode(dt.Rows[4][7].ToString());
            CheckBox48.Checked = ChangeMode(dt.Rows[4][8].ToString());
            CheckBox49.Checked = ChangeMode(dt.Rows[4][9].ToString());
            CheckBox50.Checked = ChangeMode(dt.Rows[4][10].ToString());
            CheckBox51.Checked = ChangeMode(dt.Rows[5][1].ToString());
            CheckBox52.Checked = ChangeMode(dt.Rows[5][2].ToString());
            CheckBox53.Checked = ChangeMode(dt.Rows[5][3].ToString());
            CheckBox54.Checked = ChangeMode(dt.Rows[5][4].ToString());
            CheckBox55.Checked = ChangeMode(dt.Rows[5][5].ToString());
            CheckBox56.Checked = ChangeMode(dt.Rows[5][6].ToString());
            CheckBox57.Checked = ChangeMode(dt.Rows[5][7].ToString());
            CheckBox58.Checked = ChangeMode(dt.Rows[5][8].ToString());
            CheckBox59.Checked = ChangeMode(dt.Rows[5][9].ToString());
            CheckBox60.Checked = ChangeMode(dt.Rows[5][10].ToString());
            CheckBox61.Checked = ChangeMode(dt.Rows[6][1].ToString());
            CheckBox62.Checked = ChangeMode(dt.Rows[6][2].ToString());
            CheckBox63.Checked = ChangeMode(dt.Rows[6][3].ToString());
            CheckBox64.Checked = ChangeMode(dt.Rows[6][4].ToString());
            CheckBox65.Checked = ChangeMode(dt.Rows[6][5].ToString());
            CheckBox66.Checked = ChangeMode(dt.Rows[6][6].ToString());
            CheckBox67.Checked = ChangeMode(dt.Rows[6][7].ToString());
            CheckBox68.Checked = ChangeMode(dt.Rows[6][8].ToString());
            CheckBox69.Checked = ChangeMode(dt.Rows[6][9].ToString());
            CheckBox70.Checked = ChangeMode(dt.Rows[6][10].ToString());
            CheckBox71.Checked = ChangeMode(dt.Rows[7][1].ToString());
            CheckBox72.Checked = ChangeMode(dt.Rows[7][2].ToString());
            CheckBox73.Checked = ChangeMode(dt.Rows[7][3].ToString());
            CheckBox74.Checked = ChangeMode(dt.Rows[7][4].ToString());
            CheckBox75.Checked = ChangeMode(dt.Rows[7][5].ToString());
            CheckBox76.Checked = ChangeMode(dt.Rows[7][6].ToString());
            CheckBox77.Checked = ChangeMode(dt.Rows[7][7].ToString());
            CheckBox78.Checked = ChangeMode(dt.Rows[7][8].ToString());
            CheckBox79.Checked = ChangeMode(dt.Rows[7][9].ToString());
            CheckBox80.Checked = ChangeMode(dt.Rows[7][10].ToString());
            CheckBox81.Checked = ChangeMode(dt.Rows[8][1].ToString());
            CheckBox82.Checked = ChangeMode(dt.Rows[8][2].ToString());
            CheckBox83.Checked = ChangeMode(dt.Rows[8][3].ToString());
            CheckBox84.Checked = ChangeMode(dt.Rows[8][4].ToString());
            CheckBox85.Checked = ChangeMode(dt.Rows[8][5].ToString());
            CheckBox86.Checked = ChangeMode(dt.Rows[8][6].ToString());
            CheckBox87.Checked = ChangeMode(dt.Rows[8][7].ToString());
            CheckBox88.Checked = ChangeMode(dt.Rows[8][8].ToString());
            CheckBox89.Checked = ChangeMode(dt.Rows[8][9].ToString());
            CheckBox90.Checked = ChangeMode(dt.Rows[8][10].ToString());
            CheckBox91.Checked = ChangeMode(dt.Rows[9][1].ToString());
            CheckBox92.Checked = ChangeMode(dt.Rows[9][2].ToString());
            CheckBox93.Checked = ChangeMode(dt.Rows[9][3].ToString());
            CheckBox94.Checked = ChangeMode(dt.Rows[9][4].ToString());
            CheckBox95.Checked = ChangeMode(dt.Rows[9][5].ToString());
            CheckBox96.Checked = ChangeMode(dt.Rows[9][6].ToString());
            CheckBox97.Checked = ChangeMode(dt.Rows[9][7].ToString());
            CheckBox98.Checked = ChangeMode(dt.Rows[9][8].ToString());
            CheckBox99.Checked = ChangeMode(dt.Rows[9][9].ToString());
            CheckBox100.Checked = ChangeMode(dt.Rows[9][10].ToString());

            conn.Close();
        }
        catch
        {
            Response.Write("<script>alert('网络错误！')</script>");
        }
    }

    int GetMaxIndex(int[] a)
    {
        int index = 0;
        int max = a[0];
        for (int i = 1; i <= 9; i++)
            if (a[i] > max)
            {
                max = a[i];
                index = i;
            }
        return index;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["ad"] != null)
            {
                LoadTable();
            }
            else
            {
                //LoadTable();
                Response.Redirect("~/Adminlo.aspx");
            }

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        LoadTable();
    }


    

    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            int[,] yy = new int[10, 10];//预约表
            int[] interval = new int[10];//课程间隔
            int[] tmc = new int[10];//时段预约数
            int[] tmi = new int[10];//时段预约间隔数
            int[] turn = new int[10];//时段次序

            yy[0, 0] = ChangeMode2(CheckBox1.Checked);
            yy[0, 1] = ChangeMode2(CheckBox2.Checked);
            yy[0, 2] = ChangeMode2(CheckBox3.Checked);
            yy[0, 3] = ChangeMode2(CheckBox4.Checked);
            yy[0, 4] = ChangeMode2(CheckBox5.Checked);
            yy[0, 5] = ChangeMode2(CheckBox6.Checked);
            yy[0, 6] = ChangeMode2(CheckBox7.Checked);
            yy[0, 7] = ChangeMode2(CheckBox8.Checked);
            yy[0, 8] = ChangeMode2(CheckBox9.Checked);
            yy[0, 9] = ChangeMode2(CheckBox10.Checked);

            yy[1, 0] = ChangeMode2(CheckBox11.Checked);
            yy[1, 1] = ChangeMode2(CheckBox12.Checked);
            yy[1, 2] = ChangeMode2(CheckBox13.Checked);
            yy[1, 3] = ChangeMode2(CheckBox14.Checked);
            yy[1, 4] = ChangeMode2(CheckBox15.Checked);
            yy[1, 5] = ChangeMode2(CheckBox16.Checked);
            yy[1, 6] = ChangeMode2(CheckBox17.Checked);
            yy[1, 7] = ChangeMode2(CheckBox18.Checked);
            yy[1, 8] = ChangeMode2(CheckBox19.Checked);
            yy[1, 9] = ChangeMode2(CheckBox20.Checked);

            yy[2, 0] = ChangeMode2(CheckBox21.Checked);
            yy[2, 1] = ChangeMode2(CheckBox22.Checked);
            yy[2, 2] = ChangeMode2(CheckBox23.Checked);
            yy[2, 3] = ChangeMode2(CheckBox24.Checked);
            yy[2, 4] = ChangeMode2(CheckBox25.Checked);
            yy[2, 5] = ChangeMode2(CheckBox26.Checked);
            yy[2, 6] = ChangeMode2(CheckBox27.Checked);
            yy[2, 7] = ChangeMode2(CheckBox28.Checked);
            yy[2, 8] = ChangeMode2(CheckBox29.Checked);
            yy[2, 9] = ChangeMode2(CheckBox30.Checked);

            yy[3, 0] = ChangeMode2(CheckBox31.Checked);
            yy[3, 1] = ChangeMode2(CheckBox32.Checked);
            yy[3, 2] = ChangeMode2(CheckBox33.Checked);
            yy[3, 3] = ChangeMode2(CheckBox34.Checked);
            yy[3, 4] = ChangeMode2(CheckBox35.Checked);
            yy[3, 5] = ChangeMode2(CheckBox36.Checked);
            yy[3, 6] = ChangeMode2(CheckBox37.Checked);
            yy[3, 7] = ChangeMode2(CheckBox38.Checked);
            yy[3, 8] = ChangeMode2(CheckBox39.Checked);
            yy[3, 9] = ChangeMode2(CheckBox40.Checked);

            yy[4, 0] = ChangeMode2(CheckBox41.Checked);
            yy[4, 1] = ChangeMode2(CheckBox42.Checked);
            yy[4, 2] = ChangeMode2(CheckBox43.Checked);
            yy[4, 3] = ChangeMode2(CheckBox44.Checked);
            yy[4, 4] = ChangeMode2(CheckBox45.Checked);
            yy[4, 5] = ChangeMode2(CheckBox46.Checked);
            yy[4, 6] = ChangeMode2(CheckBox47.Checked);
            yy[4, 7] = ChangeMode2(CheckBox48.Checked);
            yy[4, 8] = ChangeMode2(CheckBox49.Checked);
            yy[4, 9] = ChangeMode2(CheckBox50.Checked);

            yy[5, 0] = ChangeMode2(CheckBox51.Checked);
            yy[5, 1] = ChangeMode2(CheckBox52.Checked);
            yy[5, 2] = ChangeMode2(CheckBox53.Checked);
            yy[5, 3] = ChangeMode2(CheckBox54.Checked);
            yy[5, 4] = ChangeMode2(CheckBox55.Checked);
            yy[5, 5] = ChangeMode2(CheckBox56.Checked);
            yy[5, 6] = ChangeMode2(CheckBox57.Checked);
            yy[5, 7] = ChangeMode2(CheckBox58.Checked);
            yy[5, 8] = ChangeMode2(CheckBox59.Checked);
            yy[5, 9] = ChangeMode2(CheckBox60.Checked);

            yy[6, 0] = ChangeMode2(CheckBox61.Checked);
            yy[6, 1] = ChangeMode2(CheckBox62.Checked);
            yy[6, 2] = ChangeMode2(CheckBox63.Checked);
            yy[6, 3] = ChangeMode2(CheckBox64.Checked);
            yy[6, 4] = ChangeMode2(CheckBox65.Checked);
            yy[6, 5] = ChangeMode2(CheckBox66.Checked);
            yy[6, 6] = ChangeMode2(CheckBox67.Checked);
            yy[6, 7] = ChangeMode2(CheckBox68.Checked);
            yy[6, 8] = ChangeMode2(CheckBox69.Checked);
            yy[6, 9] = ChangeMode2(CheckBox70.Checked);

            yy[7, 0] = ChangeMode2(CheckBox71.Checked);
            yy[7, 1] = ChangeMode2(CheckBox72.Checked);
            yy[7, 2] = ChangeMode2(CheckBox73.Checked);
            yy[7, 3] = ChangeMode2(CheckBox74.Checked);
            yy[7, 4] = ChangeMode2(CheckBox75.Checked);
            yy[7, 5] = ChangeMode2(CheckBox76.Checked);
            yy[7, 6] = ChangeMode2(CheckBox77.Checked);
            yy[7, 7] = ChangeMode2(CheckBox78.Checked);
            yy[7, 8] = ChangeMode2(CheckBox79.Checked);
            yy[7, 9] = ChangeMode2(CheckBox80.Checked);

            yy[8, 0] = ChangeMode2(CheckBox81.Checked);
            yy[8, 1] = ChangeMode2(CheckBox82.Checked);
            yy[8, 2] = ChangeMode2(CheckBox83.Checked);
            yy[8, 3] = ChangeMode2(CheckBox84.Checked);
            yy[8, 4] = ChangeMode2(CheckBox85.Checked);
            yy[8, 5] = ChangeMode2(CheckBox86.Checked);
            yy[8, 6] = ChangeMode2(CheckBox87.Checked);
            yy[8, 7] = ChangeMode2(CheckBox88.Checked);
            yy[8, 8] = ChangeMode2(CheckBox89.Checked);
            yy[8, 9] = ChangeMode2(CheckBox90.Checked);

            yy[9, 0] = ChangeMode2(CheckBox91.Checked);
            yy[9, 1] = ChangeMode2(CheckBox92.Checked);
            yy[9, 2] = ChangeMode2(CheckBox93.Checked);
            yy[9, 3] = ChangeMode2(CheckBox94.Checked);
            yy[9, 4] = ChangeMode2(CheckBox95.Checked);
            yy[9, 5] = ChangeMode2(CheckBox96.Checked);
            yy[9, 6] = ChangeMode2(CheckBox97.Checked);
            yy[9, 7] = ChangeMode2(CheckBox98.Checked);
            yy[9, 8] = ChangeMode2(CheckBox99.Checked);
            yy[9, 9] = ChangeMode2(CheckBox100.Checked);

            var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
            SqlConnection conn = new SqlConnection(consql);
            conn.Open();

            string sqlsss = "select INTERVAL from CSM;";
            SqlCommand scc = new SqlCommand(sqlsss, conn);
            SqlDataReader drrr = scc.ExecuteReader();
            int ttt = 0;
            while (drrr.Read())
            {
                interval[ttt] = drrr.GetInt32(0);
                ttt++;
            }
            drrr.Close();

            ClassMessage[] cs = new ClassMessage[10];

            int[] weight;
            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] b = a.OrderBy(x => Guid.NewGuid()).ToArray();
            for (int i = 0; i <= 9; i++)
            {
                cs[i] = new ClassMessage(i, b[i]);

            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tmc[i] += yy[i, j];
                }
                tmc[i] = tmc[i] / 100;
                if (tmc[i] == 0)
                {
                    tmc[i] = 10;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (yy[i, j] == 100)
                    {
                        tmi[i] += interval[j];
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                turn[i] = i;
            }


            int temp = 0;
            int size = 10;
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size - 1 - i; j++)
                {
                    if (tmi[turn[j]] >= 2 && tmi[turn[j + 1]] < 2)
                    {
                        temp = turn[j];
                        turn[j] = turn[j + 1];
                        turn[j + 1] = temp;
                    }
                    else if (!(tmi[turn[j]] < 2 && tmi[turn[j + 1]] >= 2))
                    {
                        if (tmc[turn[j]] < tmc[turn[j + 1]])
                        {
                            temp = turn[j];
                            turn[j] = turn[j + 1];
                            turn[j + 1] = temp;
                        }
                    }
                }
            }

            for (int i = 9; i >= 0; i--)
            {
                if (tmi[turn[i]] >= 2 && i == 9)
                {
                    int[] ait = new int[9];
                    int[] cp = new int[2];
                    weight = new int[10];
                    int nk = 0;
                    for (int k = 0; k <= 9; k++)
                    {
                        if (interval[k] == 1 && yy[turn[i], k] == 100)
                        {
                            weight[k] = yy[turn[i], k] + cs[k].grade * 10 + cs[k].order + cs[k].isArranged;
                            ait[nk] = k;
                            nk++;
                        }
                    }
                    if (tmi[turn[i]] == 2)
                    {
                        cp[0] = ait[0];
                        cp[1] = ait[1];
                    }
                    else
                    {
                        cp[0] = ait[0];
                        cp[1] = ait[1];
                        if (weight[ait[3]] > weight[ait[0]])
                        {
                            cp[0] = ait[3];
                        }
                        else if (weight[ait[3]] > weight[ait[1]])
                        {
                            cp[1] = ait[3];
                        }
                    }
                    cs[cp[0]].timeno = turn[i];
                    cs[cp[0]].isArranged = -200;
                    cs[cp[1]].timeno = turn[i] + 10;
                    cs[cp[1]].isArranged = -200;
                }
                else
                {
                    weight = new int[10];
                    for (int k = 0; k <= 9; k++)
                    {
                        weight[k] = yy[turn[i], k] + cs[k].grade * 10 + cs[k].order + cs[k].isArranged;
                    }
                    cs[GetMaxIndex(weight)].timeno = turn[i];
                    cs[GetMaxIndex(weight)].isArranged = -200;
                }
            }
            /*
            string tmcss = "tmc:";
            string tmiss = "tmi:";
            string turss = "tur:";
            string cssss = "cs:";
            for (int i = 0; i < 10; i++)
            {
                tmcss += tmc[i].ToString();
                tmiss += tmi[i].ToString();
                turss += turn[i].ToString();
                cssss += cs[i].timeno.ToString();
            }
            Label1.Text = tmcss + " " + tmiss + " " + turss +" "+cssss;
            */
            ///*
            string sqlstr = "";


            for (int i = 0; i <= 9; i++)
            {
                sqlstr += string.Format("update CSM set CLASSTIME = {0} where CLASSID = {1};", cs[i].timeno, i);
            }

            SqlCommand cmd1 = new SqlCommand(sqlstr, conn);
            int n = cmd1.ExecuteNonQuery();
            if (n > 0)
            {
                Response.Redirect("alpage1.aspx");
            }
            else
            {
                Response.Write("<script>alert('提交失败，请重试')</script>");
            }
            conn.Close();
            //*/
        }
        catch
        {
            Response.Write("<script>alert('网络错误！')</script>");
        }
        
    }
}