using CL_Shop;
using System;
using System.Collections.Generic;


namespace shop
{
    class Shop
    {
        public OrderRepo Orders = new OrderRepo();
        public UserRepo Users = new UserRepo();
        public ProductRepo Products = new ProductRepo();

        private bool _IsRunning;

        public Shop()
        {

            this._IsRunning = true;

            while(this._IsRunning)
            {
                int Choice = this.PrintOptions();

                switch(Choice)
                {
                    case 0:
                        this._IsRunning = false;
                        Environment.Exit(0);
                        break;
                    case 1:
                        this.CreateUser();
                        break;
                    case 2:
                        this.CreateProduct();
                        break;
                    case 3:
                        this.CreateOrder();
                        break;
                    case 4:
                        this.Print(this.Orders.GetList());
                        break;
                    case 5:
                        this.Print(this.Users.GetList());
                        break;
                    case 6:
                        this.Print(this.Products.GetList());
                        break;
                    case 7:
                        this.PrintSale();
                        break;
                    case 8:
                        this.Delete();
                        break;
               
                }

                Console.ReadLine();
                Console.Clear();

            }
        }

        public int PrintOptions()
        {
            Console.WriteLine("Choose option:");
            Console.WriteLine("1: Create Customer");
            Console.WriteLine("2: Create Product");
            Console.WriteLine("3: Create Order");
            Console.WriteLine("4: Show Orders");
            Console.WriteLine("5: Show Customers");
            Console.WriteLine("6: Show Products");
            Console.WriteLine("7: Sales");
            Console.WriteLine("8: Delete Customer, Order, Product");
            Console.WriteLine("0: QUIT");

            return Convert.ToInt32(Console.ReadLine());
        }

        public void Print<T>(List<T> Items) where T: BaseItem
        {
            Items.ForEach(item => Console.WriteLine(item.GetStringRepl()));
        }
    

        public void PrintSale()
        {
            Console.WriteLine($"INCOME: {this.Orders.GetIncome()}");
        }

        public void Delete()
        {
            try
            {

                List<string> choices = new List<string> { "product", "order", "user" };

                for(int i = 0; i < choices.Count; i++)
                {
                    Console.WriteLine($"{i} {choices[i]}");
                }

                Console.WriteLine("Vælg type du vil slette");

                string Type = choices[Convert.ToInt32(Console.ReadLine())];

                switch(Type)
                {
                    case "product":
                        this.Print(this.Products.GetList());
                        break;
                    case "order":
                        this.Print(this.Orders.GetList());
                        break;
                    case "user":
                        this.Print(this.Users.GetList());
                        break;
                }

                Console.WriteLine("Id der skal slettes: ");
                int Id = Convert.ToInt32(Console.ReadLine());

                switch (Type)
                {
                    case "product":
                        this.Products.DeleteItem(this.Products.GetItemById(Id));
                        break;
                    case "order":
                        this.Orders.DeleteItem(this.Orders.GetItemById(Id));
                        break;
                    case "user":
                        this.Users.DeleteItem(this.Users.GetItemById(Id));
                        break;
                }
            }
            catch
            {
                this.Delete();
            }
        }
             
        public void CreateUser()
        {
            try
            {
                Console.WriteLine("Brugernavn:");
                string Name = Console.ReadLine();
                Console.WriteLine("City:");
                string City = Console.ReadLine();
                Console.WriteLine("Postal:");
                int Postal = Convert.ToInt32(Console.ReadLine());


                string Address = Postal + " " + City;

                User User = new User(Name);

                this.Users.AddItem(User);
                
            }
            catch
            {
                this.CreateUser();
            }
        }

        public void CreateProduct()
        {
            try
            {
                Console.WriteLine("PRODUCT NAME:");

                string Name = Console.ReadLine();

                Console.WriteLine("Description:");

                string Description = Console.ReadLine();

                Console.WriteLine("Price:");

                int Price = Convert.ToInt32(Console.ReadLine());

                Product Product = new Product(Name, Description, Price);

                this.Products.AddItem(Product);
            }
            catch
            {
                this.CreateProduct();
            }
        }

        public void CreateOrder()
        {
            
            try
            {

                bool _SelectingProducts = true;

                this.Print(this.Users.GetList());

                Console.WriteLine("User Id:");

                int UserId = Convert.ToInt32(Console.ReadLine());

                User User = this.Users.GetItemById(UserId);

                List<Product> Products = new List<Product>();

                while(_SelectingProducts)
                {
                    this.Print(this.Products.GetList());

                    Console.WriteLine("Product Id:");

                    Products.Add(this.Products.GetItemById(Convert.ToInt32(Console.ReadLine())));

                    Console.WriteLine("Vil du tilføje flere produkter? Y = Yes --- N = No");

                    if (Console.ReadLine().ToLower() == "n") _SelectingProducts = false;

                }

                if(Products.Count > 0)
                {
                    this.Orders.AddItem(new Order(User, Products));
                    return;
                }

                Console.WriteLine("Product OR User doesnt exist");
                Console.ReadLine();
                
            }
            catch
            {
                this.CreateOrder();
            }
        }
    }
}
