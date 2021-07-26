using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using VeganStore.Controllers;
using VeganStore.Models;
using static System.Windows.Forms.ListView;

namespace VeganStore
{
    public partial class frmStore : Form
    {
        private List<User> users = new List<User>();
        private List<Product> products = new List<Product>();
        private List<Suplier> supliers = new List<Suplier>();
        private List<Product> productsInCart = new List<Product>();
        private List<OrderTotal> ordersTotal = new List<OrderTotal>();

        private User selectedUser;
        private Product selectedProduct;
        private Suplier selectedSuplier; 

        public frmStore()
        {
            InitializeComponent();
            FillStoreListView();
            FillComboBoxOfUsersInStore();
            FillComboBoxOfSupliersInStore();

            lsvUser.GridLines = true;// Whether the grid lines are displayed
            lsvUser.FullRowSelect = true;// Whether to select the entire line

            lsvUser.View = View.Details;// Set display mode
            lsvUser.Scrollable = true;// Whether to show the scroll bar automatically
            lsvUser.MultiSelect = false;// Is it possible to select multiple lines

            lsvProducts.GridLines = true;// Whether the grid lines are displayed
            lsvProducts.FullRowSelect = true;// Whether to select the entire line

            lsvProducts.View = View.Details;// Set display mode
            lsvProducts.Scrollable = true;// Whether to show the scroll bar automatically
            lsvProducts.MultiSelect = false;// Is it possible to select multiple lines

            lsvSuplier.GridLines = true;// Whether the grid lines are displayed
            lsvSuplier.FullRowSelect = true;// Whether to select the entire line

            lsvSuplier.View = View.Details;// Set display mode
            lsvSuplier.Scrollable = true;// Whether to show the scroll bar automatically
            lsvSuplier.MultiSelect = false;// Is it possible to select multiple lines

            lsvStore.GridLines = true;// Whether the grid lines are displayed
            lsvStore.FullRowSelect = true;// Whether to select the entire line

            lsvStore.View = View.Details;// Set display mode
            lsvStore.Scrollable = true;// Whether to show the scroll bar automatically
            lsvStore.MultiSelect = false;// Is it possible to select multiple lines

            lsvOrder.GridLines = true;// Whether the grid lines are displayed
            lsvOrder.FullRowSelect = true;// Whether to select the entire line

            lsvOrder.View = View.Details;// Set display mode
            lsvOrder.Scrollable = true;// Whether to show the scroll bar automatically
            lsvOrder.MultiSelect = false;// Is it possible to select multiple lines

            lsvOrderProducts.GridLines = true;// Whether the grid lines are displayed
            lsvOrderProducts.FullRowSelect = true;// Whether to select the entire line

            lsvOrderProducts.View = View.Details;// Set display mode
            lsvOrderProducts.Scrollable = true;// Whether to show the scroll bar automatically
            lsvOrderProducts.MultiSelect = false;// Is it possible to select multiple lines
        }

        private void TabsStrore_Click(object sender, EventArgs e)
        {
            switch(((TabControl)sender).SelectedTab.Name)
            {
                case "User":
                {
                    FillUserListView();
                    break;
                }
                case "Product":
                {
                    FillProductListView();
                    FillComboBoxOfSupliersInProducts();
                    break;
                }
                case "Suplier":
                    {
                        FillSuplierListView();
                        break;
                    }
                case "Store":
                    {
                        FillStoreListView();
                        FillComboBoxOfUsersInStore();
                        FillComboBoxOfSupliersInStore();
                        break;
                    }
                case "Orders":
                    {
                        FillComboBoxOfUsersInOrder();
                        break;
                    }

            }
            
        }

        /* User Tab */

        private void SelectedRowInUserChanged(object sender, EventArgs e)
        {
            if (lsvUser.SelectedItems.Count > 0)
            {
                int selectedIndex = lsvUser.Items.IndexOf(lsvUser.SelectedItems[0]);
                int counter = 0;

                foreach(User user in users)
                {
                    if (counter++ == selectedIndex)
                    {
                        selectedUser = user;
                        break;
                    }
                }

                txtUserName.Text = selectedUser.Name;
                if(selectedUser.Role == "Staff")
                    radioButtonStaff.Checked = true;
                else
                    radioButtonClient.Checked = true;
            }
        }

