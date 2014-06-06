using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica03_MF0493
{
    interface IPerson
    {
        List<PersonManager> getAll();
        PersonManager get(int PersonID);
        int Add(PersonManager p);
        bool Remove(int PersonID);
    }
}
