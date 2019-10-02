using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SQATAssignment
{
    [TestFixture]
    class UnitTestCases
    {
        [TestCase]
        public void testCase01() //testcase1 Equilateral Triangle
        {
            Assert.AreEqual("It is an Equilateral Triangle", TriangleSolver.Analyze(8,8,8));
        }
        [TestCase]
        public void testCase02() //testcase2 Equilateral Triangle
        {
            Assert.AreEqual("It is an Equilateral Triangle", TriangleSolver.Analyze(3, 3, 3));
        }
        [TestCase]
        public void testCase03() //testcase3 Isosceles Triangle
        {
            Assert.AreEqual("It is an Isosceles Triangle", TriangleSolver.Analyze(2, 2, 5));
        }
        [TestCase]
        public void testCase04() //testcase4 Isosceles Triangle
        {
            Assert.AreEqual("It is an Isosceles Triangle", TriangleSolver.Analyze(2, 3, 2));
        }
        [TestCase]
        public void testCase05() //testcase5 Scalene Triangle
        {
            Assert.AreEqual("It is a Scalene Triangle", TriangleSolver.Analyze(2, 4, 6));
        }
        [TestCase]
        public void testCase06() //testcase6 Scalene Triangle
        {
            Assert.AreEqual("It is a Scalene Triangle", TriangleSolver.Analyze(4, 8, 5));
        }
        [TestCase]
        public void testCase07() //testcase7 when not a triangle
        {
            Assert.AreEqual("Triangle cannot be formed", TriangleSolver.Analyze(0, 1, 2));
        }
        [TestCase]
        public void testCase08() //testcase8 when not a triangle
        {
            Assert.AreEqual("Triangle cannot be formed", TriangleSolver.Analyze(0, 0, 0));
        }
    }
}
