using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21517208_HW04.Models
{
    public class WhichPlantsToGrowModel: LibraryModel
    {
        private string _Climate;
        

        public string Climate
        {
            get { return _Climate; }
            set { _Climate = value; }
        }
       
        //constructor (shortcut = ctor + tab twice)
        public WhichPlantsToGrowModel(string name,string climate) : base(name)
        {
            _Climate = climate;
            
        }
    }
}