using System.Runtime.CompilerServices;

namespace MyFirstProgram
    {
        class Program
        {
        static void Main(string[] args)
        {
            //return = return data back to the place a method is invoked

            double x;
            double y;
            double result;

            Console.WriteLine("enter in number 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter in number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);
            //kene pass dua matching argument ke parameter kat method tu
            //sebab kene pass kite dah setup parameter awal awal x,y

            Console.WriteLine(result);

            Console.ReadKey();
       
        }
        static double Multiply(double x, double y)
            //biasa static "void" tapi tgok type var return apa utk ni double
            //multiply di ats name method
        {
            double z = x * y;
            return z;
        }
        }
    }





   
