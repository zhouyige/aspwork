using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utility;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// UserLogin 的摘要说明
/// </summary>
public class UserLogin
{
    public static int QueryUser(string userid, string password)
    {
        string sqlstring = "select * from userlog where AccontName='"+userid+"'";
        SqlDataReader sqlreader = CommonDB.ExecuteReader(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
        while (sqlreader.Read())
        {
            string xx = sqlreader["UserPassword"].ToString();

            if (xx.Trim() == password)
            {
                int accounttype = -1;
                int.TryParse(sqlreader["UserAccontType"].ToString(), out accounttype);
                return accounttype;
            }
        }
        return -1;
    }
}