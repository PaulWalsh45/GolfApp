using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class Course
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int[] HolePars { get; set; }
        public int[] HoleIndexs { get; set; }

        public Course()
        {

        }

        public Course(string name, string address, string phone, string email, int[] par,int[] index)
        {
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
            HolePars = par;
            HoleIndexs = index;
        }

        Course course = new Course();
        
        
     
    }

    
}
