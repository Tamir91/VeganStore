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
            this.tabUser = new System.Windows.Forms.TabControl();
            this.User = new System.Windows.Forms.TabPage();
            this.Product = new System.Windows.Forms.TabPage();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Suplier = new System.Windows.Forms.TabPage();
            this.Store = new System.Windows.Forms.TabPage();
            this.Cart = new System.Windows.Forms.TabPage();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.radioButtonClient = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.tabUser.SuspendLayout();
            this.User.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.Store);
            this.tabUser.Controls.Add(this.Cart);
            this.tabUser.Controls.Add(this.User);
            this.tabUser.Controls.Add(this.Product);
            this.tabUser.Controls.Add(this.Suplier);
            this.tabUser.Location = new System.Drawing.Point(12, 12);
            this.tabUser.Name = "tabUser";
            this.tabUser.SelectedIndex = 0;
            this.tabUser.Size = new System.Drawing.Size(663, 426);
            this.tabUser.TabIndex = 0;
            // 
            // User
            // 
            this.User.Controls.Add(this.btnRemoveUser);
            this.User.Controls.Add(this.btnUpdateUser);
            this.User.Controls.Add(this.btnAddNewUser);
            this.User.Controls.Add(this.radioButtonAdmin);
            this.User.Controls.Add(this.radioButtonClient);
            this.User.Controls.Add(this.lblRole);
            this.User.Controls.Add(this.lblUserName);
            this.User.Controls.Add(this.lblUserId);
            this.User.Controls.Add(this.textBox2);
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
            // Product
            // 
            this.Product.Location = new System.Drawing.Point(4, 22);
            this.Product.Name = "Product";
            this.Product.Padding = new System.Windows.Forms.Padding(3);
            this.Product.Size = new System.Drawing.Size(655, 400);
            this.Product.TabIndex = 1;
            this.Product.Text = "Product";
            this.Product.UseVisualStyleBackColor = true;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(74, 7);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(100, 20);
            this.txtUserId.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // Suplier
            // 
            this.Suplier.Location = new System.Drawing.Point(4, 22);
            this.Suplier.Name = "Suplier";
            this.Suplier.Size = new System.Drawing.Size(655, 400);
            this.Suplier.TabIndex = 2;
            this.Suplier.Text = "Suplier";
            this.Suplier.UseVisualStyleBackColor = true;
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
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(6, 10);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(18, 13);
            this.lblUserId.TabIndex = 3;
            this.lblUserId.Text = "ID";
            this.lblUserId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(6, 36);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(35, 13);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Name";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(6, 65);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(29, 13);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Role";
            this.lblRole.Click += new System.EventHandler(this.label3_Click);
            // 
            // radioButtonClient
            // 
            this.radioButtonClient.AutoSize = true;
            this.radioButtonClient.Location = new System.Drawing.Point(74, 63);
            this.radioButtonClient.Name = "radioButtonClient";
            this.radioButtonClient.Size = new System.Drawing.Size(51, 17);
            this.radioButtonClient.TabIndex = 8;
            this.radioButtonClient.TabStop = true;
            this.radioButtonClient.Text = "Client";
            this.radioButtonClient.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(142, 63);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(54, 17);
            this.radioButtonAdmin.TabIndex = 9;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(9, 101);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewUser.TabIndex = 10;
            this.btnAddNewUser.Text = "Add User";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(99, 101);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateUser.TabIndex = 11;
            this.btnUpdateUser.Text = "Update user";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(191, 101);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveUser.TabIndex = 12;
            this.btnRemoveUser.Text = "Delete User";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabUser);
            this.Name = "frmStore";
            this.Text = "Store";
            this.Load += new System.EventHandler(this.frmStore_Load);
            this.tabUser.ResumeLayout(false);
            this.User.ResumeLayout(false);
            this.User.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUser;
        private System.Windows.Forms.TabPage User;
        private System.Windows.Forms.TabPage Product;
        private System.Windows.Forms.TabPage Store;
        private System.Windows.Forms.TabPage Cart;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TabPage Suplier;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.RadioButton radioButtonClient;
    }
}

