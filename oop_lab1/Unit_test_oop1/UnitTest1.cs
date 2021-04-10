using NUnit.Framework;
using System.IO;
using System;
using System.Linq;

namespace Unit_test_oop1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            double[] result = new double[12];
            double[] coordinates = new double[] { 1, 1, 2, 2, 3, 1, 4, 2 };
            Bezier_curve.Cubic_curve(coordinates, 6, result);
            var expected = new double[] { 1, 1, 1.6, 1.392, 2.2, 1.496, 2.8, 1.504, 3.4, 1.608, 4, 2 };
            //Assert.IsTrue(expected.SequenceEqual(result));
            for (var i = 0; i < 12; i++)
            {
                Assert.IsTrue(Math.Abs(expected[i] - result[i]) < 0.0001d);
            }
        }

        [Test]
        public void Test2()
        {
            var result = Bezier_curve.binom_coef(1);
            double expected = 3;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test3()
        {
            var result = Bezier_curve.Bernstein(0, 0.4);
            var expected = 0.216;
            Assert.IsTrue(Math.Abs(expected - result) < 0.0001d);
        }

    }
}
