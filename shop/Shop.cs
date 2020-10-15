using CL_Shop;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;


namespace shop
{
    class Shop
    {
        public Repo Repo;
        private bool _IsRunning;

        public Shop()
        {

            this.Repo = new Repo();

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
                        this.PrintOrders();
                        break;
                    case 5:
                        this.PrintUsers();
                        break;
                    case 6:
                        this.PrintProducts();
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


        public void PrintUsers()
        {
            this.Repo.GetList<User>()
                   .ForEach((User user) => Console.WriteLine(user.Username));
        }

        public void PrintProducts()
        {
            this.Repo.GetList<Product>()
                .ForEach((Product product) => Console.WriteLine(product.Description));
        }

        public void PrintOrders()
        {
            this.Repo.GetList<Order>()
                .ForEach((Order order) => Console.WriteLine(order.OrderId));
        }

        public void PrintSale()
        {
            Console.WriteLine(this.Repo.GetDailyIncome());
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
                        this.PrintProducts();
                        break;
                    case "order":
                        this.PrintOrders();
                        break;
                    case "user":
                        this.PrintUsers();
                        break;
                }

                Console.WriteLine("Id der skal slettes: ");
                int Id = Convert.ToInt32(Console.ReadLine());

                switch (Type)
                {
                    case "product":
                        this.Repo.DeleteItem(this.Repo.GetItemById<Product>(Id));
                        break;
                    case "order":
                        this.Repo.DeleteItem(this.Repo.GetItemById<Order>(Id));
                        break;
                    case "user":
                        this.Repo.DeleteItem(this.Repo.GetItemById<User>(Id));
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
                Console.WriteLine("Bruger id:");
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("City:");
                string City = Console.ReadLine();
                Console.WriteLine("Postal:");
                int Postal = Convert.ToInt32(Console.ReadLine());


                string Address = Postal + " " + City;

                User User = new User(Id, Name, Address, City, Postal);

                this.Repo.AddItem<User>(User);

       
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
                Console.WriteLine("Product id:");

                int Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Description:");

                string Description = Console.ReadLine();

                Console.WriteLine("Price:");

                int Price = Convert.ToInt32(Console.ReadLine());

                Product Product = new Product(Id, Description, Price);

                this.Repo.AddItem<Product>(Product);
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
                Console.WriteLine("User Id:");
                int UserId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Product Id:");
                int ProductId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Order Id:");
                int OrderId = Convert.ToInt32(Console.ReadLine());

                User User = this.Repo.GetItemById<User>(UserId) as User;

                Product Product = this.Repo.GetItemById<Product>(ProductId) as Product;

                if(Product != null && User != null)
                {
                    Order Order = new Order(User, Product, OrderId);

                    this.Repo.AddItem(Order);

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
