using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CL_Shop;

namespace little_shop
{
    public partial class MainScreen : Form
    {

        public OrderRepo Orders = new OrderRepo();
        public UserRepo Users = new UserRepo();
        public ProductRepo Products = new ProductRepo();

        public MainScreen()
        {
            InitializeComponent();
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                this.Users.AddItem(new User(inputUsername.Text));
                inputUsername.Clear();
                this.ShowMessage($"{inputUsername.Text} er nu blevet oprettet.");
            }
            catch
            {
                this.ShowMessage($"{inputUsername.Text} blev ikke oprettet... prøv igen");
            }
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnPrintUsers_Click(object sender, EventArgs e)
        {

            output.Items.Clear();

            if(!Users.HasItems())
            {
                this.ShowMessage("Der er ingen items af den type");
                return;
            }

            this.Users.GetList().ForEach(item => {          

                output.Items.Add(item.GetStringRepl().ToString());

            });
        }

        private void btnPrintProduct_Click(object sender, EventArgs e)
        {
            output.Items.Clear();
            
            if (!Products.HasItems())
            {
                this.ShowMessage("Der er ingen items af den type");
                return;
            }

            this.Products.GetList().ForEach(item => {

                output.Items.Add(item.GetStringRepl().ToString());

            });
        }

        private void ShowMessage(string message)
        {
            output.Items.Clear();

            output.Items.Add(message.ToUpper());
        }

        private void btnPrintOrder_Click(object sender, EventArgs e)
        {
            output.Items.Clear();

            if (!Orders.HasItems())
            {
                this.ShowMessage("Der er ingen items af den type");
                return;
            }

            this.Orders.GetList().ForEach(item => {

                output.Items.Add(item.GetStringRepl().ToString());

            });
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                List<TextBox> x = new List<TextBox> { inputProductName, inputProductDesc, inputProductPrice };
                this.Products
                    .AddItem(new Product(inputProductName.Text, inputProductDesc.Text, Convert.ToDouble(inputProductPrice.Text)));
                this.ShowMessage($"{inputProductName.Text} blev oprettet korrekt");
                x.ForEach(x => x.Clear());
            }
            catch
            {
                this.ShowMessage($"{inputProductName.Text} blev ikke oprettet, prøv igen");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                switch (inputDeleteType.SelectedItem.ToString().ToLower())
                {
                    case "product":
                        this.Products.DeleteItem(this.Products.GetItemById(Convert.ToInt32(inputDeleteId.Text)));
                        break;
                    case "order":
                        this.Orders.DeleteItem(this.Orders.GetItemById(Convert.ToInt32(inputDeleteId.Text)));
                        break;
                    case "user":
                        this.Users.DeleteItem(this.Users.GetItemById(Convert.ToInt32(inputDeleteId.Text)));
                        break;
                }

                this.ShowMessage($"Du har nu slettet det valgte element");
            }
            catch
            {
                this.ShowMessage("Du har ikke slettet elementet.. prøv igen");
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                User user = this.Users.GetItemById(Convert.ToInt32(inputOrderUserId.Text));

                List<Product> ProductIds = inputOrderProductId.Text
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .Select(x => this.Products.GetItemById(Convert.ToInt32(x)))
                    .ToList();

                if (user is null || ProductIds.Contains(null))
                {
                    this.ShowMessage("Bruger eller Produkt findes ikke");
                    return;
                }

                

                this.Orders.AddItem(new Order(user, ProductIds));

                this.ShowMessage("Ordre er oprettet succesfuldt");
            
            }
            catch
            {
                this.ShowMessage("Noget gik galt.. prøv igen");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.ShowMessage("Du har solgt for " + this.Orders.GetIncome(Convert.ToInt32(inputDollarDays.Text)).ToString() + " Bobs :)");
            }
            catch
            {
                this.ShowMessage("Noget gik galt.. prøv igen");
            }
        }
    }
}
