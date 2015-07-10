using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int usertype = UserLogin.QueryUser(this.txtName.Text, this.txtPwd.Text);
        if (usertype != -1)
        {
            Session["UserName"] = this.txtName.Text;
            Session["UserType"] = usertype;
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
        Response.Write("<script type='text/javascript'>alert('" + "用户名或密码错误！" + "');</script>");
    }
}