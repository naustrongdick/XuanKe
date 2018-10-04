using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class pages_alpage2 : System.Web.UI.Page
{

    protected void LoadGrid()
    {
            var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
            SqlConnection conn = new SqlConnection(consql);
            conn.Open();
            string sqlstr = string.Format("select TRM.ID as 用户编号,TRM.NAME as 用户名 from TRM,TRL where TRM.ID=TRL.ID and TRL.STATUS = 1");
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            conn.Close();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
            LoadGrid();
            
        }
    }
    
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "xiaxian")
        {
            int index = Convert.ToInt32(e.CommandArgument);
            int id = int.Parse(GridView1.Rows[index].Cells[1].Text);
            var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
            SqlConnection conn = new SqlConnection(consql);
            conn.Open();
            string sqlstr = string.Format("update TRL set STATUS=0 where ID = {0}", id);
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                Label1.Text = GridView1.Rows[index].Cells[2].Text + "已下线";
            }
            else
            {
                Label1.Text = GridView1.Rows[index].Cells[2].Text + "下线失败";
            }
            conn.Close();
            LoadGrid();
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        LoadGrid();
    }
}