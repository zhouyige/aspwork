using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Model;
using Utility;
/// <summary>
/// BookStockOP 的摘要说明
/// </summary>
public class BookStockOP
{
    public static List<bookstockModel> GetModelList()
    {
        List<bookstockModel> modellist = new List<bookstockModel>();
        string sqlstring = "select * from bookstock";
        SqlDataReader datareader = CommonDB.ExecuteReader(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
        while (datareader.Read())
        {
            double price = -1;
            double.TryParse(datareader["BookPrice"].ToString(), out price);
            bookstockModel model = new bookstockModel(datareader["BookID"].ToString(), datareader["BookName"].ToString(), datareader["BookAuthor"].ToString()
                , datareader["BookPress"].ToString(), price, datareader["BookSummary"].ToString());
            modellist.Add(model);
        } 
        return modellist;
    }
}