namespace AnbardariFinal
{
    partial class frmImportAnd_Export
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel5 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnReport = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.btnSubmit = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgExportImport = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.CodeProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSerials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmbType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.mtbCalendar = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtNote = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPerson = new DevComponents.DotNetBar.LabelX();
            this.txtPerson = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txtNumber = new DevComponents.Editors.IntegerInput();
            this.btnSearchCodeStore = new DevComponents.DotNetBar.ButtonX();
            this.btnProduct = new DevComponents.DotNetBar.ButtonX();
            this.btnSearchCodeProduct = new DevComponents.DotNetBar.ButtonX();
            this.btnAddProductToStore = new DevComponents.DotNetBar.ButtonX();
            this.txtStoreName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtCodeStore = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtProductSerial = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtProductName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtCodeProduct = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel1.SuspendLayout();
            this.groupPanel5.SuspendLayout();
            this.groupPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExportImport)).BeginInit();
            this.groupPanel3.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.groupPanel5);
            this.groupPanel1.Controls.Add(this.groupPanel4);
            this.groupPanel1.Controls.Add(this.groupPanel3);
            this.groupPanel1.Controls.Add(this.groupPanel2);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1799, 895);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            // 
            // groupPanel5
            // 
            this.groupPanel5.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel5.Controls.Add(this.btnReport);
            this.groupPanel5.Controls.Add(this.btnExit);
            this.groupPanel5.Controls.Add(this.btnSubmit);
            this.groupPanel5.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel5.Location = new System.Drawing.Point(9, 794);
            this.groupPanel5.Name = "groupPanel5";
            this.groupPanel5.Size = new System.Drawing.Size(1782, 87);
            // 
            // 
            // 
            this.groupPanel5.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel5.Style.BackColorGradientAngle = 90;
            this.groupPanel5.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel5.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderBottomWidth = 1;
            this.groupPanel5.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel5.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderLeftWidth = 1;
            this.groupPanel5.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderRightWidth = 1;
            this.groupPanel5.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderTopWidth = 1;
            this.groupPanel5.Style.CornerDiameter = 4;
            this.groupPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel5.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel5.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel5.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel5.TabIndex = 4;
            // 
            // btnReport
            // 
            this.btnReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReport.Location = new System.Drawing.Point(1354, 3);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(197, 73);
            this.btnReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "گزارش";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnExit.Location = new System.Drawing.Point(3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(197, 73);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "بازکشت";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSubmit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSubmit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSubmit.Location = new System.Drawing.Point(1569, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(197, 73);
            this.btnSubmit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupPanel4
            // 
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.Controls.Add(this.dgExportImport);
            this.groupPanel4.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel4.Location = new System.Drawing.Point(9, 454);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(1782, 334);
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel4.TabIndex = 3;
            // 
            // dgExportImport
            // 
            this.dgExportImport.AllowUserToAddRows = false;
            this.dgExportImport.AllowUserToDeleteRows = false;
            this.dgExportImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExportImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeProduct,
            this.ProductName,
            this.ProductSerials,
            this.CodeStore,
            this.StoreName,
            this.number,
            this.Person,
            this.Type,
            this.Date,
            this.note});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgExportImport.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgExportImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgExportImport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgExportImport.Location = new System.Drawing.Point(0, 0);
            this.dgExportImport.Name = "dgExportImport";
            this.dgExportImport.ReadOnly = true;
            this.dgExportImport.RowHeadersWidth = 102;
            this.dgExportImport.RowTemplate.Height = 40;
            this.dgExportImport.Size = new System.Drawing.Size(1776, 328);
            this.dgExportImport.TabIndex = 0;
            // 
            // CodeProduct
            // 
            this.CodeProduct.DataPropertyName = "CodeProduct";
            this.CodeProduct.HeaderText = "کد کالا";
            this.CodeProduct.MinimumWidth = 12;
            this.CodeProduct.Name = "CodeProduct";
            this.CodeProduct.ReadOnly = true;
            this.CodeProduct.Width = 250;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "نام کالا";
            this.ProductName.MinimumWidth = 12;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 250;
            // 
            // ProductSerials
            // 
            this.ProductSerials.DataPropertyName = "ProductSerials";
            this.ProductSerials.HeaderText = "شماره اموال";
            this.ProductSerials.MinimumWidth = 12;
            this.ProductSerials.Name = "ProductSerials";
            this.ProductSerials.ReadOnly = true;
            this.ProductSerials.Width = 250;
            // 
            // CodeStore
            // 
            this.CodeStore.DataPropertyName = "CodeStore";
            this.CodeStore.HeaderText = "کد انبار";
            this.CodeStore.MinimumWidth = 12;
            this.CodeStore.Name = "CodeStore";
            this.CodeStore.ReadOnly = true;
            this.CodeStore.Width = 250;
            // 
            // StoreName
            // 
            this.StoreName.DataPropertyName = "StoreName";
            this.StoreName.HeaderText = "نام انبار";
            this.StoreName.MinimumWidth = 12;
            this.StoreName.Name = "StoreName";
            this.StoreName.ReadOnly = true;
            this.StoreName.Width = 250;
            // 
            // number
            // 
            this.number.DataPropertyName = "Number";
            this.number.HeaderText = "تعداد";
            this.number.MinimumWidth = 12;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 250;
            // 
            // Person
            // 
            this.Person.DataPropertyName = "Person";
            this.Person.HeaderText = "شخص";
            this.Person.MinimumWidth = 12;
            this.Person.Name = "Person";
            this.Person.ReadOnly = true;
            this.Person.Width = 250;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "نوع کاربری شخص";
            this.Type.MinimumWidth = 12;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 250;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "تاریخ";
            this.Date.MinimumWidth = 12;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 250;
            // 
            // note
            // 
            this.note.DataPropertyName = "Note";
            this.note.HeaderText = "توضیحات";
            this.note.MinimumWidth = 12;
            this.note.Name = "note";
            this.note.ReadOnly = true;
            this.note.Width = 250;
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.cmbType);
            this.groupPanel3.Controls.Add(this.mtbCalendar);
            this.groupPanel3.Controls.Add(this.labelX10);
            this.groupPanel3.Controls.Add(this.labelX8);
            this.groupPanel3.Controls.Add(this.labelX7);
            this.groupPanel3.Controls.Add(this.txtNote);
            this.groupPanel3.Controls.Add(this.lblPerson);
            this.groupPanel3.Controls.Add(this.txtPerson);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Location = new System.Drawing.Point(9, 249);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(1782, 222);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 2;
            // 
            // cmbType
            // 
            this.cmbType.DisplayMember = "Text";
            this.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.ItemHeight = 39;
            this.cmbType.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3});
            this.cmbType.Location = new System.Drawing.Point(474, 41);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(338, 45);
            this.cmbType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbType.TabIndex = 67;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "مشتری";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "کارمندان";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "پیمانکاران";
            // 
            // mtbCalendar
            // 
            // 
            // 
            // 
            this.mtbCalendar.BackgroundStyle.Class = "TextBoxBorder";
            this.mtbCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtbCalendar.ButtonClear.Visible = true;
            this.mtbCalendar.Location = new System.Drawing.Point(19, 41);
            this.mtbCalendar.Mask = "##/##/####";
            this.mtbCalendar.Name = "mtbCalendar";
            this.mtbCalendar.Size = new System.Drawing.Size(336, 43);
            this.mtbCalendar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mtbCalendar.TabIndex = 66;
            this.mtbCalendar.Text = "";
            this.mtbCalendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX10.Location = new System.Drawing.Point(818, 36);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(244, 48);
            this.labelX10.TabIndex = 68;
            this.labelX10.Text = "نوع کاربری شخص";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX8.Location = new System.Drawing.Point(361, 38);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(76, 46);
            this.labelX8.TabIndex = 65;
            this.labelX8.Text = "تاریخ";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX7.Location = new System.Drawing.Point(1544, 127);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(184, 46);
            this.labelX7.TabIndex = 64;
            this.labelX7.Text = "توضیحات";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNote.Border.Class = "TextBoxBorder";
            this.txtNote.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNote.FocusHighlightEnabled = true;
            this.txtNote.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNote.Location = new System.Drawing.Point(14, 112);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.PreventEnterBeep = true;
            this.txtNote.Size = new System.Drawing.Size(1521, 84);
            this.txtNote.TabIndex = 63;
            // 
            // lblPerson
            // 
            this.lblPerson.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblPerson.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPerson.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPerson.Location = new System.Drawing.Point(1560, 41);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(184, 46);
            this.lblPerson.TabIndex = 62;
            this.lblPerson.Text = "تحویل گیرنده";
            // 
            // txtPerson
            // 
            this.txtPerson.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPerson.Border.Class = "TextBoxBorder";
            this.txtPerson.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPerson.FocusHighlightEnabled = true;
            this.txtPerson.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPerson.Location = new System.Drawing.Point(1078, 41);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.PreventEnterBeep = true;
            this.txtPerson.Size = new System.Drawing.Size(457, 40);
            this.txtPerson.TabIndex = 61;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.labelX9);
            this.groupPanel2.Controls.Add(this.txtNumber);
            this.groupPanel2.Controls.Add(this.btnSearchCodeStore);
            this.groupPanel2.Controls.Add(this.btnProduct);
            this.groupPanel2.Controls.Add(this.btnSearchCodeProduct);
            this.groupPanel2.Controls.Add(this.btnAddProductToStore);
            this.groupPanel2.Controls.Add(this.txtStoreName);
            this.groupPanel2.Controls.Add(this.labelX4);
            this.groupPanel2.Controls.Add(this.txtCodeStore);
            this.groupPanel2.Controls.Add(this.labelX6);
            this.groupPanel2.Controls.Add(this.labelX5);
            this.groupPanel2.Controls.Add(this.txtProductSerial);
            this.groupPanel2.Controls.Add(this.txtProductName);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.txtCodeProduct);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(9, 9);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1776, 234);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 1;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX9.Location = new System.Drawing.Point(510, 155);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(108, 48);
            this.labelX9.TabIndex = 65;
            this.labelX9.Text = "تعداد";
            // 
            // txtNumber
            // 
            // 
            // 
            // 
            this.txtNumber.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNumber.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtNumber.Location = new System.Drawing.Point(271, 155);
            this.txtNumber.MinValue = 0;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ShowUpDown = true;
            this.txtNumber.Size = new System.Drawing.Size(199, 44);
            this.txtNumber.TabIndex = 64;
            // 
            // btnSearchCodeStore
            // 
            this.btnSearchCodeStore.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearchCodeStore.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearchCodeStore.Location = new System.Drawing.Point(159, 17);
            this.btnSearchCodeStore.Name = "btnSearchCodeStore";
            this.btnSearchCodeStore.Size = new System.Drawing.Size(106, 46);
            this.btnSearchCodeStore.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearchCodeStore.TabIndex = 63;
            this.btnSearchCodeStore.Text = "+";
            this.btnSearchCodeStore.Click += new System.EventHandler(this.btnSearchCodeStore_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnProduct.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnProduct.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnProduct.Location = new System.Drawing.Point(689, 140);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(373, 57);
            this.btnProduct.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnProduct.TabIndex = 61;
            this.btnProduct.Text = "افزودن کالا به انبار";
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnSearchCodeProduct
            // 
            this.btnSearchCodeProduct.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearchCodeProduct.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearchCodeProduct.Location = new System.Drawing.Point(1258, 21);
            this.btnSearchCodeProduct.Name = "btnSearchCodeProduct";
            this.btnSearchCodeProduct.Size = new System.Drawing.Size(106, 46);
            this.btnSearchCodeProduct.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearchCodeProduct.TabIndex = 60;
            this.btnSearchCodeProduct.Text = "+";
            this.btnSearchCodeProduct.Click += new System.EventHandler(this.btnSearchCodeProduct_Click);
            // 
            // btnAddProductToStore
            // 
            this.btnAddProductToStore.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddProductToStore.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnAddProductToStore.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddProductToStore.Location = new System.Drawing.Point(689, 74);
            this.btnAddProductToStore.Name = "btnAddProductToStore";
            this.btnAddProductToStore.Size = new System.Drawing.Size(373, 57);
            this.btnAddProductToStore.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddProductToStore.TabIndex = 60;
            this.btnAddProductToStore.Text = "افزودن کالا";
            this.btnAddProductToStore.Click += new System.EventHandler(this.btnAddProductToStore_Click);
            // 
            // txtStoreName
            // 
            this.txtStoreName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtStoreName.Border.Class = "TextBoxBorder";
            this.txtStoreName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStoreName.Location = new System.Drawing.Point(14, 83);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.PreventEnterBeep = true;
            this.txtStoreName.ReadOnly = true;
            this.txtStoreName.Size = new System.Drawing.Size(457, 44);
            this.txtStoreName.TabIndex = 59;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX4.Location = new System.Drawing.Point(500, 83);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(135, 48);
            this.labelX4.TabIndex = 58;
            this.labelX4.Text = "نام انبار";
            // 
            // txtCodeStore
            // 
            // 
            // 
            // 
            this.txtCodeStore.Border.Class = "TextBoxBorder";
            this.txtCodeStore.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCodeStore.Location = new System.Drawing.Point(271, 17);
            this.txtCodeStore.Name = "txtCodeStore";
            this.txtCodeStore.PreventEnterBeep = true;
            this.txtCodeStore.Size = new System.Drawing.Size(200, 44);
            this.txtCodeStore.TabIndex = 57;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX6.Location = new System.Drawing.Point(500, 11);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(135, 46);
            this.labelX6.TabIndex = 56;
            this.labelX6.Text = "کد انبار";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX5.Location = new System.Drawing.Point(1576, 148);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(184, 46);
            this.labelX5.TabIndex = 55;
            this.labelX5.Text = "شماره اموال";
            // 
            // txtProductSerial
            // 
            this.txtProductSerial.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtProductSerial.Border.Class = "TextBoxBorder";
            this.txtProductSerial.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductSerial.FocusHighlightEnabled = true;
            this.txtProductSerial.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtProductSerial.Location = new System.Drawing.Point(1113, 154);
            this.txtProductSerial.Name = "txtProductSerial";
            this.txtProductSerial.PreventEnterBeep = true;
            this.txtProductSerial.ReadOnly = true;
            this.txtProductSerial.Size = new System.Drawing.Size(457, 40);
            this.txtProductSerial.TabIndex = 54;
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtProductName.Border.Class = "TextBoxBorder";
            this.txtProductName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductName.FocusHighlightEnabled = true;
            this.txtProductName.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtProductName.Location = new System.Drawing.Point(1113, 88);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PreventEnterBeep = true;
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(457, 40);
            this.txtProductName.TabIndex = 52;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX3.Location = new System.Drawing.Point(1576, 84);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(152, 44);
            this.labelX3.TabIndex = 53;
            this.labelX3.Text = "نام کالا";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX1.Location = new System.Drawing.Point(1576, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(152, 50);
            this.labelX1.TabIndex = 51;
            this.labelX1.Text = "کد کالا";
            // 
            // txtCodeProduct
            // 
            // 
            // 
            // 
            this.txtCodeProduct.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCodeProduct.FocusHighlightEnabled = true;
            this.txtCodeProduct.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCodeProduct.Location = new System.Drawing.Point(1370, 21);
            this.txtCodeProduct.Name = "txtCodeProduct";
            this.txtCodeProduct.PreventEnterBeep = true;
            this.txtCodeProduct.Size = new System.Drawing.Size(200, 40);
            this.txtCodeProduct.TabIndex = 50;
            // 
            // frmImportAnd_Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1799, 895);
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.Name = "frmImportAnd_Export";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ورود کالا به انبار";
            this.Load += new System.EventHandler(this.frmImportAnd_Export_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel5.ResumeLayout(false);
            this.groupPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgExportImport)).EndInit();
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel5;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgExportImport;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNote;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPerson;
        private DevComponents.DotNetBar.ButtonX btnSearchCodeStore;
        private DevComponents.DotNetBar.ButtonX btnProduct;
        private DevComponents.DotNetBar.ButtonX btnSearchCodeProduct;
        private DevComponents.DotNetBar.ButtonX btnAddProductToStore;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStoreName;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCodeStore;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductSerial;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductName;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCodeProduct;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.ButtonX btnSubmit;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv mtbCalendar;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.Editors.IntegerInput txtNumber;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbType;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.DotNetBar.LabelX labelX10;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSerials;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Person;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private DevComponents.DotNetBar.ButtonX btnReport;
        public DevComponents.DotNetBar.LabelX lblPerson;
    }
}