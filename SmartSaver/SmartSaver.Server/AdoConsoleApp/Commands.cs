using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AdoConsoleApp
{
    public static partial class Commands
    {
        static string ConString = "Server=(localdb)\\mssqllocaldb;Database=SmartSaver;Integrated Security=True";

        public static void deleteRow(string table, string columnName, string columnValue)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM dbo." + table + " WHERE " + columnName + " = '" + columnValue + "'", con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
                System.Console.WriteLine("Data deleted successfully.");
            }
            catch (SystemException e)
            {
                System.Console.WriteLine("Error deleting data: " + e);
            }
        }

        public static void insertRow(string gmail, float cash, float card, string fullname)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand($"INSERT INTO dbo.Users (Id, Gmail, Cash, Card, FullName) VALUES ('{Guid.NewGuid()}', '{gmail}', {cash}, {card}, '{fullname}')", con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
                System.Console.WriteLine("User inserted successfully.");
            }
            catch (SystemException e)
            {
                System.Console.WriteLine("Error inserting user: " + e);
            }
        }

        public static void updateRow(string gmail, float cash, float card, string fullname)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand($"Update dbo.Users SET Gmail = '{gmail}', Cash = '{cash}', Card = '{card}' WHERE FullName = '{fullname}'", con)) 
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
                System.Console.WriteLine("User information updated successfully");
            }
            catch (SystemException e)
            {
                System.Console.WriteLine("Error inserting user: " + e);
            }
        }

        public static void SelectData()
        {
            try
            {
                System.Console.Write("Users data:\n");
                using (SqlConnection connection = new SqlConnection(ConString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from dbo.Users", connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        System.Console.WriteLine(row["Id"] + ",  " + row["FullName"] + ",  " + row["Gmail"] + ",  " + row["Cash"] + ",  " + row["Card"]);
                    }
                }
                System.Console.Write("\nTransaction data:\n");
                using (SqlConnection connection = new SqlConnection(ConString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from dbo.Transactions", connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        System.Console.WriteLine(row["Id"] + ",  " + row["Amount"] + ",  " + row["Description"] + ",  " + row["UserId"] + ",  " + row["CreatedAt"] + ",  " + row["BalanceType"]);
                    }
                }
                System.Console.Write("\nCategory data:\n");
                using (SqlConnection connection = new SqlConnection(ConString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from dbo.Categories", connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        System.Console.WriteLine(row["Id"] + ",  " + row["Name"] + ",  " + row["UserId"]);
                    }
                }

                System.Console.Write("\nGoals data:\n");
                using (SqlConnection connection = new SqlConnection(ConString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from dbo.Goals", connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        System.Console.WriteLine(row["Id"] + ",  " + row["GoalName"] + ",  " + row["Description"] + ",  " + row["GoalAmount"] + ",  " + row["StartDate"] + ",  " + row["FinishDate"] + ",  " + row["UserId"]);
                    }
                }

            }
            catch (Exception e)
            {
                System.Console.WriteLine("Error retrieving data: " + e);
            }
        }

    }
}
