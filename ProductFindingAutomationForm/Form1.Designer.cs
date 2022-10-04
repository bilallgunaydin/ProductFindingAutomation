namespace ProductFindingAutomationForm
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
            this.dtListProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grpProductSearch = new System.Windows.Forms.GroupBox();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.ckSiteName = new System.Windows.Forms.CheckBox();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.grpProductList = new System.Windows.Forms.GroupBox();
            this.btnProductList = new System.Windows.Forms.Button();
            this.txtProductFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtListProduct)).BeginInit();
            this.grpProductSearch.SuspendLayout();
            this.grpProductList.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtListProduct
            // 
            this.dtListProduct.AllowUserToOrderColumns = true;
            this.dtListProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListProduct.Location = new System.Drawing.Point(16, 53);
            this.dtListProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dtListProduct.Name = "dtListProduct";
            this.dtListProduct.RowHeadersWidth = 51;
            this.dtListProduct.Size = new System.Drawing.Size(1005, 257);
            this.dtListProduct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(327, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÜRÜN LİSTELEME";
            // 
            // grpProductSearch
            // 
            this.grpProductSearch.Controls.Add(this.btnProductSearch);
            this.grpProductSearch.Controls.Add(this.ckSiteName);
            this.grpProductSearch.Controls.Add(this.txtProductSearch);
            this.grpProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpProductSearch.Location = new System.Drawing.Point(16, 318);
            this.grpProductSearch.Margin = new System.Windows.Forms.Padding(4);
            this.grpProductSearch.Name = "grpProductSearch";
            this.grpProductSearch.Padding = new System.Windows.Forms.Padding(4);
            this.grpProductSearch.Size = new System.Drawing.Size(433, 156);
            this.grpProductSearch.TabIndex = 2;
            this.grpProductSearch.TabStop = false;
            this.grpProductSearch.Text = "Ürün Sorgulama";
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.BackColor = System.Drawing.Color.Lime;
            this.btnProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProductSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductSearch.Location = new System.Drawing.Point(264, 53);
            this.btnProductSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(164, 57);
            this.btnProductSearch.TabIndex = 2;
            this.btnProductSearch.Text = "Ürünü Sorgula";
            this.btnProductSearch.UseVisualStyleBackColor = false;
            this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);
            // 
            // ckSiteName
            // 
            this.ckSiteName.AutoSize = true;
            this.ckSiteName.Location = new System.Drawing.Point(9, 95);
            this.ckSiteName.Margin = new System.Windows.Forms.Padding(4);
            this.ckSiteName.Name = "ckSiteName";
            this.ckSiteName.Size = new System.Drawing.Size(79, 33);
            this.ckSiteName.TabIndex = 1;
            this.ckSiteName.Text = "N11";
            this.ckSiteName.UseVisualStyleBackColor = true;
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Location = new System.Drawing.Point(9, 53);
            this.txtProductSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(201, 34);
            this.txtProductSearch.TabIndex = 0;
            this.txtProductSearch.Text = "Aranacak Ürün...";
            this.txtProductSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtProductSearch_MouseClick);
            // 
            // grpProductList
            // 
            this.grpProductList.Controls.Add(this.btnProductList);
            this.grpProductList.Controls.Add(this.txtProductFilter);
            this.grpProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpProductList.Location = new System.Drawing.Point(617, 318);
            this.grpProductList.Margin = new System.Windows.Forms.Padding(4);
            this.grpProductList.Name = "grpProductList";
            this.grpProductList.Padding = new System.Windows.Forms.Padding(4);
            this.grpProductList.Size = new System.Drawing.Size(404, 156);
            this.grpProductList.TabIndex = 3;
            this.grpProductList.TabStop = false;
            this.grpProductList.Text = "Ürün Listeleme";
            // 
            // btnProductList
            // 
            this.btnProductList.BackColor = System.Drawing.Color.SkyBlue;
            this.btnProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProductList.Location = new System.Drawing.Point(8, 91);
            this.btnProductList.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(243, 57);
            this.btnProductList.TabIndex = 1;
            this.btnProductList.Text = "Ürünleri Listele";
            this.btnProductList.UseVisualStyleBackColor = false;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // txtProductFilter
            // 
            this.txtProductFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductFilter.Location = new System.Drawing.Point(8, 53);
            this.txtProductFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductFilter.Name = "txtProductFilter";
            this.txtProductFilter.Size = new System.Drawing.Size(243, 30);
            this.txtProductFilter.TabIndex = 0;
            this.txtProductFilter.Text = "Anahtar Kelime...";
            this.txtProductFilter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtProductFilter_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 768);
            this.Controls.Add(this.grpProductList);
            this.Controls.Add(this.grpProductSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtListProduct);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Ürün Bulma Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtListProduct)).EndInit();
            this.grpProductSearch.ResumeLayout(false);
            this.grpProductSearch.PerformLayout();
            this.grpProductList.ResumeLayout(false);
            this.grpProductList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtListProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpProductSearch;
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.CheckBox ckSiteName;
        private System.Windows.Forms.TextBox txtProductSearch;
        private System.Windows.Forms.GroupBox grpProductList;
        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.TextBox txtProductFilter;
    }
}

