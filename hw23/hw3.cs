using System;

namespace hw2
{
    class Program
    {
        private static void Main()
        {
            int num = 35;
            Square(ref num);
            Console.WriteLine(num);
        }
        static int Square(ref int num)
        {
            int pow = 0;
            for (int i = 1; i * i <= num; i++)
            {
                pow++;
            }
            num = pow;
            return num;
        }
    }
}
