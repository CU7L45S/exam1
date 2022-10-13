using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    internal class student : participant
    {
        private string studentGrade;
        private string studentSchool;

        public string StudentGrade { get => studentGrade; set => studentGrade = value; }
        public string StudentSchool { get => studentSchool; set => studentSchool = value; }
        public student(string namePrefix, string name, string lastName, string age, string religion, string allergy,string studentGrade,string studentSchool):base(namePrefix, name, lastName, age, religion, allergy)
        {
            this.studentGrade = studentGrade;
            this.studentSchool = studentSchool;
        }
    }
}
