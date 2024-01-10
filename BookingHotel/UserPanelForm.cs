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
    public partial class UserPanelFrm : Form
    {
        public UserPanelFrm()
        {
            InitializeComponent();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                UpdateDatabase();
                MessageBox.Show("Data updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }


        Dictionary<string, decimal> suitePrices = new Dictionary<string, decimal>()
        {
            { "Standard Suite", 100 },  
            { "Junior Suite", 150 },
            { "Executive Suite", 200 },
    
        };
        private void UpdateDatabase()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Joshquin\source\repos\BookingHotel\BookingHotel\HotelDB.mdf;Integrated Security=True"))
                {
                    connection.Open();

                   
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                       
                        string insertGuestQuery = "INSERT INTO GuestInformation (LastName, FirstName, Age, Gender, PhoneNumber, Email, Address) " +
                                                  "VALUES (@LastName, @FirstName, @Age, @Gender, @PhoneNumber, @Email, @Address)";

                        SqlCommand insertGuestCommand = new SqlCommand(insertGuestQuery, connection, transaction);
                        insertGuestCommand.Parameters.AddWithValue("@LastName", txtLname.Text);
                        insertGuestCommand.Parameters.AddWithValue("@FirstName", txtFname.Text);
                        insertGuestCommand.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text)); 
                        insertGuestCommand.Parameters.AddWithValue("@Gender", cbGender.SelectedItem.ToString());
                        insertGuestCommand.Parameters.AddWithValue("@PhoneNumber", txtPhoneNo.Text);
                        insertGuestCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                        insertGuestCommand.Parameters.AddWithValue("@Address", txtAdds.Text);
                        

                        insertGuestCommand.ExecuteNonQuery();

                       
                        string insertRateQuery = "INSERT INTO RateInformation (RoomNo, Suite, DateIn, DateOut, NumberOfDays, RatePerPeriod, Total, AmountPaid, Balance) " +
                                                 "VALUES (@RoomNo, @Suite, @DateIn, @DateOut, @NumberOfDays, @RatePerPeriod, @Total, @AmountPaid, @Balance)";

                        SqlCommand insertRateCommand = new SqlCommand(insertRateQuery, connection, transaction);
                        insertRateCommand.Parameters.AddWithValue("@RoomNo", txtRoomNo.Text);
                        insertRateCommand.Parameters.AddWithValue("@Suite", cbSuite.SelectedItem.ToString());
                        insertRateCommand.Parameters.AddWithValue("@DateIn", dateTimePicker1.Value);
                        insertRateCommand.Parameters.AddWithValue("@DateOut", dateTimePicker2.Value);
                        insertRateCommand.Parameters.AddWithValue("@NumberOfDays", cbDaysNo.SelectedItem.ToString());  
                        insertRateCommand.Parameters.AddWithValue("@AmountPaid", decimal.Parse(txtAmountpd.Text));
                        insertRateCommand.Parameters.AddWithValue("@RatePerPeriod", decimal.Parse(lblRate.Text, System.Globalization.NumberStyles.Currency));
                        insertRateCommand.Parameters.AddWithValue("@Total", decimal.Parse(lblTotal.Text, System.Globalization.NumberStyles.Currency));
                        insertRateCommand.Parameters.AddWithValue("@Balance", decimal.Parse(lblBalance.Text, System.Globalization.NumberStyles.Currency));

                        insertRateCommand.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Transaction failed. Error: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        private void UserPanelFrm_Load(object sender, EventArgs e)
        {
            List<SuiteInfo> suites = new List<SuiteInfo>()
    {
        new SuiteInfo() { Name = "Standard Suite", Price = 1000.00m },
        new SuiteInfo() { Name = "Junior Suite", Price = 1500.00m },
        new SuiteInfo() { Name = "Executive Suite", Price = 2500.00m },
        new SuiteInfo() { Name = "Presidential Suite", Price = 3500.00m },
        new SuiteInfo() { Name = "Family Suite", Price = 10000.00m }
        
       
    };

            
            cbSuite.DataSource = suites;
            cbSuite.DisplayMember = "Name";
            cbSuite.ValueMember = "Price";
        }

        private void chckoutbtn_Click(object sender, EventArgs e)
        {
            if (cbSuite.SelectedItem != null && cbSuite.SelectedItem is SuiteInfo selectedSuite)
            {
                
                int numberOfDays = int.Parse(cbDaysNo.SelectedItem.ToString()); 

               


                decimal price = selectedSuite.Price;
                decimal totalPrice = price * numberOfDays;

               
                decimal amountPaid = decimal.Parse(txtAmountpd.Text);

                decimal ratePerPeriod = price; 
                decimal total = totalPrice;
                decimal balance = total - amountPaid;


                lblRate.Text = ratePerPeriod.ToString("C");
                lblTotal.Text = total.ToString("C");
                lblBalance.Text = balance.ToString("C");

                
                
            }
            else
            {
                MessageBox.Show("Please select a suite and number of days.");
            }
        }

        private void Printbtn_Click(object sender, EventArgs e)
        {
            if (cbSuite.SelectedItem != null && cbSuite.SelectedItem is SuiteInfo selectedSuite)
            {
                

                ReceiptForm receiptForm = new ReceiptForm();
                receiptForm.LastName = txtLname.Text;
                receiptForm.FirstName = txtFname.Text;
                receiptForm.Age = Convert.ToInt32(txtAge.Text); 
                receiptForm.Gender = cbGender.SelectedItem.ToString(); 
                receiptForm.PhoneNumber = txtPhoneNo.Text;
                receiptForm.Email = txtEmail.Text;
                receiptForm.Address = txtAdds.Text;
                receiptForm.RoomNo = txtRoomNo.Text;
                receiptForm.DateIn = DateTime.ParseExact(dateTimePicker1.Value.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                receiptForm.DateOut = DateTime.ParseExact(dateTimePicker2.Value.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                
               
                receiptForm.RatePerPeriod = decimal.Parse(lblRate.Text, System.Globalization.NumberStyles.Currency);
                receiptForm.Total = decimal.Parse(lblTotal.Text, System.Globalization.NumberStyles.Currency);
                receiptForm.AmountPaid = decimal.Parse(txtAmountpd.Text);
                receiptForm.Balance = decimal.Parse(lblBalance.Text, System.Globalization.NumberStyles.Currency);
                if (int.TryParse(cbDaysNo.SelectedItem?.ToString(), out int numberOfDays))
                {
                    receiptForm.NumberOfDays = numberOfDays; 
                }
                else
                {
                    MessageBox.Show("Please select a valid number of days.");
                    return; 
                }
                receiptForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a suite and number of days.");
            }

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
