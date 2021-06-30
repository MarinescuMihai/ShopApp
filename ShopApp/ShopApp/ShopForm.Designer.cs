
namespace ShopApp
{
    partial class ShopForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MakePurchaseBtn = new System.Windows.Forms.Button();
            this.VendorLabel = new System.Windows.Forms.Label();
            this.VendorsListBox = new System.Windows.Forms.ListBox();
            this.ShoppingBoxLabel = new System.Windows.Forms.Label();
            this.ShoppingCartListBox = new System.Windows.Forms.ListBox();
            this.AddToCartItemBtn = new System.Windows.Forms.Button();
            this.ItemsListBoxLabel = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.ShopAppLabel = new System.Windows.Forms.Label();
            this.TotalTextLabel = new System.Windows.Forms.Label();
            this.TotalSumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MakePurchaseBtn
            // 
            this.MakePurchaseBtn.Location = new System.Drawing.Point(410, 577);
            this.MakePurchaseBtn.Name = "MakePurchaseBtn";
            this.MakePurchaseBtn.Size = new System.Drawing.Size(136, 37);
            this.MakePurchaseBtn.TabIndex = 17;
            this.MakePurchaseBtn.Text = "Buy";
            this.MakePurchaseBtn.UseVisualStyleBackColor = true;
            this.MakePurchaseBtn.Click += new System.EventHandler(this.MakePurchaseBtn_Click);
            // 
            // VendorLabel
            // 
            this.VendorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VendorLabel.AutoSize = true;
            this.VendorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VendorLabel.Location = new System.Drawing.Point(232, 69);
            this.VendorLabel.Name = "VendorLabel";
            this.VendorLabel.Size = new System.Drawing.Size(72, 21);
            this.VendorLabel.TabIndex = 16;
            this.VendorLabel.Text = "Vendors";
            // 
            // VendorsListBox
            // 
            this.VendorsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VendorsListBox.FormattingEnabled = true;
            this.VendorsListBox.ItemHeight = 15;
            this.VendorsListBox.Location = new System.Drawing.Point(83, 93);
            this.VendorsListBox.Name = "VendorsListBox";
            this.VendorsListBox.Size = new System.Drawing.Size(363, 184);
            this.VendorsListBox.TabIndex = 15;
            this.VendorsListBox.SelectedIndexChanged += new System.EventHandler(this.VendorsListBox_SelectedIndexChanged);
            // 
            // ShoppingBoxLabel
            // 
            this.ShoppingBoxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShoppingBoxLabel.AutoSize = true;
            this.ShoppingBoxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShoppingBoxLabel.Location = new System.Drawing.Point(446, 354);
            this.ShoppingBoxLabel.Name = "ShoppingBoxLabel";
            this.ShoppingBoxLabel.Size = new System.Drawing.Size(41, 21);
            this.ShoppingBoxLabel.TabIndex = 14;
            this.ShoppingBoxLabel.Text = "Cart";
            // 
            // ShoppingCartListBox
            // 
            this.ShoppingCartListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShoppingCartListBox.FormattingEnabled = true;
            this.ShoppingCartListBox.ItemHeight = 15;
            this.ShoppingCartListBox.Location = new System.Drawing.Point(297, 378);
            this.ShoppingCartListBox.Name = "ShoppingCartListBox";
            this.ShoppingCartListBox.Size = new System.Drawing.Size(363, 184);
            this.ShoppingCartListBox.TabIndex = 13;
            // 
            // AddToCartItemBtn
            // 
            this.AddToCartItemBtn.Location = new System.Drawing.Point(631, 292);
            this.AddToCartItemBtn.Name = "AddToCartItemBtn";
            this.AddToCartItemBtn.Size = new System.Drawing.Size(136, 37);
            this.AddToCartItemBtn.TabIndex = 12;
            this.AddToCartItemBtn.Text = "Add To Cart";
            this.AddToCartItemBtn.UseVisualStyleBackColor = true;
            this.AddToCartItemBtn.Click += new System.EventHandler(this.AddToCartItemBtn_Click);
            // 
            // ItemsListBoxLabel
            // 
            this.ItemsListBoxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsListBoxLabel.AutoSize = true;
            this.ItemsListBoxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemsListBoxLabel.Location = new System.Drawing.Point(667, 69);
            this.ItemsListBoxLabel.Name = "ItemsListBoxLabel";
            this.ItemsListBoxLabel.Size = new System.Drawing.Size(52, 21);
            this.ItemsListBoxLabel.TabIndex = 11;
            this.ItemsListBoxLabel.Text = "Items";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 15;
            this.ItemsListBox.Location = new System.Drawing.Point(518, 93);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(363, 184);
            this.ItemsListBox.TabIndex = 10;
            // 
            // ShopAppLabel
            // 
            this.ShopAppLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShopAppLabel.AutoSize = true;
            this.ShopAppLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShopAppLabel.Location = new System.Drawing.Point(421, 13);
            this.ShopAppLabel.Name = "ShopAppLabel";
            this.ShopAppLabel.Size = new System.Drawing.Size(125, 32);
            this.ShopAppLabel.TabIndex = 9;
            this.ShopAppLabel.Text = "Shop App";
            this.ShopAppLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TotalTextLabel
            // 
            this.TotalTextLabel.AutoSize = true;
            this.TotalTextLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalTextLabel.Location = new System.Drawing.Point(715, 458);
            this.TotalTextLabel.Name = "TotalTextLabel";
            this.TotalTextLabel.Size = new System.Drawing.Size(60, 25);
            this.TotalTextLabel.TabIndex = 18;
            this.TotalTextLabel.Text = "Total:";
            // 
            // TotalSumLabel
            // 
            this.TotalSumLabel.AutoSize = true;
            this.TotalSumLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalSumLabel.Location = new System.Drawing.Point(781, 458);
            this.TotalSumLabel.Name = "TotalSumLabel";
            this.TotalSumLabel.Size = new System.Drawing.Size(23, 25);
            this.TotalSumLabel.TabIndex = 19;
            this.TotalSumLabel.Text = "0";
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 626);
            this.Controls.Add(this.TotalSumLabel);
            this.Controls.Add(this.TotalTextLabel);
            this.Controls.Add(this.MakePurchaseBtn);
            this.Controls.Add(this.VendorLabel);
            this.Controls.Add(this.VendorsListBox);
            this.Controls.Add(this.ShoppingBoxLabel);
            this.Controls.Add(this.ShoppingCartListBox);
            this.Controls.Add(this.AddToCartItemBtn);
            this.Controls.Add(this.ItemsListBoxLabel);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.ShopAppLabel);
            this.Name = "ShopForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MakePurchaseBtn;
        private System.Windows.Forms.Label VendorLabel;
        private System.Windows.Forms.ListBox VendorsListBox;
        private System.Windows.Forms.Label ShoppingBoxLabel;
        private System.Windows.Forms.ListBox ShoppingCartListBox;
        private System.Windows.Forms.Button AddToCartItemBtn;
        private System.Windows.Forms.Label ItemsListBoxLabel;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label ShopAppLabel;
        private System.Windows.Forms.Label TotalTextLabel;
        private System.Windows.Forms.Label TotalSumLabel;
    }
}

