
namespace QLDSV_TC
{
    partial class frptDanhSachSinhVienDangKyLTC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nIENKHOALabel;
            this.btnPreview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.labKhoa = new System.Windows.Forms.Label();
            this.qLDSV_TCDataSet = new QLDSV_TC.QLDSV_TCDataSet();
            this.tableAdapterManager = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            this.NhomCB = new System.Windows.Forms.ComboBox();
            this.nIENKHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nIENKHOATableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.NIENKHOATableAdapter();
            this.cmbMaMH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bdsMaMH = new System.Windows.Forms.BindingSource(this.components);
            this.mAMHTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.MAMHTableAdapter();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            nIENKHOALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIENKHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMaMH)).BeginInit();
            this.SuspendLayout();
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(98, 213);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(56, 13);
            nIENKHOALabel.TabIndex = 18;
            nIENKHOALabel.Text = "Niên khóa";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(101, 325);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 14;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Học kỳ";
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbHocKy.Location = new System.Drawing.Point(428, 213);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(121, 21);
            this.cmbHocKy.TabIndex = 12;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(167, 146);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(145, 21);
            this.cmbKhoa.TabIndex = 10;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // labKhoa
            // 
            this.labKhoa.AutoSize = true;
            this.labKhoa.Location = new System.Drawing.Point(98, 149);
            this.labKhoa.Name = "labKhoa";
            this.labKhoa.Size = new System.Drawing.Size(32, 13);
            this.labKhoa.TabIndex = 8;
            this.labKhoa.Text = "Khoa";
            // 
            // qLDSV_TCDataSet
            // 
            this.qLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.qLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.QLDSV_TCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nhóm";
            // 
            // NhomCB
            // 
            this.NhomCB.FormattingEnabled = true;
            this.NhomCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.NhomCB.Location = new System.Drawing.Point(167, 269);
            this.NhomCB.Name = "NhomCB";
            this.NhomCB.Size = new System.Drawing.Size(145, 21);
            this.NhomCB.TabIndex = 17;
            // 
            // nIENKHOABindingSource
            // 
            this.nIENKHOABindingSource.DataMember = "NIENKHOA";
            this.nIENKHOABindingSource.DataSource = this.qLDSV_TCDataSet;
            // 
            // nIENKHOATableAdapter
            // 
            this.nIENKHOATableAdapter.ClearBeforeFill = true;
            // 
            // cmbMaMH
            // 
            this.cmbMaMH.DataSource = this.bdsMaMH;
            this.cmbMaMH.DisplayMember = "TENMH";
            this.cmbMaMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaMH.FormattingEnabled = true;
            this.cmbMaMH.Location = new System.Drawing.Point(428, 149);
            this.cmbMaMH.Name = "cmbMaMH";
            this.cmbMaMH.Size = new System.Drawing.Size(121, 21);
            this.cmbMaMH.TabIndex = 21;
            this.cmbMaMH.ValueMember = "MAMH";
            this.cmbMaMH.SelectedIndexChanged += new System.EventHandler(this.TenMonHocCb_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mã môn học";
            // 
            // bdsMaMH
            // 
            this.bdsMaMH.DataMember = "MAMH";
            this.bdsMaMH.DataSource = this.qLDSV_TCDataSet;
            // 
            // mAMHTableAdapter
            // 
            this.mAMHTableAdapter.ClearBeforeFill = true;
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DataSource = this.nIENKHOABindingSource;
            this.cmbNienKhoa.DisplayMember = "NIENKHOA";
            this.cmbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(167, 208);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(145, 21);
            this.cmbNienKhoa.TabIndex = 22;
            this.cmbNienKhoa.ValueMember = "NIENKHOA";
            this.cmbNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbNienKhoa_SelectedIndexChanged);
            // 
            // frptDanhSachSinhVienDangKyLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbNienKhoa);
            this.Controls.Add(this.cmbMaMH);
            this.Controls.Add(this.label5);
            this.Controls.Add(nIENKHOALabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NhomCB);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHocKy);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.labKhoa);
            this.Name = "frptDanhSachSinhVienDangKyLTC";
            this.Text = "frptDanhSachSinhVienDangKyLTC";
            this.Load += new System.EventHandler(this.frptDanhSachSinhVienDangKyLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIENKHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMaMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label labKhoa;
        private QLDSV_TCDataSet qLDSV_TCDataSet;
        private QLDSV_TCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NhomCB;
        private System.Windows.Forms.BindingSource nIENKHOABindingSource;
        private QLDSV_TCDataSetTableAdapters.NIENKHOATableAdapter nIENKHOATableAdapter;
        private System.Windows.Forms.ComboBox cmbMaMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bdsMaMH;
        private QLDSV_TCDataSetTableAdapters.MAMHTableAdapter mAMHTableAdapter;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
    }
}