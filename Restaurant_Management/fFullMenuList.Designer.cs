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
            this.Lv_SelectFood = new System.Windows.Forms.ListView();
            this.col_Fname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Fsize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbb_Catergory = new System.Windows.Forms.ComboBox();
            this.Lbl_OrderCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lv_SelectFood
            // 
            this.Lv_SelectFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lv_SelectFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Fname,
            this.col_Fsize});
            this.Lv_SelectFood.FullRowSelect = true;
            this.Lv_SelectFood.GridLines = true;
            this.Lv_SelectFood.Location = new System.Drawing.Point(-2, 39);
            this.Lv_SelectFood.Name = "Lv_SelectFood";
            this.Lv_SelectFood.Size = new System.Drawing.Size(802, 411);
            this.Lv_SelectFood.TabIndex = 10;
            this.Lv_SelectFood.UseCompatibleStateImageBehavior = false;
            this.Lv_SelectFood.View = System.Windows.Forms.View.Details;
            // 
            // col_Fname
            // 
            this.col_Fname.Text = "Name";
            this.col_Fname.Width = 120;
            // 
            // col_Fsize
            // 
            this.col_Fsize.Text = "Size";
            this.col_Fsize.Width = 75;
            // 
            // cbb_Catergory
            // 
            this.cbb_Catergory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_Catergory.FormattingEnabled = true;
            this.cbb_Catergory.Location = new System.Drawing.Point(663, 12);
            this.cbb_Catergory.Name = "cbb_Catergory";
            this.cbb_Catergory.Size = new System.Drawing.Size(125, 21);
            this.cbb_Catergory.TabIndex = 12;
            this.cbb_Catergory.SelectedIndexChanged += new System.EventHandler(this.cbb_Catergory_SelectedIndexChanged);
            // 
            // Lbl_OrderCategory
            // 
            this.Lbl_OrderCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_OrderCategory.AutoSize = true;
            this.Lbl_OrderCategory.Location = new System.Drawing.Point(568, 15);
            this.Lbl_OrderCategory.Name = "Lbl_OrderCategory";
            this.Lbl_OrderCategory.Size = new System.Drawing.Size(55, 13);
            this.Lbl_OrderCategory.TabIndex = 11;
            this.Lbl_OrderCategory.Text = "Category :";
            this.Lbl_OrderCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fFullMenuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbb_Catergory);
            this.Controls.Add(this.Lbl_OrderCategory);
            this.Controls.Add(this.Lv_SelectFood);
            this.Name = "fFullMenuList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fFullMenuList";
            this.Load += new System.EventHandler(this.fFullMenuList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Lv_SelectFood;
        private System.Windows.Forms.ColumnHeader col_Fname;
        private System.Windows.Forms.ColumnHeader col_Fsize;
        private System.Windows.Forms.ComboBox cbb_Catergory;
        private System.Windows.Forms.Label Lbl_OrderCategory;
    }
}