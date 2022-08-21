using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace u21517208_HW04.Models
{
    public class LibraryModel
    {

        private string _Name;

        public LibraryModel(string name)
        {
            _Name = name;
        }   

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

       



    }
}