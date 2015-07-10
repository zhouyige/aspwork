using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Model
{
    public class bookborrowModel
    {
        public bookborrowModel(string bookid, string bookname, string readerid, DateTime datetime, int borrowtimes)
        {
            this.bookId = bookid;
            this.bookName = bookname;
            this.readerId = readerid;
            this.dateTime = datetime;
            this.borrowTimes = borrowtimes;
        }

        private string bookId;
        private string bookName;
        private string readerId;
        private DateTime dateTime;
        private int borrowTimes;

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

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        public int BorrowTimes
        {
            get { return borrowTimes; }
            set { borrowTimes = value; }
        }
    }
}