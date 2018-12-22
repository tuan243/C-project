namespace Restaurant_Management
{
    partial class fFullMenuList
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grB_Order = new System.Windows.Forms.GroupBox();
            this.Lv_SelectFood = new System.Windows.Forms.ListView();
            this.col_Fname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Fsize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbb_Catergory = new System.Windows.Forms.ComboBox();
            this.nUD_UnitCount = new System.Windows.Forms.NumericUpDown();
            this.Lbl_OrderCategory = new System.Windows.Forms.Label();
            this.Btn_AddOrder = new System.Windows.Forms.Button();
            this.grB_MFind = new System.Windows.Forms.GroupBox();
            this.Btn_MFind = new System.Windows.Forms.Button();
            this.Txb_MFind = new System.Windows.Forms.TextBox();
            this.grB_MInfo = new System.Windows.Forms.GroupBox();
            this.Txb_MPrice = new System.Windows.Forms.TextBox();
            this.Txb_MSize = new System.Windows.Forms.TextBox();
            this.Txb_MName = new System.Windows.Forms.TextBox();
            this.Txb_MID = new System.Windows.Forms.TextBox();
            this.Lbl_MPrice = new System.Windows.Forms.Label();
            this.Lbl_MSize = new System.Windows.Forms.Label();
            this.Lbl_MCategory = new System.Windows.Forms.Label();
            this.Lbl_MName = new System.Windows.Forms.Label();
            this.Lbl_MID = new System.Windows.Forms.Label();
            this.Txb_MCategory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grB_Order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UnitCount)).BeginInit();
            this.grB_MFind.SuspendLayout();
            this.grB_MInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grB_Order);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grB_MFind);
            this.splitContainer1.Panel2.Controls.Add(this.grB_MInfo);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 515;
            this.splitContainer1.TabIndex = 12;
            // 
            // grB_Order
            // 
            this.grB_Order.Controls.Add(this.Lv_SelectFood);
            this.grB_Order.Controls.Add(this.cbb_Catergory);
            this.grB_Order.Controls.Add(this.nUD_UnitCount);
            this.grB_Order.Controls.Add(this.Lbl_OrderCategory);
            this.grB_Order.Controls.Add(this.Btn_AddOrder);
            this.grB_Order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grB_Order.Location = new System.Drawing.Point(0, 0);
            this.grB_Order.Name = "grB_Order";
            this.grB_Order.Size = new System.Drawing.Size(515, 450);
            this.grB_Order.TabIndex = 12;
            this.grB_Order.TabStop = false;
            this.grB_Order.Text = "Order";
            // 
            // Lv_SelectFood
            // 
            this.Lv_SelectFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lv_SelectFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Fname,
            this.col_Fsize,
            this.col_Price});
            this.Lv_SelectFood.FullRowSelect = true;
            this.Lv_SelectFood.GridLines = true;
            this.Lv_SelectFood.Location = new System.Drawing.Point(5, 50);
            this.Lv_SelectFood.Name = "Lv_SelectFood";
            this.Lv_SelectFood.Size = new System.Drawing.Size(505, 362);
            this.Lv_SelectFood.TabIndex = 9;
            this.Lv_SelectFood.UseCompatibleStateImageBehavior = false;
            this.Lv_SelectFood.View = System.Windows.Forms.View.Details;
            this.Lv_SelectFood.SelectedIndexChanged += new System.EventHandler(this.Lv_SelectFood_SelectedIndexChanged);
            // 
            // col_Fname
            // 
            this.col_Fname.Text = "Name";
            this.col_Fname.Width = 300;
            // 
            // col_Fsize
            // 
            this.col_Fsize.Text = "Size";
            this.col_Fsize.Width = 75;
            // 
            // col_Price
            // 
            this.col_Price.Text = "Price";
            this.col_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.col_Price.Width = 100;
            // 
            // cbb_Catergory
            // 
            this.cbb_Catergory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_Catergory.FormattingEnabled = true;
            this.cbb_Catergory.Location = new System.Drawing.Point(100, 20);
            this.cbb_Catergory.Name = "cbb_Catergory";
            this.cbb_Catergory.Size = new System.Drawing.Size(410, 21);
            this.cbb_Catergory.TabIndex = 8;
            this.cbb_Catergory.SelectedIndexChanged += new System.EventHandler(this.cbb_Catergory_SelectedIndexChanged);
            // 
            // nUD_UnitCount
            // 
            this.nUD_UnitCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nUD_UnitCount.Location = new System.Drawing.Point(395, 420);
            this.nUD_UnitCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nUD_UnitCount.Name = "nUD_UnitCount";
            this.nUD_UnitCount.Size = new System.Drawing.Size(40, 20);
            this.nUD_UnitCount.TabIndex = 6;
            this.nUD_UnitCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Lbl_OrderCategory
            // 
            this.Lbl_OrderCategory.AutoSize = true;
            this.Lbl_OrderCategory.Location = new System.Drawing.Point(5, 23);
            this.Lbl_OrderCategory.Name = "Lbl_OrderCategory";
            this.Lbl_OrderCategory.Size = new System.Drawing.Size(55, 13);
            this.Lbl_OrderCategory.TabIndex = 0;
            this.Lbl_OrderCategory.Text = "Category :";
            this.Lbl_OrderCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_AddOrder
            // 
            this.Btn_AddOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_AddOrder.Location = new System.Drawing.Point(442, 418);
            this.Btn_AddOrder.Name = "Btn_AddOrder";
            this.Btn_AddOrder.Size = new System.Drawing.Size(70, 25);
            this.Btn_AddOrder.TabIndex = 4;
            this.Btn_AddOrder.Text = "Add";
            this.Btn_AddOrder.UseVisualStyleBackColor = true;
            // 
            // grB_MFind
            // 
            this.grB_MFind.Controls.Add(this.Btn_MFind);
            this.grB_MFind.Controls.Add(this.Txb_MFind);
            this.grB_MFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.grB_MFind.Location = new System.Drawing.Point(0, 0);
            this.grB_MFind.Name = "grB_MFind";
            this.grB_MFind.Size = new System.Drawing.Size(281, 80);
            this.grB_MFind.TabIndex = 17;
            this.grB_MFind.TabStop = false;
            this.grB_MFind.Text = "Finding";
            // 
            // Btn_MFind
            // 
            this.Btn_MFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_MFind.Location = new System.Drawing.Point(201, 50);
            this.Btn_MFind.Name = "Btn_MFind";
            this.Btn_MFind.Size = new System.Drawing.Size(75, 23);
            this.Btn_MFind.TabIndex = 5;
            this.Btn_MFind.Text = "Find";
            this.Btn_MFind.UseVisualStyleBackColor = true;
            // 
            // Txb_MFind
            // 
            this.Txb_MFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txb_MFind.Location = new System.Drawing.Point(5, 25);
            this.Txb_MFind.Name = "Txb_MFind";
            this.Txb_MFind.Size = new System.Drawing.Size(271, 20);
            this.Txb_MFind.TabIndex = 4;
            // 
            // grB_MInfo
            // 
            this.grB_MInfo.Controls.Add(this.Txb_MPrice);
            this.grB_MInfo.Controls.Add(this.Txb_MSize);
            this.grB_MInfo.Controls.Add(this.Txb_MCategory);
            this.grB_MInfo.Controls.Add(this.Txb_MName);
            this.grB_MInfo.Controls.Add(this.Txb_MID);
            this.grB_MInfo.Controls.Add(this.Lbl_MPrice);
            this.grB_MInfo.Controls.Add(this.Lbl_MSize);
            this.grB_MInfo.Controls.Add(this.Lbl_MCategory);
            this.grB_MInfo.Controls.Add(this.Lbl_MName);
            this.grB_MInfo.Controls.Add(this.Lbl_MID);
            this.grB_MInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grB_MInfo.Location = new System.Drawing.Point(0, 85);
            this.grB_MInfo.Name = "grB_MInfo";
            this.grB_MInfo.Size = new System.Drawing.Size(281, 365);
            this.grB_MInfo.TabIndex = 16;
            this.grB_MInfo.TabStop = false;
            this.grB_MInfo.Text = "Info";
            // 
            // Txb_MPrice
            // 
            this.Txb_MPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txb_MPrice.Location = new System.Drawing.Point(80, 123);
            this.Txb_MPrice.Name = "Txb_MPrice";
            this.Txb_MPrice.ReadOnly = true;
            this.Txb_MPrice.Size = new System.Drawing.Size(196, 20);
            this.Txb_MPrice.TabIndex = 9;
            // 
            // Txb_MSize
            // 
            this.Txb_MSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txb_MSize.Location = new System.Drawing.Point(80, 98);
            this.Txb_MSize.Name = "Txb_MSize";
            this.Txb_MSize.ReadOnly = true;
            this.Txb_MSize.Size = new System.Drawing.Size(196, 20);
            this.Txb_MSize.TabIndex = 9;
            // 
            // Txb_MName
            // 
            this.Txb_MName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txb_MName.Location = new System.Drawing.Point(80, 47);
            this.Txb_MName.Name = "Txb_MName";
            this.Txb_MName.ReadOnly = true;
            this.Txb_MName.Size = new System.Drawing.Size(196, 20);
            this.Txb_MName.TabIndex = 7;
            // 
            // Txb_MID
            // 
            this.Txb_MID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txb_MID.Location = new System.Drawing.Point(80, 22);
            this.Txb_MID.Name = "Txb_MID";
            this.Txb_MID.ReadOnly = true;
            this.Txb_MID.Size = new System.Drawing.Size(196, 20);
            this.Txb_MID.TabIndex = 6;
            // 
            // Lbl_MPrice
            // 
            this.Lbl_MPrice.AutoSize = true;
            this.Lbl_MPrice.Location = new System.Drawing.Point(5, 126);
            this.Lbl_MPrice.Name = "Lbl_MPrice";
            this.Lbl_MPrice.Size = new System.Drawing.Size(37, 13);
            this.Lbl_MPrice.TabIndex = 2;
            this.Lbl_MPrice.Text = "Price :";
            this.Lbl_MPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_MSize
            // 
            this.Lbl_MSize.AutoSize = true;
            this.Lbl_MSize.Location = new System.Drawing.Point(5, 101);
            this.Lbl_MSize.Name = "Lbl_MSize";
            this.Lbl_MSize.Size = new System.Drawing.Size(33, 13);
            this.Lbl_MSize.TabIndex = 2;
            this.Lbl_MSize.Text = "Size :";
            this.Lbl_MSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_MCategory
            // 
            this.Lbl_MCategory.AutoSize = true;
            this.Lbl_MCategory.Location = new System.Drawing.Point(5, 75);
            this.Lbl_MCategory.Name = "Lbl_MCategory";
            this.Lbl_MCategory.Size = new System.Drawing.Size(55, 13);
            this.Lbl_MCategory.TabIndex = 2;
            this.Lbl_MCategory.Text = "Category :";
            this.Lbl_MCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_MName
            // 
            this.Lbl_MName.AutoSize = true;
            this.Lbl_MName.Location = new System.Drawing.Point(5, 50);
            this.Lbl_MName.Name = "Lbl_MName";
            this.Lbl_MName.Size = new System.Drawing.Size(41, 13);
            this.Lbl_MName.TabIndex = 2;
            this.Lbl_MName.Text = "Name :";
            this.Lbl_MName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_MID
            // 
            this.Lbl_MID.AutoSize = true;
            this.Lbl_MID.Location = new System.Drawing.Point(5, 25);
            this.Lbl_MID.Name = "Lbl_MID";
            this.Lbl_MID.Size = new System.Drawing.Size(24, 13);
            this.Lbl_MID.TabIndex = 2;
            this.Lbl_MID.Text = "ID :";
            this.Lbl_MID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txb_MCategory
            // 
            this.Txb_MCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txb_MCategory.Location = new System.Drawing.Point(80, 72);
            this.Txb_MCategory.Name = "Txb_MCategory";
            this.Txb_MCategory.ReadOnly = true;
            this.Txb_MCategory.Size = new System.Drawing.Size(196, 20);
            this.Txb_MCategory.TabIndex = 7;
            // 
            // fFullMenuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "fFullMenuList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fFullMenuList";
            this.Load += new System.EventHandler(this.fFullMenuList_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grB_Order.ResumeLayout(false);
            this.grB_Order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_UnitCount)).EndInit();
            this.grB_MFind.ResumeLayout(false);
            this.grB_MFind.PerformLayout();
            this.grB_MInfo.ResumeLayout(false);
            this.grB_MInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grB_Order;
        private System.Windows.Forms.ListView Lv_SelectFood;
        private System.Windows.Forms.ColumnHeader col_Fname;
        private System.Windows.Forms.ColumnHeader col_Fsize;
        private System.Windows.Forms.ColumnHeader col_Price;
        private System.Windows.Forms.ComboBox cbb_Catergory;
        private System.Windows.Forms.NumericUpDown nUD_UnitCount;
        private System.Windows.Forms.Label Lbl_OrderCategory;
        private System.Windows.Forms.Button Btn_AddOrder;
        private System.Windows.Forms.GroupBox grB_MFind;
        private System.Windows.Forms.Button Btn_MFind;
        private System.Windows.Forms.TextBox Txb_MFind;
        private System.Windows.Forms.GroupBox grB_MInfo;
        private System.Windows.Forms.TextBox Txb_MPrice;
        private System.Windows.Forms.TextBox Txb_MSize;
        private System.Windows.Forms.TextBox Txb_MName;
        private System.Windows.Forms.TextBox Txb_MID;
        private System.Windows.Forms.Label Lbl_MPrice;
        private System.Windows.Forms.Label Lbl_MSize;
        private System.Windows.Forms.Label Lbl_MCategory;
        private System.Windows.Forms.Label Lbl_MName;
        private System.Windows.Forms.Label Lbl_MID;
        private System.Windows.Forms.TextBox Txb_MCategory;
    }
}