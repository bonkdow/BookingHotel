using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace BookingHotel
{
    public partial class EditAdminForm : Form
    {
        public string UpdatedRole { get; private set; }

        public EditAdminForm(string username, string currentRole)
        {
            InitializeComponent();

            txtusername.Text = username;
            txtcurrentrole.Text = currentRole;

        }

        private void EditAdminForm_Load(object sender, EventArgs e)
        {
            
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Joshquin\source\repos\BookingHotel\BookingHotel\HotelDB.mdf;Integrated Security=True"))
                {
                    connection.Open();

                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        string newRole = "user"; 

                        
                        if (txtcurrentrole.Text.ToLower() == "admin")
                        {
                            newRole = "admin"; 

                           
                            SqlCommand adminCheckCommand = new SqlCommand("SELECT COUNT(*) FROM Admins WHERE Username = @Username", connection, transaction);
                            adminCheckCommand.Parameters.AddWithValue("@Username", txtusername.Text);

                            int adminCount = (int)adminCheckCommand.ExecuteScalar();

                            
                            if (adminCount == 0)
                            {
                                
                                SqlCommand insertAdminCommand = new SqlCommand("INSERT INTO Admins (Username, Role) VALUES (@Username, @Role)", connection, transaction);
                                insertAdminCommand.Parameters.AddWithValue("@Username", txtusername.Text);
                                insertAdminCommand.Parameters.AddWithValue("@Role", "admin");
                                insertAdminCommand.ExecuteNonQuery();

                               
                                SqlCommand deleteUserCommand = new SqlCommand("DELETE FROM Users WHERE Username = @Username", connection, transaction);
                                deleteUserCommand.Parameters.AddWithValue("@Username", txtusername.Text);
                                deleteUserCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                           
                            SqlCommand userCheckCommand = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username", connection, transaction);
                            userCheckCommand.Parameters.AddWithValue("@Username", txtusername.Text);

                            int userCount = (int)userCheckCommand.ExecuteScalar();

                            
                            if (userCount == 0)
                            {
                                
                                SqlCommand insertUserCommand = new SqlCommand("INSERT INTO Users (Username, Role) VALUES (@Username, @Role)", connection, transaction);
                                insertUserCommand.Parameters.AddWithValue("@Username", txtusername.Text);
                                insertUserCommand.Parameters.AddWithValue("@Role", "user");
                                insertUserCommand.ExecuteNonQuery();

                                
                                SqlCommand deleteAdminCommand = new SqlCommand("DELETE FROM Admins WHERE Username = @Username", connection, transaction);
                                deleteAdminCommand.Parameters.AddWithValue("@Username", txtusername.Text);
                                deleteAdminCommand.ExecuteNonQuery();
                            }
                        }

                       
                        SqlCommand updateCommand = new SqlCommand("UPDATE YourTable SET Role = @NewRole WHERE Username = @Username", connection, transaction);
                        updateCommand.Parameters.AddWithValue("@NewRole", newRole);
                        updateCommand.Parameters.AddWithValue("@Username", txtusername.Text);
                        updateCommand.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Role updated successfully and moved to respective table.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Transaction failed. Error: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }
    }
}
