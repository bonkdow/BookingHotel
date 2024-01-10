using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingHotel
{
    public partial class ReceiptForm : Form
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string RoomNo { get; set; }
        public string Suite { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public int NumberOfDays { get; set; }
        public decimal RatePerPeriod { get; set; }
        public decimal Total { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Balance { get; set; }
        public ReceiptForm()
        {
            InitializeComponent();
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            lblLastName.Text = LastName;
            lblFirstName.Text = FirstName;
            lblAge.Text = Age + "years old";
            lblGender.Text = Gender;
            lblPhoneNo.Text = PhoneNumber;
            lblEmail.Text = Email;
            lblAddress.Text = Address;
            lblRoomNo.Text = RoomNo;
            lblSuite.Text = Suite;
            lblDateIn.Text = DateIn.ToString();
            lblDateOut.Text = DateOut.ToString();
            lblDays.Text = NumberOfDays.ToString();
            lblRate.Text = RatePerPeriod.ToString("C");
            lblTotal.Text = Total.ToString("C");
            lblAmountpd.Text = AmountPaid.ToString("C");
            lblBalance.Text = Balance.ToString("C");



        }
    }
}
