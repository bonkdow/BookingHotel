using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;




namespace BookingHotel
{
    class HandlerDB
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Joshquin\source\repos\BookingHotel\BookingHotel\HotelDB.mdf;Integrated Security=True";

        public string ValidateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryAdmin = "SELECT 'admin' AS Role FROM Admins WHERE Username = @Username AND Password = @Password";
                string queryUser = "SELECT 'user' AS Role FROM Users WHERE Username = @Username AND Password = @Password";

                SqlCommand command = new SqlCommand(queryAdmin + " UNION ALL " + queryUser, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string role = reader["Role"].ToString();
                    if (!string.IsNullOrEmpty(role))
                    {
                        reader.Close();
                        return role;
                    }
                }

                reader.Close();
                return null; 
            }
        }
    }
}
