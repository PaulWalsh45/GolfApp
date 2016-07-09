using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class Course:Contact
    {
        public string Name { get; set; }
        public int[] HolePars { get; set; }
        public int[] HoleIndexs { get; set; }

       

        public Course(string name, string address, string phone, string email, int[] par,int[] index)
            : base(address, phone, email)
        {
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
            HolePars = par;
            HoleIndexs = index;
        }

        
        
        
     
    }

    
}
