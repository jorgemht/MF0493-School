using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica03_MF0493
{
    interface Ioperaciones
    {
        public int getAll();
        public void get(int ID);
        public void Add(Person p);
        public bool Remove(int ID);
    }
}
