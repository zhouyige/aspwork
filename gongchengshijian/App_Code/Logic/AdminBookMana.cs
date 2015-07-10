using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Model;
using Utility;
/// <summary>
/// AdminBookMana 的摘要说明
/// </summary>
public class AdminBookMana
{
    //获得图书信息
    public static List<bookstockModel> GetModelList()
    {
        List<bookstockModel> modellist = new List<bookstockModel>();
        string sqlstring = "select * from bookstock";
        SqlDataReader datareader = CommonDB.ExecuteReader(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
        while (datareader.Read())
        {
            double price = -1;
            double.TryParse(datareader["BookPrice"].ToString(), out price);
            bookstockModel model = new bookstockModel(datareader["BookID"].ToString(), datareader["BookName"].ToString(),datareader["BookAuthor"].ToString()
                ,datareader["BookPress"].ToString(), price,datareader["BookSummary"].ToString());
            modellist.Add(model);
        }
        return modellist;
    }

    //更新图书信息
    public static void Updata(string id, string name, string author, int press, double price, string summary)
    {
        try
        {
            string sqlstring = "update bookstock set BookName='" + name + "', BookAuthor='" + author +
                               "', BookPress=" + press.ToString() + ", BookPrice=" + price.ToString() + ", BookSummary='" + summary + "' where BookID='" + id + "'";
            CommonDB.ExecuteNonQuery(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
        }
        catch (Exception ex)
        {
            Console.WriteLine("UpdataUserlog error!");
        }
    }
    //插入图书信息
    public static void Insert(string name, string author, int press, double price, string summary, string bookid)
    {
        try
        {
            string sqlstring = "insert into bookstock(BookName,BookAuthor,BookPress,BookPrice,BookSummary,BookID) " +
                "values(@name,@author,@press,@price,@summary,@bookid)";
            SqlParameter[] sqlpara = new SqlParameter[] { new SqlParameter("@name", SqlDbType.VarChar), new SqlParameter("@author", SqlDbType.VarChar)
                , new SqlParameter("@press", SqlDbType.Int), new SqlParameter("@price", SqlDbType.Float), new SqlParameter("@summary", SqlDbType.VarChar)
                , new SqlParameter("@bookid",SqlDbType.VarChar)};
            sqlpara[0].Value = name;
            sqlpara[1].Value = author;
            sqlpara[2].Value = press;
            sqlpara[3].Value = price;
            sqlpara[4].Value = summary;
            sqlpara[5].Value = bookid;

            CommonDB.ExecuteNonQuery(CommonDB.CONN_STRING, CommandType.Text, sqlstring, sqlpara);
        }
        catch (Exception ex)
        {
            Console.WriteLine("InsertUserlog error!");
        }
    }
    //删除图书信息
    public static void Delete(string bookid)
    {
        try
        {
            string sqlstring = "delete from bookstock where BookID='" + bookid + "'";
            CommonDB.ExecuteNonQuery(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
        }
        catch (Exception ex)
        {
            Console.WriteLine("DeleteUserlog error!");
        }
    }
}