using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// bookreserveModel 的摘要说明
/// </summary>

namespace Model
{
    public class bookreserveModel
    {
        public bookreserveModel(string bookid, string bookname, string readerid, DateTime borrowdate)
        {
            this.bookId = bookid;
            this.bookName = bookname;
            this.readerId = readerid;
            this.borrowDate = borrowdate;
        }

        private string bookId;
        private string bookName;
        private string readerId;
        private DateTime borrowDate;

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

        public DateTime BorrowDate
        {
            get { return borrowDate; }
            set { borrowDate = value; }
        }
    }
}