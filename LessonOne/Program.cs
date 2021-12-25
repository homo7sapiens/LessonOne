using System;

namespace LessonOne
{
    class Program
    {

        static void Main(string[] args)
        {
            var sofa1 = new Sofa
            {
                IsNew = true,
                Weight = 30.3m,
                SerialNumber = 235425,
                Color = Color.Black
            };
            var sofa2 = new Sofa
            {
                IsNew = false,
                Weight = 10.3m,
                SerialNumber = 22222,
                Color = Color.Red
            };

            Console.WriteLine("Hello World!");
        }
    }
}
