using System;
using System.Collections.Generic;
using System.Text;
using person;

namespace person.Models
{
    class Person
    {
        private int age;
        public string name;
        public string surName;

        public int Age {
            get 
            {
                return age;
            }
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Yas menfi ola bilmez!");
                    return;
                    
                }
                
                
                age = value;
       
                
            } 
        }

        public string Name {
            get
            {
                return name;
            }
            set
            {
                if (value.Length<3 || value.Length>30)
                {
                    Console.WriteLine("Adiniz en az 3 en cox 30 simvoldan ibaret ola biler");
                    return;
                }
                
                if (value.Substring(0, 1) != value.Substring(0, 1).ToUpper())
                {
                    Console.WriteLine("Adinizin ilk herifi boyuk olmalidir");
                    return;
                }

                name = value;
            }
        
        }

        public string SurName
        {
            get
            {
                return surName;
            }
            set
            {
                if (value.Length < 3 || value.Length > 35)
                {
                    Console.WriteLine("Soyadiniz en az 3 en cox 35 simvoldan ibaret ola biler");
                    return;
                }

                if (value.Substring(0, 1) != value.Substring(0, 1).ToUpper())
                {
                    Console.WriteLine("Soyadinizin ilk herifi boyuk olmalidir");
                    return;
                }

                surName = value;
            }

        }

        public Person(string name, string surName, int age) 
        {
            Name = name;
            SurName = surName;
            Age = age;
        }

    }
}
