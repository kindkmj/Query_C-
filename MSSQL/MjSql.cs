using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSQL
{
    static class MjSql
    {
        public static SqlConnection createSqlConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"server=DESKTOP-CQJNOKK;database=Test;uid=sa;pwd=1234";
            connection.Open();
            return connection;
        }

        static string selectAll()
        {
            string data="";
            return data;
        }

        public static void initQuery(List<string> sqlKeyList,List<string> sqlValueList)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = MjSql.createSqlConnection();
                cmd.CommandText = "select sqlKey from SQLQuery";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sqlKeyList.Add(reader["sqlKey"] as string);
                }
                reader.Close();
                cmd.CommandText = "select sqlValue from SQLQuery";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sqlValueList.Add(reader["sqlValue"] as string);
                }
                reader.Close();
            }
                Program.SQLDic.Clear();
            for (int i = 0; i < sqlKeyList.Count; i++)
            {
                Program.SQLDic.Add(sqlKeyList[i], sqlValueList[i]);
            }
        }
    }
}
