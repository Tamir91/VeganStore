namespace VeganStore
{
    partial class frmStore
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
            this.tabsStore = new System.Windows.Forms.TabControl();
            this.Store = new System.Windows.Forms.TabPage();
            this.Cart = new System.Windows.Forms.TabPage();
            this.User = new System.Windows.Forms.TabPage();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.radioButtonClient = new System.Windows.Forms.RadioButton();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.Product = new System.Windows.Forms.TabPage();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblProductSyplierID = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtProductSuplierID = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.Suplier = new System.Windows.Forms.TabPage();
            this.lblSuplierPhone = new System.Windows.Forms.Label();
            this.txtSuplierPhone = new System.Windows.Forms.TextBox();
            this.lblSuplierName = new System.Windows.Forms.Label();
            this.txtSuplierName = new System.Windows.Forms.TextBox();
            this.btnDeleteSuplier = new System.Windows.Forms.Button();
            this.btnUpdateSuplier = new System.Windows.Forms.Button();
            this.btnAddSuplier = new System.Windows.Forms.Button();
            this.lblSuplierID = new System.Windows.Forms.Label();
            this.txtSuplierID = new System.Windows.Forms.TextBox();
            this.tabsStore.SuspendLayout();
            this.User.SuspendLayout();
            this.Product.SuspendLayout();
            this.Suplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsStore
            // 
            this.tabsStore.Controls.Add(this.Store);
            this.tabsStore.Controls.Add(this.Cart);
            this.tabsStore.Controls.Add(this.User);
            this.tabsStore.Controls.Add(this.Product);
            this.tabsStore.Controls.Add(this.Suplier);
            this.tabsStore.Location = new System.Drawing.Point(12, 12);
            this.tabsStore.Name = "tabsStore";
            this.tabsStore.SelectedIndex = 0;
            this.tabsStore.Size = new System.Drawing.Size(663, 426);
            this.tabsStore.TabIndex = 0;
            // 
            // Store
            // 
            this.Store.Location = new System.Drawing.Point(4, 22);
            this.Store.Name = "Store";
            this.Store.Size = new System.Drawing.Size(655, 400);
            this.Store.TabIndex = 3;
            this.Store.Text = "Store";
            this.Store.UseVisualStyleBackColor = true;
            // 
            // Cart
            // 
            this.Cart.Location = new System.Drawing.Point(4, 22);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(655, 400);
            this.Cart.TabIndex = 4;
            this.Cart.Text = "Cart";
            this.Cart.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            this.User.Controls.Add(this.btnRemoveUser);
            this.User.Controls.Add(this.btnUpdateUser);
            this.User.Controls.Add(this.btnAddNewUser);
            this.User.Controls.Add(this.radioButtonAdmin);
            this.User.Controls.Add(this.radioButtonClient);
            this.User.Controls.Add(this.lblUserRole);
            this.User.Controls.Add(this.lblUserName);
            this.User.Controls.Add(this.lblUserId);
            this.User.Controls.Add(this.txtUserName);
            this.User.Controls.Add(this.txtUserId);
            this.User.Location = new System.Drawing.Point(4, 22);
            this.User.Name = "User";
            this.User.Padding = new System.Windows.Forms.Padding(3);
            this.User.Size = new System.Drawing.Size(655, 400);
            this.User.TabIndex = 0;
            this.User.Text = "User";
            this.User.UseVisualStyleBackColor = true;
            this.User.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(195, 101);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveUser.TabIndex = 12;
            this.btnRemoveUser.Text = "Delete User";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(103, 101);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateUser.TabIndex = 11;
            this.btnUpdateUser.Text = "Update user";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(13, 101);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewUser.TabIndex = 10;
            this.btnAddNewUser.Text = "Add User";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(146, 63);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(54, 17);
            this.radioButtonAdmin.TabIndex = 9;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // radioButtonClient
            // 
            this.radioButtonClient.AutoSize = true;
            this.radioButtonClient.Location = new System.Drawing.Point(78, 63);
            this.radioButtonClient.Name = "radioButtonClient";
            this.radioButtonClient.Size = new System.Drawing.Size(51, 17);
            this.radioButtonClient.TabIndex = 8;
            this.radioButtonClient.TabStop = true;
            this.radioButtonClient.Text = "Client";
            this.radioButtonClient.UseVisualStyleBackColor = true;
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Location = new System.Drawing.Point(10, 65);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(29, 13);
            this.lblUserRole.TabIndex = 5;
            this.lblUserRole.Text = "Role";
            this.lblUserRole.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(10, 36);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(35, 13);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Name";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(10, 10);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(18, 13);
            this.lblUserId.TabIndex = 3;
            this.lblUserId.Text = "ID";
            this.lblUserId.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtUserName.Location = new System.Drawing.Point(78, 33);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(78, 7);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(100, 20);
            this.txtUserId.TabIndex = 0;
            // 
            // Product
            // 
            this.Product.Controls.Add(this.lblProductPrice);
            this.Product.Controls.Add(this.txtProductPrice);
            this.Product.Controls.Add(this.lblProductQuantity);
            this.Product.Controls.Add(this.txtProductQuantity);
            this.Product.Controls.Add(this.lblProductName);
            this.Product.Controls.Add(this.txtProductName);
            this.Product.Controls.Add(this.btnDeleteProduct);
            this.Product.Controls.Add(this.btnUpdateProduct);
            this.Product.Controls.Add(this.btnAddProduct);
            this.Product.Controls.Add(this.lblProductSyplierID);
            this.Product.Controls.Add(this.lblProductID);
            this.Product.Controls.Add(this.txtProductSuplierID);
            this.Product.Controls.Add(this.txtProductID);
            this.Product.Location = new System.Drawing.Point(4, 22);
            this.Product.Name = "Product";
            this.Product.Padding = new System.Windows.Forms.Padding(3);
            this.Product.Size = new System.Drawing.Size(655, 400);
            this.Product.TabIndex = 1;
            this.Product.Text = "Product";
            this.Product.UseVisualStyleBackColor = true;
            this.Product.Click += new System.EventHandler(this.Product_Click);
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(9, 88);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(31, 13);
            this.lblProductPrice.TabIndex = 28;
            this.lblProductPrice.Text = "Price";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(77, 85);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(100, 20);
            this.txtProductPrice.TabIndex = 27;
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Location = new System.Drawing.Point(9, 62);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblProductQuantity.TabIndex = 26;
            this.lblProductQuantity.Text = "Quantity";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(77, 59);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtProductQuantity.TabIndex = 25;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(9, 36);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(35, 13);
            this.lblProductName.TabIndex = 24;
            this.lblProductName.Text = "Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(77, 33);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 23;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(214, 137);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(115, 23);
            this.btnDeleteProduct.TabIndex = 22;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(93, 137);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(115, 23);
            this.btnUpdateProduct.TabIndex = 21;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(12, 137);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 20;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // lblProductSyplierID
            // 
            this.lblProductSyplierID.AutoSize = true;
            this.lblProductSyplierID.Location = new System.Drawing.Point(9, 114);
            this.lblProductSyplierID.Name = "lblProductSyplierID";
            this.lblProductSyplierID.Size = new System.Drawing.Size(53, 13);
            this.lblProductSyplierID.TabIndex = 16;
            this.lblProductSyplierID.Text = "Suplier ID";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(9, 10);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(18, 13);
            this.lblProductID.TabIndex = 15;
            this.lblProductID.Text = "ID";
            // 
            // txtProductSuplierID
            // 
            this.txtProductSuplierID.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtProductSuplierID.Location = new System.Drawing.Point(77, 111);
            this.txtProductSuplierID.Name = "txtProductSuplierID";
            this.txtProductSuplierID.Size = new System.Drawing.Size(100, 20);
            this.txtProductSuplierID.TabIndex = 14;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(77, 7);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 20);
            this.txtProductID.TabIndex = 13;
            // 
            // Suplier
            // 
            this.Suplier.Controls.Add(this.lblSuplierPhone);
            this.Suplier.Controls.Add(this.txtSuplierPhone);
            this.Suplier.Controls.Add(this.lblSuplierName);
            this.Suplier.Controls.Add(this.txtSuplierName);
            this.Suplier.Controls.Add(this.btnDeleteSuplier);
            this.Suplier.Controls.Add(this.btnUpdateSuplier);
            this.Suplier.Controls.Add(this.btnAddSuplier);
            this.Suplier.Controls.Add(this.lblSuplierID);
            this.Suplier.Controls.Add(this.txtSuplierID);
            this.Suplier.Location = new System.Drawing.Point(4, 22);
            this.Suplier.Name = "Suplier";
            this.Suplier.Size = new System.Drawing.Size(655, 400);
            this.Suplier.TabIndex = 2;
            this.Suplier.Text = "Suplier";
            this.Suplier.UseVisualStyleBackColor = true;
            // 
            // lblSuplierPhone
            // 
            this.lblSuplierPhone.AutoSize = true;
            this.lblSuplierPhone.Location = new System.Drawing.Point(9, 60);
            this.lblSuplierPhone.Name = "lblSuplierPhone";
            this.lblSuplierPhone.Size = new System.Drawing.Size(38, 13);
            this.lblSuplierPhone.TabIndex = 39;
            this.lblSuplierPhone.Text = "Phone";
            // 
            // txtSuplierPhone
            // 
            this.txtSuplierPhone.Location = new System.Drawing.Point(77, 57);
            this.txtSuplierPhone.Name = "txtSuplierPhone";
            this.txtSuplierPhone.Size = new System.Drawing.Size(100, 20);
            this.txtSuplierPhone.TabIndex = 38;
            this.txtSuplierPhone.TextChanged += new System.EventHandler(this.txtSuplierPhone_TextChanged);
            // 
            // lblSuplierName
            // 
            this.lblSuplierName.AutoSize = true;
            this.lblSuplierName.Location = new System.Drawing.Point(9, 34);
            this.lblSuplierName.Name = "lblSuplierName";
            this.lblSuplierName.Size = new System.Drawing.Size(35, 13);
            this.lblSuplierName.TabIndex = 37;
            this.lblSuplierName.Text = "Name";
            // 
            // txtSuplierName
            // 
            this.txtSuplierName.Location = new System.Drawing.Point(77, 31);
            this.txtSuplierName.Name = "txtSuplierName";
            this.txtSuplierName.Size = new System.Drawing.Size(100, 20);
            this.txtSuplierName.TabIndex = 36;
            this.txtSuplierName.TextChanged += new System.EventHandler(this.txtSuplierName_TextChanged);
            // 
            // btnDeleteSuplier
            // 
            this.btnDeleteSuplier.Location = new System.Drawing.Point(214, 135);
            this.btnDeleteSuplier.Name = "btnDeleteSuplier";
            this.btnDeleteSuplier.Size = new System.Drawing.Size(115, 23);
            this.btnDeleteSuplier.TabIndex = 35;
            this.btnDeleteSuplier.Text = "Delete Suplier";
            this.btnDeleteSuplier.UseVisualStyleBackColor = true;
            this.btnDeleteSuplier.Click += new System.EventHandler(this.btnDeleteSuplier_Click);
            // 
            // btnUpdateSuplier
            // 
            this.btnUpdateSuplier.Location = new System.Drawing.Point(93, 135);
            this.btnUpdateSuplier.Name = "btnUpdateSuplier";
            this.btnUpdateSuplier.Size = new System.Drawing.Size(115, 23);
            this.btnUpdateSuplier.TabIndex = 34;
            this.btnUpdateSuplier.Text = "Update Suplier";
            this.btnUpdateSuplier.UseVisualStyleBackColor = true;
            this.btnUpdateSuplier.Click += new System.EventHandler(this.btnUpdateSuplier_Click);
            // 
            // btnAddSuplier
            // 
            this.btnAddSuplier.Location = new System.Drawing.Point(12, 135);
            this.btnAddSuplier.Name = "btnAddSuplier";
            this.btnAddSuplier.Size = new System.Drawing.Size(75, 23);
            this.btnAddSuplier.TabIndex = 33;
            this.btnAddSuplier.Text = "Add Suplier";
            this.btnAddSuplier.UseVisualStyleBackColor = true;
            this.btnAddSuplier.Click += new System.EventHandler(this.btnAddSuplier_Click);
            // 
            // lblSuplierID
            // 
            this.lblSuplierID.AutoSize = true;
            this.lblSuplierID.Location = new System.Drawing.Point(9, 8);
            this.lblSuplierID.Name = "lblSuplierID";
            this.lblSuplierID.Size = new System.Drawing.Size(18, 13);
            this.lblSuplierID.TabIndex = 31;
            this.lblSuplierID.Text = "ID";
            // 
            // txtSuplierID
            // 
            this.txtSuplierID.Location = new System.Drawing.Point(77, 5);
            this.txtSuplierID.Name = "txtSuplierID";
            this.txtSuplierID.Size = new System.Drawing.Size(100, 20);
            this.txtSuplierID.TabIndex = 29;
            this.txtSuplierID.TextChanged += new System.EventHandler(this.txtSuplierID_TextChanged);
            // 
            // frmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabsStore);
            this.Name = "frmStore";
            this.Text = "Store";
            this.Load += new System.EventHandler(this.frmStore_Load);
            this.tabsStore.ResumeLayout(false);
            this.User.ResumeLayout(false);
            this.User.PerformLayout();
            this.Product.ResumeLayout(false);
            this.Product.PerformLayout();
            this.Suplier.ResumeLayout(false);
            this.Suplier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsStore;
        private System.Windows.Forms.TabPage User;
        private System.Windows.Forms.TabPage Product;
        private System.Windows.Forms.TabPage Store;
        private System.Windows.Forms.TabPage Cart;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TabPage Suplier;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.RadioButton radioButtonClient;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblProductSyplierID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtProductSuplierID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblSuplierPhone;
        private System.Windows.Forms.TextBox txtSuplierPhone;
        private System.Windows.Forms.Label lblSuplierName;
        private System.Windows.Forms.TextBox txtSuplierName;
        private System.Windows.Forms.Button btnDeleteSuplier;
        private System.Windows.Forms.Button btnUpdateSuplier;
        private System.Windows.Forms.Button btnAddSuplier;
        private System.Windows.Forms.Label lblSuplierID;
        private System.Windows.Forms.TextBox txtSuplierID;
    }
}

