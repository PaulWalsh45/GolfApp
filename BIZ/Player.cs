using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class Player:Contact
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public int Handicap { get; set; }
        public int Adjust { get; set; }
        public string Club { get; set; }
        public string Image { get; set; }


        public Player(string firstname, string lastname, int handicap, int adjust, string address, string phone, string email, string club, string image)
            : base (address,phone,email)
        {
            FirstName = firstname;
            Lastname = lastname;
            Handicap = handicap;
            Adjust = Adjust;
            Address = address;
            Phone = phone;
            Email = email;
            Club = club;
            Image = image;
        }

    }

    
}
