using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// bookloanModel 的摘要说明
/// </summary>
public class bookloanModel
{
	public bookloanModel(string bookid, string bookname, DateTime reversedate, DateTime removereversedate, int sendflag)
	{
	    this.bookId = bookid;
	    this.bookName = bookname;
	    this.reverseDate = reversedate;
	    this.removeReverseDate = removereversedate;
	    this.sendFlag = sendflag;
	}

    private string bookId;
    private string bookName;
    private DateTime reverseDate;
    private DateTime removeReverseDate;
    private int sendFlag;

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

    public DateTime ReverseDate
    {
        get { return reverseDate; }
        set { reverseDate = value; }
    }

    public DateTime RemoveReverseDate
    {
        get { return removeReverseDate; }
        set { removeReverseDate = value; }
    }

    public int SendFlag
    {
        get { return sendFlag; }
        set { sendFlag = value; }
    }
}