using System;

namespace ChkPalundrome
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ChkPalindrome("racecar");
        }
        public static void ChkPalindrome(string str)
        {
            bool flag = false;
            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }

                else
                    flag = true;
            }
            if (flag)
            {
                Console.WriteLine("Palindrome");
            }
            else
                Console.WriteLine("Not Palindrome");
        }
    }
}
            
