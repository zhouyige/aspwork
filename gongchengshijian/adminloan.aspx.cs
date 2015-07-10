using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

public partial class adminloan : System.Web.UI.Page
{
    private static List<bookloanModel> modellist;
    private static string readername;
    protected void Page_Load(object sender, EventArgs e)
    {
        //IList<bookloanModel> bookreserveinfo = new List<bookloanModel>();
        //bookreserveinfo.Add(new bookloanModel("bookid", "bookname", new DateTime(199, 1, 2), new DateTime(199, 1, 2), 1));
        ////bookreserveinfo.Add(new bookloanModel("bookid", "bookname", new DateTime(199, 1, 2), new DateTime(199, 1, 2), 1));
        
        //GridView1.DataSource = bookreserveinfo;
        //GridView1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text.Trim() != "")
        {
            readername = TextBox1.Text.Trim();
            modellist = AdminloanLogic.GetModelList(readername);
            if (modellist != null)
            {
                IList<bookloanModel> ilist = modellist;
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
        if (e.CommandName == "借出" && readername != "")
        {

            int rownum = Convert.ToInt32(e.CommandArgument);
            ReaderReverse.Remove(readername, modellist[rownum].BookId);
            bookborrowModel bmodel = new bookborrowModel(modellist[rownum].BookId, modellist[rownum].BookName, readername, System.DateTime.Now, 1);
            AdminloanLogic.BorrowOut(bmodel);
            //ButtonField bf = GridView1.Columns[4] as ButtonField;
            //bf.Text = "借出成功";
            modellist = AdminloanLogic.GetModelList(readername);
            if (modellist != null)
            {
                IList<bookloanModel> ilist = modellist;
                GridView1.DataSource = ilist;
                GridView1.DataBind();
            }
            Response.Write("<script type='text/javascript'>alert('" + "借出成功！" + "');</script>");
        }
    }
}