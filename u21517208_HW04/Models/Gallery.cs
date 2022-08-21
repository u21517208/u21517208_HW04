using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21517208_HW04.Models
{
    public class Gallery : LibraryModel
    {
        private string _Location;
        private int _PeopleFed;
        //private Uri _Image;

        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }
        public int PeopleFed
        {
            get { return _PeopleFed; }
            set { _PeopleFed = value; }

        }

        //public Uri Image
        //{
        //    get { return _Image; }
        //    set { _Image = value; }

        //}

        //constructor (shortcut = ctor + tab twice)
        public Gallery(string name, string location, int peoplefed/*, Uri image*/):base(name)
        {
            _Location = location;
            _PeopleFed = peoplefed;
            //_Image = image;
        }
    }
}