using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// CommonDB 的摘要说明
/// </summary>
namespace Utility
{ 
    public class CommonDB
    {
        //数据库连接字符串
        public static readonly string CONN_STRING = @"server=.;database=libmanage;Integrated Security=SSPI;";
        // 用Hashtable缓存存储参数
        private static Hashtable parmCache = Hashtable.Synchronized(new Hashtable());
        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, CommandType cmdType, string cmdText, SqlParameter[] cmdParms)
        {

            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            if (trans != null)
                cmd.Transaction = trans;

            cmd.CommandType = cmdType;

            if (cmdParms != null)
            {
                foreach (SqlParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }
        public static void CacheParameters(string cacheKey, params SqlParameter[] cmdParms)
        {
            parmCache[cacheKey] = cmdParms;
        }
        public static SqlParameter[] GetCachedParameters(string cacheKey)
        {
            SqlParameter[] cachedParms = (SqlParameter[])parmCache[cacheKey];

            if (cachedParms == null)
                return null;

            SqlParameter[] clonedParms = new SqlParameter[cachedParms.Length];

            for (int i = 0, j = cachedParms.Length; i < j; i++)
                clonedParms[i] = (SqlParameter)((ICloneable)cachedParms[i]).Clone();

            return clonedParms;
        }
        public static int ExecuteNonQuery(string connString, CommandType cmdType, string cmdText, params SqlParameter[] cmdParms)
        {

            SqlCommand cmd = new SqlCommand();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, cmdParms);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
        }
        public static SqlDataReader ExecuteReader(string connString, CommandType cmdType, string cmdText, params SqlParameter[] cmdParms)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, cmdParms);
                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return rdr;
            }
            catch
            {
                conn.Close();
                throw;
            }
        }
    }
}