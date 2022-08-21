using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21517208_HW04.Models
{
    public class DonateModel 
    {
        private string _Name;
        private string _Surname;
        private int _Amount;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Surname
        {
            get { return _Surname; }
            set { _Surname = value; }
        }
        public int Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        //constructor (shortcut = ctor + tab twice)

        public DonateModel(string name, string surname, int amount)//called when Donation is done
        {
            _Name = name;
            _Surname = surname;
            _Amount = amount;
        }

       
    }
}