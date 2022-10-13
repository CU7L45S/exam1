using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam1
{
    internal class participant
    {
        private string namePrefix;
        private string name;
        private string lastName;
        private string age;
        private string religion;
        private string allergy;
        private bool administrator;
        private string email;
        private string password;

        //default constructor
        public participant()
        {
            Console.WriteLine("Paticipating");
        }

        public string NamePrefix { get => namePrefix; set => namePrefix = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Age { get => age; set => age = value; }
        public string Religion { get => religion; set => religion = value; }
        public string Allergy { get => allergy; set => allergy = value; }
        public bool Administrator { get => administrator; set => administrator = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        
        public participant(string namePrefix, string name, string lastName, string age, string religion, string allergy)
        {
            this.NamePrefix = namePrefix;
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
            this.Religion = religion;
            this.Allergy = allergy;
        }
        public virtual void patiregis()
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

        }
    }
}
