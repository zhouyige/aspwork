using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

public partial class adminbookreturn : System.Web.UI.Page
{
    private static List<bookreturnModel> modellist;
    private static string readername;
    protected void Page_Load(object sender, EventArgs e)
    {
        //IList<bookreturnModel> bookreserveinfo = new List<bookreturnModel>();
        //bookreserveinfo.Add(new bookreturnModel("bookid1", "bookname1", new DateTime(1991, 1, 2), new DateTime(199, 1, 2), 1));
        //bookreserveinfo.Add(new bookreturnModel("bookid2", "bookname2", new DateTime(1992, 1, 2), new DateTime(199, 1, 2), 1));

        //GridView1.DataSource = bookreserveinfo;
        //GridView1.DataBind();
       
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text.Trim() != "")
        {
            readername = TextBox1.Text.Trim();
            modellist = AdminBookReturnLogic.GetModelList(readername);
            if (modellist != null)
            {
                IList<bookreturnModel> ilist = modellist;
                GridView1.DataSource = ilist;
                GridView1.DataBind();
            }
        }
        else
        {
            Response.Write("<script type='text/javascript'>alert('" + "请输入用户ID！" + "');</script>");
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "确认归还" && readername != "")
        {

            int rownum = Convert.ToInt32(e.CommandArgument);
            AdminBookReturnLogic.Return(modellist[rownum].BookId.Trim(), readername);
            modellist = AdminBookReturnLogic.GetModelList(readername);
            if (modellist != null)
            {
                IList<bookreturnModel> ilist = modellist;
                GridView1.DataSource = ilist;
                GridView1.DataBind();
            }
            Response.Write("<script type='text/javascript'>alert('" + "归还成功！" + "');</script>");
        }
    }
}