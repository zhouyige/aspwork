using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] != null)
        {
            LinkButton1.Text = Session["UserName"].ToString();
            LinkButton2.Visible = true;
        }
        else
        {
            LinkButton2.Visible = false;
        }
    }
    protected void BookSearchTextBox_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void BookSearchButton_Click(object sender, EventArgs e)
    {
        Session["SearchStr"] = BookSearchTextBox.Text.Trim();
        Response.Redirect("booksearch.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

        if (Session["UserName"] != null)
        {
            int usertype = -1;
            int.TryParse(Session["UserType"].ToString(), out usertype);
            if (usertype == 1)
            {
                Response.Redirect("adminloan.aspx");
            }
            else if (usertype == 2)
            {
                Response.Redirect("readersearch.aspx");
            }
            else if (usertype == 3)
            {
                Response.Redirect("sysmanaAM.aspx");
            }
        }
        else
        {
            Response.Redirect("login.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
}