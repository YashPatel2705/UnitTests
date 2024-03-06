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
        //UnitTest2
        [Test]
        public void ValidTriangle2_Input30and70and70_OutputValidTriangle()
        {
            //Arrange
            int fAngle = 30, sAngle = 70, tAngle = 70;

            string expected = "An isosceles triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(fAngle, sAngle, tAngle);

            //Assert 
            Assert.AreEqual(expected, actual);
        }
        //UnitTest3
        [Test]
        public void ValidTriangle3_Input30and90and90_OutputValidTriangle()
        {
            //Arrange
            int fAngle = 30, sAngle = 90, tAngle = 90;

            string expected = "An isosceles triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(fAngle, sAngle, tAngle);

            //Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
