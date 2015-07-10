using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

public partial class adminreaderinfo : System.Web.UI.Page
{
    private static string readername;
    private static List<readerboorowinfoModel> modellist;
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text.Trim() != "")
        {
            readername = TextBox1.Text.Trim();
            modellist = Readerborrowinfocheck.GetModelList(readername);
            if (modellist != null)
            {
                IList<readerboorowinfoModel> ilist = modellist;
                GridView1.DataSource = ilist;
                GridView1.DataBind();
            }
        }
        else
        {
            Response.Write("<script type='text/javascript'>alert('" + "请输入用户ID！" + "');</script>");
        }
    }
}