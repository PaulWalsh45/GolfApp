using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGolfSocietyApp
{
    public class Licience
    {
        private DateTime expDate = new DateTime(2018, 1, 31);// set your licience expiry here
        private bool active;

        public DateTime ExpiryDate
        {
            get { return expDate; }
            //set { myVar = value; } readonly
        }
        
        public bool Active
        {
            get
            {
                if (DateTime.Now > expDate)
                {
                    active = false;
                }
                else
                {
                    active = true;
                }

                return active;
            }
            //set { active = value; } read only

        }

    }
}
