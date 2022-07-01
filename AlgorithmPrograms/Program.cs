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
            Console.WriteLine("Welcome to Prime number Program");
            primeNumbers();
            /*
            Console.WriteLine("Welcome to Merge Sort Program");

            int[] arr = { 15, 10, 11, 6, 7, 8 };
            Console.WriteLine("Given Array");
            printArray(arr);

            // Sort Array 
            sort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array");
            printArray(arr);

            Console.WriteLine("Welcome to Anagram Program");
            anagram();

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

       
        //Creating the Merge Sort Method
        public static void mergeSort(int[] arr, int l, int m, int r)
        {

            int n1 = m - l + 1;
            int n2 = r - m;


            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];


            i = 0;
            j = 0;

            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        //Sorting the Array
        public static void sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                sort(arr, l, m);
                sort(arr, m + 1, r);
                mergeSort(arr, l, m, r);
            }
        }
        //printing the array
        public static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }

         */
        public static void primeNumbers()
        {
            for (int i = 1; i <= 1000; i++)
            {
                int div = 1;
                int count = 0;
                while (div <= i)
                {
                    if (i % div == 0)
                    {
                        count++;
                    }
                    div++;
                }

                if (count == 2)
                    Console.WriteLine(i);
            }
        }
    }
}




