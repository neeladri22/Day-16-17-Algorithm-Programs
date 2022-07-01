using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Anagram Program");
            anagram();

            /*
            Console.WriteLine("Welcome to BubbleSort Program");
            Console.WriteLine("Please enter the length of the Array");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Please enter the array elements");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Program.BubbleSort(arr);
                        
            insertionSort();

            // String array which has different strings
            String[] arr = { "Neeladri", "Vamsi", "Mahesh", "Hema", "Laxman", "Varsha" };

            String x = "neeladri";
            int result = binarySearch(arr, x);
            if (result == -1)
            {
                Console.WriteLine("Element is not present");
            }
            else
            {
                Console.WriteLine("Element found at index : " + result);
            }

            // permutations of the string

             String str = "NEEl";
             int len = str.Length;
             Console.WriteLine("All the permutations of the string are: ");
             generatePermutation(str, 0, len);
            */
        }
        /*
        public static String swapString(String a, int i, int j)
        {
            char[] b = a.ToCharArray();
            char ch;
            ch = b[i];
            b[i] = b[j];
            b[j] = ch;
            //Converting characters from array into single string  
            return string.Join("", b);
        }

       

        //Function for generating different permutations of the string  
        public static void generatePermutation(String str, int start, int end)
        {
            //Prints the permutations  
            if (start == end - 1)
                Console.WriteLine(str);
            else
            {
                for (int i = start; i < end; i++)
                {
                    str = swapString(str, start, i);
                    generatePermutation(str, start + 1, end);
                    str = swapString(str, start, i);
                }
            }
        }  
        

        static int binarySearch(String[] arr, String x)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                int res = x.CompareTo(arr[m]);

                if (res == 0)
                {
                    return m;
                }

                if (res > 0)
                {
                    l = m + 1;
                }

                else
                {
                    r = m - 1;
                }
            }
            return -1;
        }
        
        public static void insertionSort()
        {
            int[] arr = { 10, 22, 55, 14, 33, 7 };

            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {

                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            //Display unit
            Console.WriteLine("Sorted array is: ");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

        }

        */

        public static void anagram()
        {
            //Receive Words from User  
            Console.Write("Enter first word:");
            string word1 = Console.ReadLine();
            Console.Write("Enter second word:");
            string word2 = Console.ReadLine();
 
            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();
 
            Array.Sort(char1);
            Array.Sort(char2);
            string str1 = new string(char1);
            string str2 = new string(char2);
 
            if (str1 == str2)
            {
                Console.WriteLine("Both the Words are Anagrams", word1, word2);
            }
            else
            {
                Console.WriteLine("Both the Words are not Anagrams", word1, word2);
            }
            Console.ReadLine();
        }

    }
}



