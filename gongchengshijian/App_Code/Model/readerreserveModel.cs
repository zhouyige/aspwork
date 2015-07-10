using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
/// <summary>
/// readerreserveModel 的摘要说明
/// </summary>
public class readerreserveModel
{
	public readerreserveModel(bookreserveModel model)
	{
	    this.bookId = model.BookId;
	    this.bookName = model.BookName;
	    this.readerId = model.ReaderId;
	    this.reserveDate = model.BorrowDate;
	    this.returnDate = model.BorrowDate.AddDays(30);
	}
    private string bookId;
    private string bookName;
    private string readerId;
    private DateTime reserveDate;
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

    public string ReaderId
    {
        get { return readerId; }
        set { readerId = value; }
    }

    public DateTime ReserveDate
    {
        get { return reserveDate; }
        set { reserveDate = value; }
    }

    public DateTime ReturnDate
    {
        get { return returnDate; }
        set { returnDate = value; }
    }
}