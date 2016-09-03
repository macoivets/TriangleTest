using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TriangleTest
{
    public class Mas
    {

        private int[][] Arr { get; set; }
      
        private int size { get; set; }

        public void ReadArr(string filename)
        {
            Arr=new int[size][];
            var file = new StreamReader(filename);
            for (int i = 0; i < size; i++)
            {
                var line = file.ReadLine();
                Arr[i] = line.Split(' ').Select(n => int.Parse(n)).ToArray();
            }
        }

        public void WriteArr()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < Arr[i].Length; j++)
                {
                    Console.Write(Arr[i][j]+" ");
                }
                Console.WriteLine();
            }
        }

        private int MaxOfThree(int a, int b, int c)
        {
            int max = 0;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            if (c > max)
            {
                return c;
            }
            else
            {
                return max;
            }


        }

        public int MaxUpper(int i, int j)
        {
            int Max =0;
            if (j == 0)
            {
                Max=MaxOfThree(0, Arr[i - 1][j], Arr[i - 1][j + 1]);
            }
            else
            {
                if (j == Arr[i].Length - 1)
                {
                    Max=Arr[i - 1][j-1];
                }
                else
                {
                    if (j == Arr[i].Length - 2)
                    {
                        Max = MaxOfThree(0, Arr[i - 1][j], Arr[i - 1][j - 1]);
                    }
                    else
                    {
                        Max = MaxOfThree(Arr[i - 1][j - 1], Arr[i - 1][j], Arr[i - 1][j + 1]);
                    }
                    
                }
            }

            return Max;
        }

        public int FindPath()
        {
            Arr[1][0] += Arr[0][0];
            Arr[1][1] += Arr[0][0];

            for (int i = 2; i < size; i++)
            {
                for (int j = 0; j < Arr[i].Length; j++)
                {
                    Arr[i][j] += MaxUpper(i, j);
                }
                
            }

            return Arr[size-1].Max();
        }



        public Mas(int s)
        {
            size = s;
        }

    }
}
