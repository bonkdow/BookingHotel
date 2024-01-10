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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            HandlerDB dbHandler = new HandlerDB();
            string role = dbHandler.ValidateUser(username, password);

            if (role != null)
            {
                if (role == "admin")
                {
                   
                    AdminPanelForm adminPanel = new AdminPanelForm();
                    adminPanel.Show();
                    this.Hide(); 
                }
                else if (role == "user")
                {
                    
                    UserPanelFrm userPanel = new UserPanelFrm();
                    userPanel.Show();
                    this.Hide(); 
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }

        }
    }
}
