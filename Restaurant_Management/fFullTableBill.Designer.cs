namespace Restaurant_Management
{
    partial class fFullTableBill
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
            this.grB_Bill = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_TotalPrice = new System.Windows.Forms.Label();
            this.txb_Total = new System.Windows.Forms.TextBox();
            this.Lv_Bill = new System.Windows.Forms.ListView();
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_totalprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Flp_Bmenu = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_Remove = new System.Windows.Forms.Button();
            this.Btn_Discount = new System.Windows.Forms.Button();
            this.nUD_Discount = new System.Windows.Forms.NumericUpDown();
            this.Btn_CheckOut = new System.Windows.Forms.Button();
            this.grB_Bill.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Flp_Bmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Discount)).BeginInit();
            this.SuspendLayout();
            // 
            // grB_Bill
            // 
            this.grB_Bill.Controls.Add(this.panel1);
            this.grB_Bill.Controls.Add(this.Lv_Bill);
            this.grB_Bill.Controls.Add(this.Flp_Bmenu);
            this.grB_Bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grB_Bill.Location = new System.Drawing.Point(0, 0);
            this.grB_Bill.Name = "grB_Bill";
            this.grB_Bill.Size = new System.Drawing.Size(800, 450);
            this.grB_Bill.TabIndex = 10;
            this.grB_Bill.TabStop = false;
            this.grB_Bill.Text = "Bill";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Lbl_TotalPrice);
            this.panel1.Controls.Add(this.txb_Total);
            this.panel1.Location = new System.Drawing.Point(5, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 30);
            this.panel1.TabIndex = 3;
            // 
            // Lbl_TotalPrice
            // 
            this.Lbl_TotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_TotalPrice.AutoSize = true;
            this.Lbl_TotalPrice.Location = new System.Drawing.Point(205, 9);
            this.Lbl_TotalPrice.Name = "Lbl_TotalPrice";
            this.Lbl_TotalPrice.Size = new System.Drawing.Size(37, 13);
            this.Lbl_TotalPrice.TabIndex = 1;
            this.Lbl_TotalPrice.Text = "Total :";
            // 
            // txb_Total
            // 
            this.txb_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_Total.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txb_Total.Location = new System.Drawing.Point(250, 5);
            this.txb_Total.Name = "txb_Total";
            this.txb_Total.ReadOnly = true;
            this.txb_Total.Size = new System.Drawing.Size(454, 20);
            this.txb_Total.TabIndex = 0;
            this.txb_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Lv_Bill
            // 
            this.Lv_Bill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lv_Bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_name,
            this.col_Size,
            this.col_count,
            this.col_price,
            this.col_totalprice});
            this.Lv_Bill.FullRowSelect = true;
            this.Lv_Bill.GridLines = true;
            this.Lv_Bill.Location = new System.Drawing.Point(5, 20);
            this.Lv_Bill.Name = "Lv_Bill";
            this.Lv_Bill.Size = new System.Drawing.Size(704, 392);
            this.Lv_Bill.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.Lv_Bill.TabIndex = 0;
            this.Lv_Bill.UseCompatibleStateImageBehavior = false;
            this.Lv_Bill.View = System.Windows.Forms.View.Details;
            // 
            // col_name
            // 
            this.col_name.Text = "Name";
            this.col_name.Width = 200;
            // 
            // col_Size
            // 
            this.col_Size.Text = "Size";
            this.col_Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_Size.Width = 75;
            // 
            // col_count
            // 
            this.col_count.Text = "Count";
            this.col_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_count.Width = 50;
            // 
            // col_price
            // 
            this.col_price.Text = "Price";
            this.col_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.col_price.Width = 75;
            // 
            // col_totalprice
            // 
            this.col_totalprice.Text = "Total Price";
            this.col_totalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.col_totalprice.Width = 75;
            // 
            // Flp_Bmenu
            // 
            this.Flp_Bmenu.Controls.Add(this.Btn_Remove);
            this.Flp_Bmenu.Controls.Add(this.Btn_Discount);
            this.Flp_Bmenu.Controls.Add(this.nUD_Discount);
            this.Flp_Bmenu.Controls.Add(this.Btn_CheckOut);
            this.Flp_Bmenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.Flp_Bmenu.Location = new System.Drawing.Point(716, 16);
            this.Flp_Bmenu.Name = "Flp_Bmenu";
            this.Flp_Bmenu.Size = new System.Drawing.Size(81, 431);
            this.Flp_Bmenu.TabIndex = 2;
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.Location = new System.Drawing.Point(3, 3);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(75, 25);
            this.Btn_Remove.TabIndex = 13;
            this.Btn_Remove.Text = "Remove";
            this.Btn_Remove.UseVisualStyleBackColor = true;
            this.Btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // Btn_Discount
            // 
            this.Btn_Discount.Location = new System.Drawing.Point(3, 34);
            this.Btn_Discount.Name = "Btn_Discount";
            this.Btn_Discount.Size = new System.Drawing.Size(75, 25);
            this.Btn_Discount.TabIndex = 14;
            this.Btn_Discount.Text = "Discount";
            this.Btn_Discount.UseVisualStyleBackColor = true;
            // 
            // nUD_Discount
            // 
            this.nUD_Discount.Location = new System.Drawing.Point(3, 65);
            this.nUD_Discount.Name = "nUD_Discount";
            this.nUD_Discount.Size = new System.Drawing.Size(75, 20);
            this.nUD_Discount.TabIndex = 16;
            // 
            // Btn_CheckOut
            // 
            this.Btn_CheckOut.Location = new System.Drawing.Point(3, 91);
            this.Btn_CheckOut.Name = "Btn_CheckOut";
            this.Btn_CheckOut.Size = new System.Drawing.Size(75, 50);
            this.Btn_CheckOut.TabIndex = 12;
            this.Btn_CheckOut.Text = "Check Out";
            this.Btn_CheckOut.UseVisualStyleBackColor = true;
            this.Btn_CheckOut.Click += new System.EventHandler(this.Btn_CheckOut_Click);
            // 
            // fFullTableBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grB_Bill);
            this.Name = "fFullTableBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fFullTableBill";
            this.Load += new System.EventHandler(this.fFullTableBill_Load);
            this.grB_Bill.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Flp_Bmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Discount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grB_Bill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_TotalPrice;
        private System.Windows.Forms.TextBox txb_Total;
        private System.Windows.Forms.ListView Lv_Bill;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_Size;
        private System.Windows.Forms.ColumnHeader col_count;
        private System.Windows.Forms.ColumnHeader col_price;
        private System.Windows.Forms.ColumnHeader col_totalprice;
        private System.Windows.Forms.FlowLayoutPanel Flp_Bmenu;
        private System.Windows.Forms.Button Btn_Remove;
        private System.Windows.Forms.Button Btn_Discount;
        private System.Windows.Forms.NumericUpDown nUD_Discount;
        private System.Windows.Forms.Button Btn_CheckOut;
    }
}