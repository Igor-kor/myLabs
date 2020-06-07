using System;

namespace lab2graph
{
    public class graph
    {
        // матрица смежности
        public int[,] matrix;
        int N;

        // на входе матрица инцидентности, размер
        public graph(int[,] matrixInc, int n)
        {
            N = n;
            matrix = new int[N, N];
            // ПРЕОБРАЗОВАНИЕ МАТРИЦЫ ИНЦИДЕНТНОСТИ В МАТРИЦУ СМЕЖНОСТИ
            for (int j = 0; j < N; j++)
            {
                int[] temp = { 0, 0 };
                int index = 0;
                for (int i = 0; i < N; i++) if (matrixInc[i, j] == 1) temp[index++] = i;
                int f = temp[0];
                int s = temp[1];
                matrix[f, s] = 1;
                matrix[s, f] = 1;
            }
        }

        public void print()
        {
            Console.WriteLine("Матрица смежности");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }

        private void deleteNotLoop()
        {
            int[] nodes = new int[N * N];
            for (int i = 0; i < N; i++)
            {
                int count = 0;
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] == 1) count++;
                }
                if (count == 1)
                {
                    // если у вершины нет входящей и исходящей связи то удаляем ее
                    for (int j = 0; j < N; j++)
                    {
                        matrix[i, j] = 0;
                        matrix[j, i] = 0;
                    }
                    // и начинаем поиск по новой
                    deleteNotLoop();
                    return;
                }
            }
        }

        // если после удаления всех конечных вершин остались вершины то значит они связаны в цикл
        public bool findLoop()
        {
            deleteNotLoop();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }

}
