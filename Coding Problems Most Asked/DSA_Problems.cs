using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems_Most_Asked
{
    public class DSA_Problems
    {
        /// <summary>
        /// Two sum by normal approach with complexity of O(n²)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSumBruteForce(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new[] { i, j };
                    }
                }
            }

            return Array.Empty<int>();
        }

        /// <summary>
        /// Find the given sum of two number in an array and return those indices
        /// </summary>
        /// <param name="num"></param>
        /// <param name="target"></param>
        public static int[] TwoSumByDictionary(int[] nums, int target)
        {
            //var map = new Dictionary<int, int>();
            var list = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                //map.TryGetValue(complement, out int index) || 
                if (list.Contains(complement))
                {
                    return new[] { nums[i], complement };
                    //return new[] { index, i };
                }
                list.Add(nums[i]);
                //map[nums[i]] = i;
            }

            return Array.Empty<int>();
        }

        /// <summary>
        /// Two sum by using 2 pointers way
        /// it reduce O(n²) → O(n)
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>

        public static int[] TwoSumByTwoPointersMethod(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                int sum = numbers[left] + numbers[right];

                if (sum == target)
                {
                    return new[] { left, right };
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return Array.Empty<int>();
        }

        /// <summary>
        /// check in a given string is a valid parenthesis
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>

        public static bool IsValidParentheses(string s)
        {
            var stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                        return false;

                    char top = stack.Pop();

                    if ((c == ')' && top != '(') ||
                        (c == ']' && top != '[') ||
                        (c == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        /// <summary>
        /// Three Sum problem(Given an integer array nums, find all unique triplets) by bruteForce
        /// Input:   nums = [-1, 0, 1, 2, -1, -4]
        /// Output:  [ [-1, -1, 2],[-1, 0, 1] ]
        /// problem with this is Time compexity is = O(n³)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> ThreeSumBruteForce(int[] nums)
        {
            var result = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            result.Add(new List<int>
                    {
                        nums[i],
                        nums[j],
                        nums[k]
                    });
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Approach 3Sum = Sort + Fix one element + Two Pointers + Skip duplicates.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> ThreeSumByTwoPointer(int[] nums)
        {
            var result = new List<IList<int>>();

            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                // Skip duplicate first numbers
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (sum == 0)
                    {
                        result.Add(new List<int>
                {
                    nums[i],
                    nums[left],
                    nums[right]
                });

                        left++;
                        right--;

                        // Skip duplicate left values
                        while (left < right && nums[left] == nums[left - 1])
                            left++;

                        // Skip duplicate right values
                        while (left < right && nums[right] == nums[right + 1])
                            right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return result;
        }


        /// <summary>
        /// Remove Duplicates problem using Two Pointers
        /// its complexity is O(n) but array should be sorted for this, unsorted array this will not work
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>

        public static int RemoveDuplicatesTwoPointers(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int slow = 0;

            for (int fast = 1; fast < nums.Length; fast++)
            {
                if (nums[fast] != nums[slow])
                {
                    slow++;
                    nums[slow] = nums[fast];
                }
            }

            return slow + 1;
        }

        /// <summary>
        /// We ca use List in case of unsorted array but complexity increase and become O(n²) due to list 
        /// will check element in the in itself
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>

        public static int RemoveDuplicatesListApproach(int[] nums)
        {
            var list = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!list.Contains(nums[i]))
                {
                    list.Add(nums[i]);
                }
            }

            return list.Count;
        }

        /// <summary>
        /// So better solution in case of unsorted array is use the hashset
        /// complexity is O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int RemoveDuplicatesByHashSet(int[] nums)
        {
            var seen = new HashSet<int>();
            int index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (seen.Add(nums[i]))
                {
                    nums[index] = nums[i];
                    index++;
                }
            }

            return index;
        }

        /// <summary>
        /// Container with most water problem
        /// for example height = [1, 8, 6, 2, 5, 4, 8, 3, 7]
        /// Output will be 49 because
        /// The two lines are: 8 and 7 at indexes 1 and 8 have the most water
        /// BruteForce approach complexity O(n²)
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public static int MaxAreaBruteForce(int[] height)
        {
            int maxArea = 0;

            for (int i = 0; i < height.Length; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    int width = j - i;

                    int containerHeight = Math.Min(height[i], height[j]);

                    int area = width * containerHeight;

                    maxArea = Math.Max(maxArea, area);
                }
            }

            return maxArea;
        }

        /// <summary>
        /// Container with most water with Two Pointer approach
        /// Complexity O(n)
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public static int MaxAreaTwoPointer(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;

            int maxArea = 0;

            while (left < right)
            {
                int width = right - left;

                int containerHeight = Math.Min(
                    height[left],
                    height[right]);

                int area = width * containerHeight;

                maxArea = Math.Max(maxArea, area);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxArea;
        }

        /// <summary>
        /// Merge array by simple approach complexity is O(n+m)
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        public static int[] MergeArray(int[] arr1, int[] arr2)
        {

            int[] arrMerged = new int[arr1.Length + arr2.Length];
            int counterIndex = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                arrMerged[counterIndex] = arr1[i];
                counterIndex++;
            }
            for (int j = 0; j < arr2.Length; j++)
            {
                arrMerged[counterIndex] = arr2[j];
                counterIndex++;
            }
            return arrMerged;
        }

        /// <summary>
        /// Merge array by two pinnter approach
        /// complexity is O(n+m)
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public static int[] MergeSortedArraysByTwoPointer(int[] nums1, int[] nums2)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            int[] result = new int[nums1.Length + nums2.Length];

            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] <= nums2[j])
                {
                    result[k] = nums1[i];
                    i++;
                }
                else
                {
                    result[k] = nums2[j];
                    j++;
                }

                k++;
            }

            // Remaining elements from nums1
            while (i < nums1.Length)
            {
                result[k] = nums1[i];
                i++;
                k++;
            }

            // Remaining elements from nums2
            while (j < nums2.Length)
            {
                result[k] = nums2[j];
                j++;
                k++;
            }

            return result;
        }

        /// <summary>
        /// Fixed-Size Sliding Window
        /// Array = [2, 1, 5, 1, 3, 2]        K = 3
        /// Output get the maximum sum of windows
        /// [2, 1, 5] → sum = 8, [1, 5, 1] → sum = 7,   [5, 1, 3] → sum = 9, [1, 3, 2] → sum = 6
        /// complexity O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int MaxSumFixSizeWindow(int[] nums, int k)
        {
            int windowSum = 0;

            // First window
            for (int i = 0; i < k; i++)
            {
                windowSum += nums[i];
            }

            int maxSum = windowSum;

            // Slide the window
            for (int i = k; i < nums.Length; i++)
            {
                windowSum = windowSum + nums[i] - nums[i - k];

                maxSum = Math.Max(maxSum, windowSum);
            }

            return maxSum;
        }

        /// <summary>
        /// Find the length of the longest subarray whose sum is less than or equal to K.
        /// For example:   nums = [2, 1, 5, 2, 3, 2]   K = 7
        /// this is example of variable size window pattern
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int LongestSubarrayVariableSize(int[] nums, int k)
        {
            int left = 0;
            int windowSum = 0;
            int maxLength = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                // Expand window
                windowSum += nums[right];

                // Shrink window while condition is invalid
                while (windowSum > k)
                {
                    windowSum -= nums[left];
                    left++;
                }

                // Current window is valid
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }

        /// <summary>
        /// Given a string, find the length of the longest substring that contains no repeated characters.
        /// input s = "abcabcbb"
        /// Possible substrings:"abc"  → length 3,"bca"  → length 3,"cab"  → length 3,"abc"  → length 3
        /// Output is 3
        /// Using two pointers to resolve this
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            int maxLength = 0;
            int start = 0;
            // Maps a character to its most recent index in the string
            Dictionary<char, int> seenCharacters = new Dictionary<char, int>();

            for (int end = 0; end < s.Length; end++)
            {
                char currentChar = s[end];

                // If the character is already seen and is inside the current window
                if (seenCharacters.ContainsKey(currentChar))
                {
                    // Move the start pointer to the right of the previous duplicate
                    start = Math.Max(start, seenCharacters[currentChar] + 1);
                }

                // Update or add the current character's index
                seenCharacters[currentChar] = end;

                // Calculate the current window size and update maxLength if it's larger
                maxLength = Math.Max(maxLength, end - start + 1);
            }

            return maxLength;
        }


        /// <summary>
        /// Given an array of strings, group the strings that are anagrams of each other.
        /// Input: ["eat", "tea", "tan", "ate", "nat", "bat"]
        /// Output:
        ///  [
        ///    ["eat", "tea", "ate"],
        ///    ["tan", "nat"],
        ///    ["bat"]
        ///  ]
        ///  complexity O(K log K)
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var map = new Dictionary<string, IList<string>>();

            foreach (string str in strs)
            {
                // Convert string to character array
                char[] chars = str.ToCharArray();

                // Sort characters
                Array.Sort(chars);

                // Convert back to string
                string key = new string(chars);

                // If key doesn't exist, create a new list
                if (!map.ContainsKey(key))
                {
                    map[key] = new List<string>();
                }

                // Add original string to the group
                map[key].Add(str);
            }

            return map.Values.ToList();
        }

        /// <summary>
        /// Top K Frequent Elements — C# Using HashMap / Dictionary
        /// Input:        nums = [1, 1, 1, 2, 2, 3]        k = 2
        /// Output:       [1,2]
        /// Given an integer array nums and an integer k, return the k elements that appear most frequently.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static List<int> TopKFrequent(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (!dict.TryGetValue(num, out int val))
                {
                    dict.Add(num, 1);
                }
                else
                {
                    dict[num]++;
                }
            }

            return dict.OrderByDescending(i => i.Value).Take(2).Select(i => i.Key).ToList();


        }

        /// <summary>
        /// Given an integer array nums and an integer k, find the total number of continuous subarrays whose sum equals k.
        /// Input int[] nums = { 1, 2, 3 };       int k = 3;
        /// Output: 2 => because The valid subarrays are [3] and [1, 2]
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int SubarraySumByHashDictionary(int[] nums, int k)
        {
            var map = new Dictionary<int, int>();

            // An empty prefix has sum 0 and occurs once
            map[0] = 1;

            int prefixSum = 0;
            int count = 0;

            foreach (int num in nums)
            {
                // Calculate the running prefix sum
                prefixSum += num;

                // Check whether a previous prefix sum
                // can form a subarray with sum k
                int required = prefixSum - k;

                if (map.TryGetValue(required, out int frequency))
                {
                    count += frequency;
                }

                // Record the current prefix sum
                if (map.ContainsKey(prefixSum))
                {
                    map[prefixSum]++;
                }
                else
                {
                    map[prefixSum] = 1;
                }
            }

            return count;
        }

        /// <summary>
        /// Given an integer array nums and an integer k, find the total number of continuous subarrays whose sum equals k.
        /// Input int[] nums = { 1, 2, 3 };       int k = 3;
        /// Output: 2 => because The valid subarrays are [3] and [1, 2]
        /// Using Sliding window approach
        /// but should be only positive numbers
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int SubarraySumBySlidingWin(int[] nums, int k)
        {
            int left = 0;
            int sum = 0;
            int count = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                sum += nums[right];

                while (sum > k)
                {
                    sum -= nums[left];
                    left++;
                }

                if (sum == k)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Given an integer array nums and an integer k, find the total number of continuous subarrays whose sum equals k.
        /// Input int[] nums = { 1, 2, 3 };       int k = 3;
        /// Output: 2 => because The valid subarrays are [3] and [1, 2]
        /// Using brute force approach
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int SubarraySumByBruteForce(int[] nums, int k)
        {
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;

                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];

                    if (sum == k)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
