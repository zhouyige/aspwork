using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using System.IO;
using  Utility;
public partial class sysmanaAM : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)//如是第一次调用才执行这个方法
        {
            IList<userlogModel> bookreserveinfo = ReaderInfoOP.GetInfoList();

            GridView1.DataSource = bookreserveinfo;
            GridView1.DataBind();
        }
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)//更新
    {
    //    //确定是否处于插入状态
    //    bool IsInsert = (GridView1.Rows[0].Cells[9].Controls[0] as LinkButton).Text == "增加" ? true : false;
  
    ////因为这个Demo有性别和角色，所以用到了RadioButtonList和DropDownList，这里取到控件。
    //    RadioButtonList rbl = GridView1.Rows[e.RowIndex].FindControl("rbl_Gender") as RadioButtonList;
    //    DropDownList ddl = GridView1.Rows[e.RowIndex].FindControl("ddl_RoleName") as DropDownList;
  
    ////下面确定需要插入或者编辑的字段
    //string userId = IsInsert ?
    //    (GridView1.Rows[0].FindControl("txt_UserId") as TextBox).Text.Trim() :
    //    GridView1.DataKeys[0]["UserId"].ToString();
    //string name = (GridView1.Rows[e.RowIndex].FindControl("txt_Name") as TextBox).Text.Trim(); //错误1 cells[0-1]
    //string gender = rbl.SelectedItem.Value;
    //string password = "123"; //插入新的用户时，默认密码为123
    //int roleId = Convert.ToInt32(ddl.SelectedItem.Value);
 
    ////以下进行插入或者编辑操作，因为原本是三层架构的Demo，所以这里就不写一坨了，本文重点也不在这里。
    //if (IsInsert)
    //{
      
    //}
    //else
    //{
     
    //}

    //GridView1.EditIndex = -1;
    ////GridView1_DataBind(); //调用自定义的事件绑定函数
        //if(!IsPostBack)
        //    return;
        //获取编辑状态下那行的内容并更新数据库
        string accountname = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[0].Controls[0])).Text.Trim();
        string accountpwd = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text.Trim();
        int accounttype = -1;
        int.TryParse(((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.Trim(), out accounttype);
        string name = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text.Trim();
        string addr = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[4].Controls[0])).Text.Trim();
        string telnum = ((TextBox) (GridView1.Rows[e.RowIndex].Cells[5].Controls[0])).Text.Trim();
        string college = ((TextBox) (GridView1.Rows[e.RowIndex].Cells[6].Controls[0])).Text.Trim();
        string dept = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[7].Controls[0])).Text.Trim();

        ReaderInfoOP.Updata(accountname, accountname, accountpwd, accounttype, telnum, college, addr, dept, name);
        GridView1.EditIndex = -1;//取消编辑状态
        //重新读取并数据绑定
        IList<userlogModel> bookreserveinfo = ReaderInfoOP.GetInfoList();
        GridView1.DataSource = bookreserveinfo;
        GridView1.DataBind();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;//如果缺这句话的话  你点更新按钮后获取到的值是编辑之前的值
        IList<userlogModel> bookreserveinfo = ReaderInfoOP.GetInfoList();
        GridView1.DataSource = bookreserveinfo;
        GridView1.DataBind();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string accountname = this.GridView1.Rows[e.RowIndex].Cells[0].Text.Trim();
        
        ReaderInfoOP.Delete(accountname);

        IList<userlogModel> bookreserveinfo = ReaderInfoOP.GetInfoList();
        GridView1.DataSource = bookreserveinfo;
        GridView1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //(GridView1.Rows[0].Cells[9].Controls[0] as LinkButton).Text = "增加";



    }
    protected void TextBox11_TextChanged(object sender, EventArgs e)
    {

    }
    protected void ButtonAddSure_Click(object sender, EventArgs e)
    {
        string accountname = TextBox1.Text;
        string accountpwd = TextBox2.Text;
        int accounttype = -1;
        int.TryParse(TextBox11.Text.Trim(), out accounttype);//将文本转换为int类型
        string name = TextBox12.Text;
        string telnum = TextBox5.Text;
        string college = TextBox6.Text;
        string dept = TextBox7.Text;
        string addr = TextBox8.Text;

        ReaderInfoOP.Insert(accountname, accountpwd, accounttype, telnum, college, addr, dept, name);

        IList<userlogModel> bookreserveinfo = ReaderInfoOP.GetInfoList();
        GridView1.DataSource = bookreserveinfo;
        GridView1.DataBind();
    }
}