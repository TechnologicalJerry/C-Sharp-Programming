using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
        }
    }
}



namespace MyApplication
{
    class Car
    {
        public string color = "red";
    }
}
