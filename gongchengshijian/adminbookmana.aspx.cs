using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

public partial class adminbookmana : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //IList<bookstockModel> bookreserveinfo = new List<bookstockModel>();
        //bookreserveinfo.Add(new bookstockModel("id1", "name1", "author1", "press1", 1, "summary1"));
        //bookreserveinfo.Add(new bookstockModel("id2", "name2", "author2", "press2", 1, "summary2"));
        //GridView1.DataSource = bookreserveinfo;
        //GridView1.DataBind();
        if (!IsPostBack)
        {
            IList<bookstockModel> ilist = AdminBookMana.GetModelList();
         //   GridView1.Attributes.Add("style", "position:absolute; left:20%; width:500px; z-index: 3;");
            GridView1.DataSource = ilist;
            GridView1.DataBind();
        }
        
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string bookid = GridView1.Rows[e.RowIndex].Cells[0].Text.Trim();
        AdminBookMana.Delete(bookid);

        IList<bookstockModel> ilist = AdminBookMana.GetModelList();
        GridView1.DataSource = ilist;
        GridView1.DataBind();
    }
    protected void ButtonAddSure_Click(object sender, EventArgs e)
    {
        string bookid = TextBox1.Text;
        string bookauhor = TextBox11.Text;
        int bookpress = -1;
        int.TryParse(TextBox12.Text, out bookpress);
        double bookprice = -1;
        double.TryParse(TextBox12.Text, out bookprice);
        string bookname = TextBox5.Text;
        string booksummary = TextBox7.Text;

        AdminBookMana.Insert(bookname, bookauhor, bookpress, bookprice, booksummary, bookid);
        IList<bookstockModel> ilist = AdminBookMana.GetModelList();
        GridView1.DataSource = ilist;
        GridView1.DataBind();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        IList<bookstockModel> ilist = AdminBookMana.GetModelList();
        GridView1.DataSource = ilist;
        GridView1.DataBind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string bookid = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[0].Controls[0])).Text.Trim();
        string bookauhor = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.Trim();
        int bookpress = -1;
        int.TryParse(((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text.Trim(), out bookpress);
        double bookprice = -1;
        double.TryParse(((TextBox)(GridView1.Rows[e.RowIndex].Cells[4].Controls[0])).Text.Trim(), out bookprice);
        string bookname = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text.Trim();
        string booksummary = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[5].Controls[0])).Text.Trim();

        AdminBookMana.Updata(bookid, bookname, bookauhor, bookpress, bookprice, booksummary);
        GridView1.EditIndex = -1;
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
}