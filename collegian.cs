using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    internal class collegian:participant
    {
        private string collegID;

        public string CollegID { get => collegID; set => collegID = value; }
        public collegian(string namePrefix, string name, string lastName, string age, string religion, string allergy, string collegID) : base(namePrefix, name, lastName, age, religion, allergy)
        {
            this.collegID = collegID;
          
        }
        public override void patiregis()
        {
            Console.WriteLine("input Name Prefix ,Mr.,Mrs.,Ms.");
            string nameprefix = Console.ReadLine();
            Console.WriteLine("input Name");
            string name = Console.ReadLine();
            Console.WriteLine("input Lastname");
            string lastName = Console.ReadLine();
            Console.WriteLine("input Age");
            string age = Console.ReadLine();
            Console.WriteLine("input Religion");
            string religion = Console.ReadLine();
            Console.WriteLine("input allergy");
            string allergy = Console.ReadLine();
            Console.WriteLine("input collegian ID");
            string collegID = Console.ReadLine();
            collegian colg1 = new collegian(nameprefix, name, lastName, age, religion, allergy,collegID);
        }
    }
}
