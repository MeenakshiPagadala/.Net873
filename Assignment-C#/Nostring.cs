using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Nostring
    {
        void Swap(int n1,int n2)
        {
            int c;
            c = n1;
            n1 = n2;
            n2 = c;
            Console.WriteLine("After swaping n1={0}, n2={1}", n1,n2);
        }
        void Swap(string a, string b)
        {
            string c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("After swaping a={0}, b={1}", a, b);
        }

        static void Main()
        {
            Nostring ns = new Nostring();
            Console.WriteLine("enter two numbers:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swaping n1={0},n2={1}", n1, n2);
            ns.Swap(n1,n2);
            Console.WriteLine("enter two strings:");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            Console.WriteLine("Before swaping a={0},b={1}", a, b);
            ns.Swap(a, b);
            Console.Read(); 
        }
    }
}
