using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica03_MF0493
{
    interface IPerson
    {
        List<Person> getAll();
        Person get(int PersonID);
        int Add(Person p);
        bool Remove(int PersonID);
    }
}
