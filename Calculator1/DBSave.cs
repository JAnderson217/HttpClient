using DataBaseApp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    public class DBSave : IDBSave
    {
        //public void Save(string message)
        //{
        //    using (DiagnosticsDBEntities context = new DiagnosticsDBEntities())
        //    {
        //        //Write to db
        //        Log log = new Log
        //        {
        //            Message = (DateTime.Now + ":  " +message)
        //            //Message = message
        //        };
        //        context.Logs.Add(log);
        //        context.SaveChanges();
        //    }
        //}

        // Stored Procedure
        public void Read()
        {
            //SqlConnection con = new SqlConnection("data source=.\\sqlexpress;initial catalog=DiagnosticsDB;persist security info=True;user id=sa;password=Password123();");
            //SqlDataAdapter da = new SqlDataAdapter("getAllRecords", con);
            //SqlCommand cmd = new SqlCommand("getAllRecords", con);
            //da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            //con.Open();
            //var results = cmd.ExecuteReader();

            //while (results.Read())
            //{
            //    Console.WriteLine(results["Id"] + "  " + results["Message"]);
            //}
            //con.Close();
            //Console.ReadLine();
           // HttpClient client = new HttpClient();
        }
        public void Save(string message)
        {
            String strConnString = ("data source=.\\SQLEXPRESS;initial catalog=DiagnosticsDB;integrated security=True;user id=JackA;password=DB21();");
            SqlConnection conn = new SqlConnection(strConnString);
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "storeLog";
            //cmd.Parameters.Add("@Message", SqlDbType.VarChar).Value = message.Trim();
            //cmd.Connection = conn;
            string sql = "INSERT INTO Diagnostics(Message) VALUES (@param1)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@param1", SqlDbType.VarChar).Value = message;
            cmd.CommandType = CommandType.Text;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Record inserted successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
           
        }
            
     


    }
}