        private void FillUserListView()
        {
            users = UserController.GetAllUsers();
            lsvUser.Items.Clear();

            foreach (User user in users)
            {
                ListViewItem item = new ListViewItem(user.Id.ToString());
                item.SubItems.Add(user.Name.ToString());
                item.SubItems.Add(user.Role.ToString());

                lsvUser.Items.Add(item);
            }
        }

        private void BtnAddNewUser_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text;
            string role = "";

            if (!String.IsNullOrEmpty(name))
            {
                role = radioButtonStaff.Checked ? "Staff" : "Client";

                UserController.AddUser(name, role);

                FillUserListView();
            }
        }

        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text;

            if (!String.IsNullOrEmpty(name) && selectedUser != null)
            {
                selectedUser.Name = txtUserName.Text;

                if (radioButtonClient.Checked)
                    selectedUser.Role = "Client";
                else
                    selectedUser.Role = "Staff";

                UserController.UpdateUser(selectedUser);
                FillUserListView();
            }
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {

                UserController.DeleteUser(selectedUser.Id.ToString());
                FillUserListView();
            }
        }

        /* Product Tab */

        private void SelectedRowInProductChanged(object sender, EventArgs e)
        {
            if (lsvProducts.SelectedItems.Count > 0)
            {
                int selectedIndex = lsvProducts.Items.IndexOf(lsvProducts.SelectedItems[0]);
                int counter = 0;

                foreach (Product p in products)
                {
                    if (counter++ == selectedIndex)
                    {
                        selectedProduct = p;
                        break;
                    }
                }

                txtProductName.Text = selectedProduct.Name;
                txtProductPrice.Text = selectedProduct.Price.ToString();
                txtProductQuantity.Text = selectedProduct.Quantity.ToString();
            }
        }

        private void FillProductListView()
        {
            products = ProductController.GetAllProducts();
            supliers = SuplierController.GetAllSupliers();
            lsvProducts.Items.Clear();

            foreach (Product product in products)
            {
                ListViewItem item = new ListViewItem(product.Id.ToString());
                item.SubItems.Add(product.Name.ToString());
                item.SubItems.Add(product.Price.ToString());
                item.SubItems.Add(product.Quantity.ToString());
                item.SubItems.Add(product.Suplier_name.ToString());

                lsvProducts.Items.Add(item);
            }
        }

        private void FillComboBoxOfSupliersInProducts()
        {
            int ind = 0;
            cmbSuplier.Items.Clear();
            System.Object[] ItemObject = new System.Object[supliers.Count];

            foreach (Suplier s in supliers)
            {
                ItemObject[ind++] = s.Name.ToString();
            }
            cmbSuplier.Items.AddRange(ItemObject);
        }

        private void BtnAddNewProduct_Click(object sender, EventArgs e)
        {
            string name = txtProductName.Text;
            string quantity = txtProductQuantity.Text;
            string price = txtProductPrice.Text;
            long suplierID = GetSuplierIdByName();

            if (ProductController.IsInputProductDataCorrect(name, quantity, price) && suplierID != 0)
            { 
                ProductController.AddProduct(name, quantity, price, suplierID);

                FillProductListView();
            }
        }

        private long GetSuplierIdByName()
        {
            long suplierID = 0;
            string suplierName = "";

            if (cmbSuplier != null && cmbSuplier.SelectedItem != null)
            {
                suplierName = cmbSuplier.SelectedItem.ToString();
            }
            
            foreach (Suplier s in supliers)
            {
                if(s.Name.ToString() == suplierName)
                {
                    suplierID = s.Id;
                    break;
                }
            }
            return suplierID;
        }

        private void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            string name = txtProductName.Text;
            string quantity = txtProductQuantity.Text;
            string price = txtProductPrice.Text;

            if (ProductController.IsInputProductDataCorrect(name, quantity, price) && selectedProduct != null)
            {
                selectedProduct.Name = name;
                selectedProduct.Quantity = Convert.ToInt32(quantity);
                selectedProduct.Price = Convert.ToInt32(price);
                long suplierID = GetSuplierIdByName();

                ProductController.UpdateProduct(selectedProduct);
                FillProductListView();
            }
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                ClearProductInputs();
                ProductController.DeleteProduct(selectedProduct.Id.ToString());
                FillProductListView();
            }
        }

        private void ClearProductInputs()
        {
            txtProductName.Text = "";
            txtProductQuantity.Text = "";
            txtProductPrice.Text = "";
        }

        /* Suplier Tab */

        private void SelectedRowInSuplierChanged(object sender, EventArgs e)
        {
            if (lsvSuplier.SelectedItems.Count > 0)
            {
                int selectedIndex = lsvSuplier.Items.IndexOf(lsvSuplier.SelectedItems[0]);
                int counter = 0;

                foreach (Suplier s in supliers)
                {
                    if (counter++ == selectedIndex)
                    {
                        selectedSuplier = s;
                        break;
                    }
                }

                txtSuplierName.Text = selectedSuplier.Name;
                txtSuplierPhone.Text = selectedSuplier.Phone;
            }
        }

        private void FillSuplierListView()
        {
            supliers = SuplierController.GetAllSupliers();
            lsvSuplier.Items.Clear();

            foreach (Suplier s in supliers)
            {
                ListViewItem item = new ListViewItem(s.Id.ToString());
                item.SubItems.Add(s.Name.ToString());
                item.SubItems.Add(s.Phone.ToString());

                lsvSuplier.Items.Add(item);
            }
        }

        private void BtnAddNewSuplier_Click(object sender, EventArgs e)
        {
            string name = txtSuplierName.Text;
            string phone =txtSuplierPhone.Text;

            if (SuplierController.IsInputSuplierDataCorrect(name, phone))
            {
                SuplierController.AddSuplier(name, phone);

                FillSuplierListView();
            }
        }

        private void BtnUpdateSuplier_Click(object sender, EventArgs e)
        {
            string name = txtSuplierName.Text;
            string phone = txtSuplierPhone.Text;

            if (SuplierController.IsInputSuplierDataCorrect(name, phone) && selectedSuplier != null)
            {
                selectedSuplier.Name = name;
                selectedSuplier.Phone = phone;

                SuplierController.UpdateSuplier(selectedSuplier);
                FillSuplierListView();
            }
        }

        private void BtnDeleteSuplier_Click(object sender, EventArgs e)
        {
            if (selectedSuplier != null)
            {
                ClearSuplierInputs();
                SuplierController.DeleteSuplier(selectedSuplier.Id.ToString());
                FillSuplierListView();
            }
        }

        private void ClearSuplierInputs()
        {
            txtSuplierName.Text = "";
            txtSuplierPhone.Text = "";
        }

        /* Store Tab */

        private void FillStoreListView(long suplierID = 0)
        {
            if(suplierID == 0)
                products = ProductController.GetAllProducts();
            else
                products = ProductController.GetAllProducts(suplierID);

            lsvStore.Items.Clear();

            foreach (Product p in products)
            {
                ListViewItem item = new ListViewItem(p.Id.ToString());
                item.SubItems.Add(p.Name.ToString());
                item.SubItems.Add(p.Price.ToString());

                lsvStore.Items.Add(item);
            }
        }

        private void FillComboBoxOfSupliersInStore()
        {
            int ind = 1;
            cmbSuplierInStore.Items.Clear();

            supliers = SuplierController.GetAllSupliers();
            System.Object[] ItemObject = new System.Object[supliers.Count + 1];

            ItemObject[0] = "--select--";
            foreach (Suplier s in supliers)
            {
                ItemObject[ind++] = s.Name.ToString();
            }

            cmbSuplierInStore.Items.AddRange(ItemObject);
            cmbSuplierInStore.SelectedItem = null;
            cmbSuplierInStore.SelectedText = "--select--";
        }

        private void FillComboBoxOfUsersInStore()
        {
            int ind = 0;
            cmbUsersInStore.Items.Clear();

            users = UserController.GetAllUsers();
            System.Object[] ItemObject = new System.Object[users.Count];

            foreach (User us in users)
            {
                ItemObject[ind++] = us.Name.ToString();
            }
            cmbUsersInStore.Items.AddRange(ItemObject);
        }

        private void CmbSuplierIndexChanged(object sender, EventArgs e)
        {
            long suplierId = GetSuplierIdByNameInStore();

            FillStoreListView(suplierId);
        }

        private long GetSuplierIdByNameInStore()
        {
            long suplierID = 0;
            string suplierName = "";

            if (cmbSuplierInStore != null && cmbSuplierInStore.SelectedItem != null)
            {
                suplierName = cmbSuplierInStore.SelectedItem.ToString();
            }

            foreach (Suplier s in supliers)
            {
                if (s.Name.ToString() == suplierName)
                {
                    suplierID = s.Id;
                    break;
                }
            }
            return suplierID;
        }

        private void SelectedRowInProductStoreChanged(object sender, EventArgs e)
        {
            if (lsvStore.SelectedItems.Count > 0)
            {
                lsvCart.Items.Clear();
                int selectedIndex = lsvStore.Items.IndexOf(lsvStore.SelectedItems[0]);
                int counter = 0;

                foreach (Product p in products)
                {
                    if (counter++ == selectedIndex)
                    {
                        if (productsInCart.Contains(p))
                        {
                            int ind = productsInCart.IndexOf(p);
                            productsInCart[ind].Quantity++;
                        }
                        else
                        {
                            p.Quantity = 1;
                            productsInCart.Add(p);
                        }
                        
                        break;
                    }
                }

                foreach (Product p in productsInCart)
                {
                    ListViewItem item = new ListViewItem(p.Id.ToString());
                    item.SubItems.Add(p.Name.ToString());
                    item.SubItems.Add(p.Quantity.ToString());

                    lsvCart.Items.Add(item);
                }

            }
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            int ind = cmbUsersInStore.SelectedIndex;

            if(ind != -1 && productsInCart.Count > 0)
            {
                long userId = users[ind].Id;
                long cartID = CartController.AddCart(userId);

                foreach (Product p in productsInCart)
                {
                    OrderController.AddOrder(p.Id, p.Quantity, cartID);
                }
            }
            lsvCart.Items.Clear();
            productsInCart.Clear();
        }

        /* Order Tab */

        private void FillComboBoxOfUsersInOrder()
        {
            int ind = 0;
            cmbUsersInOrders.Items.Clear();

            users = UserController.GetAllUsers();
            System.Object[] ItemObject = new System.Object[users.Count];

            foreach (User us in users)
            {

                ItemObject[ind++] = us.Name.ToString();
            }
            cmbUsersInOrders.Items.AddRange(ItemObject);
        }

        private void FillOrdersTotalListView(List<OrderTotal> orders)
        {
            lsvOrder.Items.Clear();
            lsvOrderProducts.Items.Clear();

            foreach (OrderTotal ord in orders)
            {
                ListViewItem item = new ListViewItem(ord.Cart_id.ToString());
                item.SubItems.Add(ord.Name.ToString());
                item.SubItems.Add(ord.Total.ToString());
                item.SubItems.Add(ord.Created_at.ToString());

                lsvOrder.Items.Add(item);
            }
        }

        private void CmbUserIndexInOrdersChanged(object sender, EventArgs e)
        {
            long userId = users[cmbUsersInOrders.SelectedIndex].Id;

            ordersTotal = OrderController.GetOrdersByUserID(userId);
            FillOrdersTotalListView(ordersTotal);
        }

        private void SelectedRowInOrdersChanged(object sender, EventArgs e)
        {
            
            if (lsvOrder.SelectedItems.Count > 0)
            {
                lsvOrderProducts.Items.Clear();

                int selectedIndex = lsvOrder.Items.IndexOf(lsvOrder.SelectedItems[0]);
                long cart_id = ordersTotal[selectedIndex].Cart_id;

                List<OrderProduct> products = OrderController.GetOrderProductsByCartID(cart_id);

                foreach (OrderProduct p in products)
                {
                    ListViewItem item = new ListViewItem(p.Product_id.ToString());
                    item.SubItems.Add(p.Name.ToString());
                    item.SubItems.Add(p.Quantity.ToString());
                    item.SubItems.Add(p.Price.ToString());
                    item.SubItems.Add(p.Total_price.ToString());

                    lsvOrderProducts.Items.Add(item);
                }
            }
        }

        private void BtnCreateUserExcel_Click(object sender, EventArgs e)
        {
            ExcelController.CreateExcelReport<User>("users.xls");
        }

        private void BtnCreateProductExel_Click(object sender, EventArgs e)
        {
            ExcelController.CreateExcelReport<Product>("products.xls");
        }
    }
}
