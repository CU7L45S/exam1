using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    internal class Teacher : participant
    {
        private string teacherRankPosition;
        private bool teacherCarOrNot;
        private string teacherCarlicense;

        public Teacher(string namePrefix, string name, string lastName, string age, string religion, string allergy,string teacherRankPosition):base(namePrefix, name, lastName, age, religion, allergy)
        {
            this.teacherRankPosition = teacherRankPosition;

        }
        private Teacher(bool teacherCarOrNot, string teacherCarlicense)
        {
            
            this.teacherCarOrNot = teacherCarOrNot;
            this.teacherCarlicense = teacherCarlicense;
        }
    }
}
