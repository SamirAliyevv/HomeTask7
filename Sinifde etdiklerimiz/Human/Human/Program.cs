using System;

namespace Human
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human
            {
                Name = "Samir",
                Surname = "Aliyev",
                Age = 17,
                BornBirthday = "7 iyul 2005 ci il"


            };
            Console.WriteLine(human1.HumanInfo());
        }
    }
}
