using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApplication4.dao
{
    interface IDao
    {
        public int insert(object row);
        public int update(object row);
        public Boolean delete(object row);
        public List<object> findAll();
        public object findById(int id);
    }
}
