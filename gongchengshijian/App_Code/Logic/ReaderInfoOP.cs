using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Model;
using Utility;

/// <summary>
/// ReaderInfoOP 的摘要说明
/// </summary>
public class ReaderInfoOP
{
    //获得用户信息
    public static userlogModel GetInfo(string accontname)
    {
        string sqlstring = "select * from userlog where AccontName='" + accontname + "'";
        SqlDataReader datareader =  CommonDB.ExecuteReader(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
        if (datareader.Read())
        {
            int acconttype = -1;
            int.TryParse(datareader["UserAccontType"].ToString(), out acconttype);
            MemoryStream imagems;
            if (datareader["picture"] != System.DBNull.Value)
            {
                byte[] imagebt = (byte[]) datareader["picture"];
                imagems = new MemoryStream(imagebt);
            }
            else
            {
                imagems = null;
            }

            return new userlogModel(datareader["AccontName"].ToString(), datareader["AccontName"].ToString(), datareader["UserPassword"].ToString(), acconttype
                , datareader["TelNumber"].ToString(), datareader["College"].ToString(), datareader["Address"].ToString(), datareader["Profession"].ToString()
                , datareader["Name"].ToString(), imagems);
        }
        return null;
    }
    //获得所有用户表
    public static IList<userlogModel> GetInfoList()
    {
        List<userlogModel> modellist = new List<userlogModel>();
        try
        {
            string sqlstring = "select * from userlog";
            SqlDataReader datareader = CommonDB.ExecuteReader(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
            while (datareader.Read())
            {
                userlogModel model;
                int acconttype = -1;
                int.TryParse(datareader["UserAccontType"].ToString(), out acconttype);
                if (datareader["picture"] == null)
                {
                    byte[] imagebt = (byte[]) datareader["picture"];
                    MemoryStream imagems = new MemoryStream(imagebt);
                    model = new userlogModel(datareader["AccontName"].ToString(),
                        datareader["AccontName"].ToString(), datareader["UserPassword"].ToString(), acconttype
                        , datareader["TelNumber"].ToString(), datareader["College"].ToString(),
                        datareader["Address"].ToString(), datareader["Profession"].ToString()
                        , datareader["Name"].ToString(), imagems);
                }
                else
                {
                    model = new userlogModel(datareader["AccontName"].ToString(),
                        datareader["AccontName"].ToString(), datareader["UserPassword"].ToString(), acconttype
                        , datareader["TelNumber"].ToString(), datareader["College"].ToString(),
                        datareader["Address"].ToString(), datareader["Profession"].ToString()
                        , datareader["Name"].ToString(), null);
                }
                
                
             
                modellist.Add(model);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("AdminloanLogic GetModelList error!");
        }
        return modellist;
    }
    //更新用户信息
    public static void Updata(string userid, string accontname, string userpasswd, int acconttype, string telnum,
        string college, string address, string profession, string name, MemoryStream img = null)
    {
        try
        {
            if (img != null)
            {
               
            }
            else
            {
                string sqlstring = "update userlog set (AccontName,UserPassword,UserAccontType,TelNumber,College,Address,Profession,Name) " +
                "values (@accontname,@userpasswd,@acconttype,@telnum,@college,@address,@profession,@name) where AccontName='" +
                                   userid.Trim() + "'";
                SqlParameter[] sqlpara = new SqlParameter[] { new SqlParameter("@accontname", SqlDbType.VarChar), new SqlParameter("@userpasswd", SqlDbType.VarChar)
                , new SqlParameter("@acconttype", SqlDbType.Int), new SqlParameter("@telnum", SqlDbType.VarChar)
                , new SqlParameter("@college", SqlDbType.VarChar), new SqlParameter("@address", SqlDbType.VarChar)
                , new SqlParameter("@profession", SqlDbType.VarChar), new SqlParameter("@name", SqlDbType.VarChar)
               };
                sqlpara[0].Value = accontname;
                sqlpara[1].Value = userpasswd;
                sqlpara[2].Value = acconttype;
                sqlpara[3].Value = telnum;
                sqlpara[4].Value = college;
                sqlpara[5].Value = address;
                sqlpara[6].Value = profession;
                sqlpara[7].Value = name;
                CommonDB.ExecuteNonQuery(CommonDB.CONN_STRING, CommandType.Text, sqlstring, sqlpara);
            }
    }
        catch (Exception ex)
        {
            Console.WriteLine("UpdataUserlog error!");
        }
        return;
    }
    //插入用户信息
    public static void Insert(string accontname, string userpasswd, int acconttype, string telnum,
        string college, string address, string profession, string name, MemoryStream img = null)
    {
        try
        {
            string sqlstring = "insert into userlog (AccontName,UserPassword,UserAccontType,TelNumber,College,Address,Profession,Name) " +
                "values (@accontname,@userpasswd,@acconttype,@telnum,@college,@address,@profession,@name)";
            SqlParameter[] sqlpara = new SqlParameter[] { new SqlParameter("@accontname", SqlDbType.VarChar), new SqlParameter("@userpasswd", SqlDbType.VarChar)
                , new SqlParameter("@acconttype", SqlDbType.Int), new SqlParameter("@telnum", SqlDbType.VarChar)
                , new SqlParameter("@college", SqlDbType.VarChar), new SqlParameter("@address", SqlDbType.VarChar)
                , new SqlParameter("@profession", SqlDbType.VarChar), new SqlParameter("@name", SqlDbType.VarChar)
               };
            sqlpara[0].Value = accontname.Trim();
            sqlpara[1].Value = userpasswd.Trim();
            sqlpara[2].Value = acconttype;
            sqlpara[3].Value = telnum.Trim();
            sqlpara[4].Value = college.Trim();
            sqlpara[5].Value = address.Trim();
            sqlpara[6].Value = profession.Trim();
            sqlpara[7].Value = name.Trim(); 

            CommonDB.ExecuteNonQuery(CommonDB.CONN_STRING, CommandType.Text, sqlstring, sqlpara);
        }
        catch (Exception ex)
        {
            Console.WriteLine("InsertUserlog error!");
        }
    }
    //删除用户信息
    public static void Delete(string accontname)
    {
        try
        {
            string sqlstring = "delete from userlog where AccontName='" + accontname + "'";
            CommonDB.ExecuteNonQuery(CommonDB.CONN_STRING, CommandType.Text, sqlstring, null);
        }
        catch (Exception ex)
        {
            Console.WriteLine("DeleteUserlog error!");
        }
    }

}