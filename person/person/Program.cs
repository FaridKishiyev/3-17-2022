using System;
using person.Models;

namespace person
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ferid","Kisiyev",25,87);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.SurName);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.Point);
        }
    }
}
