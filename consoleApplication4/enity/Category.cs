﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApplication4.enity
{
    /// <summary>
    /// inheritance from BaseRow
    /// </summary>
    class Category:BaseRow
    {
        public Category()
        { }
        
       
        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public String toString()
        {
            return "\t" + this.id + "\t" + this.name;
        }
    }
}
