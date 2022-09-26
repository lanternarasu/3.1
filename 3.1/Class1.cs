using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    internal class Class1
    {
        protected string customer_id;
        protected string customer_name,customer_city,customer_mobile,customer_occupation;
        protected void get_cust_details()
        {
            Console.WriteLine("Enter customer_id , Customer_name , Customer_city , Customer_mobile , Customer_occupation :");
            customer_id = Console.ReadLine();
            customer_name = Console.ReadLine();
            customer_city = Console.ReadLine();
            customer_mobile = Console.ReadLine();
            customer_occupation = Console.ReadLine();
        }
    }
}
