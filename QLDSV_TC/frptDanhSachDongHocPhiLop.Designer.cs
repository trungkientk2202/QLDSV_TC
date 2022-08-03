
namespace QLDSV_TC
{
    partial class frptDanhSachDongHocPhiLop
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
            System.Windows.Forms.Label tENLOPLabel;
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.labKhoa = new System.Windows.Forms.Label();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.nIENKHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_TCDataSet = new QLDSV_TC.QLDSV_TCDataSet();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.TableAdapterManager();
            this.tENLOPComboBox = new System.Windows.Forms.ComboBox();
            this.nIENKHOATableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.NIENKHOATableAdapter();
            nIENKHOALabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nIENKHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(99, 190);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(56, 13);
            nIENKHOALabel.TabIndex = 26;
            nIENKHOALabel.Text = "Niên khóa";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(377, 127);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(25, 13);
            tENLOPLabel.TabIndex = 30;
            tENLOPLabel.Text = "Lớp";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(168, 124);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(145, 21);
            this.cmbKhoa.TabIndex = 12;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // labKhoa
            // 
            this.labKhoa.AutoSize = true;
            this.labKhoa.Location = new System.Drawing.Point(99, 127);
            this.labKhoa.Name = "labKhoa";
            this.labKhoa.Size = new System.Drawing.Size(32, 13);
            this.labKhoa.TabIndex = 11;
            this.labKhoa.Text = "Khoa";
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DataSource = this.nIENKHOABindingSource;
            this.cmbNienKhoa.DisplayMember = "NIENKHOA";
            this.cmbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(168, 185);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(145, 21);
            this.cmbNienKhoa.TabIndex = 29;
            this.cmbNienKhoa.ValueMember = "NIENKHOA";
            this.cmbNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbNienKhoa_SelectedIndexChanged);
            // 
            // nIENKHOABindingSource
            // 
            this.nIENKHOABindingSource.DataMember = "NIENKHOA";
            this.nIENKHOABindingSource.DataSource = this.qLDSV_TCDataSet;
            // 
            // qLDSV_TCDataSet
            // 
            this.qLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.qLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(168, 262);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 25;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 24;
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
            this.cmbHocKy.Location = new System.Drawing.Point(468, 187);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(121, 21);
            this.cmbHocKy.TabIndex = 23;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSV_TCDataSet;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.QLDSV_TCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tENLOPComboBox
            // 
            this.tENLOPComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "TENLOP", true));
            this.tENLOPComboBox.DataSource = this.lOPBindingSource;
            this.tENLOPComboBox.DisplayMember = "TENLOP";
            this.tENLOPComboBox.FormattingEnabled = true;
            this.tENLOPComboBox.Location = new System.Drawing.Point(468, 124);
            this.tENLOPComboBox.Name = "tENLOPComboBox";
            this.tENLOPComboBox.Size = new System.Drawing.Size(121, 21);
            this.tENLOPComboBox.TabIndex = 31;
            this.tENLOPComboBox.ValueMember = "MALOP";
            this.tENLOPComboBox.SelectedIndexChanged += new System.EventHandler(this.tENLOPComboBox_SelectedIndexChanged);
            // 
            // nIENKHOATableAdapter
            // 
            this.nIENKHOATableAdapter.ClearBeforeFill = true;
            // 
            // frptDanhSachDongHocPhiLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(this.tENLOPComboBox);
            this.Controls.Add(this.cmbNienKhoa);
            this.Controls.Add(nIENKHOALabel);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHocKy);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.labKhoa);
            this.Name = "frptDanhSachDongHocPhiLop";
            this.Text = "frptDanhSachDongHocPhiLop";
            this.Load += new System.EventHandler(this.frptDanhSachDongHocPhiLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nIENKHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label labKhoa;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private QLDSV_TCDataSet qLDSV_TCDataSet;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSV_TCDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private QLDSV_TCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox tENLOPComboBox;
        private QLDSV_TCDataSetTableAdapters.NIENKHOATableAdapter nIENKHOATableAdapter;
        private System.Windows.Forms.BindingSource nIENKHOABindingSource;
    }
}