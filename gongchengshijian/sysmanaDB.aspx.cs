using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Utility;

public partial class sysmanaDB : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //IList<bookreserveModel> bookreserveinfo = new List<bookreserveModel>();
        //bookreserveinfo.Add(new bookreserveModel("id1", "name1", "readid1", new DateTime(199, 1, 2)));
        //bookreserveinfo.Add(new bookreserveModel("id2", "name3", "readid3", new DateTime(1994, 1, 2)));
        //GridView1.DataSource = bookreserveinfo;
        //GridView1.DataBind();

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label1.Text = DropDownList1.SelectedValue;
        if (Label1.Text == "预定信息表")
        {
            IList<bookInfoModel> ilist = BookInfoOP.GetModelList();
            GridView1.DataSource = ilist;
            GridView1.DataBind();
        }
        else if (Label1.Text == "图书信息表")
        {
            IList<bookstockModel> ilist = BookStockOP.GetModelList();
            GridView1.DataSource = ilist;
            GridView1.DataBind();
        }
        else if (Label1.Text == "用户信息表")
        {
            IList<userlogModel> ilist = ReaderInfoOP.GetInfoList();
            GridView1.DataSource = ilist;
            GridView1.DataBind();
        }
        else if (Label1.Text == "借阅信息表")
        {
            IList<bookborrowModel> ilist = BookBorrowOP.GetModelList();
            GridView1.DataSource = ilist;
            GridView1.DataBind();
        }
    }
}