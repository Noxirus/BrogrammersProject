namespace BrogrammersWorkshop
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
            this.Packages = new System.Windows.Forms.TabControl();
            this.tabPagePackageDetails = new System.Windows.Forms.TabPage();
            this.pckProductSupplier = new System.Windows.Forms.DataGridView();
            this.txtAgencyCommision = new System.Windows.Forms.TextBox();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtPckDesc = new System.Windows.Forms.TextBox();
            this.txtPckEnd = new System.Windows.Forms.TextBox();
            this.txtPckStart = new System.Windows.Forms.TextBox();
            this.comboPckID = new System.Windows.Forms.ComboBox();
            this.txtPckName = new System.Windows.Forms.TextBox();
            this.lblAgencyCommision = new System.Windows.Forms.Label();
            this.lblPckBasePrice = new System.Windows.Forms.Label();
            this.lblPckDesc = new System.Windows.Forms.Label();
            this.lblPckEnd = new System.Windows.Forms.Label();
            this.lblPckStart = new System.Windows.Forms.Label();
            this.lblPckName = new System.Windows.Forms.Label();
            this.lblPckID = new System.Windows.Forms.Label();
            this.tabPageProductSuppliers = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.txtPrdID = new System.Windows.Forms.TextBox();
            this.txtPrdSup = new System.Windows.Forms.TextBox();
            this.lblSuppID = new System.Windows.Forms.Label();
            this.lblPrdID = new System.Windows.Forms.Label();
            this.lblPrdSup = new System.Windows.Forms.Label();
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.products = new System.Windows.Forms.DataGridView();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.tabPageSupplier = new System.Windows.Forms.TabPage();
            this.Suppliers = new System.Windows.Forms.DataGridView();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.supplierID = new System.Windows.Forms.ComboBox();
            this.lblSupName = new System.Windows.Forms.Label();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Packages.SuspendLayout();
            this.tabPagePackageDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pckProductSupplier)).BeginInit();
            this.tabPageProductSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.products)).BeginInit();
            this.tabPageSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Suppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // Packages
            // 
            this.Packages.Controls.Add(this.tabPagePackageDetails);
            this.Packages.Controls.Add(this.tabPageProductSuppliers);
            this.Packages.Controls.Add(this.tabPageProducts);
            this.Packages.Controls.Add(this.tabPageSupplier);
            this.Packages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Packages.Location = new System.Drawing.Point(5, 83);
            this.Packages.Name = "Packages";
            this.Packages.SelectedIndex = 0;
            this.Packages.Size = new System.Drawing.Size(1215, 492);
            this.Packages.TabIndex = 0;
            // 
            // tabPagePackageDetails
            // 
            this.tabPagePackageDetails.Controls.Add(this.pckProductSupplier);
            this.tabPagePackageDetails.Controls.Add(this.txtAgencyCommision);
            this.tabPagePackageDetails.Controls.Add(this.txtBasePrice);
            this.tabPagePackageDetails.Controls.Add(this.txtPckDesc);
            this.tabPagePackageDetails.Controls.Add(this.txtPckEnd);
            this.tabPagePackageDetails.Controls.Add(this.txtPckStart);
            this.tabPagePackageDetails.Controls.Add(this.comboPckID);
            this.tabPagePackageDetails.Controls.Add(this.txtPckName);
            this.tabPagePackageDetails.Controls.Add(this.lblAgencyCommision);
            this.tabPagePackageDetails.Controls.Add(this.lblPckBasePrice);
            this.tabPagePackageDetails.Controls.Add(this.lblPckDesc);
            this.tabPagePackageDetails.Controls.Add(this.lblPckEnd);
            this.tabPagePackageDetails.Controls.Add(this.lblPckStart);
            this.tabPagePackageDetails.Controls.Add(this.lblPckName);
            this.tabPagePackageDetails.Controls.Add(this.lblPckID);
            this.tabPagePackageDetails.Location = new System.Drawing.Point(4, 29);
            this.tabPagePackageDetails.Name = "tabPagePackageDetails";
            this.tabPagePackageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePackageDetails.Size = new System.Drawing.Size(1207, 459);
            this.tabPagePackageDetails.TabIndex = 3;
            this.tabPagePackageDetails.Text = "Package Details";
            this.tabPagePackageDetails.UseVisualStyleBackColor = true;
            // 
            // pckProductSupplier
            // 
            this.pckProductSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pckProductSupplier.Location = new System.Drawing.Point(528, 22);
            this.pckProductSupplier.Name = "pckProductSupplier";
            this.pckProductSupplier.RowHeadersWidth = 51;
            this.pckProductSupplier.RowTemplate.Height = 24;
            this.pckProductSupplier.Size = new System.Drawing.Size(660, 367);
            this.pckProductSupplier.TabIndex = 14;
            // 
            // txtAgencyCommision
            // 
            this.txtAgencyCommision.Location = new System.Drawing.Point(242, 306);
            this.txtAgencyCommision.Name = "txtAgencyCommision";
            this.txtAgencyCommision.Size = new System.Drawing.Size(253, 27);
            this.txtAgencyCommision.TabIndex = 13;
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(242, 249);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(253, 27);
            this.txtBasePrice.TabIndex = 12;
            // 
            // txtPckDesc
            // 
            this.txtPckDesc.Location = new System.Drawing.Point(242, 366);
            this.txtPckDesc.Name = "txtPckDesc";
            this.txtPckDesc.Size = new System.Drawing.Size(253, 27);
            this.txtPckDesc.TabIndex = 11;
            // 
            // txtPckEnd
            // 
            this.txtPckEnd.Location = new System.Drawing.Point(242, 195);
            this.txtPckEnd.Name = "txtPckEnd";
            this.txtPckEnd.Size = new System.Drawing.Size(253, 27);
            this.txtPckEnd.TabIndex = 10;
            // 
            // txtPckStart
            // 
            this.txtPckStart.Location = new System.Drawing.Point(242, 138);
            this.txtPckStart.Name = "txtPckStart";
            this.txtPckStart.Size = new System.Drawing.Size(253, 27);
            this.txtPckStart.TabIndex = 9;
            // 
            // comboPckID
            // 
            this.comboPckID.FormattingEnabled = true;
            this.comboPckID.Location = new System.Drawing.Point(242, 23);
            this.comboPckID.Name = "comboPckID";
            this.comboPckID.Size = new System.Drawing.Size(253, 28);
            this.comboPckID.TabIndex = 8;
            this.comboPckID.SelectedIndexChanged += new System.EventHandler(this.comboPckID_SelectedIndexChanged);
            // 
            // txtPckName
            // 
            this.txtPckName.Location = new System.Drawing.Point(242, 82);
            this.txtPckName.Name = "txtPckName";
            this.txtPckName.Size = new System.Drawing.Size(253, 27);
            this.txtPckName.TabIndex = 7;
            // 
            // lblAgencyCommision
            // 
            this.lblAgencyCommision.AutoSize = true;
            this.lblAgencyCommision.Location = new System.Drawing.Point(43, 313);
            this.lblAgencyCommision.Name = "lblAgencyCommision";
            this.lblAgencyCommision.Size = new System.Drawing.Size(179, 20);
            this.lblAgencyCommision.TabIndex = 6;
            this.lblAgencyCommision.Text = "Agency Commission";
            // 
            // lblPckBasePrice
            // 
            this.lblPckBasePrice.AutoSize = true;
            this.lblPckBasePrice.Location = new System.Drawing.Point(37, 256);
            this.lblPckBasePrice.Name = "lblPckBasePrice";
            this.lblPckBasePrice.Size = new System.Drawing.Size(185, 20);
            this.lblPckBasePrice.TabIndex = 5;
            this.lblPckBasePrice.Text = "Package Base Price:";
            // 
            // lblPckDesc
            // 
            this.lblPckDesc.AutoSize = true;
            this.lblPckDesc.Location = new System.Drawing.Point(39, 369);
            this.lblPckDesc.Name = "lblPckDesc";
            this.lblPckDesc.Size = new System.Drawing.Size(183, 20);
            this.lblPckDesc.TabIndex = 4;
            this.lblPckDesc.Text = "Package Description";
            // 
            // lblPckEnd
            // 
            this.lblPckEnd.AutoSize = true;
            this.lblPckEnd.Location = new System.Drawing.Point(37, 202);
            this.lblPckEnd.Name = "lblPckEnd";
            this.lblPckEnd.Size = new System.Drawing.Size(170, 20);
            this.lblPckEnd.TabIndex = 3;
            this.lblPckEnd.Text = "Package End Date:";
            // 
            // lblPckStart
            // 
            this.lblPckStart.AutoSize = true;
            this.lblPckStart.Location = new System.Drawing.Point(37, 145);
            this.lblPckStart.Name = "lblPckStart";
            this.lblPckStart.Size = new System.Drawing.Size(179, 20);
            this.lblPckStart.TabIndex = 2;
            this.lblPckStart.Text = "Package Start Date:";
            // 
            // lblPckName
            // 
            this.lblPckName.AutoSize = true;
            this.lblPckName.Location = new System.Drawing.Point(37, 89);
            this.lblPckName.Name = "lblPckName";
            this.lblPckName.Size = new System.Drawing.Size(140, 20);
            this.lblPckName.TabIndex = 1;
            this.lblPckName.Text = "Package Name:";
            // 
            // lblPckID
            // 
            this.lblPckID.AutoSize = true;
            this.lblPckID.Location = new System.Drawing.Point(37, 31);
            this.lblPckID.Name = "lblPckID";
            this.lblPckID.Size = new System.Drawing.Size(111, 20);
            this.lblPckID.TabIndex = 0;
            this.lblPckID.Text = "Package ID:";
            // 
            // tabPageProductSuppliers
            // 
            this.tabPageProductSuppliers.Controls.Add(this.dataGridView1);
            this.tabPageProductSuppliers.Controls.Add(this.txtSupplierID);
            this.tabPageProductSuppliers.Controls.Add(this.txtPrdID);
            this.tabPageProductSuppliers.Controls.Add(this.txtPrdSup);
            this.tabPageProductSuppliers.Controls.Add(this.lblSuppID);
            this.tabPageProductSuppliers.Controls.Add(this.lblPrdID);
            this.tabPageProductSuppliers.Controls.Add(this.lblPrdSup);
            this.tabPageProductSuppliers.Location = new System.Drawing.Point(4, 29);
            this.tabPageProductSuppliers.Name = "tabPageProductSuppliers";
            this.tabPageProductSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProductSuppliers.Size = new System.Drawing.Size(1207, 459);
            this.tabPageProductSuppliers.TabIndex = 1;
            this.tabPageProductSuppliers.Text = "Product/Suppliers";
            this.tabPageProductSuppliers.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(537, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(626, 322);
            this.dataGridView1.TabIndex = 6;
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(249, 193);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(160, 27);
            this.txtSupplierID.TabIndex = 5;
            // 
            // txtPrdID
            // 
            this.txtPrdID.Location = new System.Drawing.Point(249, 111);
            this.txtPrdID.Name = "txtPrdID";
            this.txtPrdID.Size = new System.Drawing.Size(160, 27);
            this.txtPrdID.TabIndex = 4;
            // 
            // txtPrdSup
            // 
            this.txtPrdSup.Location = new System.Drawing.Point(249, 42);
            this.txtPrdSup.Name = "txtPrdSup";
            this.txtPrdSup.Size = new System.Drawing.Size(160, 27);
            this.txtPrdSup.TabIndex = 3;
            // 
            // lblSuppID
            // 
            this.lblSuppID.AutoSize = true;
            this.lblSuppID.Location = new System.Drawing.Point(40, 200);
            this.lblSuppID.Name = "lblSuppID";
            this.lblSuppID.Size = new System.Drawing.Size(109, 20);
            this.lblSuppID.TabIndex = 2;
            this.lblSuppID.Text = "Supplier ID:";
            // 
            // lblPrdID
            // 
            this.lblPrdID.AutoSize = true;
            this.lblPrdID.Location = new System.Drawing.Point(40, 111);
            this.lblPrdID.Name = "lblPrdID";
            this.lblPrdID.Size = new System.Drawing.Size(105, 20);
            this.lblPrdID.TabIndex = 1;
            this.lblPrdID.Text = "Product ID:";
            // 
            // lblPrdSup
            // 
            this.lblPrdSup.AutoSize = true;
            this.lblPrdSup.Location = new System.Drawing.Point(40, 42);
            this.lblPrdSup.Name = "lblPrdSup";
            this.lblPrdSup.Size = new System.Drawing.Size(180, 20);
            this.lblPrdSup.TabIndex = 0;
            this.lblPrdSup.Text = "Product Supplier ID:";
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.products);
            this.tabPageProducts.Controls.Add(this.txtProductName);
            this.tabPageProducts.Controls.Add(this.txtProductID);
            this.tabPageProducts.Controls.Add(this.lblProductName);
            this.tabPageProducts.Controls.Add(this.lblProductID);
            this.tabPageProducts.Location = new System.Drawing.Point(4, 29);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(1207, 459);
            this.tabPageProducts.TabIndex = 2;
            this.tabPageProducts.Text = "Products";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // products
            // 
            this.products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products.Location = new System.Drawing.Point(500, 49);
            this.products.Name = "products";
            this.products.RowHeadersWidth = 51;
            this.products.RowTemplate.Height = 24;
            this.products.Size = new System.Drawing.Size(649, 289);
            this.products.TabIndex = 4;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(219, 129);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(181, 27);
            this.txtProductName.TabIndex = 3;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(219, 64);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(181, 27);
            this.txtProductID.TabIndex = 2;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(56, 136);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(134, 20);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name:";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(51, 67);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(105, 20);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "Product ID:";
            // 
            // tabPageSupplier
            // 
            this.tabPageSupplier.Controls.Add(this.Suppliers);
            this.tabPageSupplier.Controls.Add(this.txtSupplierName);
            this.tabPageSupplier.Controls.Add(this.supplierID);
            this.tabPageSupplier.Controls.Add(this.lblSupName);
            this.tabPageSupplier.Controls.Add(this.lblSupplierID);
            this.tabPageSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageSupplier.Location = new System.Drawing.Point(4, 29);
            this.tabPageSupplier.Name = "tabPageSupplier";
            this.tabPageSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSupplier.Size = new System.Drawing.Size(1207, 459);
            this.tabPageSupplier.TabIndex = 0;
            this.tabPageSupplier.Text = "Suppliers";
            this.tabPageSupplier.UseVisualStyleBackColor = true;
            // 
            // Suppliers
            // 
            this.Suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Suppliers.Location = new System.Drawing.Point(549, 40);
            this.Suppliers.Name = "Suppliers";
            this.Suppliers.RowHeadersWidth = 51;
            this.Suppliers.RowTemplate.Height = 24;
            this.Suppliers.Size = new System.Drawing.Size(599, 318);
            this.Suppliers.TabIndex = 4;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(228, 141);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(221, 27);
            this.txtSupplierName.TabIndex = 3;
            // 
            // supplierID
            // 
            this.supplierID.FormattingEnabled = true;
            this.supplierID.Location = new System.Drawing.Point(228, 68);
            this.supplierID.Name = "supplierID";
            this.supplierID.Size = new System.Drawing.Size(213, 28);
            this.supplierID.TabIndex = 2;
            // 
            // lblSupName
            // 
            this.lblSupName.AutoSize = true;
            this.lblSupName.Location = new System.Drawing.Point(56, 148);
            this.lblSupName.Name = "lblSupName";
            this.lblSupName.Size = new System.Drawing.Size(138, 20);
            this.lblSupName.TabIndex = 1;
            this.lblSupName.Text = "Supplier Name:";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Location = new System.Drawing.Point(56, 74);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(109, 20);
            this.lblSupplierID.TabIndex = 0;
            this.lblSupplierID.Text = "Supplier ID:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(314, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(565, 34);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "TRAVEL EXPERTS  PRODUCT MANAGEMENT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 587);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Packages);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Packages.ResumeLayout(false);
            this.tabPagePackageDetails.ResumeLayout(false);
            this.tabPagePackageDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pckProductSupplier)).EndInit();
            this.tabPageProductSuppliers.ResumeLayout(false);
            this.tabPageProductSuppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageProducts.ResumeLayout(false);
            this.tabPageProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.products)).EndInit();
            this.tabPageSupplier.ResumeLayout(false);
            this.tabPageSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Suppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Packages;
        private System.Windows.Forms.TabPage tabPagePackageDetails;
        private System.Windows.Forms.TextBox txtAgencyCommision;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtPckDesc;
        private System.Windows.Forms.TextBox txtPckEnd;
        private System.Windows.Forms.TextBox txtPckStart;
        private System.Windows.Forms.ComboBox comboPckID;
        private System.Windows.Forms.TextBox txtPckName;
        private System.Windows.Forms.Label lblAgencyCommision;
        private System.Windows.Forms.Label lblPckBasePrice;
        private System.Windows.Forms.Label lblPckDesc;
        private System.Windows.Forms.Label lblPckEnd;
        private System.Windows.Forms.Label lblPckStart;
        private System.Windows.Forms.Label lblPckName;
        private System.Windows.Forms.Label lblPckID;
        private System.Windows.Forms.TabPage tabPageProductSuppliers;
        private System.Windows.Forms.TabPage tabPageProducts;
        private System.Windows.Forms.TabPage tabPageSupplier;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView pckProductSupplier;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.TextBox txtPrdID;
        private System.Windows.Forms.TextBox txtPrdSup;
        private System.Windows.Forms.Label lblSuppID;
        private System.Windows.Forms.Label lblPrdID;
        private System.Windows.Forms.Label lblPrdSup;
        private System.Windows.Forms.DataGridView products;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.DataGridView Suppliers;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.ComboBox supplierID;
        private System.Windows.Forms.Label lblSupName;
        private System.Windows.Forms.Label lblSupplierID;
    }
}

