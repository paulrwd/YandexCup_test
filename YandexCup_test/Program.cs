using System;

namespace YandexCup_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split(' ');

            int count = int.Parse(first[0]);
            int period = int.Parse(first[1]);
            int wakeup = int.Parse(first[2]);
            int[] mas = new int[count];
           
            string[] second = Console.ReadLine().Split(' ');

            for (int i = 0; i < count; i++)
            {
                mas[i] = int.Parse(second[i]);                
            }

          
        }
    }
}
