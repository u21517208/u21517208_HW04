using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21517208_HW04.Models
{
    public class CookBookModel
    {//strict encapsulation
        private string _Name;
        private string _Ingredients;
        private string _Method;
        private int _Serves;

        public CookBookModel(string name, string ingredients, string method, int serves)
        {
            _Name = name;
            _Ingredients = ingredients;
            _Method = method;
            _Serves = serves;
        }


        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Ingredients
        {
            get { return _Ingredients; }
            set { _Ingredients = value; }
        }
        public string Method
        {
            get { return _Method; }
            set { _Method = value; }
        }
        public int Serves
        {
            get { return _Serves; }
            set { _Serves = value; }
        }

    }
}