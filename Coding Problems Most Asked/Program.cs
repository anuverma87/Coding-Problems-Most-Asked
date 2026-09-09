

using System.Data;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        string stringForReverse = "ankit";
        Console.WriteLine("---------------------");
       Console.WriteLine(ReverseString(stringForReverse));
        Console.WriteLine("---------------------");
        Console.WriteLine(ReverseString2(stringForReverse));

        Console.WriteLine("---------------------");
        string stringForPalindrome = "madam";
        Console.WriteLine(Palindrome(stringForPalindrome));
        Console.WriteLine("---------------------");
        string stringForOrderReverse = "hi ankit how are you";

        Console.WriteLine(ReverseStringOrder(stringForOrderReverse));
        Console.WriteLine("---------------------");
        Console.WriteLine(ReverseEachWordOfString(stringForOrderReverse));
        Console.WriteLine("---------------------");
        Console.WriteLine(CountEachCharInString("hello world"));
        Console.WriteLine("---------------------");

        Console.WriteLine(RemoveDuplicateChars("hello"));
        Console.WriteLine("---------------------");

        Console.WriteLine(stringAllSubstring("abcd"));
        Console.WriteLine("---------------------");


        int[] arr = [1, 2, 3, 4, 5];
        RotateLeft(arr);
        Console.WriteLine("---------------------");
        Console.WriteLine(findPrimeNumber(17));
        Console.WriteLine("---------------------");
        Console.WriteLine(getSumOfAllDigits(168));
        Console.WriteLine("---------------------");
        int[] arrNum = [1, 4, 2, 5, 3, 7];
        largestNumberInArray(arrNum, 2);
        Console.WriteLine("---------------------");

        FindKthLargest(arrNum, 2);
        int[] arrDuplicate = { 10, 7, 5, 9, 1, 5,7 };
        Console.WriteLine("---------------------");
        findDuplicateInArray(arrDuplicate);
        Console.WriteLine("---------------------");

        FindAngleinTime(9, 30);
        Console.WriteLine("---------------------");

        BubbleSort(arrNum);
        Console.WriteLine("---------------------");
        Console.WriteLine("");
       int[] arrQuick = { 10, 7, 8, 9, 1, 5 };


        Console.WriteLine("Sorted Arry using quick sort is:");

        QuickSort(arrQuick, 0, arrQuick.Length - 1); 
        
        Console.WriteLine(string.Join(" ", arrQuick));
        Console.WriteLine("---------------------");
        // ToDo: Linear and Binary search

        Console.ReadKey();
    }

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

    /// perform Left circular rotation of an array
    /// like input: 1 2 3 4 5, output: 2 3 4 5 1
    /// 

    public static void RotateLeft(int[] arr)
    {
        int size = arr.Length;
        int temp;
        for (int j = size - 1; j > 0; j--)
        {
            temp = arr[size - 1];
            arr[size - 1] = arr[j - 1];
            arr[j - 1] = temp;
        }

        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }

    /// positive integer is a prime number or not
    /// input: 20, output: Not Prime ,input: 17, output: Prime

    public static string findPrimeNumber(int num)
    {

        bool isPrime = true;
        string res;
        if (num <= 1) isPrime = false;

        for (int i = 2; i * i < num; i++)
        {
            if (num % i == 0) isPrime = false;
        }

        if (isPrime) res = "Prime";
        else res = "Not prime";

        return res;
    }


    ///  sum of digits of a positive integer
    ///  input: 168, output: 15
    ///  

    public static int getSumOfAllDigits(int number)
    {
        // first approach
        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            number = number / 10;
        }
        return sum;

        // second approach

        //string str=Convert.ToString(number);
        //int sum = 0;
        //for (int i = 0; i < str.Length; i++) {
        //    sum +=Convert.ToInt32(str[i]-'0');
        //}
        //return sum;
    }

    /// find second largest integer in an array 
    /// like input: 3 2 1 5 4, output: 4
    /// 

    public static void largestNumberInArray(int[] arr, int pos)
    {


        int n1 = arr[0];
        int n2 = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > n1)
            {
                n2 = n1;
                n1 = arr[i];

            }
            else if (arr[i] > n2)
            {
                n2 = arr[i];
            }
        }
        Console.WriteLine($"1st and 2nd largest value is:{n1} and {n2}");

    }

    public static void FindKthLargest(int[] arr, int k)
    {
        int[] largest = new int[k];

        for (int i = 0; i < k; i++)
        {
            largest[i] = int.MinValue;
        }

        foreach (int number in arr)
        {
            // Find where this number belongs
            for (int i = 0; i < k; i++)
            {
                if (number > largest[i])
                {
                    // Shift smaller values to the right
                    for (int j = k - 1; j > i; j--)
                    {
                        largest[j] = largest[j - 1];
                    }

                    largest[i] = number;
                    break;
                }
            }
        }

        Console.WriteLine(largest[k - 1]);
    }

    /// <summary>
    ///  get the duplicate numbers in an array
    /// </summary>
    /// <param name="arr"></param>
    public static void findDuplicateInArray(int[] arr) {
        //// without using any function

        Dictionary<int, int> duplicate = new Dictionary<int, int>();

        int count = 0;
        foreach (int number in arr)
        {
            if (!duplicate.ContainsKey(number))
            {
                duplicate.Add(number, 1);
            }
            else
            {
                duplicate[number]++;
            }
        }

        foreach (var item in duplicate)
        {
            if (item.Value > 1)
            {
                Console.WriteLine($"Duplicate: {item.Key}, Count: {item.Value}");
            }
        }

        //// by using linq
        //var duplicate= arr.GroupBy(i => i).Where(x => x.Count() > 1).Select(x => x.Key);
        //Console.WriteLine("Duplicate number in array are:");
        //foreach (int i in duplicate)
        //{
        //    Console.Write($"{i},"); 
        //}
        //Console.WriteLine("");


    }


    ///find the angle between hour and minute hands of a clock at any given time
    /// input: 9 30, output: The angle between hour hand and minute hand is 105 degrees
    /// 

    public static void FindAngleinTime(int hours, int mins)
    {
        double hourDegrees = (hours * 30) + (mins * 30.0 / 60);
        double minuteDegrees = mins * 6;

        double diff = Math.Abs(hourDegrees - minuteDegrees);

        if (diff > 180)
        {
            diff = 360 - diff;
        }

        Console.WriteLine("The angle between hour hand and minute hand is {0} degrees", diff);
    }

    /// <summary>
    /// Bubble Sorting Complexity O(n²)
    /// </summary>
    /// <param name="arr"></param>
    public static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            bool swapped = false;

            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;

                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }
        Console.WriteLine("Sorted array is:");
        foreach (int i in arr) {           
            Console.Write($"{i}, ");
        }
    }

    /// <summary>
    /// quick sorting complexity o(nlogn)
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="low"></param>
    /// <param name="high"></param>
    public static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);

            // Sort left side
            QuickSort(arr, low, pivotIndex - 1);

            // Sort right side
            QuickSort(arr, pivotIndex + 1, high);
        }
    }

    public static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];

        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;

                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        // Put pivot in its correct position
        int temp2 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp2;

        return i + 1;
    }

}