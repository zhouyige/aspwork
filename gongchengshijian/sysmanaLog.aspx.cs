using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

public partial class sysmanaLog : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        IList<oplogModel> bookreserveinfo =  OpLogOP.GetModelList();
        GridView1.DataSource = bookreserveinfo;
        GridView1.DataBind();
    }
}