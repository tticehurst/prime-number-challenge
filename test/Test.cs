using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using challenge_primenum;
using System.Linq;

namespace test
{

  

    [TestClass]
    public class IsPrime
    {
        readonly int[] seedPrimes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };


        [TestMethod]
        public void IsPrimePositiveTo100()
        {
            for(int t=0; t<=100; t++)
            {
                bool result = Program.IsPrime(t);
                bool expected = seedPrimes.Contains(t);
                Assert.AreEqual(expected, result, t.ToString());
            }
        }

        [TestMethod]
        public void isPrimeNegativeTo100()
        {
            for(int t=0; t>=-100; t--)
            {
                bool result = Program.IsPrime(t);
                bool expected = false;
                Assert.AreEqual(expected, result, t.ToString());

            }
        }
      

    }


    [TestClass]
    public class GetClosestPrime
    {
        [TestMethod]
        public void ClosestTheSame()
        {
            Assert.AreEqual(5, Program.GetClosestPrime(5));
        }

        [TestMethod]
        public void ClosestZero()
        {
            Assert.AreEqual(2, Program.GetClosestPrime(0));
        }

        [TestMethod]
        public void ClosesDown()
        {
            Assert.AreEqual(7, Program.GetClosestPrime(8));
        }

        [TestMethod]
        public void ClosesUp()
        {
            Assert.AreEqual(11, Program.GetClosestPrime(10));
        }

    }
}
