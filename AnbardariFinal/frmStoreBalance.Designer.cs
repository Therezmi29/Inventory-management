namespace AnbardariFinal
{
    partial class frmStoreBalance
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
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.btnPrintStore = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgStoreBalance = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnShowAll = new DevComponents.DotNetBar.ButtonX();
            this.txtProductSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSearchStore = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSerials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductFirstBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCurrentBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1.SuspendLayout();
            this.groupPanel5.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStoreBalance)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.groupPanel5);
            this.groupPanel1.Controls.Add(this.groupPanel3);
            this.groupPanel1.Controls.Add(this.groupPanel2);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1846, 905);
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
            this.groupPanel5.Controls.Add(this.btnExit);
            this.groupPanel5.Controls.Add(this.btnPrintStore);
            this.groupPanel5.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel5.Location = new System.Drawing.Point(9, 790);
            this.groupPanel5.Name = "groupPanel5";
            this.groupPanel5.Size = new System.Drawing.Size(1822, 100);
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
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnExit.Location = new System.Drawing.Point(14, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(215, 72);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "بازگشت";
            this.btnExit.TextColor = System.Drawing.Color.Black;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrintStore
            // 
            this.btnPrintStore.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrintStore.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrintStore.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPrintStore.Location = new System.Drawing.Point(1449, 8);
            this.btnPrintStore.Name = "btnPrintStore";
            this.btnPrintStore.Size = new System.Drawing.Size(349, 72);
            this.btnPrintStore.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrintStore.TabIndex = 6;
            this.btnPrintStore.Text = "چاپ گزارش انبارها";
            this.btnPrintStore.TextColor = System.Drawing.Color.Black;
            this.btnPrintStore.Click += new System.EventHandler(this.btnPrintStore_Click);
            // 
            // groupPanel3
            // 
            this.groupPanel3.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.dgStoreBalance);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Location = new System.Drawing.Point(9, 145);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(1822, 620);
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
            this.groupPanel3.Text = "موجودی انبار ها";
            // 
            // dgStoreBalance
            // 
            this.dgStoreBalance.AllowUserToAddRows = false;
            this.dgStoreBalance.AllowUserToDeleteRows = false;
            this.dgStoreBalance.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgStoreBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStoreBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.CodeStore,
            this.StoreName,
            this.CodeProduct,
            this.PoductName,
            this.ProductSerials,
            this.ProductPlace,
            this.ProductFirstBalance,
            this.ProductCurrentBalance});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgStoreBalance.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgStoreBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStoreBalance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStoreBalance.Location = new System.Drawing.Point(0, 0);
            this.dgStoreBalance.Name = "dgStoreBalance";
            this.dgStoreBalance.ReadOnly = true;
            this.dgStoreBalance.RowHeadersWidth = 102;
            this.dgStoreBalance.RowTemplate.Height = 40;
            this.dgStoreBalance.Size = new System.Drawing.Size(1816, 575);
            this.dgStoreBalance.TabIndex = 0;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnShowAll);
            this.groupPanel2.Controls.Add(this.txtProductSearch);
            this.groupPanel2.Controls.Add(this.txtSearchStore);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(9, 3);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1828, 118);
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
            // btnShowAll
            // 
            this.btnShowAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowAll.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAll.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnShowAll.Location = new System.Drawing.Point(705, 30);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(414, 57);
            this.btnShowAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "نمایش همه";
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // txtProductSearch
            // 
            // 
            // 
            // 
            this.txtProductSearch.Border.Class = "TextBoxBorder";
            this.txtProductSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductSearch.Location = new System.Drawing.Point(62, 30);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.PreventEnterBeep = true;
            this.txtProductSearch.Size = new System.Drawing.Size(474, 44);
            this.txtProductSearch.TabIndex = 1;
            this.txtProductSearch.WatermarkText = "نام کالا را وارد کنید";
            this.txtProductSearch.TextChanged += new System.EventHandler(this.txtProductSearch_TextChanged);
            // 
            // txtSearchStore
            // 
            // 
            // 
            // 
            this.txtSearchStore.Border.Class = "TextBoxBorder";
            this.txtSearchStore.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearchStore.Location = new System.Drawing.Point(1318, 30);
            this.txtSearchStore.Name = "txtSearchStore";
            this.txtSearchStore.PreventEnterBeep = true;
            this.txtSearchStore.Size = new System.Drawing.Size(474, 44);
            this.txtSearchStore.TabIndex = 0;
            this.txtSearchStore.WatermarkText = "نام انبار را وارد کنید";
            this.txtSearchStore.TextChanged += new System.EventHandler(this.txtSearchStore_TextChanged);
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "کد";
            this.Code.MinimumWidth = 12;
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 250;
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
            // CodeProduct
            // 
            this.CodeProduct.DataPropertyName = "CodeProduct";
            this.CodeProduct.HeaderText = "کد کالا";
            this.CodeProduct.MinimumWidth = 12;
            this.CodeProduct.Name = "CodeProduct";
            this.CodeProduct.ReadOnly = true;
            this.CodeProduct.Width = 250;
            // 
            // PoductName
            // 
            this.PoductName.DataPropertyName = "ProductName";
            this.PoductName.HeaderText = "نام کالا";
            this.PoductName.MinimumWidth = 12;
            this.PoductName.Name = "PoductName";
            this.PoductName.ReadOnly = true;
            this.PoductName.Width = 250;
            // 
            // ProductSerials
            // 
            this.ProductSerials.DataPropertyName = "ProductSerials";
            this.ProductSerials.HeaderText = "کد اموال";
            this.ProductSerials.MinimumWidth = 12;
            this.ProductSerials.Name = "ProductSerials";
            this.ProductSerials.ReadOnly = true;
            this.ProductSerials.Width = 250;
            // 
            // ProductPlace
            // 
            this.ProductPlace.DataPropertyName = "ProductPlace";
            this.ProductPlace.HeaderText = "قفسه";
            this.ProductPlace.MinimumWidth = 12;
            this.ProductPlace.Name = "ProductPlace";
            this.ProductPlace.ReadOnly = true;
            this.ProductPlace.Width = 250;
            // 
            // ProductFirstBalance
            // 
            this.ProductFirstBalance.DataPropertyName = "FirstBalance";
            this.ProductFirstBalance.HeaderText = "موجودی اولیه";
            this.ProductFirstBalance.MinimumWidth = 12;
            this.ProductFirstBalance.Name = "ProductFirstBalance";
            this.ProductFirstBalance.ReadOnly = true;
            this.ProductFirstBalance.Width = 250;
            // 
            // ProductCurrentBalance
            // 
            this.ProductCurrentBalance.DataPropertyName = "CurrentBalance";
            this.ProductCurrentBalance.HeaderText = "موجودی فعلی";
            this.ProductCurrentBalance.MinimumWidth = 12;
            this.ProductCurrentBalance.Name = "ProductCurrentBalance";
            this.ProductCurrentBalance.ReadOnly = true;
            this.ProductCurrentBalance.Width = 250;
            // 
            // frmStoreBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1846, 905);
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.Name = "frmStoreBalance";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "گزارش موجودی انبارها";
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel5.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgStoreBalance)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel5;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgStoreBalance;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btnShowAll;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchStore;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.ButtonX btnPrintStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSerials;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductFirstBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCurrentBalance;
    }
}