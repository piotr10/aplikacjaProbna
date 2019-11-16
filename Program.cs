using System;

namespace AplikacjaProbna
{
    class Program
    {
        static void Main(string[] args)
        {
            void MethodOne()
            {
                NewClass imie = new NewClass();

                Console.Write(imie.Method());
            }
        }
    }
}
