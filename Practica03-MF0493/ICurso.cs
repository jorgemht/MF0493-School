using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica03_MF0493
{
    interface ICurso
    {

        List<Course> getAll();
        Course get(int CourseID);
        int Add(Course p);
        bool Remove(int CourseID);
    }
}
