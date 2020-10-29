using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Customer
    {
        int customerid,age;
        string name,city,phone;
        internal Customer()
        {
            Console.WriteLine("default");
        }
        internal Customer(int customerid,string name,int age,string phone,string city)
        {
            this.customerid = customerid;
            this.name = name;
            this.age = age;
            this.phone = phone;
            this.city = city;
        }
        internal void DisplayCustomer()
        {
            Console.WriteLine("the customerid is {0}, name is {1}, age is {2}, phone number is {3} and city {4}", customerid,name,age,phone,city);
        }
    }
    class CustomerDetails
    {
        static void Main()
        {
            Customer cd = new Customer();
            Customer cd1 = new Customer(101,"Fawad",22,"985674312","Kolkata");
            cd1.DisplayCustomer();
            Console.Read();
        }
    }
}
