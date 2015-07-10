using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

/// <summary>
/// 用户账号信息
/// </summary>
namespace Model
{
    public class userlogModel
    {
        public userlogModel(string userid, string accontname, string userpassword, int useraccounttype
            , string telnumber, string col, string addr, string pro, string na, MemoryStream img)
        {
            this.userId = userid;
            this.accontName = accontname;
            this.userPassword = userpassword;
            this.userAccontType = useraccounttype;
            this.telNumber = telnumber;
            this.college = col;
            this.address = addr;
            this.profession = pro;
            this.name = na;
            this.imagefs = img;
        }

        private string userId;
        private string accontName;
        private string userPassword;
        private int userAccontType;
        private string telNumber;
        private string college;
        private string address;
        private string profession;
        private string name;
        private MemoryStream imagefs;

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string AccontName
        {
            get { return accontName; }
            set { accontName = value; }
        }

        public string UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }

        public int UserAccontType
        {
            get { return userAccontType; }
            set { userAccontType = value; }
        }

        public string TelNumber
        {
            get { return telNumber; }
            set { telNumber = value; }
        }

        public string College
        {
            get { return college; }
            set { college = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public MemoryStream Imagefs
        {
            get { return imagefs; }
            set { imagefs = value; }
        }
    }
}