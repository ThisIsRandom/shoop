using System;
using System.Collections.Generic;
using System.Text;

namespace CL_Shop.ShopItems.user
{
    public class User : IUser
    {
        public string username { get; }

        public int id { get; }

        public DateTime createdAt { get; }

        public string getStringRepl()
        {
            return $"USER ID: {this.id} --- USERNAME: {this.username}";
        }

        public User(IUserProps props)
        {
            this.username = props.username;
            this.id = props.id;
        }
        
    }
}
