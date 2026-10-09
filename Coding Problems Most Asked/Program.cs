

using Coding_Problems_Most_Asked;
using System.Collections.Specialized;
using System.Data;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        DSA_Problems dsa = new DSA_Problems();
        string stringForReverse = "ankit";
        Console.WriteLine("---------------------");
        Console.WriteLine(String_Problems.ReverseString(stringForReverse));
        Console.WriteLine("---------------------");
        Console.WriteLine(String_Problems.ReverseString2(stringForReverse));

        Console.WriteLine("---------------------");
        string stringForPalindrome = "madam";
        Console.WriteLine(String_Problems.Palindrome(stringForPalindrome));
        Console.WriteLine("---------------------");
        string stringForOrderReverse = "hi ankit how are you";

        Console.WriteLine(String_Problems.ReverseStringOrder(stringForOrderReverse));
        Console.WriteLine("---------------------");
        Console.WriteLine(String_Problems.ReverseEachWordOfString(stringForOrderReverse));
        Console.WriteLine("---------------------");
        Console.WriteLine(String_Problems.CountEachCharInString("hello world"));
        Console.WriteLine("---------------------");

        Console.WriteLine(String_Problems.RemoveDuplicateChars("hello"));
        Console.WriteLine("---------------------");

        Console.WriteLine(String_Problems.stringAllSubstring("abcd"));
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
        int[] arrDuplicate = { 10, 7, 5, 9, 1, 5, 7 };
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


        Console.WriteLine("---------------------");
        Console.WriteLine("Check if a valid parenthesis exist or not");
        Console.WriteLine(DSA_Problems.IsValidParentheses("{{}}"));

        Console.WriteLine("----------Two Sum by Brute force method-----------");
        int[] twosumArrByBF = DSA_Problems.TwoSumBruteForce(arrQuick, 11);
        foreach (int twosum in twosumArrByBF) Console.WriteLine(twosum);

        Console.WriteLine("----------Two SUmmby 2 Pointer method-----------");
        int[] twosumArrByPointer = DSA_Problems.TwoSumByTwoPointersMethod(arrQuick, 11);
        foreach (int twosum in twosumArrByPointer) Console.WriteLine(twosum);

        Console.WriteLine("----------Two Sum by Dictionary method-----------");
        int[] twosumArrByDict = DSA_Problems.TwoSumByDictionary(arrQuick, 11);
        foreach (int twosum in twosumArrByDict) Console.WriteLine(twosum);

        Console.WriteLine("----------Three Sum by Bruteforce method-----------");
        IList<IList<int>> threesumArrByDict = DSA_Problems.ThreeSumBruteForce(arrQuick);
        foreach (List<int> threesum in threesumArrByDict) Console.WriteLine(threesum);

        Console.WriteLine("----------Three Sum by two pinter method-----------");
        IList<IList<int>> threesumArrByPointer = DSA_Problems.ThreeSumByTwoPointer(arrQuick);
        foreach (List<int> threesum in threesumArrByPointer) Console.WriteLine(threesum);

        Console.WriteLine("----------Remove duplicate and give count by two pointers-----------");
        int duplicateCount = DSA_Problems.RemoveDuplicatesTwoPointers(arrQuick);
        Console.WriteLine(duplicateCount);

        Console.WriteLine("----------Remove duplicate and give count by list approach-----------");
        int duplicateCountByList = DSA_Problems.RemoveDuplicatesListApproach(arrQuick);
        Console.WriteLine(duplicateCountByList);

        Console.WriteLine("----------Remove duplicate and give count by hash set-----------");
        int duplicateCountByhashSet = DSA_Problems.RemoveDuplicatesByHashSet(arrQuick);
        Console.WriteLine(duplicateCountByhashSet);


        Console.WriteLine("----------Water container problem with bruteforce-----------");
        int area = DSA_Problems.MaxAreaBruteForce(arrQuick);
        Console.WriteLine(area);

        Console.WriteLine("----------Water container problem with two pointer-----------");
        int areaByTwoPointer = DSA_Problems.MaxAreaTwoPointer(arrQuick);
        Console.WriteLine(areaByTwoPointer);

        Console.WriteLine("----------Merge array simple approach-----------");
        int[] mergedArr = DSA_Problems.MergeArray(arrQuick, arrDuplicate);
        foreach (var item in mergedArr)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("----------Merge array simple approach-----------");
        int[] mergedArrTwoPinter = DSA_Problems.MergeSortedArraysByTwoPointer(arrQuick, arrDuplicate);
        foreach (var item in mergedArrTwoPinter)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("----------Max Sum by variable size window-----------");
        int sum = DSA_Problems.MaxSumFixSizeWindow(arrQuick, 3);
        Console.WriteLine(sum);

        Console.WriteLine("----------Max window length by variable size window-----------");
        int size = DSA_Problems.LongestSubarrayVariableSize(arrQuick, 8);
        Console.WriteLine(size);

        Console.WriteLine("----------Given a string, find the length of the longest substring that contains no repeated characters-----------");
        int length = DSA_Problems.LengthOfLongestSubstring("abcabcbb");
        Console.WriteLine(length);

        Console.WriteLine("----------Group anargam problem of hashmap or dictioanry-----------");
        string[] arrAnargam = ["eat", "tea", "tan", "ate", "nat", "bat"];
        IList<IList<string>> anargamStrings = DSA_Problems.GroupAnagrams(arrAnargam);
        foreach (List<string> str in anargamStrings)
        {
            Console.WriteLine(" ");
            foreach (string str2 in str)
            {
                Console.Write(str2);
                Console.Write(',');
            }
        }

        int[] frequentElementArr = [1, 1, 1, 2, 2, 3, 4];
        Console.WriteLine(" ");
        Console.WriteLine("----------Tok k frequent element-----------");
        List<int> lst = DSA_Problems.TopKFrequent(frequentElementArr, 2);
        foreach (int i in lst)
        {
            Console.WriteLine(i);
        }

        int[] arrSubarr = [1, 2, 3];
        Console.WriteLine(" ");
        Console.WriteLine("----------total number of continuous subarrays whose sum equals k-by dictionary----------");
        int sumSubArr = DSA_Problems.SubarraySumByHashDictionary(arrSubarr, 3);
        Console.WriteLine(sumSubArr);

        Console.WriteLine(" ");
        Console.WriteLine("----------total number of continuous subarrays whose sum equals k---by sliding window--------");
        sumSubArr = DSA_Problems.SubarraySumBySlidingWin(arrSubarr, 3);
        Console.WriteLine(sumSubArr);

        Console.WriteLine(" ");
        Console.WriteLine("----------total number of continuous subarrays whose sum equals k-----by brute force------");
        sumSubArr = DSA_Problems.SubarraySumByBruteForce(arrSubarr, 3);
        Console.WriteLine(sumSubArr);






        Console.ReadKey();
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
    public static void findDuplicateInArray(int[] arr)
    {
        //// without using any function

        Dictionary<int, int> duplicate = new Dictionary<int, int>();

        //int count = 0;
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
        foreach (int i in arr)
        {
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