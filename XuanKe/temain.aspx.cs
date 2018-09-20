using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Session["id"].ToString();
        string name = null;
        string sex = null;
        string mobile = null;
        string email = null;

        Session.Clear();

        var consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionServer"].ConnectionString;
        SqlConnection conn = new SqlConnection(consql);

        string sqlstr = "select * from TRM where ID = " + id;
        SqlCommand cmd = new SqlCommand(sqlstr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            name = dr[1].ToString();
            if ("False".Equals(dr[2].ToString()))
            {
                sex = "男";
            }
            else
            {
                sex = "女";
            }
            mobile = dr[3].ToString();
            email = dr[4].ToString();
        }

        TextBox1.Text = id + "\r\n" + name + "\r\n" + sex + "\r\n" + mobile + "\r\n" + email;


        dr.Close();
        conn.Close();
    }
}