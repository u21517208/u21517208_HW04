using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21517208_HW04.Models
{
    public class VolunteerModel 
    {
        private int _Phone;


        public int Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        //constructor (shortcut = ctor + tab twice)

        public VolunteerModel(string name, string surname, int phone) //called when Donation is done
        {

            _Phone = phone;
        }


    }
}
