
namespace QLDSV_TC
{
    partial class frmDKLTC
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtHocKi = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNienKhoa = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimLTC = new System.Windows.Forms.Button();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgvDKLTC = new System.Windows.Forms.DataGridView();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnDKLTC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDKLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtHocKi);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtNienKhoa);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.btnTimLTC);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(826, 100);
            this.panelControl1.TabIndex = 0;
            // 
            // txtHocKi
            // 
            this.txtHocKi.Location = new System.Drawing.Point(514, 16);
            this.txtHocKi.Name = "txtHocKi";
            this.txtHocKi.Size = new System.Drawing.Size(100, 20);
            this.txtHocKi.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Học kì";
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.Location = new System.Drawing.Point(242, 16);
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(100, 20);
            this.txtNienKhoa.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Niên khóa";
            // 
            // btnTimLTC
            // 
            this.btnTimLTC.Location = new System.Drawing.Point(363, 52);
            this.btnTimLTC.Name = "btnTimLTC";
            this.btnTimLTC.Size = new System.Drawing.Size(93, 33);
            this.btnTimLTC.TabIndex = 4;
            this.btnTimLTC.Text = "Tìm lớp tín chỉ";
            this.btnTimLTC.UseVisualStyleBackColor = true;
            this.btnTimLTC.Click += new System.EventHandler(this.btnTimLTC_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvDKLTC);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 100);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(826, 332);
            this.panelControl2.TabIndex = 1;
            // 
            // dgvDKLTC
            // 
            this.dgvDKLTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDKLTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDKLTC.Location = new System.Drawing.Point(2, 2);
            this.dgvDKLTC.Name = "dgvDKLTC";
            this.dgvDKLTC.Size = new System.Drawing.Size(822, 328);
            this.dgvDKLTC.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnDKLTC);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 432);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(826, 100);
            this.panelControl3.TabIndex = 2;
            // 
            // btnDKLTC
            // 
            this.btnDKLTC.Location = new System.Drawing.Point(363, 32);
            this.btnDKLTC.Name = "btnDKLTC";
            this.btnDKLTC.Size = new System.Drawing.Size(93, 27);
            this.btnDKLTC.TabIndex = 0;
            this.btnDKLTC.Text = "Đăng kí";
            this.btnDKLTC.UseVisualStyleBackColor = true;
            this.btnDKLTC.Click += new System.EventHandler(this.btnDKLTC_Click);
            // 
            // frmDKLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 549);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDKLTC";
            this.Text = "frmDKLTC";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmDKLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDKLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.DataGridView dgvDKLTC;
        private DevExpress.XtraEditors.TextEdit txtHocKi;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtNienKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimLTC;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Button btnDKLTC;
    }
}