using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructorBL
{
    public class Instructor
    {
        private float avgFeedback;
        private int experience;
        private string instructorName;
        private string[] instructorSkill;

        public Instructor()
        {

        }

        public Instructor(string instructorName, float avgFeedback, int experience, string[] instructorSkill)
        {
            this.instructorName = instructorName;
            this.avgFeedback = avgFeedback;
            this.experience = experience;
            this.instructorSkill = instructorSkill;
        }

        static bool CheckSkill(string technology)
        {

        }

        public bool validateEligibility()
        {

        }

    }
}
