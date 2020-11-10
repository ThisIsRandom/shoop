using CL_Shop;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using CL_Shop.shop_factory;
using CL_Shop.ShopItems;
using CL_Shop.ShopItems.user;
using CL_Shop.ShopItems.product;
using System.Windows.Forms.VisualStyles;
using CL_Shop.ShopItems.order;
using CL_Shop.shop_items.product;
using CL_Shop.shop_items.order;
using CL_Shop.shop_items.user;

namespace little_shop
{
    public partial class MainScreen : Form
    {


        public UserRepo Users = RepoFactory.createUserRepo();
        public ProductRepo Products = RepoFactory.createProductRepo();
        public OrderRepo Orders = RepoFactory.createOrderRepo();
        public ShopItemFactory ItemsFactory = new ShopItemFactory();

        //public SqlConnection con = db.GetDbConnection();
        public MainScreen()
        {
            InitializeComponent();

            Generator.createIndexForType("order", 0);
            Generator.createIndexForType("product", 0);
            Generator.createIndexForType("user", 0);
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            try
            {

                IUserProps props = new UserProps();
                props.username = inputUsername.Text;
                props.id = Generator.getId("user");
               

                this.Users.AddItem(this.ItemsFactory.create(props));
                inputUsername.Clear();
                this.ShowMessage($"{props.username} er nu blevet oprettet.");
            }
            catch
            {
                this.ShowMessage($"blev ikke oprettet... prøv igen");
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

                output.Items.Add(item.getStringRepl().ToString());

            });
        }

        private void btnPrintProduct_Click(object sender, EventArgs e)
        {
            //SqlCommand command = new SqlCommand("INSERT INTO Product (ProductName, ProductPrice, ProductsDesc) VALUES('test', 10, 'dadadad')", this.con);
            //SqlDataReader reader = command.ExecuteReader();
            //reader.Read();
            //reader.Close();
            output.Items.Clear();
            
            if (!Products.HasItems())
            {
                this.ShowMessage("Der er ingen items af den type");
                return;
            }

            this.Products.GetList().ForEach(item => {

                output.Items.Add(item.getStringRepl().ToString());

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

                output.Items.Add(item.getStringRepl().ToString());

            });
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            try
            {

                IProductProps props = new ProductProps();

                props.id = Generator.getId("product");
                props.description = inputProductDesc.Text;
                props.price = Convert.ToDouble(inputProductPrice.Text);
                props.name = inputProductName.Text;

                this.Products
                    .AddItem(this.ItemsFactory.create(props));
                this.ShowMessage($"{props.name} blev oprettet korrekt");
               
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
         
                IUser user = this.Users.GetItemById(Convert.ToInt32(inputOrderUserId.Text));

                IOrderProps props = new OrderProps();

                List<IProduct> ProductIds = inputOrderProductId.Text
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .Select(x => this.Products.GetItemById(Convert.ToInt32(x)))
                    .ToList();

                if (user is null || ProductIds.Contains(null))
                {
                    this.ShowMessage("Bruger eller Produkt findes ikke");
                    return;
                }

                props.user = user;
                props.products = ProductIds;

                this.Orders.AddItem(this.ItemsFactory.create(props));

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

        private void inputProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputProductPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void output_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
