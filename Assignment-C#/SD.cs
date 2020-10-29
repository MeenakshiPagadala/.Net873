using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Saledetails
    {
        int Salesno, Productno, Qty, price;
        float TotalAmount;
        DateTime dosale;
        internal float Sales()
        {
            TotalAmount = Qty * price;
            return TotalAmount;
        }
       
        internal Saledetails(int Salesno, int Productno, int Qty, int price, DateTime dosale )
        {
            this.Salesno = Salesno;
            this.Productno = Productno;
            this.price = price;
            this.Qty = Qty;
            this.dosale = dosale;
        }
        internal void Display()
        {
            Sales();
            Console.WriteLine("the salesno is {0}, productno is {1}, price is {2},Date of sale is {3}, Quantity is {4} and the total amount is {5}", Salesno, Productno, price, dosale, Qty, TotalAmount);
            //Console.WriteLine("the total amount is {0}", TotalAmount);
        }

    }
    class SD
    {
        static void Main()
        
        {
            Console.WriteLine("enter salesno :");
             int Salesno = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter productno:");
             int Productno = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter quantity:");
             int Qty = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter price");
             int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter date");
            DateTime dosale = Convert.ToDateTime(Console.ReadLine());
            //DateTime dosale = new DateTime(1995,4,28);
            Saledetails sd = new Saledetails(Salesno,Productno,Qty,price,dosale);
            /* DateTime dosale = new DateTime(1995, 4, 28);
             Saledetails sd = new Saledetails(101, 1001, 25, 10, dosale);
            sd.Sales(10,25);*/
            sd.Display();
            Console.Read();
        }
    }
}
