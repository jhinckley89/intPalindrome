using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isPalindrome(123));
            Console.WriteLine(isPalindrome(121));
            Console.WriteLine(isPalindrome(1234321));
            Console.WriteLine(isPalindrome(0));
            Console.WriteLine(isPalindrome(110011));
            Console.WriteLine(isPalindrome(120011));
        }

        public static bool isPalindrome(int input)
        {

            string sVal = input.ToString();

            if (sVal.ToString().Length <= 1)
            {
                //base case
                 return true;
            }

            if (getFirst(sVal) != getLast(sVal))
            {
                //current first and last match
                //get the midsection and call again
                return false;
            }

            return isPalindrome(getMid(sVal));

        }

        public static char getFirst(string val)
        {
            return val[0];
        }

        public static char getLast(string val)
        {
            return val[val.Length - 1];
        }

        public static int getMid(string val)
        {
            return Convert.ToInt32(val.Substring(1, val.Length-2));
        }
    }


}
