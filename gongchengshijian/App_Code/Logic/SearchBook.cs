using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Model;
using Utility;

/// <summary>
/// SearchBook 的摘要说明
/// </summary>
public class SearchBook
{
    public static List<bookstockModel> BookSearchByAuthor(string searchkeyword)
    {
        List<bookstockModel> modellist = new List<bookstockModel>();
        try
        {
           
            string sqlstring = "select * from bookstock where BookAuthor like *" + searchkeyword + "*";
            SqlDataReader sqlreader = CommonDB.ExecuteReader(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
            while (sqlreader.Read())
            {
                double bookprice = -1;
                double.TryParse(sqlreader["BookPrice"].ToString(), out bookprice);
                bookstockModel model = new bookstockModel(sqlreader["BookClassID"].ToString(),
                    sqlreader["BookName"].ToString(), sqlreader["BookAuthor"].ToString(),
                    sqlreader["BookPress"].ToString(), bookprice, sqlreader["BookSummary"].ToString());
                modellist.Add(model);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("BookSearchByAuthor error!");
        }

        return modellist;
    }

    public static List<bookstockModel> BookSearchByBookName(string searchkeyword)
    {
        List<bookstockModel> modellist = new List<bookstockModel>();
        try
        {

            string sqlstring = "select * from bookstock where BookName like '%" + searchkeyword + "%'";
            SqlDataReader sqlreader = CommonDB.ExecuteReader(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
            while (sqlreader.Read())
            {
                double bookprice = -1;
                double.TryParse(sqlreader["BookPrice"].ToString(), out bookprice);
                bookstockModel model = new bookstockModel(sqlreader["BookID"].ToString(),
                    sqlreader["BookName"].ToString(), sqlreader["BookAuthor"].ToString(),
                    sqlreader["BookPress"].ToString(), bookprice, sqlreader["BookSummary"].ToString());
                modellist.Add(model);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("BookSearchByBookName error!");
        }

        return modellist;
    }
}