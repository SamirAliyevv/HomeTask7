using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask7
{
    internal class Notebook
    {
        public string Brand;
        public string Model;
        public double Price;


        public Notebook(string brand, string model,double price)
        {
            Brand= brand;
            Model= model;   
            Price= price;
        }
        public string  ShowInfo()
        {
            return $"Brand : {Brand},Model : {Model}, Price : {Price}";
        }


        
        
        
        


    }
}
