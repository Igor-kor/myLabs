using System;
using lab2graph;

namespace lab2
{
    class Program
    {
        // вариант 1
        // входной формат МИ – Матрица инцидентности
        // внутреннее представление МС – Матрица смежности
        //вариант 3
        // Проверка на наличие циклов в графе

        static void Main(string[] args)
        {
            int N = 10;
            int[,] matrix = GenMatrixInc(N);

            Console.WriteLine("Матрица инцидентности");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            graph mygraph = new graph(matrix,N);
            mygraph.print();
            if (mygraph.findLoop())
            {
                Console.WriteLine("В графе есть циклы");
            }
            else
            {
                Console.WriteLine("В графе циклы отсутствуют");
            }
      
        }
    
        // ГЕНЕРАЦИЯ МАТРИЦЫ ИНЦИДЕНТНОСТИ
        static int[,] GenMatrixInc(int N)
        {
            Random ran = new Random();
            int[,] matrix = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                matrix[i, i] = 0;
                int count = 0;
                for (int j = 0; j < N; j++)
                {
                    if (count == 2)
                    {
                        matrix[j, i] = 0;
                    }
                    else
                    {
                        if (i + (2 - count) + 1 == N) matrix[j, i] = 1;
                        else matrix[j, i] = ran.Next(0, 2);
                    }
                    if (matrix[j, i] == 1) count++;
                }
            }
            return matrix;
        }

    }
}
