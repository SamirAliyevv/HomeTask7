using System;

namespace HomeTask7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook[] notebooks = new Notebook[2];
            for (int i = 0; i < notebooks.Length; i++)
            {
                Console.WriteLine("Enter Brand");
                string brand=Console.ReadLine();
                Console.WriteLine("Enter Model");
                string model=Console.ReadLine();
                Console.WriteLine("Enter price");
                string  pricestr = Console.ReadLine();
                double price=Convert.ToDouble(pricestr);

                Notebook lp=new Notebook(brand,model,price);
                notebooks[i] = lp;
            }
              double sum = 0;
            for (int i = 0; i < notebooks.Length; i++)
            {
                sum += notebooks[i].Price;

            }
              double average=sum/notebooks.Length;
            Console.WriteLine(average);
        }
    }
}
