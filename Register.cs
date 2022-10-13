using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Exam1
{
    internal class Register
    {
        public Register()
        {
            
            
        }
        public void Newpaticipant()
        {
            string[] newpati = new string[100];
            for(int i = 0; i < newpati.Length; i++)
            {
                Register regis = new Register();
            }
            registeration();
        }
        public void paticipating()
        {
            
        }
        public void registeration()
        {
            int regisnum = 0;
            

            Console.WriteLine("Registeration");
            Console.WriteLine("Collegian type 1");
            Console.WriteLine("Student type 2");
            Console.WriteLine("teacher type 3");
            int.TryParse(Console.ReadLine(), out regisnum);

            if(regisnum == 1)
            {
                
            }else if(regisnum == 2)
            {

            }else if(regisnum == 3)
            {

            }
        }
    }
}
