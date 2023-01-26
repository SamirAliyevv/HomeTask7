using System;
using System.Collections.Generic;
using System.Text;

namespace Sinifde_etdiklerimiz
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public int Age;
        public int GroupNo;


        public string StudentInfo()
        {
            return $"Name : {Name},Surname : {Surname}, Age : {Age}, GroupNo : {GroupNo}";

        }



    }
}
