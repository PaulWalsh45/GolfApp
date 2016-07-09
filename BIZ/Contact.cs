using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class Contact
    {
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Contact(string address, string phone, string email)
        {
            Address = address;
            Phone = phone;
            Email = email;
        }
    }
}
