using System;
using System.Collections.Generic;
using System.Linq;

namespace Group8_Assignment2_CT_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Question 1");
            int[] l1 = new int[] { 5, 6, 6, 9, 9, 12 };
            int target = 9;
            int[] r = TargetRange(l1, target);
            for(int i = 0; i < r.Length; i++)
            {
                Console.Write(r[i]);
            }
            Console.WriteLine();
            // Write your code to print range r here
            Console.WriteLine("Question 2");
            string s = "University of South Florida";
            string rs = StringReverse(s);
            Console.WriteLine(rs);
            Console.WriteLine("Question 3");
            int[] l2 = new int[] { 4, 5, 6, 9 };
            int sum = MinimumSum(l2);
            Console.WriteLine(sum);*/

            Console.WriteLine("Question 4");
            string s2 = "eebhhh";
            string sortedString = FreqSort(s2);
            Console.WriteLine(sortedString);
            Console.WriteLine("Question 5-Part 1");
            int[] nums1 = { 2, 1, 1, 2 };
            int[] nums2 = { 1, 1, 1 };
            int[] intersect1 = Intersect1(nums1, nums2);
            Console.WriteLine("Part 1- Intersection of two arrays is: ");
            DisplayArray(intersect1);
            Console.WriteLine("\n");
            Console.WriteLine("Question 5-Part 2");
            int[] intersect2 = Intersect2(nums1, nums2);
            Console.WriteLine("Part 2- Intersection of two arrays is: ");
            DisplayArray(intersect2);
            Console.WriteLine("\n");
            Console.WriteLine("Question 6");
            char[] arr = new char[] { 'a', 'b', 'c', 'a', 'b', 'c' };
            int k = 3;
            Console.WriteLine(ContainsDuplicate(arr, k));
            Console.WriteLine("Question 7");
            int rodLength = 15;
            int priceProduct = GoldRod(rodLength);
            Console.WriteLine(priceProduct);
            Console.WriteLine("Question 8");
            string[] userDict = new string[] { "rocky", "usf", "hello", "apple" };
            string keyword = "hhllo";
            Console.WriteLine(DictSearch(userDict, keyword));
            /*
           Console.WriteLine("Question 9");
           SolvePuzzle();*/
        }
        public static void DisplayArray(int[] a)
        {
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
        }
        public static int[] TargetRange(int[] l1, int t)
        {
            int[] targetRange = new int[2];
            try
            {
                //Write your code here;
                int element = 0;
                for (int i = 0; i < l1.Length; i++)
                {

                    if (t == l1[i])
                    {
                        targetRange[element] = i;
                        element += 1;
                    }
                }
                if (targetRange.Length == 0)
                {
                    targetRange = new int[] { -1, 1 };
                }
            }

            catch (Exception)
            {
                throw;
            }
            return targetRange;
        }
        public static string StringReverse(string s)
        {
            string reverse = "";
            try
            {
                //write your code here
                int spaces = 0;
                foreach (char i in s)
                {
                    if (i == ' ')
                    {
                        spaces += 1;
                    }
                }
                string[] strArray = new string[] { };
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (!s[i].Equals(" "))
                    {
                        reverse += s[i];
                    }
                    else
                    {
                        reverse += " ";
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return reverse;
        }
        public static int MinimumSum(int[] l2)
        {
            int sum = 0;
            try
            {
                //Write your code here;
                for (int i = 0; i < l2.Length - 1; i++)
                {
                    if (l2[i] == l2[i + 1])
                    {
                        l2[i + 1] = l2[i + 1] + 1;
                        sum += l2[i];
                    }
                    else
                    {
                        sum += l2[i];
                    }
                }
                sum += l2[l2.Length - 1];
            }
            catch (Exception)
            {
                throw;
            }
            return sum;
        }
        public static string FreqSort(string s2)
        {
            String freqSorted = "";
            try
            {
                //Write Your Code Here
                Dictionary<char, int> dictionary = new Dictionary<char, int>();
                foreach (char c in s2)
                {
                    if (dictionary.ContainsKey(c))
                    {
                        dictionary[c] += 1;
                    }
                    else
                    {
                        dictionary.Add(c, 1);
                    }
                }
                dictionary = dictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                foreach (KeyValuePair<char, int> item in dictionary)
                {
                    for (int i = 0; i < item.Value; i++)
                    {
                        freqSorted += item.Key;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return freqSorted;
        }
        public static int[] Intersect1(int[] nums1, int[] nums2)
        {
            int[] intersect = new int[] { };
            try
            {
                // Write your code here
                int len1 = nums1.Length;
                int len2 = nums2.Length;

                string intersectedValues = "";

                Array.Sort(nums1);
                Array.Sort(nums2);

                int i = 0;
                int j = 0;

                if (nums2 is null || nums2 is null)
                {
                    intersect = new int[] { };
                }

                else
                {
                    while (i < len1 && j < len2)
                    {
                        if (nums1[i] == nums2[j])
                        {
                            intersectedValues += nums1[i];
                            i++;
                            j++;
                        }
                        else if (nums1[i] < nums2[j])
                        {
                            i++;
                        }
                        else
                        {
                            j++;
                        }
                    }
                }

                intersect = new int[intersectedValues.Length];
                for (int k = 0; k < intersectedValues.Length; k++)
                {
                    intersect[k] = int.Parse(intersectedValues[k].ToString());
                }
            }
            catch
            {
                throw;
            }
            return intersect;
        }
        public static int[] Intersect2(int[] nums1, int[] nums2)
        {
            int[] intersect = new int[] { };
            try
            {
                // Write your code here
                Dictionary<int, int> dict = new Dictionary<int, int>();
                foreach (int i in nums1)
                {
                    if (dict.ContainsKey(i))
                    {
                        dict[i] += 1;
                    }
                    else
                    {
                        dict.Add(i, 1);
                    }
                }
                string intersectedValues = "";
                foreach (int i in nums2)
                {
                    if (dict.ContainsKey(i))
                    {
                        intersectedValues += i;
                        if (dict[i] > 1)
                        {
                            dict[i]--;
                        }
                        else
                        {
                            dict.Remove(i);
                        }
                    }
                }
                intersect = new int[intersectedValues.Length];
                for (int i = 0; i < intersectedValues.Length; i++)
                {
                    intersect[i] = int.Parse(intersectedValues[i].ToString());
                }
            }
            catch
            {
                throw;
            }
            return intersect;
        }

        public static bool ContainsDuplicate(char[] arr, int k)
        {
            try
            {
                //Write your code here;
                Dictionary<char, int> dict = new Dictionary<char, int>();
                for (int i = 0; i < arr.Length; i++)
                {
                    int index1 = 0;
                    //int index2 = 0;
                    int diff = 0;
                    if (dict.ContainsKey(arr[i]))
                    {
                        index1 = dict[arr[i]];
                        diff = i - index1;
                        dict.Remove(arr[i]);
                        dict.Add(arr[i], i);
                    }
                    else
                    {
                        //index1 = i;
                        dict.Add(arr[i], i);
                    }
                    if (diff > 0 && diff <= k)
                    {
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }

        public static int GoldRod(int rodLength)
        {
            try
            {
                int[] output = new int[rodLength];
                //Calculating combinations of the length, returning the maximum product
                return Combinations(1, rodLength, output, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured in GoldRod method: ", e);
            }
            return 0;
        }

        static int product = 1;
        private static int Combinations(int i, int n, int[] a, int index)
        {
            if (n == 0)
            {
                //Calculate the product of the combination
                int productnew = FindProduct(a, index);
                //If product is higher, save it
                if (productnew > product)
                    product = productnew;
            }
            //Get combinations using recursion
            for (int j = i; j <= n; j++)
            {
                a[index] = j;
                Combinations(j, n - j, a, index + 1);
            }

            //Return the highest product
            return product;
        }
        private static int FindProduct(int[] a, int n)
        {
            int s = 1;
            for (int i = 0; i < n; i++)
                s = s * a[i];
            return s;
        }
        public static bool DictSearch(string[] userDict, string keyword)
        {
            try
            {
                //Logic: If the length of string in userDict and keyword are the same
                //Calculate the number of chars that differ in the words
                //If the number of different chars for the words is 1, return true.
                foreach (string a in userDict)
                {
                    char[] userword = a.ToCharArray();
                    char[] keywordchars = keyword.ToCharArray();
                    int count = keyword.ToCharArray().Length;
                    int diffchars = 0;
                    if (count == userword.Length)
                    {
                        while (count > 0)
                        {
                            //Calculating the number of different chars in the word
                            if (keywordchars[count - 1] != userword[count - 1])
                            {
                                diffchars++;
                            }
                            count--;
                        }
                        //If diffchars is 1, then return true
                        if (diffchars == 1)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured in DictSearch method: ", e);
            }
            return false;
        }
    }
}