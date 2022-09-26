using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    internal class Class3 : Class2
    {
        private int loan_amt;
        public void  call_methods()
        {
            get_cust_details();
            get_account_details();
            Console.WriteLine("Enter loan amount: ");
            loan_amt = Convert.ToInt32(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine(customer_id);
            Console.WriteLine(customer_name);
            Console.WriteLine(customer_city);
            Console.WriteLine(customer_mobile);
            Console.WriteLine(customer_occupation);
            display_2();
            Console.WriteLine(loan_amt);
        }
    }
}
