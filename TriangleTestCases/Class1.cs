using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TriangleTestCases
{
    [TestFixture]
    public class TriangleTest1
    {
        //UnitTest1
        [Test]
        public void ValidTriangle1_Input50and50and50_OutputValidTriangle()
        {
            //Arrange
            int fAngle = 50, sAngle = 50, tAngle = 50;

            string expected = "An equilateral triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(fAngle, sAngle, tAngle);

            //Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
