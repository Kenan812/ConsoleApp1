using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            #region Task 1
            /*
             1. Объявить одномерный (5 элементов ) массив с именем 
                A и двумерный массив (3 строки, 4 столбца) дробных 
                чисел с именем B. Заполнить одномерный массив А 
                числами, введенными с клавиатуры пользователем, 
                а двумерный массив В случайными числами с помощью циклов. Вывести на экран значения массивов: 
                массива А в одну строку, массива В — в виде матрицы. Найти в данных массивах общий максимальный 
                элемент, минимальный элемент, общую сумму всех 
                элементов, общее произведение всех элементов, сумму четных элементов массива А, сумму нечетных 
                столбцов массива В. 
             */


            /*
             double[] A = new double[5];
            double[,] B = new double[3, 4];

            Console.WriteLine("Enter A elements: ");
            for (int i = 0; i < 5; i++)
                A[i] = Double.Parse(Console.ReadLine());


            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    B[i, j] = rnd.Next(1, 11);

            Console.WriteLine();
            Console.Write("Elements of A: ");
            for (int i = 0; i < 5; i++)
                Console.Write(A[i] + " ");


            Console.WriteLine();
            Console.WriteLine("Elements of B: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(B[i,j] + " ");
                Console.WriteLine();
            }

            double sum = 0;
            double mult = 1;
            double sumA = 0;
            double sumB = 0;
            double max = 0, min = 0;

            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
                mult *= A[i];

                if (i % 2 == 0) sumA += A[i];
            }

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    sum += B[i, j];
                    mult *= B[i, j];

                    if (j % 2 == 0) sumB += B[i, j];
                }
            }


            Array.Sort(A);

            for (int i = A.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < B.GetLength(0); j++)
                {
                    for (int k = 0; k < B.GetLength(1); k++)
                    {
                        if (A[i] == B[j, k])
                        {
                            max = A[i];
                            break;
                        }
                    }
                }

            }

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.GetLength(0); j++)
                {
                    for (int k = 0; k < B.GetLength(1); k++)
                    {
                        if (A[i] == B[j, k])
                        {
                            min = A[i];
                            break;
                        }
                    }
                }

            }


            Console.WriteLine();
            Console.WriteLine($"Max element in both arrays: {max}");
            Console.WriteLine($"Min element in both arrays: {min}");
            Console.WriteLine($"Sum of all elements: {sum}");
            Console.WriteLine($"Mult of all elements: {mult}");
            Console.WriteLine($"Sum of even A: {sumA}");
            Console.WriteLine($"Sum of even columns B: {sumB}");

             */
            #endregion



            #region Task 2


            /*
             2. Даны 2 массива размерности M и N соответственно. 
                Необходимо переписать в третий массив общие элементы первых двух массивов без повторений.
             */

            /*
            const int M = 5;
            const int N = 4;

            int[] arr1 = new int[M];
            int[] arr2 = new int[N];
            int[] arr3 = new int[M + N];

            for (int i = 0; i < M; i++)
                arr1[i] = rnd.Next(1, 10);

            for (int i = 0; i < N; i++)
                arr2[i] = rnd.Next(1, 10);


            Console.Write("Array 1: ");
            for (int i = 0; i < M; i++)
                Console.Write(arr1[i] + " ");
            Console.WriteLine();
            
            Console.Write("Array 2: ");
            for (int i = 0; i < N; i++)
                Console.Write(arr2[i] + " ");
            Console.WriteLine();

            int idx = 0;
            for (int i = 0; i < M; i++)
            {
                if (Array.Find(arr2,s=>s==arr1[i]) != 0)
                {
                    if (Array.Find(arr3, s => s == arr1[i]) == 0)
                    {
                        arr3[idx] = arr1[i];
                        idx++;
                    }

                }
            }


            Console.Write("Array 3: ");
            for (int i = 0; i < idx; i++)
                Console.Write(arr3[i] + " ");
            Console.WriteLine();
             */
            #endregion



            #region Task 3


            /*
             3. Пользователь вводит строку. Проверить, является ли 
                эта строка палиндромом. Палиндромом называется 
                строка, которая одинаково читается слева направо 
                и справа налево.
             */

            /*
            Console.Write("Enter message: ");
            string s = Console.ReadLine().ToLower();
            bool isPolindrom = true;

            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    isPolindrom = false;
                    break;
                }
            }

            if (isPolindrom) Console.WriteLine("The string is polindrome");
            else Console.WriteLine("The string is not polindrom");
            */


            #endregion



            #region Task 4

            /*
             4. Подсчитать количество слов во введенном предложении. 
             */

            /*

            Console.Write("Enter sentence: ");
            string s = Console.ReadLine().ToLower();
            int count = 0; 

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == ' ' && ((int)s[i + 1] >= 97 && (int)s[i + 1] <= 122))
                {
                    count++;
                }
            }

            // to find out if the first word
            if ((int)s[0] >= 97 && (int)s[0] <= 122) count++;

            Console.WriteLine($"Number of words in sentence: {count}");
            
             
             */


            #endregion



            #region Task 5

            /*
             5. Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100. 
                Определить сумму элементов массива, расположенных 
                между минимальным и максимальным элементами
             */


            /*
            int[,] arr = new int[5, 5];
            int sum = 0;
            int max = -101;
            int min = 101;
            bool flag = false;

            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = rnd.Next(-100, 101);

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(arr[i,j] + " ");
                Console.WriteLine();
            }


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    // new max found
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                   
                    else if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
            }

            bool flag2 = true;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((arr[i, j] == max || arr[i, j] == min) && !flag)
                    {
                        flag = true;
                        continue;
                    }
                    else if ((arr[i, j] == max || arr[i, j] == min) && flag) { flag2 = false;  break; }

                    if (flag)
                    {
                        sum += arr[i, j];
                    }


                }
                if (!flag2) break;
            }

            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Sum: {sum}");

            */





                    /*  DON'T DECOMMENT */



            /*
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    // new max found
                    if (arr[i, j] > max)
                    {
                        sum = 0;
                        sumTillMin = 0;
                        max = arr[i, j];
                        min = 101;
                    }
                    else if (arr[i, j] < min)
                    {
                        sum += sumTillMin;
                        sumTillMin = 0;
                        min = arr[i,j];
                    }
                  
                    else
                    {
                        sumTillMin += arr[i, j];
                    }

                }
            }

            Console.WriteLine($"Sum: {sum}");
            */
            #endregion


        }
    }
}


