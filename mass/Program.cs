using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace mass
{
    internal class Program
    {
        static int[] InPut()
        {
            Write("Введите размерность массива: ");
            byte n = Convert.ToByte(ReadLine());
            int[] array = new int[n];

            Random random = new Random();

            for (byte i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-5, 5);
            }
            return array;
        }

        static void Output(int[] array)
        {
            foreach(var element in array)
            {
                Write($"{element};\t");
            }
        }

        static int Count(int[] array)
        {
            int count = 0;
            foreach (var element in array)
            {
                if (element > 0)
                {
                    count++;
                }
            }
            return count;
        }
        static int Max(int[] array)
        {
            int max = 0;
            foreach(var element in array)
            {
                if (element > max)
                {
                    max = element;
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            try
            {
                int[] array = InPut();
                Output(array);
                WriteLine($"\n\nКол-во положительных элементов:{Count(array)}");
                WriteLine($"\nМаксимальный элемент массива: {Max(array)}");

            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
