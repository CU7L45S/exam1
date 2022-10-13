using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    internal class idiacamp
    {
        public idiacamp()
        {
            
            
        }
        public void firstpage()
        {
            Console.WriteLine("Register type 1");
            Console.WriteLine("Login type 2");
            choose();
        }
        public void choose()
        {
            int choose = 0;
            int.TryParse(Console.ReadLine(), out choose);
            if (choose == 1)
            {
                Register rg1 = new Register();
                rg1.Newpaticipant();
            }
            else
            {

            }
        }
    }
}
