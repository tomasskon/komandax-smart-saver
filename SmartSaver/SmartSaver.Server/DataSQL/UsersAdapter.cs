using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataSQL
{
    public partial class UsersAdapter
    {
        public static SqlDataAdapter CreateCustomerAdapter(SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Users " +
                "WHERE FullName = @FullName AND  Cash = @Cash AND Card = @Card AND Gmail = @Gmail AND Id = @Id", connection);

            // Add the parameters for the SelectCommand.
            command.Parameters.Add("@FullName", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@Gmail", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@Card", SqlDbType.Float, 50);
            command.Parameters.Add("@Cash", SqlDbType.Float, 50);
            command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier, 50);

            adapter.SelectCommand = command;

            // Create the InsertCommand.
            command = new SqlCommand(
                "INSERT INTO dbo.Users (Fullname, Gmail, Card, Cash, Id) " +
                "VALUES (@Fullname, @Gmail, @Card, @Cash, @Id)", connection);

            // Add the parameters for the InsertCommand.
            command.Parameters.Add("@FullName", SqlDbType.NVarChar, 50, "FullName");
            command.Parameters.Add("@Gmail", SqlDbType.NVarChar, 50, "Gmail");
            command.Parameters.Add("@Card", SqlDbType.Float, 50, "Card");
            command.Parameters.Add("@Cash", SqlDbType.Float, 50, "Cash");
            command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier, 50, "Id");

            adapter.InsertCommand = command;

            // Create the UpdateCommand.
            command = new SqlCommand(
                "UPDATE Customers SET Id = @Id, FullName = @FullName, Gmail = @Gmail, Card = @Card, Cash = @Cash " +
                "WHERE Id = @oldId", connection);

            // Add the parameters for the UpdateCommand.
            command.Parameters.Add("@FullName", SqlDbType.NVarChar, 50, "FullName");
            command.Parameters.Add("@Gmail", SqlDbType.NVarChar, 50, "Gmail");
            command.Parameters.Add("@Card", SqlDbType.Float, 50, "Card");
            command.Parameters.Add("@Cash", SqlDbType.Float, 50, "Cash");
            command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier, 50, "Id");
            SqlParameter parameter = command.Parameters.Add(
                "@oldId", SqlDbType.UniqueIdentifier, 50, "Id");
            parameter.SourceVersion = DataRowVersion.Original;

            adapter.UpdateCommand = command;

            // Create the DeleteCommand.
            command = new SqlCommand(
                "DELETE FROM Customers WHERE Id = @Id", connection);

            // Add the parameters for the DeleteCommand.
            parameter = command.Parameters.Add(
                "@Id", SqlDbType.UniqueIdentifier, 50, "Id");
            parameter.SourceVersion = DataRowVersion.Original;

            adapter.DeleteCommand = command;

            return adapter;
        }
    }
}
