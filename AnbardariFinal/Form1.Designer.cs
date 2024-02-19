namespace AnbardariFinal
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUserName = new DevComponents.DotNetBar.LabelX();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.اطلاعاتپایهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCompanyInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProductInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStockInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.ورودوخروجکالاهابهانبارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExport = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCustomersReport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProductReport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBalanceReport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImportReport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportReport = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتبانکاطلاعاتیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBackUp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1642, 941);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AnbardariFinal.Properties.Resources.warehouse_management_software;
            this.pictureBox1.Location = new System.Drawing.Point(12, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1162, 829);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblUserName);
            this.groupBox2.Controls.Add(this.lblTime);
            this.groupBox2.Controls.Add(this.lblDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(1202, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 858);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblUserName
            // 
            // 
            // 
            // 
            this.lblUserName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblUserName.Location = new System.Drawing.Point(6, 124);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(232, 57);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "........";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(88, 336);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(59, 34);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "null";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(88, 224);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 34);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "null";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "ساعت :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "تاریخ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "خوش آمدید :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اطلاعاتپایهToolStripMenuItem,
            this.ورودوخروجکالاهابهانبارToolStripMenuItem,
            this.گزارشاتToolStripMenuItem,
            this.مدیریتبانکاطلاعاتیToolStripMenuItem,
            this.btnExit});
            this.menuStrip1.Location = new System.Drawing.Point(3, 36);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1636, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // اطلاعاتپایهToolStripMenuItem
            // 
            this.اطلاعاتپایهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCompanyInfo,
            this.btnCustomers,
            this.btnProductInfo,
            this.btnStockInfo,
            this.btnAddProduct});
            this.اطلاعاتپایهToolStripMenuItem.Name = "اطلاعاتپایهToolStripMenuItem";
            this.اطلاعاتپایهToolStripMenuItem.Size = new System.Drawing.Size(189, 40);
            this.اطلاعاتپایهToolStripMenuItem.Text = "اطلاعات پایه";
            // 
            // btnCompanyInfo
            // 
            this.btnCompanyInfo.Name = "btnCompanyInfo";
            this.btnCompanyInfo.Size = new System.Drawing.Size(425, 54);
            this.btnCompanyInfo.Text = "تعریف شرکت";
            this.btnCompanyInfo.Click += new System.EventHandler(this.btnCompanyInfo_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(425, 54);
            this.btnCustomers.Text = "تعریف اشخاص";
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnProductInfo
            // 
            this.btnProductInfo.Name = "btnProductInfo";
            this.btnProductInfo.Size = new System.Drawing.Size(425, 54);
            this.btnProductInfo.Text = "تعریف کالا های انبار";
            this.btnProductInfo.Click += new System.EventHandler(this.btnProductInfo_Click);
            // 
            // btnStockInfo
            // 
            this.btnStockInfo.Name = "btnStockInfo";
            this.btnStockInfo.Size = new System.Drawing.Size(425, 54);
            this.btnStockInfo.Text = "تعریف انبارها";
            this.btnStockInfo.Click += new System.EventHandler(this.btnStockInfo_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(425, 54);
            this.btnAddProduct.Text = "افزودن کالا به انبارها";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // ورودوخروجکالاهابهانبارToolStripMenuItem
            // 
            this.ورودوخروجکالاهابهانبارToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImport,
            this.btnExport});
            this.ورودوخروجکالاهابهانبارToolStripMenuItem.Name = "ورودوخروجکالاهابهانبارToolStripMenuItem";
            this.ورودوخروجکالاهابهانبارToolStripMenuItem.Size = new System.Drawing.Size(353, 40);
            this.ورودوخروجکالاهابهانبارToolStripMenuItem.Text = "ورود و خروج کالاها به انبار";
            // 
            // btnImport
            // 
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(374, 54);
            this.btnImport.Text = "ورود کالا به انبار";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(374, 54);
            this.btnExport.Text = "خروج کالا از انبار";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // گزارشاتToolStripMenuItem
            // 
            this.گزارشاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustomersReport,
            this.btnProductReport,
            this.btnBalanceReport,
            this.btnImportReport,
            this.btnExportReport});
            this.گزارشاتToolStripMenuItem.Name = "گزارشاتToolStripMenuItem";
            this.گزارشاتToolStripMenuItem.Size = new System.Drawing.Size(146, 40);
            this.گزارشاتToolStripMenuItem.Text = "گزارشات";
            // 
            // btnCustomersReport
            // 
            this.btnCustomersReport.Name = "btnCustomersReport";
            this.btnCustomersReport.Size = new System.Drawing.Size(453, 54);
            this.btnCustomersReport.Text = "گزارش اشخاص";
            this.btnCustomersReport.Click += new System.EventHandler(this.btnCustomersReport_Click);
            // 
            // btnProductReport
            // 
            this.btnProductReport.Name = "btnProductReport";
            this.btnProductReport.Size = new System.Drawing.Size(453, 54);
            this.btnProductReport.Text = "گزارش کالا";
            this.btnProductReport.Click += new System.EventHandler(this.btnProductReport_Click);
            // 
            // btnBalanceReport
            // 
            this.btnBalanceReport.Name = "btnBalanceReport";
            this.btnBalanceReport.Size = new System.Drawing.Size(453, 54);
            this.btnBalanceReport.Text = "گرازش موجودی انبارها";
            this.btnBalanceReport.Click += new System.EventHandler(this.btnBalanceReport_Click);
            // 
            // btnImportReport
            // 
            this.btnImportReport.Name = "btnImportReport";
            this.btnImportReport.Size = new System.Drawing.Size(453, 54);
            this.btnImportReport.Text = "گزارش ورود کالا";
            this.btnImportReport.Click += new System.EventHandler(this.btnImportReport_Click);
            // 
            // btnExportReport
            // 
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(453, 54);
            this.btnExportReport.Text = "گزارش خروج کالا";
            this.btnExportReport.Click += new System.EventHandler(this.btnExportReport_Click);
            // 
            // مدیریتبانکاطلاعاتیToolStripMenuItem
            // 
            this.مدیریتبانکاطلاعاتیToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBackUp,
            this.btnRestore});
            this.مدیریتبانکاطلاعاتیToolStripMenuItem.Name = "مدیریتبانکاطلاعاتیToolStripMenuItem";
            this.مدیریتبانکاطلاعاتیToolStripMenuItem.Size = new System.Drawing.Size(312, 40);
            this.مدیریتبانکاطلاعاتیToolStripMenuItem.Text = "مدیریت بانک اطلاعاتی";
            // 
            // btnBackUp
            // 
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(372, 54);
            this.btnBackUp.Text = "پشتیبان گیری";
            // 
            // btnRestore
            // 
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(372, 54);
            this.btnRestore.Text = "بازیابی پشتیبان";
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 40);
            this.btnExit.Text = "خروج";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1642, 941);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار انبارداری";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem اطلاعاتپایهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCompanyInfo;
        private System.Windows.Forms.ToolStripMenuItem btnCustomers;
        private System.Windows.Forms.ToolStripMenuItem btnProductInfo;
        private System.Windows.Forms.ToolStripMenuItem btnStockInfo;
        private System.Windows.Forms.ToolStripMenuItem btnAddProduct;
        private System.Windows.Forms.ToolStripMenuItem ورودوخروجکالاهابهانبارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnImport;
        private System.Windows.Forms.ToolStripMenuItem btnExport;
        private System.Windows.Forms.ToolStripMenuItem گزارشاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCustomersReport;
        private System.Windows.Forms.ToolStripMenuItem btnProductReport;
        private System.Windows.Forms.ToolStripMenuItem btnBalanceReport;
        private System.Windows.Forms.ToolStripMenuItem btnImportReport;
        private System.Windows.Forms.ToolStripMenuItem btnExportReport;
        private System.Windows.Forms.ToolStripMenuItem مدیریتبانکاطلاعاتیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnBackUp;
        private System.Windows.Forms.ToolStripMenuItem btnRestore;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.Timer timer;
        public DevComponents.DotNetBar.LabelX lblUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

