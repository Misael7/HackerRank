using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2DHR
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] hourglass = new int[6, 6];
            Random ranNum = new Random();
            int sumas = 0;
            int max = 0;

            for (int x = 0; x < hourglass.GetLength(0); x++)
            {

                for (int y = 0; y < hourglass.GetLength(1); y++)
                {
                    hourglass[x, y] = ranNum.Next(-9, 9);

                    if (x < hourglass.GetLength(0) - 3 && y < hourglass.GetLength(1) - 3)
                    {
                        sumas = hourglass[x, y] + hourglass[x + 1, y] + hourglass[x + 2, y] + hourglass[x + 1, y + 1] + hourglass[x, y + 2] + hourglass[x + 1, y + 2] + hourglass[x + 2, y + 2];
                        Console.WriteLine("Suma reloj: " + sumas);
                        if (sumas > max) { max = sumas; }
                    }

                }

            }
            Console.WriteLine("El valor máximo es: " + max);
            Console.ReadLine();
        }
    }
}