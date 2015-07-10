using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Model;
using Utility;
/// <summary>
/// BookReserveOP 的摘要说明
/// </summary>
public class BookReserveOP
{
    public static List<bookreserveModel> GetModelList()
    {
        List<bookreserveModel> modellist = new List<bookreserveModel>();
        string sqlstring = "select * from bookInfo";
        SqlDataReader datareader = CommonDB.ExecuteReader(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
        while (datareader.Read())
        {
            DateTime time;
            DateTime.TryParse(datareader["BookDate"].ToString(), out time);
            bookreserveModel model = new bookreserveModel(datareader["BookID"].ToString(), datareader["BookName"].ToString(), datareader["CardNum"].ToString(), time);
            modellist.Add(model);
        }
        return modellist;
    }
}