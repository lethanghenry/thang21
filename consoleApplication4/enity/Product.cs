using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApplication4.enity
{
    /// <summary>
    /// inheritance from BaseRow
    /// </summary>
    class Product:BaseRow
    {
       
        public int categoryId { get; set; }
        public Product()
        { }

        public Product(int id, string name, int categoryId)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
        }
        public String toString()
        {
            return "\t" + this.id + "\t" + this.name + "\t" + this.categoryId;
        }
    }
}
