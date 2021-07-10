using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InstructorUI
{
    class Instructor
    {
        static string[] InstructorSkill = new string[10000];
        static int Experience;
        static float AvgFeedback;

        static void Main(string[] args)
        {
        /* float avgFeedback;
         int experience;
         string instructorName;
         string[] instructorSkill = new string[Int32.MaxValue];.*/


        AvgFeedback = (float)Convert.ToDouble(Console.ReadLine());
        Experience = Convert.ToInt32(Console.ReadLine());
        string InstructorName = Console.ReadLine();
            
        int input = Convert.ToInt32(Console.ReadLine());
        for(int index = 0; index < input;index++){
            InstructorSkill[index] = Console.ReadLine();
            }
        Instructor inst = new Instructor(InstructorName, AvgFeedback, Experience, InstructorSkill);
        string technology = Console.ReadLine();
        bool hasSkill = inst.CheckSkill(technology);
            if (hasSkill)
                Console.WriteLine("Match Found");
            else
                Console.WriteLine("Match not Found");
    }

    public Instructor()
        {

        }

    Instructor(string instructorName, float avgFeedback, int experience, string[] instructorSkill)
    {
    instructorName = instructorName;
    avgFeedback = avgFeedback;
    experience = experience;
    instructorSkill = instructorSkill;
    }

    bool CheckSkill(string technology)
    {
            int pos = -1;
        for(int index = 0; index < InstructorSkill.Length; index++)
            {
                if (technology.Equals(InstructorSkill[index]))
                    pos = index;
            }
        if (pos == -1)
            return false;
        else
        {
            return ValidateEligibility();
        }
    }

    public bool ValidateEligibility()
    {
        if(Experience>3 && AvgFeedback >= 4.5)
        {
            return true;
        }
        else if(Experience<3 && AvgFeedback >= 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
}
