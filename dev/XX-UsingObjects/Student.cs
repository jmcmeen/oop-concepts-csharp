using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XX_UsingObjects
{
    internal class Student
    {
        public string firstName;
        public string lastName;
        public List<double> grades;

        public Student()
        {
            firstName = RandomGen.NextName(8);
            lastName = RandomGen.NextName(8);

            grades = new List<double>();
        }
    }
}
