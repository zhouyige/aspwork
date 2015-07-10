using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// 图书信息
/// </summary>

namespace Model
{
    public class bookInfoModel
    {
        public bookInfoModel(string id, string classid, int sendflag)
        {
            this.BookId = id;
            this.BookClassId = classid;
            this.SendFlag = sendflag;
        }

        private string bookId;
        private string bookClassId;
        private int sendFlag;

        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }

        public string BookClassId
        {
            get { return bookClassId; }
            set { bookClassId = value; }
        }

        public int SendFlag
        {
            get { return sendFlag; }
            set { sendFlag = value; }
        }
    }
}