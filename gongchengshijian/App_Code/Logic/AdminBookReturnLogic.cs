using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Model;
using Utility;
/// <summary>
/// AdminBookReturnLogic 的摘要说明
/// </summary>
public class AdminBookReturnLogic
{
    public static List<bookreturnModel> GetModelList(string accontname)
    {
        List<bookreturnModel> modellist = new List<bookreturnModel>();
        try
        {
            string sqlstring = "select * from bookborrow where ReaderID='" + accontname + "'";
            SqlDataReader datareader = CommonDB.ExecuteReader(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
            while (datareader.Read())
            {
                DateTime reservedate;
                DateTime.TryParse(datareader["BorrowDate"].ToString(), out reservedate);
                int borrowtimes = -1;
                int.TryParse(datareader["BorrowTimes"].ToString(), out borrowtimes);
                DateTime removedate = reservedate.AddDays(30 * borrowtimes);
                bookreturnModel model = new bookreturnModel(datareader["BookID"].ToString(), datareader["BookName"].ToString(), reservedate, removedate, 0);
                modellist.Add(model);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("AdminloanLogic GetModelList error!");
        }
        return modellist;
    }

    public static void Return(string bookid, string accontname)
    {
        try
        {
            //string sqlstring = "select * from bookborrow where BooID='" + bookid + "'";
            //SqlDataReader datareader = CommonDB.ExecuteReader(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
            //int borrowtimes = -1;
            //datareader.Read();
            //int.TryParse(datareader["BorrowTimes"].ToString(), out borrowtimes);
            //borrowtimes = 0;
            string sqlstring = "delete from bookborrow where BookID='" + bookid + "' AND ReaderID='" + accontname + "'";
            CommonDB.ExecuteNonQuery(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
        }
        catch (Exception ex)
        {
            Console.WriteLine("AdminloanLogic BorrowOut error!");
        }
    }
}