using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApplication4.enity
{
   abstract class BaseRow:IEnity
    {
        public override int id { get; set; }
        public override string name { get; set; }


    }
}
