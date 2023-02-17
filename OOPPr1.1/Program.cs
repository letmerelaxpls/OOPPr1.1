using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPr1._1
{
    internal class Program
    {
        public delegate int Delegat(int x, int y);
        static void Main(string[] args)
        {
            Console.WriteLine("Choose one from: +,-,*,/");
            string d = Console.ReadLine();
            Console.WriteLine("First number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number");
            int b = Convert.ToInt32(Console.ReadLine());
            switch (d)
            {
                case "+":
                    Delegat delegat = (x, y) => x + y;
                    int deleg = delegat(a, b);
                    Console.WriteLine("Result: {0}", deleg);
                    break;
                case "-":
                    Delegat delegat1 = (x, y) => x - y;
                    int deleg1 = delegat1(a, b);
                    Console.WriteLine("Result: {0}", deleg1);
                    break;
                case "*":
                    Delegat delegat2 = (x, y) => x * y;
                    int deleg2 = delegat2(a, b);
                    Console.WriteLine("Result: {0}", deleg2);
                    break;
                case "/":
                    Delegat myDelegat3 = (x, y) => y == 0 ? 0 : x / y;
                    int deleg3 = myDelegat3(a, b);
                    Console.WriteLine("Result: {0}", deleg3);
                    break;
            }
        }
    }
}
