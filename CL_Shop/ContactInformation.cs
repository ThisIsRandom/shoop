using System;
using System.Collections.Generic;
using System.Text;

namespace CL_Shop
{
    public class ContactInformation
    {
        public string Address;
        public string City;
        public int PostalCode;

        public ContactInformation(string Addr, string City, int Postal)
        {
            this.Address = Addr;
            this.City = City;
            this.PostalCode = Postal;
        }
    }
}

 