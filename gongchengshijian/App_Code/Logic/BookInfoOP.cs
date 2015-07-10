using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Model;
using Utility;
/// <summary>
/// BookInfoOP 的摘要说明
/// </summary>
public class BookInfoOP
{
    public static List<bookInfoModel> GetModelList()
    {
        List<bookInfoModel> modellist = new List<bookInfoModel>();
        string sqlstring = "select * from bookInfo";
        SqlDataReader datareader = CommonDB.ExecuteReader(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
        while (datareader.Read())
        {
            int sendflag = -1;
            int.TryParse(datareader["BorrowTimes"].ToString(), out sendflag);
            bookInfoModel model = new bookInfoModel(datareader["BookID"].ToString(), datareader["BookClassID"].ToString(), sendflag);
            modellist.Add(model);
        }
        return modellist;
    }
}