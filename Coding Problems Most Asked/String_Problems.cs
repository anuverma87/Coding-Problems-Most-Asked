using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems_Most_Asked
{
    public class String_Problems
    {
        /// String reverse
        /// 

        public static string ReverseString(string str)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            return sb.ToString();
        }

        public static string ReverseString2(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {

                charArray[i] = charArray[j];
                charArray[j] = str[i];

            }

            string reversedString = new string(charArray);
            return reversedString;

        }

        /// string is palindrome or not
        /// 

        public static bool Palindrome(string str)
        {
            bool isPalindrome = false;

            string reversed = ReverseString2(str);
            if (reversed.Equals(str))
            {
                isPalindrome = true;
            }

            return isPalindrome;
        }


        /// Reverse order of words in a string 
        /// like "Hi ankit how are you" output=> you are how ankit hi"
        /// 

        public static string ReverseStringOrder(string str)
        {
            string reverseOrder = "";

            string[] strArray = str.Split(' ');
            string temp;
            for (int i = 0, j = strArray.Length - 1; i < j; i++, j--)
            {

                temp = strArray[i];
                strArray[i] = strArray[j];
                strArray[j] = temp;
            }

            reverseOrder = string.Join(" ", strArray);

            return reverseOrder;

        }

        /// Reverse each word in a string
        /// like "hi ankit how are you" => "uoy era woh tikna ih"
        /// 

        public static string ReverseEachWordOfString(string str)
        {

            string reversed = ReverseString2((str));

            return reversed;
        }

        /// count the occurrence of each character in a string
        /// like hello world => h – 1,   e – 1, l – 3, o – 2,w – 1,r – 1,d – 1
        /// 

        public static string CountEachCharInString(string str)
        {

            // using with Dictionary

            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in str)
            {

                if (c == ' ') continue;
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount.Add(c, 1);
                }
            }
            StringBuilder sb = new StringBuilder();
            foreach (var item in charCount)
            {
                sb.Append($"{item.Key}={item.Value}, ");
            }
            return sb.ToString();


            //----------------------------
            // Using ASCII array

            //int[] count = new int[256];

            //foreach (char c in str)
            //{
            //    if (c != ' ')
            //        count[c]++;
            //}
            //for (int i = 0; i < count.Length; i++)
            //{
            //    if (count[i] > 0)
            //    {
            //        Console.Write($"{(char)i} - {count[i]}, ");
            //    }
            //}
            //return "";

            //// using Linq
            ///
            //var characterCount = str.GroupBy(c => c)
            //                      .ToDictionary(g => g.Key, g => g.Count());
            //foreach (var kvp in characterCount)
            //{
            //    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            //}
        }


        /// remove duplicate characters from a string
        /// like hello=> helo
        /// 

        public static string RemoveDuplicateChars(string str)
        {

            string fineString = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {

                if (!fineString.Contains(str[i]))
                {
                    fineString += str[i];
                }

            }

            return fineString;
        }

        /// find all possible substring of a given string
        /// like abcd , output : a ab abc abcd b bc bcd c cd d
        /// 

        public static string stringAllSubstring(string str)
        {
            StringBuilder newString = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                StringBuilder subString = new StringBuilder();

                for (int j = i; j < str.Length; j++)
                {
                    subString.Append(str[j]);
                    newString.Append(subString.ToString());
                    newString.Append(',');
                }
            }
            return newString.ToString();
        }
    }
}
