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
            this.btnBuy = new System.Windows.Forms.Button();
            this.cmbUsersInStore = new System.Windows.Forms.ComboBox();
            this.lsvCart = new System.Windows.Forms.ListView();
            this.CartProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CartProdactName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CartProductQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvStore = new System.Windows.Forms.ListView();
            this.StoreProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StoreProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StoreProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StoreProductQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbSuplierInStore = new System.Windows.Forms.ComboBox();
            this.Orders = new System.Windows.Forms.TabPage();
            this.lsvOrder = new System.Windows.Forms.ListView();
            this.OrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderCreatedAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbUsersInOrders = new System.Windows.Forms.ComboBox();
            this.lsvOrderProducts = new System.Windows.Forms.ListView();
            this.OrdersProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrdersProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderProductQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderProductTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.User = new System.Windows.Forms.TabPage();
            this.btnCreateExcel = new System.Windows.Forms.Button();
            this.lsvUser = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.radioButtonStaff = new System.Windows.Forms.RadioButton();
            this.radioButtonClient = new System.Windows.Forms.RadioButton();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.Product = new System.Windows.Forms.TabPage();
            this.btnCreateProductExel = new System.Windows.Forms.Button();
            this.cmbSuplier = new System.Windows.Forms.ComboBox();
            this.lsvProducts = new System.Windows.Forms.ListView();
            this.productID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productSuplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblProductSyplier = new System.Windows.Forms.Label();
            this.Suplier = new System.Windows.Forms.TabPage();
            this.lsvSuplier = new System.Windows.Forms.ListView();
            this.SuplierID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuplierName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuplierPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSuplierPhone = new System.Windows.Forms.Label();
            this.txtSuplierPhone = new System.Windows.Forms.TextBox();
            this.lblSuplierName = new System.Windows.Forms.Label();
            this.txtSuplierName = new System.Windows.Forms.TextBox();
            this.btnDeleteSuplier = new System.Windows.Forms.Button();
            this.btnUpdateSuplier = new System.Windows.Forms.Button();
            this.btnAddSuplier = new System.Windows.Forms.Button();
            this.tabsStore.SuspendLayout();
            this.Store.SuspendLayout();
            this.Orders.SuspendLayout();
            this.User.SuspendLayout();
            this.Product.SuspendLayout();
            this.Suplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsStore
            // 
            this.tabsStore.Controls.Add(this.Store);
            this.tabsStore.Controls.Add(this.Orders);
            this.tabsStore.Controls.Add(this.User);
            this.tabsStore.Controls.Add(this.Product);
            this.tabsStore.Controls.Add(this.Suplier);
            this.tabsStore.Location = new System.Drawing.Point(12, 12);
            this.tabsStore.Name = "tabsStore";
            this.tabsStore.SelectedIndex = 0;
            this.tabsStore.Size = new System.Drawing.Size(776, 426);
            this.tabsStore.TabIndex = 0;
            this.tabsStore.Click += new System.EventHandler(this.TabsStrore_Click);
            // 
            // Store
            // 
            this.Store.Controls.Add(this.btnBuy);
            this.Store.Controls.Add(this.cmbUsersInStore);
            this.Store.Controls.Add(this.lsvCart);
            this.Store.Controls.Add(this.lsvStore);
            this.Store.Controls.Add(this.cmbSuplierInStore);
            this.Store.Location = new System.Drawing.Point(4, 22);
            this.Store.Name = "Store";
            this.Store.Size = new System.Drawing.Size(768, 400);
            this.Store.TabIndex = 3;
            this.Store.Text = "Store";
            this.Store.UseVisualStyleBackColor = true;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(343, 28);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 4;
            this.btnBuy.Text = "BUY";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // cmbUsersInStore
            // 
            this.cmbUsersInStore.FormattingEnabled = true;
            this.cmbUsersInStore.Location = new System.Drawing.Point(23, 28);
            this.cmbUsersInStore.Name = "cmbUsersInStore";
            this.cmbUsersInStore.Size = new System.Drawing.Size(121, 21);
            this.cmbUsersInStore.TabIndex = 3;
            // 
            // lsvCart
            // 
            this.lsvCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CartProductID,
            this.CartProdactName,
            this.CartProductQuantity});
            this.lsvCart.HideSelection = false;
            this.lsvCart.Location = new System.Drawing.Point(343, 55);
            this.lsvCart.Name = "lsvCart";
            this.lsvCart.Size = new System.Drawing.Size(309, 342);
            this.lsvCart.TabIndex = 2;
            this.lsvCart.UseCompatibleStateImageBehavior = false;
            this.lsvCart.View = System.Windows.Forms.View.Details;
            // 
            // CartProductID
            // 
            this.CartProductID.Text = "id";
            this.CartProductID.Width = 30;
            // 
            // CartProdactName
            // 
            this.CartProdactName.Text = "Name";
            this.CartProdactName.Width = 200;
            // 
            // CartProductQuantity
            // 
            this.CartProductQuantity.Text = "Quantity";
            // 
            // lsvStore
            // 
            this.lsvStore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StoreProductID,
            this.StoreProductName,
            this.StoreProductPrice,
            this.StoreProductQuantity});
            this.lsvStore.HideSelection = false;
            this.lsvStore.Location = new System.Drawing.Point(3, 55);
            this.lsvStore.Name = "lsvStore";
            this.lsvStore.Size = new System.Drawing.Size(334, 342);
            this.lsvStore.TabIndex = 1;
            this.lsvStore.UseCompatibleStateImageBehavior = false;
            this.lsvStore.View = System.Windows.Forms.View.Details;
            this.lsvStore.Click += new System.EventHandler(this.SelectedRowInProductStoreChanged);
            // 
            // StoreProductID
            // 
            this.StoreProductID.Text = "id";
            this.StoreProductID.Width = 30;
            // 
            // StoreProductName
            // 
            this.StoreProductName.Text = "Name";
            this.StoreProductName.Width = 150;
            // 
            // StoreProductPrice
            // 
            this.StoreProductPrice.Text = "Price";
            this.StoreProductPrice.Width = 50;
            // 
            // StoreProductQuantity
            // 
            this.StoreProductQuantity.Text = "Quantity";
            // 
            // cmbSuplierInStore
            // 
            this.cmbSuplierInStore.FormattingEnabled = true;
            this.cmbSuplierInStore.Location = new System.Drawing.Point(181, 28);
            this.cmbSuplierInStore.Name = "cmbSuplierInStore";
            this.cmbSuplierInStore.Size = new System.Drawing.Size(121, 21);
            this.cmbSuplierInStore.TabIndex = 0;
            this.cmbSuplierInStore.SelectedIndexChanged += new System.EventHandler(this.CmbSuplierIndexChanged);
            // 
            // Orders
            // 
            this.Orders.Controls.Add(this.lsvOrder);
            this.Orders.Controls.Add(this.cmbUsersInOrders);
            this.Orders.Controls.Add(this.lsvOrderProducts);
            this.Orders.Location = new System.Drawing.Point(4, 22);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(768, 400);
            this.Orders.TabIndex = 4;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = true;
            // 
            // lsvOrder
            // 
            this.lsvOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderID,
            this.OrderUserName,
            this.OrderTotal,
            this.OrderCreatedAt});
            this.lsvOrder.HideSelection = false;
            this.lsvOrder.Location = new System.Drawing.Point(3, 76);
            this.lsvOrder.Name = "lsvOrder";
            this.lsvOrder.Size = new System.Drawing.Size(306, 321);
            this.lsvOrder.TabIndex = 2;
            this.lsvOrder.UseCompatibleStateImageBehavior = false;
            this.lsvOrder.View = System.Windows.Forms.View.Details;
            this.lsvOrder.SelectedIndexChanged += new System.EventHandler(this.SelectedRowInOrdersChanged);
            // 
            // OrderID
            // 
            this.OrderID.Text = "id";
            this.OrderID.Width = 30;
            // 
            // OrderUserName
            // 
            this.OrderUserName.Text = "User";
            this.OrderUserName.Width = 100;
            // 
            // OrderTotal
            // 
            this.OrderTotal.Text = "Total";
            this.OrderTotal.Width = 70;
            // 
            // OrderCreatedAt
            // 
            this.OrderCreatedAt.Text = "date";
            this.OrderCreatedAt.Width = 70;
            // 
            // cmbUsersInOrders
            // 
            this.cmbUsersInOrders.FormattingEnabled = true;
            this.cmbUsersInOrders.Location = new System.Drawing.Point(17, 13);
            this.cmbUsersInOrders.Name = "cmbUsersInOrders";
            this.cmbUsersInOrders.Size = new System.Drawing.Size(121, 21);
            this.cmbUsersInOrders.TabIndex = 1;
            this.cmbUsersInOrders.SelectedIndexChanged += new System.EventHandler(this.CmbUserIndexInOrdersChanged);
            // 
            // lsvOrderProducts
            // 
            this.lsvOrderProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrdersProductID,
            this.OrdersProductName,
            this.OrderProductQuantity,
            this.OrderProductPrice,
            this.OrderProductTotal});
            this.lsvOrderProducts.HideSelection = false;
            this.lsvOrderProducts.Location = new System.Drawing.Point(315, 76);
            this.lsvOrderProducts.Name = "lsvOrderProducts";
            this.lsvOrderProducts.Size = new System.Drawing.Size(450, 321);
            this.lsvOrderProducts.TabIndex = 0;
            this.lsvOrderProducts.UseCompatibleStateImageBehavior = false;
            this.lsvOrderProducts.View = System.Windows.Forms.View.Details;
            // 
            // OrdersProductID
            // 
            this.OrdersProductID.Text = "id";
            this.OrdersProductID.Width = 30;
            // 
            // OrdersProductName
            // 
            this.OrdersProductName.Text = "Product Name";
            this.OrdersProductName.Width = 200;
            // 
            // OrderProductQuantity
            // 
            this.OrderProductQuantity.Text = "Quantity";
            this.OrderProductQuantity.Width = 70;
            // 
            // OrderProductPrice
            // 
            this.OrderProductPrice.Text = "Price";
            this.OrderProductPrice.Width = 70;
            // 
            // OrderProductTotal
            // 
            this.OrderProductTotal.Text = "Total";
            this.OrderProductTotal.Width = 70;
            // 
            // User
            // 
            this.User.Controls.Add(this.btnCreateExcel);
            this.User.Controls.Add(this.lsvUser);
            this.User.Controls.Add(this.btnRemoveUser);
            this.User.Controls.Add(this.btnUpdateUser);
            this.User.Controls.Add(this.btnAddNewUser);
            this.User.Controls.Add(this.radioButtonStaff);
            this.User.Controls.Add(this.radioButtonClient);
            this.User.Controls.Add(this.lblUserRole);
            this.User.Controls.Add(this.lblUserName);
            this.User.Controls.Add(this.txtUserName);
            this.User.Location = new System.Drawing.Point(4, 22);
            this.User.Name = "User";
            this.User.Padding = new System.Windows.Forms.Padding(3);
            this.User.Size = new System.Drawing.Size(768, 400);
            this.User.TabIndex = 0;
            this.User.Text = "User";
            this.User.UseVisualStyleBackColor = true;
            // 
            // btnCreateExcel
            // 
            this.btnCreateExcel.Location = new System.Drawing.Point(288, 101);
            this.btnCreateExcel.Name = "btnCreateExcel";
            this.btnCreateExcel.Size = new System.Drawing.Size(75, 23);
            this.btnCreateExcel.TabIndex = 16;
            this.btnCreateExcel.Text = "Excel";
            this.btnCreateExcel.UseVisualStyleBackColor = true;
            this.btnCreateExcel.Click += new System.EventHandler(this.BtnCreateUserExcel_Click);
            // 
            // lsvUser
            // 
            this.lsvUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.role});
            this.lsvUser.HideSelection = false;
            this.lsvUser.Location = new System.Drawing.Point(6, 130);
            this.lsvUser.Name = "lsvUser";
            this.lsvUser.Size = new System.Drawing.Size(643, 264);
            this.lsvUser.TabIndex = 15;
            this.lsvUser.UseCompatibleStateImageBehavior = false;
            this.lsvUser.View = System.Windows.Forms.View.Details;
            this.lsvUser.SelectedIndexChanged += new System.EventHandler(this.SelectedRowInUserChanged);
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 30;
            // 
            // name
            // 
            this.name.Text = "name";
            this.name.Width = 300;
            // 
            // role
            // 
            this.role.Text = "role";
            this.role.Width = 100;
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(195, 101);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveUser.TabIndex = 12;
            this.btnRemoveUser.Text = "Delete User";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(103, 101);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateUser.TabIndex = 11;
            this.btnUpdateUser.Text = "Update user";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.BtnUpdateUser_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(13, 101);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewUser.TabIndex = 10;
            this.btnAddNewUser.Text = "Add User";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.BtnAddNewUser_Click);
            // 
            // radioButtonStaff
            // 
            this.radioButtonStaff.AutoSize = true;
            this.radioButtonStaff.Location = new System.Drawing.Point(146, 63);
            this.radioButtonStaff.Name = "radioButtonStaff";
            this.radioButtonStaff.Size = new System.Drawing.Size(47, 17);
            this.radioButtonStaff.TabIndex = 9;
            this.radioButtonStaff.TabStop = true;
            this.radioButtonStaff.Text = "Staff";
            this.radioButtonStaff.UseVisualStyleBackColor = true;
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
            // txtUserName
            // 
            this.txtUserName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtUserName.Location = new System.Drawing.Point(78, 33);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(121, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // Product
            // 
            this.Product.Controls.Add(this.btnCreateProductExel);
            this.Product.Controls.Add(this.cmbSuplier);
            this.Product.Controls.Add(this.lsvProducts);
            this.Product.Controls.Add(this.lblProductPrice);
            this.Product.Controls.Add(this.txtProductPrice);
            this.Product.Controls.Add(this.lblProductQuantity);
            this.Product.Controls.Add(this.txtProductQuantity);
            this.Product.Controls.Add(this.lblProductName);
            this.Product.Controls.Add(this.txtProductName);
            this.Product.Controls.Add(this.btnDeleteProduct);
            this.Product.Controls.Add(this.btnUpdateProduct);
            this.Product.Controls.Add(this.btnAddProduct);
            this.Product.Controls.Add(this.lblProductSyplier);
            this.Product.Location = new System.Drawing.Point(4, 22);
            this.Product.Name = "Product";
            this.Product.Padding = new System.Windows.Forms.Padding(3);
            this.Product.Size = new System.Drawing.Size(768, 400);
            this.Product.TabIndex = 1;
            this.Product.Text = "Product";
            this.Product.UseVisualStyleBackColor = true;
            // 
            // btnCreateProductExel
            // 
            this.btnCreateProductExel.Location = new System.Drawing.Point(335, 137);
            this.btnCreateProductExel.Name = "btnCreateProductExel";
            this.btnCreateProductExel.Size = new System.Drawing.Size(75, 23);
            this.btnCreateProductExel.TabIndex = 32;
            this.btnCreateProductExel.Text = "Excel";
            this.btnCreateProductExel.UseVisualStyleBackColor = true;
            this.btnCreateProductExel.Click += new System.EventHandler(this.BtnCreateProductExel_Click);
            // 
            // cmbSuplier
            // 
            this.cmbSuplier.FormattingEnabled = true;
            this.cmbSuplier.Location = new System.Drawing.Point(77, 111);
            this.cmbSuplier.Name = "cmbSuplier";
            this.cmbSuplier.Size = new System.Drawing.Size(100, 21);
            this.cmbSuplier.TabIndex = 30;
            // 
            // lsvProducts
            // 
            this.lsvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productID,
            this.productName,
            this.productPrice,
            this.productQuantity,
            this.productSuplier});
            this.lsvProducts.HideSelection = false;
            this.lsvProducts.Location = new System.Drawing.Point(6, 166);
            this.lsvProducts.Name = "lsvProducts";
            this.lsvProducts.Size = new System.Drawing.Size(643, 228);
            this.lsvProducts.TabIndex = 29;
            this.lsvProducts.UseCompatibleStateImageBehavior = false;
            this.lsvProducts.View = System.Windows.Forms.View.Details;
            this.lsvProducts.SelectedIndexChanged += new System.EventHandler(this.SelectedRowInProductChanged);
            // 
            // productID
            // 
            this.productID.Text = "id";
            this.productID.Width = 30;
            // 
            // productName
            // 
            this.productName.Text = "name";
            this.productName.Width = 200;
            // 
            // productPrice
            // 
            this.productPrice.Text = "price";
            // 
            // productQuantity
            // 
            this.productQuantity.Text = "Quantity";
            // 
            // productSuplier
            // 
            this.productSuplier.Text = "Suplier";
            this.productSuplier.Width = 200;
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
            this.btnDeleteProduct.Click += new System.EventHandler(this.BtnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(93, 137);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(115, 23);
            this.btnUpdateProduct.TabIndex = 21;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.BtnUpdateProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(12, 137);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 20;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddNewProduct_Click);
            // 
            // lblProductSyplier
            // 
            this.lblProductSyplier.AutoSize = true;
            this.lblProductSyplier.Location = new System.Drawing.Point(9, 114);
            this.lblProductSyplier.Name = "lblProductSyplier";
            this.lblProductSyplier.Size = new System.Drawing.Size(39, 13);
            this.lblProductSyplier.TabIndex = 16;
            this.lblProductSyplier.Text = "Suplier";
            // 
            // Suplier
            // 
            this.Suplier.Controls.Add(this.lsvSuplier);
            this.Suplier.Controls.Add(this.lblSuplierPhone);
            this.Suplier.Controls.Add(this.txtSuplierPhone);
            this.Suplier.Controls.Add(this.lblSuplierName);
            this.Suplier.Controls.Add(this.txtSuplierName);
            this.Suplier.Controls.Add(this.btnDeleteSuplier);
            this.Suplier.Controls.Add(this.btnUpdateSuplier);
            this.Suplier.Controls.Add(this.btnAddSuplier);
            this.Suplier.Location = new System.Drawing.Point(4, 22);
            this.Suplier.Name = "Suplier";
            this.Suplier.Size = new System.Drawing.Size(768, 400);
            this.Suplier.TabIndex = 2;
            this.Suplier.Text = "Suplier";
            this.Suplier.UseVisualStyleBackColor = true;
            // 
            // lsvSuplier
            // 
            this.lsvSuplier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SuplierID,
            this.SuplierName,
            this.SuplierPhone});
            this.lsvSuplier.HideSelection = false;
            this.lsvSuplier.Location = new System.Drawing.Point(12, 164);
            this.lsvSuplier.Name = "lsvSuplier";
            this.lsvSuplier.Size = new System.Drawing.Size(633, 222);
            this.lsvSuplier.TabIndex = 40;
            this.lsvSuplier.UseCompatibleStateImageBehavior = false;
            this.lsvSuplier.View = System.Windows.Forms.View.Details;
            this.lsvSuplier.SelectedIndexChanged += new System.EventHandler(this.SelectedRowInSuplierChanged);
            // 
            // SuplierID
            // 
            this.SuplierID.Text = "id";
            this.SuplierID.Width = 30;
            // 
            // SuplierName
            // 
            this.SuplierName.Text = "Name";
            this.SuplierName.Width = 300;
            // 
            // SuplierPhone
            // 
            this.SuplierPhone.Text = "Phone";
            this.SuplierPhone.Width = 200;
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
            this.txtSuplierPhone.Size = new System.Drawing.Size(252, 20);
            this.txtSuplierPhone.TabIndex = 38;
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
            this.txtSuplierName.Size = new System.Drawing.Size(252, 20);
            this.txtSuplierName.TabIndex = 36;
            // 
            // btnDeleteSuplier
            // 
            this.btnDeleteSuplier.Location = new System.Drawing.Point(214, 135);
            this.btnDeleteSuplier.Name = "btnDeleteSuplier";
            this.btnDeleteSuplier.Size = new System.Drawing.Size(115, 23);
            this.btnDeleteSuplier.TabIndex = 35;
            this.btnDeleteSuplier.Text = "Delete Suplier";
            this.btnDeleteSuplier.UseVisualStyleBackColor = true;
            this.btnDeleteSuplier.Click += new System.EventHandler(this.BtnDeleteSuplier_Click);
            // 
            // btnUpdateSuplier
            // 
            this.btnUpdateSuplier.Location = new System.Drawing.Point(93, 135);
            this.btnUpdateSuplier.Name = "btnUpdateSuplier";
            this.btnUpdateSuplier.Size = new System.Drawing.Size(115, 23);
            this.btnUpdateSuplier.TabIndex = 34;
            this.btnUpdateSuplier.Text = "Update Suplier";
            this.btnUpdateSuplier.UseVisualStyleBackColor = true;
            this.btnUpdateSuplier.Click += new System.EventHandler(this.BtnUpdateSuplier_Click);
            // 
            // btnAddSuplier
            // 
            this.btnAddSuplier.Location = new System.Drawing.Point(12, 135);
            this.btnAddSuplier.Name = "btnAddSuplier";
            this.btnAddSuplier.Size = new System.Drawing.Size(75, 23);
            this.btnAddSuplier.TabIndex = 33;
            this.btnAddSuplier.Text = "Add Suplier";
            this.btnAddSuplier.UseVisualStyleBackColor = true;
            this.btnAddSuplier.Click += new System.EventHandler(this.BtnAddNewSuplier_Click);
            // 
            // frmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabsStore);
            this.Name = "frmStore";
            this.Text = "Store";
            this.tabsStore.ResumeLayout(false);
            this.Store.ResumeLayout(false);
            this.Orders.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage Orders;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TabPage Suplier;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.RadioButton radioButtonStaff;
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
        private System.Windows.Forms.Label lblProductSyplier;
        private System.Windows.Forms.Label lblSuplierPhone;
        private System.Windows.Forms.TextBox txtSuplierPhone;
        private System.Windows.Forms.Label lblSuplierName;
        private System.Windows.Forms.TextBox txtSuplierName;
        private System.Windows.Forms.Button btnDeleteSuplier;
        private System.Windows.Forms.Button btnUpdateSuplier;
        private System.Windows.Forms.Button btnAddSuplier;
        private System.Windows.Forms.ListView lsvUser;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader role;
        private System.Windows.Forms.ListView lsvProducts;
        private System.Windows.Forms.ColumnHeader productID;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader productPrice;
        private System.Windows.Forms.ColumnHeader productQuantity;
        private System.Windows.Forms.ColumnHeader productSuplier;
        private System.Windows.Forms.ComboBox cmbSuplier;
        private System.Windows.Forms.ListView lsvSuplier;
        private System.Windows.Forms.ColumnHeader SuplierID;
        private System.Windows.Forms.ColumnHeader SuplierName;
        private System.Windows.Forms.ColumnHeader SuplierPhone;
        private System.Windows.Forms.ListView lsvStore;
        private System.Windows.Forms.ComboBox cmbSuplierInStore;
        private System.Windows.Forms.ListView lsvCart;
        private System.Windows.Forms.ColumnHeader CartProdactName;
        private System.Windows.Forms.ColumnHeader CartProductQuantity;
        private System.Windows.Forms.ColumnHeader StoreProductID;
        private System.Windows.Forms.ColumnHeader StoreProductName;
        private System.Windows.Forms.ColumnHeader StoreProductPrice;
        private System.Windows.Forms.ColumnHeader StoreProductQuantity;
        private System.Windows.Forms.ComboBox cmbUsersInStore;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.ColumnHeader CartProductID;
        private System.Windows.Forms.ListView lsvOrder;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader OrderUserName;
        private System.Windows.Forms.ColumnHeader OrderTotal;
        private System.Windows.Forms.ColumnHeader OrderCreatedAt;
        private System.Windows.Forms.ComboBox cmbUsersInOrders;
        private System.Windows.Forms.ListView lsvOrderProducts;
        private System.Windows.Forms.ColumnHeader OrdersProductID;
        private System.Windows.Forms.ColumnHeader OrdersProductName;
        private System.Windows.Forms.ColumnHeader OrderProductQuantity;
        private System.Windows.Forms.ColumnHeader OrderProductPrice;
        private System.Windows.Forms.ColumnHeader OrderProductTotal;
        private System.Windows.Forms.Button btnCreateExcel;
        private System.Windows.Forms.Button btnCreateProductExel;
    }
}

