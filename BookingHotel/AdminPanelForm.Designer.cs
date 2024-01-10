
namespace BookingHotel
{
    partial class AdminPanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewAdmins = new System.Windows.Forms.DataGridView();
            this.dataGdUsers = new System.Windows.Forms.DataGridView();
            this.dataGdGuestInformation = new System.Windows.Forms.DataGridView();
            this.dataGdRateInformation = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.adminbtn = new System.Windows.Forms.Button();
            this.editUsers = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGdUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGdGuestInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGdRateInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdmins
            // 
            this.dataGridViewAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmins.Location = new System.Drawing.Point(24, 61);
            this.dataGridViewAdmins.Name = "dataGridViewAdmins";
            this.dataGridViewAdmins.Size = new System.Drawing.Size(324, 232);
            this.dataGridViewAdmins.TabIndex = 0;
            this.dataGridViewAdmins.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmins_CellContentClick);
            // 
            // dataGdUsers
            // 
            this.dataGdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGdUsers.Location = new System.Drawing.Point(24, 396);
            this.dataGdUsers.Name = "dataGdUsers";
            this.dataGdUsers.Size = new System.Drawing.Size(324, 235);
            this.dataGdUsers.TabIndex = 1;
            // 
            // dataGdGuestInformation
            // 
            this.dataGdGuestInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGdGuestInformation.Location = new System.Drawing.Point(427, 61);
            this.dataGdGuestInformation.Name = "dataGdGuestInformation";
            this.dataGdGuestInformation.Size = new System.Drawing.Size(950, 247);
            this.dataGdGuestInformation.TabIndex = 2;
            // 
            // dataGdRateInformation
            // 
            this.dataGdRateInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGdRateInformation.Location = new System.Drawing.Point(413, 379);
            this.dataGdRateInformation.Name = "dataGdRateInformation";
            this.dataGdRateInformation.Size = new System.Drawing.Size(941, 262);
            this.dataGdRateInformation.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admins";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Users";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(597, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "RateInformation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "GuestInformation";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1427, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminbtn
            // 
            this.adminbtn.Location = new System.Drawing.Point(246, 239);
            this.adminbtn.Name = "adminbtn";
            this.adminbtn.Size = new System.Drawing.Size(84, 31);
            this.adminbtn.TabIndex = 10;
            this.adminbtn.Text = "edit";
            this.adminbtn.UseVisualStyleBackColor = true;
            this.adminbtn.Click += new System.EventHandler(this.adminbtn_Click);
            // 
            // editUsers
            // 
            this.editUsers.Location = new System.Drawing.Point(246, 582);
            this.editUsers.Name = "editUsers";
            this.editUsers.Size = new System.Drawing.Size(84, 31);
            this.editUsers.TabIndex = 11;
            this.editUsers.Text = "Edit";
            this.editUsers.UseVisualStyleBackColor = true;
            this.editUsers.Click += new System.EventHandler(this.editUsers_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1243, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1243, 590);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 704);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.editUsers);
            this.Controls.Add(this.adminbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGdRateInformation);
            this.Controls.Add(this.dataGdGuestInformation);
            this.Controls.Add(this.dataGdUsers);
            this.Controls.Add(this.dataGridViewAdmins);
            this.Name = "AdminPanelForm";
            this.Text = "AdminPanelForm";
            this.Load += new System.EventHandler(this.AdminPanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGdUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGdGuestInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGdRateInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAdmins;
        private System.Windows.Forms.DataGridView dataGdUsers;
        private System.Windows.Forms.DataGridView dataGdGuestInformation;
        private System.Windows.Forms.DataGridView dataGdRateInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button adminbtn;
        private System.Windows.Forms.Button editUsers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}