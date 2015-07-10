using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Model;
using Utility;
/// <summary>
/// AdminRenewLogic 的摘要说明
/// </summary>
public class AdminRenewLogic
{
    public static List<renewModel> GetModelList(string accontname)
    {
        List<renewModel> modellist = new List<renewModel>();
        try
        {
            string sqlstring = "select * from bookborrow where CardNum='" + accontname + "'";
            SqlDataReader datareader = CommonDB.ExecuteReader(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
            while (datareader.Read())
            {
                DateTime borrowdate;
                DateTime.TryParse(datareader["BorrowDate"].ToString(), out borrowdate);
                int borrowtimes = 0;
                int.TryParse(datareader["BorrowTimes"].ToString(), out borrowtimes);
                DateTime returndate = borrowdate.AddDays(30 * borrowtimes);

                renewModel model = new renewModel(datareader["BookID"].ToString(), datareader["BookName"].ToString(), borrowdate, returndate, 0);
                modellist.Add(model);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("AdminRenewLogic GetModelList error!");
        }
        return modellist;
    }

    public static void Renew(string bookid, string accontname)
    {
        try
        {
            string sqlstring = "select * from bookborrow where BooID='" + bookid + "' AND CardNum='" + accontname + "'";
            SqlDataReader datareader = CommonDB.ExecuteReader(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
            int borrowtimes = -1;
            datareader.Read();
            int.TryParse(datareader["BorrowTimes"].ToString(), out borrowtimes);
            borrowtimes++;
            sqlstring = "update [bookborrow] set BorrowTimes='" + borrowtimes + "' where BooID='" + bookid + "' AND CardNum='" + accontname + "'";
            CommonDB.ExecuteNonQuery(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
        }
        catch (Exception ex)
        {
            Console.WriteLine("AdminRenewLogic Renew error!");
        }
    }
}