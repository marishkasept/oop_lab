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
        public void Test_Bezier_curve()
        {
            var curve = new Bezier_curve();
            Point2d[] result = new Point2d[6];
            Point2d[] coordinates = new Point2d[4];
            coordinates[0] = new Point2d(1, 1);
            coordinates[1] = new Point2d(2, 2);
            coordinates[2] = new Point2d(3, 1);
            coordinates[3] = new Point2d(4, 2);
            curve.Cubic_curve(coordinates, 6, result);
            var expected = new Point2d[6];
            expected[0] = new Point2d(1, 1);
            expected[1] = new Point2d(1.6, 1.392);
            expected[2] = new Point2d(2.2, 1.496);
            expected[3] = new Point2d(2.8, 1.504);
            expected[4] = new Point2d(3.4, 1.608);
            expected[5] = new Point2d(4, 2);
            for (var i = 0; i < 6; i++)
            {
                Assert.IsTrue(Point2d.Abs(expected[i] - result[i]) < 0.0001d);
            }
        }

        [Test]
        public void Test_Binomial_coef()
        {
            var result = Bezier_curve.get_binom_coef(1);
            double expected = 3;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_Bernstein()
        {
            var result = Bezier_curve.get_Bernstein(0, 0.4);
            var expected = 0.216;
            Assert.IsTrue(Math.Abs(expected - result) < 0.0001d);
        }

        [Test]
        public void Test_factorial()
        {
            var result = Bezier_curve.get_factorial(3);
            var expected = 6;
            Assert.AreEqual(expected, result);
        }
    }
}
