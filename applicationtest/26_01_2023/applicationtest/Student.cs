using System;
using System.Collections.Generic;
using System.Text;

namespace applicationtest
{
    internal class Student
    {
        public string FullName;
        public string GroupNo;
        public int Point;

        public bool IsGraduated()
        {
            if (Point < 65)
            {
                return false;
            }
            return true;
        }
        

    }
}
