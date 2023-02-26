using _17._02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._02
{
    public class Nums
    {
        public static int[] GetEvenNumbers(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count++;
                }
            }
            int[] result = new int[count];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    result[index] = arr[i];
                    index++;
                }
            }
            return result;
        }

        public static int[] GetOddNumbers(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    count++;
                }
            }
            int[] result = new int[count];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    result[index] = arr[i];
                    index++;
                }
            }
            return result;
        }

        public static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int[] GetPrimeNumbers(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]))
                {
                    count++;
                }
            }
            int[] result = new int[count];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]))
                {
                    result[index] = arr[i];
                    index++;
                }
            }
            return result;
        }

        public static int[] GetFibonacciNumbers(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsFibonacci(arr[i]))
                {
                    count++;
                }
            }
            int[] result = new int[count];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsFibonacci(arr[i]))
                {
                    result[index] = arr[i];
                    index++;
                }
            }
            return result;
        }

        public static bool IsFibonacci(int n)
        {
            int a = 0;
            int b = 1;
            while (b < n)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return b == n;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            DateTime currentDate = DateTime.Now;
            Console.WriteLine("Текущее время: " + currentDate.ToString("hh:mm:ss tt"));
            Console.WriteLine("Текущая дата: " + currentDate.ToString("dd.MM.yyyy"));
            Console.WriteLine("День недели: " + currentDate.ToString("dddd"));


            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("\nЧетные числа:");
            int[] evenNumbers = Nums.GetEvenNumbers(arr);
            foreach (int num in evenNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Нечетные числа:");
            int[] oddNumbers = Nums.GetOddNumbers(arr);
            foreach (int num in oddNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Простые числа:");
            int[] primeNumbers = Nums.GetPrimeNumbers(arr);
            foreach (int num in primeNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Числа Фибоначчи:");
            int[] fibonacciNumbers = Nums.GetFibonacciNumbers(arr);
            foreach (int num in fibonacciNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
