using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Model;
using Utility;

/// <summary>
/// Readerborrowinfocheck 的摘要说明
/// </summary>
public class Readerborrowinfocheck
{
    public static List<readerboorowinfoModel> GetModelList(string accontname)
    {
        List<readerboorowinfoModel> modellist = new List<readerboorowinfoModel>();
        string sqlstring = "select * from bookborrow where ReaderID='" + accontname + "'";
        SqlDataReader datareader = CommonDB.ExecuteReader(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
        while (datareader.Read())
        {
            int times = -1;
            DateTime outdate, indate;
            int.TryParse(datareader["BorrowTimes"].ToString(), out times);
            DateTime.TryParse(datareader["BorrowDate"].ToString(), out outdate);
            indate = outdate;
            indate = indate.AddDays(times * 30);
            
            readerboorowinfoModel model = new readerboorowinfoModel(datareader["BookID"].ToString(), datareader["BookName"].ToString(), outdate, indate);

            modellist.Add(model);
        }
        return modellist;
    }
}