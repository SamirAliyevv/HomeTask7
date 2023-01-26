using System;
using System.IO;

namespace Sinifde_etdiklerimiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student
            {
                Name = "Samir",
                Surname = "Aliyev",
                Age = 17,
                GroupNo = 1,
                
                
            };
            Console.WriteLine(student1.StudentInfo());
           

        }
    }
}
