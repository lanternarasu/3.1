using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    internal class Class2 : Class1
    {
        private string acc_no,branch_id;
        private int balance;
        protected void get_account_details()
        {
            Console.WriteLine("Enter acc_no , branch_id , balance :");
            acc_no = Console.ReadLine();
            branch_id = Console.ReadLine();
            balance = Convert.ToInt32(Console.ReadLine());
        }
        protected void display_2()
        {
            Console.WriteLine(acc_no);
            Console.WriteLine(branch_id);
            Console.WriteLine(balance);
        }
    }
}
