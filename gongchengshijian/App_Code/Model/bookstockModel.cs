using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// bookstockModel 的摘要说明
/// </summary>

namespace Model
{
    public class bookstockModel
    {
        public bookstockModel(string id, string name, string author, string press, double price, string summary)
        {
            this.bookId = id;
            this.bookName = name;
            this.bookAuthor = author;
            this.bookPress = press;
            this.bookPrice = price;
            this.bookSummary = summary;
        }

        private string bookId;
        private string bookName;
        private string bookAuthor;
        private string bookPress;
        private double bookPrice;
        private string bookSummary;

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

        public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }

        public string BookPress
        {
            get { return bookPress; }
            set { bookPress = value; }
        }

        public double BookPrice
        {
            get { return bookPrice; }
            set { bookPrice = value; }
        }

        public string BookSummary
        {
            get { return bookSummary; }
            set { bookSummary = value; }
        }
    }
}