using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Data.Sql;
/// <summary>
/// SqlHelper 的摘要说明
/// </summary>
public class SqlHelper
{
    public string Sql{get;set;}//数据库连接信息，从配置文件中读取数据的信息
   // public string Excute { get; set; }
    public SqlHelper()
    {
        Sql = System.Configuration.ConfigurationManager.AppSettings["Conn"];
        
    }
    public DataSet GetDataSet(string sql, string tablename)
    {
        DataSet ds = new DataSet();
        using(SqlConnection conn = new SqlConnection(Sql))//连接数据库
        {
            conn.Open();
            SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
            ada.Fill(ds,tablename);
            conn.Close();
        }
        
        return ds;
    }
    public bool IsIn(string sql)
    {
       // DataRow dr = new DataRow();
        using (SqlConnection conn = new SqlConnection(Sql))
        {
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader reader = comm.ExecuteReader();

            if (reader.HasRows)
            {
                comm.Dispose();
                return true;
            }
            else return false;
        }
    }
    public void ExcuteSql(string excute)
    {
        if (excute == "")
            return;
        using(SqlConnection conn = new SqlConnection(Sql))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(excute, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
    public string GetOneRec(string sql,string tablename,string colname)//获取一条记录
    {
        string r = "";
        DataSet ds = new DataSet();
        ds = GetDataSet(sql, tablename);
        if (ds.Tables[tablename].Rows.Count != 0)
            r = ds.Tables[tablename].Rows[0][colname].ToString();
        return r;
    }
}