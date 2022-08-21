using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21517208_HW04.Models
{
    public class HowToPlantModel : LibraryModel
    {
        private int _Time;
        private string _SoilType;
        private string _Method;

        public int Time
        {
            get { return _Time; }
            set { _Time = value; }
        }
        public  string SoilType
        {
            get { return _SoilType; }
            set { _SoilType = value; }

        }

        public string Method
        {
            get { return _Method; }
            set{ _Method = value; }
        }

        //constructor (shortcut = ctor + tab twice)
        public HowToPlantModel(string name, int time, string soiltype, string method) : base(name)
        {
            _Time = time;
            _SoilType = soiltype;
            _Method = method;
        }
    }
}