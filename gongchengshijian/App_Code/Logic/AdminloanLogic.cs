using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Model;
using Utility;
/// <summary>
/// AdminloanLogic 的摘要说明
/// </summary>
public class AdminloanLogic
{
    public static List<bookloanModel> GetModelList(string accontname)
    {
        List<bookloanModel> modellist = new List<bookloanModel>();
        try
        {
            string sqlstring = "select * from bookreserve where ReaderID='" + accontname + "'";
            SqlDataReader datareader = CommonDB.ExecuteReader(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
            while (datareader.Read())
            {
                DateTime reservedate;
                DateTime.TryParse(datareader["ReserveDate"].ToString(), out reservedate);
                DateTime removedate = reservedate.AddDays(30);
                bookloanModel model = new bookloanModel(datareader["BookID"].ToString(), datareader["BookName"].ToString(), reservedate, removedate, 0);
                modellist.Add(model);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("AdminloanLogic GetModelList error!");
        }
        return modellist;
    }

    public static void BorrowOut(bookborrowModel model)
    {
        try
        {
            //string sqlstring = "select * from bookborrow where BooID='" + bookid + "'";
            //SqlDataReader datareader = CommonDB.ExecuteReader(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
            //int borrowtimes = -1;
            //datareader.Read();
            //int.TryParse(datareader["BorrowTimes"].ToString(), out borrowtimes);
            //borrowtimes++;
            //sqlstring = "update [bookborrow] set BorrowTimes='" + borrowtimes + "' where BooID='" + bookid + "' AND ReaderID='" + accontname + "'";
            //CommonDB.ExecuteNonQuery(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
            string sqlstring = "insert into bookborrow (BookID,BookName,ReaderID,BorrowDate,BorrowTimes) values (@bookid,@bookname,@readerid,@borrowdate,@borrowtimes)";
            SqlParameter[] sqlpara = new SqlParameter[]{ new SqlParameter("@bookid", SqlDbType.VarChar), new SqlParameter("@bookname", SqlDbType.VarChar)
                , new SqlParameter("@readerid", SqlDbType.VarChar), new SqlParameter("@borrowdate", SqlDbType.DateTime), new SqlParameter("@borrowtimes", SqlDbType.Int)};
            sqlpara[0].Value = model.BookId;
            sqlpara[1].Value = model.BookName;
            sqlpara[2].Value = model.ReaderId;
            sqlpara[3].Value = model.DateTime;
            sqlpara[4].Value = model.BorrowTimes;
            CommonDB.ExecuteNonQuery(CommonDB.CONN_STRING, CommandType.Text, sqlstring, sqlpara);
        }
        catch (Exception ex)
        {
            Console.WriteLine("AdminloanLogic BorrowOut error!");
        }
    }
}