using System;

namespace Lab1
{

    public class Lab1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Func1(1, 100, 20));

            int[] arr = new int[5];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                arr[i] = rnd.Next(-256,256);              
            }
            Console.WriteLine(Func2(arr));
        }

        //11 вариант Сумма членов арифметической прогрессии(рекурсия)
        public static int Func1(int start, int finish, int steps, int sum = 0)
        {
            sum += start;
            if (start + steps > finish) return sum;
            return Func1(start + steps, finish, steps, sum);
        }

        //Произведение отрицательных элементов массива
        public static int Func2(int[] arr, int index = 0, int count = 0)
        {
            if (arr.Length - 1 == index)
            {      
                if (arr[index] >= 0)
                {
                    if (count == 0) throw new ArgumentOutOfRangeException("Массив не содержит отрицательных элементов");
                    return 1;
                }
                return arr[index];
            }
            if (arr[index] < 0) return arr[index] * Func2(arr, index + 1,count+1);          
            return Func2(arr, index + 1, count);
        }
    }
}
