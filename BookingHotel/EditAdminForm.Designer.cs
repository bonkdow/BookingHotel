
namespace BookingHotel
{
    partial class EditAdminForm
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtcurrentrole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updatebtn = new System.Windows.Forms.Button();
            this.txtUpdatedRole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(245, 95);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 0;
            // 
            // txtcurrentrole
            // 
            this.txtcurrentrole.Location = new System.Drawing.Point(245, 133);
            this.txtcurrentrole.Name = "txtcurrentrole";
            this.txtcurrentrole.Size = new System.Drawing.Size(100, 20);
            this.txtcurrentrole.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "role";
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(260, 210);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(85, 29);
            this.updatebtn.TabIndex = 4;
            this.updatebtn.Text = "update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // txtUpdatedRole
            // 
            this.txtUpdatedRole.Location = new System.Drawing.Point(245, 171);
            this.txtUpdatedRole.Name = "txtUpdatedRole";
            this.txtUpdatedRole.Size = new System.Drawing.Size(100, 20);
            this.txtUpdatedRole.TabIndex = 5;
            // 
            // EditAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUpdatedRole);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcurrentrole);
            this.Controls.Add(this.txtusername);
            this.Name = "EditAdminForm";
            this.Text = "EditAdminForm";
            this.Load += new System.EventHandler(this.EditAdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtcurrentrole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.TextBox txtUpdatedRole;
    }
}