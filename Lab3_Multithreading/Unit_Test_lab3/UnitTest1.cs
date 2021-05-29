using NUnit.Framework;
using System;
using System.Threading;

namespace Unit_Test_lab3
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Mutex()
        {
            SingleAppInstance sai = new SingleAppInstance();
            bool flag1 = false, flag2 = false;
            Thread thread1 = new Thread(Func1);
            Thread thread2 = new Thread(Func2);
            thread1.Start();
            thread2.Start();
            void Func1()
            {
                flag1 = sai.StartMutex();
                sai.CheckoutMutex(flag1);
            }
            void Func2()
            {
                flag2 = sai.StartMutex();
                sai.CheckoutMutex(flag2);
                sai.FreeMutex();
            }
            var expected = true;
            var result = !(flag1 && flag2);
            Assert.AreEqual(expected, result);
        }
    }
}