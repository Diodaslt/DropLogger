﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropLogger
{
    public class MenuItemDetails
    {
        private string _name;
        public string name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
    }
}
