using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_RFID
{
   public  class SqlServer
    {
       public SqlServer()
       {

       }
       public DataTable Table(string Get, string Table, string Where, SqlConnection con, String desc="")
       {
           DataTable dt = new DataTable();
           String sql = "";
          
           if (Where != "")
               sql = "SELECT " + Get + " FROM " + Table + " WHERE " + Where + desc;
           else
               sql = "SELECT " + Get + " FROM " + Table + "" + desc;
           using (SqlDataAdapter mycommand = new SqlDataAdapter(sql, con))
           {

               DataSet DS = new DataSet();
               mycommand.Fill(DS);
               dt = DS.Tables[0];
           }
           return dt;
       }
        public int ExecuteNonQuery(string sql, SqlConnection conn)
        {
            int rowsUpdated = 0;



            using (SqlCommand mycommand = new SqlCommand())
            {
                mycommand.Connection = conn;
                mycommand.CommandText = sql;
                rowsUpdated = mycommand.ExecuteNonQuery();
            }

            return rowsUpdated;

        }
        public bool Delete(String tableName, String where, SqlConnection con)
        {
            Boolean returnCode = true;
            try
            {

                this.ExecuteNonQuery(String.Format("delete from {0} where {1};", tableName, where), con);
            }
            catch (Exception ex)
            {
                returnCode = false;
            }
            return returnCode;
        }
        public List<String> List(int noCol, DataTable dt)
       {
           List<String> value = new List<String>();
           try
           {
               string[] array = dt.Rows.OfType<DataRow>().Select(k => k[noCol].ToString()).ToArray();

               foreach (String arr in array)
               {
                   value.Add(arr);
               }
           }
           catch (Exception e)
           {
               throw new Exception(e.Message);
           }

           return value;
       }
       public bool Check(string Get, string Table, string Where, SqlConnection con)
       {
           DataTable dt = new DataTable();
         


               using (SqlCommand mycommand = new SqlCommand())
               {
                   mycommand.Connection = con;
                   mycommand.CommandText = "SELECT " + Get + " FROM " + Table + " WHERE " + Where + " "; ;
                   using (SqlDataReader reader = mycommand.ExecuteReader())
                   {
                       dt.Load(reader);
                       reader.Close();
                   }
               }

               if (dt.Rows.Count == 0)
                   return false;
               else
               {
                   string[] array = dt.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
                   //   G.IDFil.Clear();
                   foreach (String arr in array)
                   {
                       //       G.IDFil.Add(arr);
                   }
                   return true;
               }

          
           return false;
       }
    }
}
