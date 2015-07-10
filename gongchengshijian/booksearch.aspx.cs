using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using Model;

   class Test{
    private string testData;
    public Test(string ss)
    {
        testData = ss;
    }
    public string TestData
    {
        get { return testData; }
        set { testData = value; }
    }
}
public partial class booksearch : System.Web.UI.Page
{
    private static List<bookstockModel> bookstocklist;
    Button _button;
    bool buttonvisibel = true;
    public static string KeepPre(string html)
    {
        if (string.IsNullOrEmpty(html))
        {
            return html;
        }
        html = html.Replace("\n", "<br/>");
        return html;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            //_button.Text = "已预订";
            //string searrchstr = Session["SearchStr"].ToString();
            //SearchName.Text = searrchstr;
            // List<bookstockModel> bookstocklist = SearchBook.BookSearchByBookName(searrchstr);;

            // List<Test> list = new List<Test>();

            // foreach (bookstockModel model in bookstocklist)
            // {
            //     string modelinfo;
            //     int rownum = 25;
            //     int strrow = model.BookSummary.Length / rownum;
            //     string summary = null;
            //     for (int i = 0; i <= strrow; i++)
            //     {

            //         if (i != strrow)
            //         {

            //             if (i != 0)
            //             {
            //                 summary += "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + model.BookSummary.Substring(i * rownum, rownum) + "<br/>";
            //             }
            //             else
            //             {
            //                 summary += model.BookSummary.Substring(i * rownum, rownum) + "<br/>";
            //             }
            //         }
            //         else
            //         {
            //             summary += "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + model.BookSummary.Substring(i * rownum, model.BookSummary.Length - rownum * i) + "<br/><br/>";
            //         }
            //     }

            //     modelinfo = "书名：" + model.BookName + "<br/>" + "作者：" + model.BookAuthor + "<br/>" + "存数：" + model.BookPrice.ToString() + "<br/>" + "单价：" + model.BookPress
            //         + "<br/>" + "摘要：" + summary;
            //     Test mytest = new Test(modelinfo);
            //     list.Add(mytest);
            // }


            // IList<Test> listtest = list;
            // GridView1.Attributes.Add("style", "position:absolute; left:20%; width:500px; z-index: 3;");
            // GridView1.DataSource = listtest;
            // GridView1.DataBind();
            
        }
        else
        {
            SearchingSelected.Attributes.Add("style", "z-index:3;");
        
            Label2.Text = "0";
            Label4.Text = "0";
            //string eX = "select one";
            //string f = "select one";
            //string col5 = eX + f;
            //TemplateField customField = new TemplateField();
            //customField.HeaderTemplate = new GridViewTemplate(DataControlRowType.Header, "HeadText");
            //customField.ItemTemplate = new GridViewTemplate(DataControlRowType.DataRow, col5);
            //GridView1.Columns.Add(customField);
            
            string searrchstr = Session["SearchStr"].ToString();
           
            bookstocklist = SearchBook.BookSearchByBookName(searrchstr);

            List<Test> list = new List<Test>();
        
            foreach(bookstockModel model in bookstocklist)
            {
                string modelinfo;
                int rownum = 25;
                int strrow = model.BookSummary.Trim().Length / rownum;
                string summary=null;
                for(int i=0; i<=strrow; i++)
                {

                    if (i != strrow)
                    {

                        if (i != 0)
                        {
                            summary += "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + model.BookSummary.Substring(i * rownum, rownum) + "<br/>"; 
                        }
                        else
                        {
                            summary += model.BookSummary.Substring(i * rownum, rownum) + "<br/>";
                        }
                    }
                    else
                    {
                        summary += "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + model.BookSummary.Substring(i * rownum, model.BookSummary.Length - rownum * i) + "<br/><br/>";
                    }
                }

                modelinfo = "书名：" + model.BookName + "<br/>" + "作者：" + model.BookAuthor + "<br/>" + "存数：" + model.BookPrice.ToString() + "<br/>" + "单价：" + model.BookPress
                    + "<br/>" + "摘要：" + summary.Trim();
                Test mytest = new Test(modelinfo);
                list.Add(mytest);
            }
        
       
            IList<Test> listtest = list;
            GridView1.Attributes.Add("style", "position:absolute; left:20%; width:500px; z-index: 3;");
            GridView1.DataSource = listtest;
            GridView1.DataBind();
            Label2.Text = bookstocklist.Count.ToString();
            Label4.Text = Session["SearchStr"].ToString();
        }
        
    }

    protected void SearchingButton_Click(object sender, EventArgs e)
    {
        
     
        if (SearchingSelected.Text.Trim() == "书名")
        {
            bookstocklist = SearchBook.BookSearchByBookName(SearchName.Text.Trim());
        }
        else
        {
            bookstocklist = SearchBook.BookSearchByAuthor(SearchName.Text.Trim());
        }

        List<Test> list = new List<Test>();

        foreach (bookstockModel model in bookstocklist)
        {
            string modelinfo;
            int rownum = 25;
            int strrow = model.BookSummary.Length / rownum;
            string summary = null;
            for (int i = 0; i <= strrow; i++)
            {

                if (i != strrow)
                {

                    if (i != 0)
                    {
                        summary += "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + model.BookSummary.Substring(i * rownum, rownum) + "<br/>";
                    }
                    else
                    {
                        summary += model.BookSummary.Substring(i * rownum, rownum) + "<br/>";
                    }
                }
                else
                {
                    summary += "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + model.BookSummary.Substring(i * rownum, model.BookSummary.Length - rownum * i) + "<br/><br/>";
                }
            }

            modelinfo = "书名：" + model.BookName + "<br/>" + "作者：" + model.BookAuthor + "<br/>" + "存数：" + model.BookPrice.ToString() + "<br/>" + "单价：" + model.BookPress
                + "<br/>" + "摘要：" + summary;
            Test mytest = new Test(modelinfo);
            list.Add(mytest);
        }


        IList<Test> listtest = list;
        GridView1.Attributes.Add("style", "position:absolute; left:20%; width:500px; z-index: 3;");
        GridView1.DataSource = listtest;
        GridView1.DataBind();
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        var bu = (((sender as Button).Parent.Parent) as GridViewRow).DataItemIndex;
        
        var bookpress = -1;
        int.TryParse(bookstocklist[bu].BookPress, out bookpress); 
        if (bookpress > 0)
        {
            if (Session["UserType"].ToString() == "2")
            {
                var bookid = bookstocklist[bu].BookId;
                var bookname = bookstocklist[bu].BookName;
                string readerid = Session["UserName"].ToString();
               bookreserveModel _model = new bookreserveModel(bookid, bookname, readerid, System.DateTime.Now);
               ReaderReverse.AddReverse(_model);
               Response.Write("<script type='text/javascript'>alert('" + "预定成功！" + "');</script>");
            }
        }
        else
        {
            Response.Write("<script type='text/javascript'>alert('" + "存书不足！" + "');</script>");
        }
        
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        
    }
    protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
    {
        //if (_button == null)
        //{
        //    _button = (Button)e.Row.FindControl("Button1");
        //}
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (Session["UserType"] != null)
        {
            if (Session["UserType"].ToString() != "2")
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    ((Button)(e.Row.Cells[0].FindControl("Button1"))).Visible = false;
                }
            }
        }
        else
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ((Button)(e.Row.Cells[0].FindControl("Button1"))).Visible = false;
            }
        }
        
        
    }
}