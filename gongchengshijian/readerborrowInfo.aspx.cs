using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

public partial class readerborrowInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] != null)
	    {
		    IList<readerboorowinfoModel> ilist = Readerborrowinfocheck.GetModelList(Session["UserName"].ToString());
            ReaderBorrowInfo.DataSource = ilist;
            ReaderBorrowInfo.DataBind();
	    }
        
    }
}