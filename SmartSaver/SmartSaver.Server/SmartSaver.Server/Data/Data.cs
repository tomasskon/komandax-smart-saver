using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace SmartSaver.Server.Data
{
    public partial class Data
    {
        protected void Fill()
        {
            string sqlConnectString = "Server=(localdb)\\mssqllocaldb;Database=SmartSaver;Integrated Security=True";

            string sqlSelect = "SELECT FullName FROM dbo.Users";

            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, sqlConnectString);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
                Console.WriteLine("{0} {1}", row[0], row["Fullname"]);


            DataSet ds = new DataSet();
            da.Fill(ds, "Contact");

            Console.WriteLine(ds.Tables.Count);
            Console.WriteLine(ds.Tables[0].TableName);
            foreach (DataRow row in ds.Tables["Users"].Rows)
                Console.WriteLine("{0} {1}", row[0], row[1]);
        }
    }
}
