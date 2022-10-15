using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Collections;



namespace tumakoww
{
    class Prgram
    {

        static void  Main(string[] args)
        {

        }

        static void task1(string argument)
        {
            int GlasnCount = 0; int SoglasnCount = 0;

            char[] str = File.ReadAllText(argument).ToArray<char>();

            string glasn = "eyuioa";
            string sogl = "qwrtpsdfghjklzxcvbnm";

            foreach (char i in str)
            {
                if (glasn.Contains(i))
                {
                    GlasnCount++;
                }
                else if (sogl.Contains(i))
                {
                    SoglasnCount++;
                }
            }
            Console.WriteLine($"number of vowels - {GlasnCount}\nnumber of consonants - {SoglasnCount}");

        }

        //static int[,] task2(int[,] matrix1, int[,] matrix2)
        //{
        //    int str_cnt1 = matrix1.GetLength(0);
        //    int str_cnt2 = matrix2.GetLength(0);
        //    int len_cnt1 = matrix1.GetLength(1);
        //    int len_cnt2 = matrix2.GetLength(1);

        //    if (str_cnt2 == len_cnt1)
        //    {
        //        int[,] NewMatrix = new int[str_cnt1, len_cnt2];
        //        for (int p = 0; p<str_cnt1; p++)
        //        {
        //            for (int q = 0; q<len_cnt2; q++)
        //            {
        //                for (int w = 0; w< len_cnt1; w++)
        //                {
        //                    NewMatrix[p, q] += matrix1[p, w] * matrix2[q, w];
        //                }
        //            }
        //        }
        //        return NewMatrix;
        //    }
            
        //}
        static void task2(int[,] matrix)
        {
            for (int i = 0; i<matrix.GetLength(0); i++)
            {
                for (int j = 0; j<matrix.GetLength(1); j++)
                {
                    Console.WriteLine($"{matrix[i, j]}");
                }
            }
        }

        static void task3()
        {
            int[,] temperature = new int[12, 30];
            Random rnd = new Random();
            for (int i = 0; i<temperature.GetLength(0); i++)
            {
                for (int j = 0; j<temperature.GetLength(1); j++)
                {
                    temperature[i, j] = rnd.Next(-30, 30);
                }
            }

            int[] average_temperature(int[,] array)
            {
                int[] result = new int[12];
                for (int i = 0; i<12; i++)
                {
                    for (int j = 0; j<30; j++)
                    {
                        result[i] += array[i, j];
                    }
                    result[i] /= result.Length;
                }
                return result;
            }
            int[] ResultOfTask = average_temperature(temperature);
            Array.Sort(ResultOfTask);
            Console.WriteLine(string.Join("", ResultOfTask));
        }

        static void task4(string argument)
        {
            List<char> list = File.ReadAllText(argument).ToList<char>();

            int GlasnCount = 0; int SoglasnCount = 0;

            string glasn = "eyuioa";
            string sogl = "qwrtpsdfghjklzxcvbnm";

            foreach (char i in list)
            {
                if (glasn.Contains(i))
                {
                    GlasnCount++;
                }
                else if (sogl.Contains(i))
                {
                    SoglasnCount++;
                }
                Console.WriteLine($"number of vowels - {GlasnCount}\nnumber of consonants - {SoglasnCount}");
            }
        }

        static int[] task6(Dictionary<string, int[]> temp)
        {
            string[] month = { "Jan", "Fab", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            int[] temperature = new int[12];

            for (int i = 0; i<month.Length; i++)
            {
                temperature[i] = temp[month[i]].Sum() / 30;
            }
            return temperature;

        }

        static void task5(LinkedList<LinkedList<int>> matrix1, LinkedList<LinkedList<int>> matrix2, ref LinkedList<LinkedList<int>> multi)
        {
            LinkedList<int> m1 = new LinkedList<int>();
            LinkedList<int> m2 = new LinkedList<int>();
            LinkedList<int> mult = new LinkedList<int>();
            m1.AddFirst(1); m1.AddLast(2); m1.AddLast(3); m1.AddLast(4);
            m2.AddFirst(5); m2.AddLast(6); m2.AddLast(7); m2.AddLast(8);
            matrix1.AddFirst(m1);
            matrix2.AddFirst(m2);
            var a1 = m1.First; var a2 = a1.Next; var a3 = a2.Next; var a4 = a3.Next;
            var b1 = m2.First; var b2 = b1.Next; var b3 = b2.Next; var b4 = b3.Next;
            var c0 = a1.Value * b1.Value + a2.Value * b3.Value;
            var c1 = a1.Value * b2.Value + a2.Value * b4.Value;
            var c2 = a3.Value * b1.Value + a4.Value * b3.Value;
            var c3 = a3.Value * b2.Value + a4.Value * b4.Value;
            mult.AddFirst(c0); mult.AddLast(c1); mult.AddLast(c2); mult.AddLast(c3);
            multi.AddFirst(mult);
            var item = mult.First;
            int i = 0;
            Console.WriteLine("Произведение матриц:");
            while (item != null)
            {
                Console.Write(item.Value + " ");
                item = item.Next;
                i++;
                if (i == 2)
                {
                    Console.WriteLine();
                }
            }
        }

    }
}

