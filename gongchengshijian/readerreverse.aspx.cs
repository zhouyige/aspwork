using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

public partial class readerreverse : System.Web.UI.Page
{
    private static string readername;
    private static List<bookreserveModel> bkremodellist;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] != null)
        {
            readername = Session["UserName"].ToString();
            bkremodellist = ReaderReverse.GetModelList(readername);
            IList<readerreserveModel> ilist = new List<readerreserveModel>();;
            foreach (bookreserveModel bomodel in bkremodellist)
            {
                ilist.Add(new readerreserveModel(bomodel));
            }
            ReaderBorrowInfo.DataSource = ilist;
            ReaderBorrowInfo.DataBind();
        }
    }
    protected void ReaderBorrowInfo_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "解除预订" && readername != "")
        {

            int rownum = Convert.ToInt32(e.CommandArgument);
            ReaderReverse.Remove(readername, bkremodellist[rownum].BookId);
            bkremodellist = ReaderReverse.GetModelList(readername);
            IList<readerreserveModel> ilist = new List<readerreserveModel>(); ;
            foreach (bookreserveModel bomodel in bkremodellist)
            {
                ilist.Add(new readerreserveModel(bomodel));
            }
            ReaderBorrowInfo.DataSource = ilist;
            ReaderBorrowInfo.DataBind();
            Response.Write("<script type='text/javascript'>alert('" + "成功解除预定！" + "');</script>");
        }
    }
}