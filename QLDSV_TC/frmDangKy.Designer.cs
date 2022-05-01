
namespace QLDSV_TC
{
    partial class frmDangKy
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
            this.labelAddLogin = new System.Windows.Forms.Label();
            this.labelLGName = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labRole = new System.Windows.Forms.Label();
            this.txtLGName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnAddLogin = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAddLogin
            // 
            this.labelAddLogin.AutoSize = true;
            this.labelAddLogin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddLogin.Location = new System.Drawing.Point(365, 47);
            this.labelAddLogin.Name = "labelAddLogin";
            this.labelAddLogin.Size = new System.Drawing.Size(144, 27);
            this.labelAddLogin.TabIndex = 0;
            this.labelAddLogin.Text = "Tạo tài khoản";
            // 
            // labelLGName
            // 
            this.labelLGName.AutoSize = true;
            this.labelLGName.Location = new System.Drawing.Point(238, 109);
            this.labelLGName.Name = "labelLGName";
            this.labelLGName.Size = new System.Drawing.Size(79, 19);
            this.labelLGName.TabIndex = 1;
            this.labelLGName.Text = "Login name";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(248, 163);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(69, 19);
            this.labelPass.TabIndex = 2;
            this.labelPass.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(243, 221);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(74, 19);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "User name";
            // 
            // labRole
            // 
            this.labRole.AutoSize = true;
            this.labRole.Location = new System.Drawing.Point(272, 275);
            this.labRole.Name = "labRole";
            this.labRole.Size = new System.Drawing.Size(37, 19);
            this.labRole.TabIndex = 4;
            this.labRole.Text = "Role";
            // 
            // txtLGName
            // 
            this.txtLGName.Location = new System.Drawing.Point(359, 106);
            this.txtLGName.Name = "txtLGName";
            this.txtLGName.Size = new System.Drawing.Size(236, 26);
            this.txtLGName.TabIndex = 5;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(359, 218);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(236, 26);
            this.txtUserName.TabIndex = 7;
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(359, 272);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(236, 27);
            this.cmbRole.TabIndex = 8;
            // 
            // btnAddLogin
            // 
            this.btnAddLogin.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLogin.Location = new System.Drawing.Point(297, 351);
            this.btnAddLogin.Name = "btnAddLogin";
            this.btnAddLogin.Size = new System.Drawing.Size(108, 38);
            this.btnAddLogin.TabIndex = 9;
            this.btnAddLogin.Text = "Tạo";
            this.btnAddLogin.UseVisualStyleBackColor = true;
            this.btnAddLogin.Click += new System.EventHandler(this.btnAddLogin_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(477, 351);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 38);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(359, 156);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(236, 26);
            this.txtPass.TabIndex = 6;
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnAddLogin);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLGName);
            this.Controls.Add(this.labRole);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelLGName);
            this.Controls.Add(this.labelAddLogin);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangKy";
            this.Text = "frmDangKy";
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddLogin;
        private System.Windows.Forms.Label labelLGName;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labRole;
        private System.Windows.Forms.TextBox txtLGName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnAddLogin;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtPass;
    }
}