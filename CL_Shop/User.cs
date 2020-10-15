using System;

namespace CL_Shop
{
    public class User
    {
        public int UserId;
        public string Username;
        public ContactInformation ContactInformation;

        public User(int Id, string Name, String Address, string City, int Postal)
        {
            this.UserId = Id;
            this.Username = Name;
            this.ContactInformation = new ContactInformation(Address, City, Postal);
        }

    }
}
