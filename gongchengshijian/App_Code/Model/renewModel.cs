using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// renewModel 的摘要说明
/// </summary>
public class renewModel
{
	public renewModel(string bookid, string bookname, DateTime borrowdate, DateTime returndate, int renewflag)
	{
	    this.BookId = bookid;
	    this.BookName = bookname;
	    this.BorrowDate = borrowdate;
	    this.ReturnDate = returndate;
	    this.RenewFlag = renewflag;
	}

    private string bookId;
    private string bookName;
    private DateTime borrowDate;
    private DateTime returnDate;
    private int renewFlag;

    public string BookId
    {
        get { return bookId; }
        set { bookId = value; }
    }

    public string BookName
    {
        get { return bookName; }
        set { bookName = value; }
    }

    public DateTime BorrowDate
    {
        get { return borrowDate; }
        set { borrowDate = value; }
    }

    public DateTime ReturnDate
    {
        get { return returnDate; }
        set { returnDate = value; }
    }

    public int RenewFlag
    {
        get { return renewFlag; }
        set { renewFlag = value; }
    }
}