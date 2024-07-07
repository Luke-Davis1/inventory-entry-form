namespace InventoryEntryForm
{
    partial class frmInventoryItemAdd
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
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.lblItemType = new System.Windows.Forms.Label();
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpBoxFurniture = new System.Windows.Forms.GroupBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.grpBoxBook = new System.Windows.Forms.GroupBox();
            this.cmbBookType = new System.Windows.Forms.ComboBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblBookType = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.grpBoxGrocery = new System.Windows.Forms.GroupBox();
            this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPackDate = new System.Windows.Forms.DateTimePicker();
            this.cmbGroceryCategory = new System.Windows.Forms.ComboBox();
            this.lblGroceryCategory = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblPackageDate = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.cmbCompanies = new System.Windows.Forms.ComboBox();
            this.dgInventoryItems = new System.Windows.Forms.DataGridView();
            this.lblSearchAreaTitle = new System.Windows.Forms.Label();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSearchItemType = new System.Windows.Forms.ComboBox();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchReset = new System.Windows.Forms.Button();
            this.grpBoxFurniture.SuspendLayout();
            this.grpBoxBook.SuspendLayout();
            this.grpBoxGrocery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventoryItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(30, 30);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(41, 20);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(125, 24);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(283, 26);
            this.txtItemName.TabIndex = 1;
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Location = new System.Drawing.Point(492, 30);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(44, 20);
            this.lblItemPrice.TabIndex = 2;
            this.lblItemPrice.Text = "Price";
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Location = new System.Drawing.Point(572, 24);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(280, 26);
            this.txtItemPrice.TabIndex = 3;
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.AutoSize = true;
            this.lblItemDescription.Location = new System.Drawing.Point(30, 75);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(89, 20);
            this.lblItemDescription.TabIndex = 4;
            this.lblItemDescription.Text = "Description";
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = new System.Drawing.Point(125, 75);
            this.txtItemDescription.Multiline = true;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(727, 54);
            this.txtItemDescription.TabIndex = 28;
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.Location = new System.Drawing.Point(30, 158);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(79, 20);
            this.lblItemType.TabIndex = 29;
            this.lblItemType.Text = "Item Type";
            // 
            // cmbItemType
            // 
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.Location = new System.Drawing.Point(125, 158);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(268, 28);
            this.cmbItemType.TabIndex = 30;
            this.cmbItemType.Text = "--Select One--";
            this.cmbItemType.SelectedIndexChanged += new System.EventHandler(this.cmbItemType_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(496, 396);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(168, 39);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(199, 396);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(194, 39);
            this.btnSubmit.TabIndex = 33;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // grpBoxFurniture
            // 
            this.grpBoxFurniture.Controls.Add(this.txtWeight);
            this.grpBoxFurniture.Controls.Add(this.lblWeight);
            this.grpBoxFurniture.Controls.Add(this.txtHeight);
            this.grpBoxFurniture.Controls.Add(this.lblHeight);
            this.grpBoxFurniture.Controls.Add(this.txtWidth);
            this.grpBoxFurniture.Controls.Add(this.txtLength);
            this.grpBoxFurniture.Controls.Add(this.lblWidth);
            this.grpBoxFurniture.Controls.Add(this.lblLength);
            this.grpBoxFurniture.Location = new System.Drawing.Point(34, 209);
            this.grpBoxFurniture.Name = "grpBoxFurniture";
            this.grpBoxFurniture.Size = new System.Drawing.Size(615, 115);
            this.grpBoxFurniture.TabIndex = 35;
            this.grpBoxFurniture.TabStop = false;
            this.grpBoxFurniture.Text = "Dimensions";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(447, 71);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(140, 26);
            this.txtWeight.TabIndex = 7;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(368, 77);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(59, 20);
            this.lblWeight.TabIndex = 6;
            this.lblWeight.Text = "Weight";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(447, 25);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(140, 26);
            this.txtHeight.TabIndex = 5;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(368, 31);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(56, 20);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(143, 74);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(140, 26);
            this.txtWidth.TabIndex = 3;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(143, 31);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(140, 26);
            this.txtLength.TabIndex = 2;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(45, 74);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(50, 20);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(45, 31);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(59, 20);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length";
            // 
            // grpBoxBook
            // 
            this.grpBoxBook.Controls.Add(this.cmbBookType);
            this.grpBoxBook.Controls.Add(this.txtAuthor);
            this.grpBoxBook.Controls.Add(this.lblAuthor);
            this.grpBoxBook.Controls.Add(this.txtISBN);
            this.grpBoxBook.Controls.Add(this.lblBookType);
            this.grpBoxBook.Controls.Add(this.lblISBN);
            this.grpBoxBook.Location = new System.Drawing.Point(36, 212);
            this.grpBoxBook.Name = "grpBoxBook";
            this.grpBoxBook.Size = new System.Drawing.Size(612, 115);
            this.grpBoxBook.TabIndex = 36;
            this.grpBoxBook.TabStop = false;
            this.grpBoxBook.Text = "Book Details";
            // 
            // cmbBookType
            // 
            this.cmbBookType.FormattingEnabled = true;
            this.cmbBookType.Location = new System.Drawing.Point(143, 73);
            this.cmbBookType.Name = "cmbBookType";
            this.cmbBookType.Size = new System.Drawing.Size(140, 28);
            this.cmbBookType.TabIndex = 6;
            this.cmbBookType.SelectedIndexChanged += new System.EventHandler(this.cmbBookType_SelectedIndexChanged);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(447, 33);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(140, 26);
            this.txtAuthor.TabIndex = 5;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(368, 36);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(57, 20);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Author";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(143, 31);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(140, 26);
            this.txtISBN.TabIndex = 2;
            // 
            // lblBookType
            // 
            this.lblBookType.AutoSize = true;
            this.lblBookType.Location = new System.Drawing.Point(45, 74);
            this.lblBookType.Name = "lblBookType";
            this.lblBookType.Size = new System.Drawing.Size(84, 20);
            this.lblBookType.TabIndex = 1;
            this.lblBookType.Text = "Book Type";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(45, 31);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(47, 20);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "ISBN";
            // 
            // grpBoxGrocery
            // 
            this.grpBoxGrocery.Controls.Add(this.dtpExpirationDate);
            this.grpBoxGrocery.Controls.Add(this.dtpPackDate);
            this.grpBoxGrocery.Controls.Add(this.cmbGroceryCategory);
            this.grpBoxGrocery.Controls.Add(this.lblGroceryCategory);
            this.grpBoxGrocery.Controls.Add(this.lblExpirationDate);
            this.grpBoxGrocery.Controls.Add(this.lblPackageDate);
            this.grpBoxGrocery.Location = new System.Drawing.Point(33, 209);
            this.grpBoxGrocery.Name = "grpBoxGrocery";
            this.grpBoxGrocery.Size = new System.Drawing.Size(615, 119);
            this.grpBoxGrocery.TabIndex = 37;
            this.grpBoxGrocery.TabStop = false;
            this.grpBoxGrocery.Text = "Grocery Dates";
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.Location = new System.Drawing.Point(143, 66);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Size = new System.Drawing.Size(200, 26);
            this.dtpExpirationDate.TabIndex = 9;
            // 
            // dtpPackDate
            // 
            this.dtpPackDate.Location = new System.Drawing.Point(143, 26);
            this.dtpPackDate.Name = "dtpPackDate";
            this.dtpPackDate.Size = new System.Drawing.Size(200, 26);
            this.dtpPackDate.TabIndex = 8;
            // 
            // cmbGroceryCategory
            // 
            this.cmbGroceryCategory.FormattingEnabled = true;
            this.cmbGroceryCategory.Location = new System.Drawing.Point(449, 28);
            this.cmbGroceryCategory.Name = "cmbGroceryCategory";
            this.cmbGroceryCategory.Size = new System.Drawing.Size(140, 28);
            this.cmbGroceryCategory.TabIndex = 7;
            this.cmbGroceryCategory.SelectedIndexChanged += new System.EventHandler(this.cmbGroceryCategory_SelectedIndexChanged);
            // 
            // lblGroceryCategory
            // 
            this.lblGroceryCategory.AutoSize = true;
            this.lblGroceryCategory.Location = new System.Drawing.Point(370, 31);
            this.lblGroceryCategory.Name = "lblGroceryCategory";
            this.lblGroceryCategory.Size = new System.Drawing.Size(73, 20);
            this.lblGroceryCategory.TabIndex = 6;
            this.lblGroceryCategory.Text = "Category";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(17, 73);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(118, 20);
            this.lblExpirationDate.TabIndex = 4;
            this.lblExpirationDate.Text = "Expiration Date";
            // 
            // lblPackageDate
            // 
            this.lblPackageDate.AutoSize = true;
            this.lblPackageDate.Location = new System.Drawing.Point(25, 31);
            this.lblPackageDate.Name = "lblPackageDate";
            this.lblPackageDate.Size = new System.Drawing.Size(110, 20);
            this.lblPackageDate.TabIndex = 0;
            this.lblPackageDate.Text = "Package Date";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(32, 344);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 20);
            this.lblQuantity.TabIndex = 38;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(125, 341);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(147, 26);
            this.txtQuantity.TabIndex = 39;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(490, 161);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(76, 20);
            this.lblCompany.TabIndex = 40;
            this.lblCompany.Text = "Company";
            // 
            // cmbCompanies
            // 
            this.cmbCompanies.FormattingEnabled = true;
            this.cmbCompanies.Location = new System.Drawing.Point(572, 155);
            this.cmbCompanies.Name = "cmbCompanies";
            this.cmbCompanies.Size = new System.Drawing.Size(280, 28);
            this.cmbCompanies.TabIndex = 41;
            this.cmbCompanies.Text = "--Select One--";
            this.cmbCompanies.SelectedIndexChanged += new System.EventHandler(this.cmbCompanies_SelectedIndexChanged);
            // 
            // dgInventoryItems
            // 
            this.dgInventoryItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInventoryItems.Location = new System.Drawing.Point(34, 541);
            this.dgInventoryItems.Name = "dgInventoryItems";
            this.dgInventoryItems.RowHeadersWidth = 62;
            this.dgInventoryItems.RowTemplate.Height = 28;
            this.dgInventoryItems.Size = new System.Drawing.Size(1035, 240);
            this.dgInventoryItems.TabIndex = 42;
            // 
            // lblSearchAreaTitle
            // 
            this.lblSearchAreaTitle.AutoSize = true;
            this.lblSearchAreaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchAreaTitle.Location = new System.Drawing.Point(458, 452);
            this.lblSearchAreaTitle.Name = "lblSearchAreaTitle";
            this.lblSearchAreaTitle.Size = new System.Drawing.Size(145, 29);
            this.lblSearchAreaTitle.TabIndex = 43;
            this.lblSearchAreaTitle.Text = "Search Area";
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(165, 493);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(278, 26);
            this.txtSearchText.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Item Type";
            // 
            // cmbSearchItemType
            // 
            this.cmbSearchItemType.FormattingEnabled = true;
            this.cmbSearchItemType.Location = new System.Drawing.Point(551, 493);
            this.cmbSearchItemType.Name = "cmbSearchItemType";
            this.cmbSearchItemType.Size = new System.Drawing.Size(174, 28);
            this.cmbSearchItemType.TabIndex = 46;
            this.cmbSearchItemType.Text = "--Select One--";
            this.cmbSearchItemType.SelectedIndexChanged += new System.EventHandler(this.cmbSearchItemType_SelectedIndexChanged);
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.Location = new System.Drawing.Point(752, 489);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(152, 34);
            this.btnSearchItem.TabIndex = 47;
            this.btnSearchItem.Text = "Search";
            this.btnSearchItem.UseVisualStyleBackColor = true;
            this.btnSearchItem.Click += new System.EventHandler(this.btnSearchItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Search by Name:";
            // 
            // btnSearchReset
            // 
            this.btnSearchReset.Location = new System.Drawing.Point(917, 489);
            this.btnSearchReset.Name = "btnSearchReset";
            this.btnSearchReset.Size = new System.Drawing.Size(152, 34);
            this.btnSearchReset.TabIndex = 49;
            this.btnSearchReset.Text = "Reset";
            this.btnSearchReset.UseVisualStyleBackColor = true;
            this.btnSearchReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmInventoryItemAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 803);
            this.Controls.Add(this.btnSearchReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearchItem);
            this.Controls.Add(this.cmbSearchItemType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.lblSearchAreaTitle);
            this.Controls.Add(this.dgInventoryItems);
            this.Controls.Add(this.cmbCompanies);
            this.Controls.Add(this.grpBoxBook);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.grpBoxGrocery);
            this.Controls.Add(this.grpBoxFurniture);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbItemType);
            this.Controls.Add(this.lblItemType);
            this.Controls.Add(this.txtItemDescription);
            this.Controls.Add(this.lblItemDescription);
            this.Controls.Add(this.txtItemPrice);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblItemName);
            this.Name = "frmInventoryItemAdd";
            this.Text = "Inventory Item: Add";
            this.grpBoxFurniture.ResumeLayout(false);
            this.grpBoxFurniture.PerformLayout();
            this.grpBoxBook.ResumeLayout(false);
            this.grpBoxBook.PerformLayout();
            this.grpBoxGrocery.ResumeLayout(false);
            this.grpBoxGrocery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventoryItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.Label lblItemDescription;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.ComboBox cmbItemType;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox grpBoxFurniture;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.GroupBox grpBoxBook;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblBookType;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.GroupBox grpBoxGrocery;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblPackageDate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.ComboBox cmbCompanies;
        private System.Windows.Forms.Label lblGroceryCategory;
        private System.Windows.Forms.ComboBox cmbGroceryCategory;
        private System.Windows.Forms.DateTimePicker dtpExpirationDate;
        private System.Windows.Forms.DateTimePicker dtpPackDate;
        private System.Windows.Forms.ComboBox cmbBookType;
        private System.Windows.Forms.DataGridView dgInventoryItems;
        private System.Windows.Forms.Label lblSearchAreaTitle;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSearchItemType;
        private System.Windows.Forms.Button btnSearchItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchReset;
    }
}

