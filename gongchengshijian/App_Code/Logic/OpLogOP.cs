using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Model;
using Utility;
/// <summary>
/// OpLogOP 的摘要说明
/// </summary>
public class OpLogOP
{
    public static List<oplogModel> GetModelList()
    {
        List<oplogModel> modellist = new List<oplogModel>();
        string sqlstring = "select * from oplog";
        SqlDataReader datareader = CommonDB.ExecuteReader(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
        while (datareader.Read())
        {
            DateTime time;
            DateTime.TryParse(datareader["OpTime"].ToString(), out time);
            oplogModel model = new oplogModel(datareader["GID"].ToString(), datareader["UserID"].ToString(), time, datareader["OpDetail"].ToString());
            modellist.Add(model);
        }
        return modellist;
    }

    public static void DeleteRow(string gid)
    {
        try
        {
            string sqlstring = "delete from oplog where GID='" + gid + "'";
            CommonDB.ExecuteNonQuery(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
        }
        catch (Exception ex)
        {
            Console.WriteLine("OpLogOP DeleteRow error!");
        }
    }
}