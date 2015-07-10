using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Model;
using Utility;
/// <summary>
/// BookBorrowOP 的摘要说明
/// </summary>
public class BookBorrowOP
{
    public static List<bookborrowModel> GetModelList()
    {
        List<bookborrowModel> modellist = new List<bookborrowModel>();
        string sqlstring = "select * from bookborrow";
        SqlDataReader datareader = CommonDB.ExecuteReader(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
        while (datareader.Read())
        {
            DateTime time;
            DateTime.TryParse(datareader["BorrowDate"].ToString(), out time);
            int times=-1;
            int.TryParse(datareader["BorrowTimes"].ToString(), out times);
            bookborrowModel model = new bookborrowModel(datareader["BookID"].ToString(), datareader["BookName"].ToString(), datareader["ReaderID"].ToString(), time, times);
            modellist.Add(model);
        }
        return modellist;
    }
}