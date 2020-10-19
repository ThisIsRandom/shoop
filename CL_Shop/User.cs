using System;

namespace CL_Shop
{
    public class User: BaseItem
    {
        public string Username;
        public ContactInformation ContactInformation;

        public User(string Name /*, String Address, string City, int Postal*/)
        {
            
            this.Username = Name;
            //this.ContactInformation = new ContactInformation(Address, City, Postal);

        }

        public override string GetStringRepl()
        {
            return $"USER ID: {this.Id} --- USERNAME: {this.Username}";
        }
        

    }
}
