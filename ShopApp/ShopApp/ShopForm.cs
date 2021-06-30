using ShopAppLibrary;
using ShopAppLibrary.Proxy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ShopApp
{
    public partial class ShopForm : Form
    {

        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();

        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();

        public ShopForm()
        {
            InitializeComponent();
            SetupData();
        }

        private void SetupData()
        {
            store.Vendors.Add(new Vendor() { Name = "Altex"});
            store.Vendors.Add(new Vendor() { Name = "Amazon"});

            store.Items.Add(new Item() { Title = "Clean Code", Price = 240, Owner = store.Vendors[1] });
            store.Items.Add(new Item() { Title = "C# in Depth", Price = 140, Owner = store.Vendors[1] });
            store.Items.Add(new Item() { Title = "C# 8.0 and .NET Core 3.0", Price = 240, Owner = store.Vendors[1] });
            store.Items.Add(new Item() { Title = "Head First C#", Price = 140, Owner = store.Vendors[1] });
            store.Items.Add(new Item() { Title = "Learning SQL", Price = 240, Owner = store.Vendors[1] });
            store.Items.Add(new Item() { Title = "The Pragmatic Programmer", Price = 140, Owner = store.Vendors[1] });
            store.Items.Add(new Item() { Title = "Samsung Oled TV", Price = 3800, Owner = store.Vendors[0] });
            store.Items.Add(new Item() { Title = "LG Wing", Price = 3200, Owner = store.Vendors[0] });
            store.Items.Add(new Item() { Title = "Samsung Led TV", Price = 800, Owner = store.Vendors[0] });
            store.Items.Add(new Item() { Title = "LG Shine", Price = 200, Owner = store.Vendors[0] });
            store.Items.Add(new Item() { Title = "Sony Experia 1", Price = 2200, Owner = store.Vendors[0] });
            store.Items.Add(new Item() { Title = "Sony TV 4k", Price = 1900, Owner = store.Vendors[0] });
            store.Items.Add(new Item() { Title = "HP Laptop", Price = 2100, Owner = store.Vendors[0] });
            store.Items.Add(new Item() { Title = "Dell xps 15", Price = 11000, Owner = store.Vendors[0] });

            #region create Bindings
            itemsBinding.DataSource = store.Items.Where(i => i.Sold == false).ToList();
            ItemsListBox.DataSource = itemsBinding;
            ItemsListBox.DisplayMember = "Display";
            ItemsListBox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            ShoppingCartListBox.DataSource = cartBinding;
            ShoppingCartListBox.DisplayMember = "Display";
            ShoppingCartListBox.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            VendorsListBox.DataSource = vendorsBinding;
            VendorsListBox.DisplayMember = "Name";
            VendorsListBox.ValueMember = "Name";
            #endregion
        }

        private void AddToCartItemBtn_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)ItemsListBox.SelectedItem;

            if (!shoppingCartData.Exists(i => i.Title == selectedItem.Title))
            {
                shoppingCartData.Add(selectedItem);
            }

            cartBinding.ResetBindings(false);

            decimal total = 0;
            var orderProxy = new OrderProxy();

            foreach (var item in shoppingCartData)
            {
                total += orderProxy.CalculatePriceWithTaxes(item);
            }
            TotalSumLabel.Text = total.ToString();
        }

        private void MakePurchaseBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in shoppingCartData)
            {
                item.Sold = true;
            }

            shoppingCartData.Clear();

            Vendor selectedVendor = (Vendor)VendorsListBox.SelectedItem;
            itemsBinding.DataSource = store.Items.Where(i => i.Sold == false && i.Owner.Name == selectedVendor.Name).ToList();

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);

            TotalSumLabel.Text = "0";
        }

        private void VendorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vendor selectedVendor = (Vendor)VendorsListBox.SelectedItem;

            itemsBinding.DataSource = store.Items.Where(i => i.Sold == false && i.Owner == selectedVendor);

            itemsBinding.ResetBindings(false);
        }
    }
}
