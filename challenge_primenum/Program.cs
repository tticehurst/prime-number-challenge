using System;
using System.Collections.Generic;

namespace challenge_primenum {
    class Program {
        static bool IsPrime(int num) {
            char[] charArray = Convert.ToString(num).ToCharArray();

            if (num == 2 || num == 3) return true;
            if (num <= 1 || num % 2 == 0 || num % 3 == 0 || (num > 5 && charArray[^1] == '5')) return false;


            return true;
        }

        static int IntInput(string message) {
            try {
                Console.WriteLine(message);

                return Convert.ToInt32(Console.ReadLine()); ;
            } catch {
                Console.WriteLine("Your input was not a number");

                return IntInput(message); ;
            }
        }

        static int GetClosestPrime(int num) {
            bool prime = false;
            int returnValue = 0;

            int newNumUp = num;
            int newNumLow = num;

            while (!prime) {
                int newNumUpper = newNumUp++;
                int newNumLower = newNumLow--;

                if (IsPrime(newNumUpper)) {
                    returnValue = newNumUpper;
                    prime = true;
                } else if (newNumLower > 0 && IsPrime(newNumLower)) {
                    returnValue = newNumLower;
                    prime = true;
                }
            }

            return returnValue;
        }

        static void Main(string[] args) {
            int yourPrime = IntInput("Please input a number to test");
            bool isPrime = IsPrime(yourPrime);
            List<int> factors = new List<int>();

            for (int i = 1; i < 100 + 1; i++) if (yourPrime % i == 0) factors.Add(i);

            Console.WriteLine($"{(isPrime ? "Your number is prime" : "Your number is not prime")}\nFactors of {yourPrime}: {string.Join(", ", factors)}\nClosest prime: {GetClosestPrime(yourPrime)}");
        }
    }
}
