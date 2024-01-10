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
    public partial class AdminPanelForm : Form
    {
        
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            DisplayDataFromTables();
        }
        private void DisplayDataFromTables()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Joshquin\source\repos\BookingHotel\BookingHotel\HotelDB.mdf;Integrated Security=True"))
                {
                    connection.Open();

                    string queryAdmins = "SELECT Username, Role FROM Admins";
                    string queryUsers = "SELECT Username, Role FROM Users";
                    string queryGuestInformation = "SELECT LastName, FirstName, Age, Gender, PhoneNumber, Email, Address FROM GuestInformation";
                    string queryRateInformation = "SELECT RoomNo, Suite, DateIn, DateOut, NumberOfDays, RatePerPeriod, Total, AmountPaid, Balance FROM RateInformation";


                    SqlDataAdapter adapterAdmins = new SqlDataAdapter(queryAdmins, connection);
                    SqlDataAdapter adapterUsers = new SqlDataAdapter(queryUsers, connection);
                    SqlDataAdapter adapterGuestInformation = new SqlDataAdapter(queryGuestInformation, connection);
                    SqlDataAdapter adapterRateInformation = new SqlDataAdapter(queryRateInformation, connection);

                    DataTable dataTableAdmins = new DataTable();
                    DataTable dataTableUsers = new DataTable();
                    DataTable dataTableGuestInformation = new DataTable();
                    DataTable dataTableRateInformation = new DataTable();

                    adapterAdmins.Fill(dataTableAdmins);
                    adapterUsers.Fill(dataTableUsers);
                    adapterGuestInformation.Fill(dataTableGuestInformation);
                    adapterRateInformation.Fill(dataTableRateInformation);

                    dataGridViewAdmins.DataSource = dataTableAdmins;
                    dataGdUsers.DataSource = dataTableUsers;
                    dataGdGuestInformation.DataSource = dataTableGuestInformation;
                    dataGdRateInformation.DataSource = dataTableRateInformation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayDataFromTables();
        }

        private void dataGridViewAdmins_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewAdmins.Columns["Edit"].Index)
            {
                DataGridViewRow selectedRow = dataGridViewAdmins.Rows[e.RowIndex];
                string username = selectedRow.Cells["Username"].Value.ToString();
                string role = selectedRow.Cells["Role"].Value.ToString();

                // Open the edit form for Admins data
                EditAdminForm editAdminForm = new EditAdminForm(username, role);
                editAdminForm.ShowDialog();
            }

        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                string selectedUsername = dataGridViewAdmins.CurrentRow.Cells["Username"].Value.ToString();
                string selectedRole = dataGridViewAdmins.CurrentRow.Cells["Role"].Value.ToString();

                
                EditAdminForm editAdminForm = new EditAdminForm(selectedUsername, selectedRole);
                editAdminForm.ShowDialog();

                
                string updatedRole = editAdminForm.UpdatedRole;

                // Update the role in the database
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Joshquin\source\repos\BookingHotel\BookingHotel\HotelDB.mdf;Integrated Security=True"))
                {
                    connection.Open();

                    string updateQuery = "UPDATE Admins SET Role = @UpdatedRole WHERE Username = @Username";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@UpdatedRole", updatedRole);
                    updateCommand.Parameters.AddWithValue("@Username", selectedUsername);

                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Role updated successfully!");
                        
                        DisplayDataFromTables();
                    }
                    else
                    {
                        MessageBox.Show("Role update failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void editUsers_Click(object sender, EventArgs e)
        {

        }
    }
}
