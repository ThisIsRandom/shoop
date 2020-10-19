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
        public ProductRepo Product = new ProductRepo();

        public MainScreen()
        {
            InitializeComponent();
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            this.Users.AddItem(new User(inputUsername.Text));
            inputUsername.Clear();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnPrintUsers_Click(object sender, EventArgs e)
        {
            this.Users.GetList().ForEach(item => {

                TextBox TextItem = new TextBox();

                TextItem.Width = 300;

                TextItem.Text = item.GetStringRepl();

                Size size = TextRenderer.MeasureText(TextItem.Text, TextItem.Font);

                TextItem.Width = size.Width;

                OutputContainer.Controls.Add(TextItem);

            });
        }
    }
}
