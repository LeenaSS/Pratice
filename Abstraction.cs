﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayso
{
    public class Abstraction
    {
        public string Name { get; set; }
        public int age { get; set; }
        public string details()
        {
            return $" name :{Name} age :{age}";
        }
    }
}
