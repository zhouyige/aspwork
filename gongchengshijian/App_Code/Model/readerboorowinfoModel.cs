using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// readerboorowinfoModel 的摘要说明
/// </summary>
public class readerboorowinfoModel
{
	public readerboorowinfoModel(string bookid, string bookname, DateTime borrowdate, DateTime returndate)
	{
	    this.bookId = bookid;
	    this.bookName = bookname;
	    this.BorrowDate = borrowdate;
	    this.ReturnDate = returndate;
	}

    private string bookId;
    private string bookName;
    private DateTime borrowDate;
    private DateTime returnDate;

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
}