using Microsoft.VisualStudio.TestTools.UnitTesting;
using InstructorUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructorUI.Tests
{
    [TestClass()]
    public class InstructorTests
    {
        

        
        

        [TestMethod()]
        public void CheckSkillTest()
        {
            string temp = "java";
            Instructor inst = new Instructor();
            bool received = inst.CheckSkill(temp);
            bool expected = false;
            Assert.AreEqual(received, expected);
        }

        [TestMethod()]
        public void ValidateEligibilityTest()
        {
            
        }
    }
}