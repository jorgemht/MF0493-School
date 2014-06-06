using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica03_MF0493
{
    interface ICurso
    {

        List<Practica03_MF0493.CourseManager> getAll();
        CourseManager get(int CourseID);
        int Add(CourseManager p);
        bool Remove(int CourseID);
    }
}
