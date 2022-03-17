using System;
using System.Collections.Generic;
using System.Text;
using person;
namespace person.Models
{
    class Student: Person
    {
        private double point;

        public double Point {
            get 
            {
                return point;
            }
            set 
            {
                if (value<0 || value>100)
                {
                    Console.WriteLine("Xal 0-100 aralginda ola biler");
                    return;
                }

                point = value;
            }
        }

        public Student( string name, string surName, int age, double point ) :base(name,surName,age)
        {
            Point = point;
            
        }

       
    }
}
