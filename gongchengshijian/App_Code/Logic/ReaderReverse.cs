using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Model;
using Utility;

/// <summary>
/// ReaderReverse 的摘要说明
/// </summary>
public class ReaderReverse
{
    public static List<bookreserveModel> GetModelList(string accontname)
    {
        List<bookreserveModel> modellist = new List<bookreserveModel>();
        string sqlstring = "select * from bookreserve where ReaderID='" + accontname + "'";
        SqlDataReader datareader = CommonDB.ExecuteReader(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
        while (datareader.Read())
        {
            DateTime time;
            DateTime.TryParse(datareader["ReserveDate"].ToString(), out time);

            bookreserveModel model = new bookreserveModel(datareader["BookID"].ToString(), datareader["BookName"].ToString(), datareader["ReaderID"].ToString(), time);
            modellist.Add(model);
        }
        return modellist;
    }

    public static void Remove(string accontname, string bookid)
    {
        try
        {
            string sqlstring = "delete from bookreserve where ReaderID='" + accontname + "' AND BookID='" + bookid + "'";
            CommonDB.ExecuteNonQuery(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
        }
        catch (Exception ex)
        {
            Console.WriteLine("ReaderReverse Remove error!");
        }
    }

    public static void AddReverse(bookreserveModel model)
    {
        try
        {
            string sqlstring = "insert into bookreserve (BookID,BookName,ReaderID,ReserveDate) " +
                               "values (@bookid,@bookname,@readerid,@reservedate)";
            SqlParameter[] sqlpara = new SqlParameter[]{ new SqlParameter("@bookid", SqlDbType.VarChar), new SqlParameter("@bookname", SqlDbType.VarChar)
                , new SqlParameter("@readerid", SqlDbType.VarChar), new SqlParameter("@reservedate", SqlDbType.DateTime)};

            sqlpara[0].Value = model.BookId;
            sqlpara[1].Value = model.BookName;
            sqlpara[2].Value = model.ReaderId;
            sqlpara[3].Value = model.BorrowDate;

            CommonDB.ExecuteNonQuery(CommonDB.CONN_STRING, CommandType.Text, sqlstring, sqlpara);
        }
        catch (Exception ex)
        {

            Console.WriteLine("ReaderReverse Remove error!");
        }
    }
}