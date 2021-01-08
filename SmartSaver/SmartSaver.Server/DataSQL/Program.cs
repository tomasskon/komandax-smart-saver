using System;
using System.Data;
using System.Data.SqlClient;
namespace DataSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            string sqlConnectString = "Server=(localdb)\\mssqllocaldb;Database=SmartSaver;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sqlConnectString);
            conn.Open();
            string sqlSelect = "SELECT FullName FROM dbo.Users";
            UsersAdapter ua = new UsersAdapter();
            SqlDataAdapter da = UsersAdapter.CreateCustomerAdapter(conn);
            DataTable dt = new DataTable();
            //da.SelectCommand.ExecuteNonQuery();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
                Console.WriteLine("{0} {1}", row[0], row["Fullname"]);


            DataSet ds = new DataSet();
            da.Fill(ds, "Users");

            Console.WriteLine(ds.Tables[0].TableName);
            foreach (DataRow row in ds.Tables["Users"].Rows)
                Console.WriteLine("{0} {1}", row[0], row[0]);
        }
    }
}
