using System;
using System.Linq;

namespace YandexCup_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split(' ');

            int count = int.Parse(first[0]);
            int period = int.Parse(first[1]);
            int count_wakeup = int.Parse(first[2]);
            int[] mas = new int[count];
            int res = 0;
           
            string[] second = Console.ReadLine().Split(' ');

            for (int i = 0; i < count; i++)
            {
                mas[i] = int.Parse(second[i]);                
            }

            mas = mas.OrderBy(x => x).ToArray();

            int p = 0;
            int c = 1;

            if (count >= count_wakeup)
            {
               foreach (int i in mas)
               {
                  p++;
                  if (p == count_wakeup)
                  {
                      res = i;
                  }
                        
               }
               
            }
            else
            {
                p = count - 1;
                while (p != count_wakeup)
                {
                    foreach (int i in mas)
                    {
                        
                        res = i + (c*period);
                        p++;
                        if (p == count_wakeup)
                        {
                            break;
                        }
                    }
                    c++;

                }
                
            }




            Console.WriteLine(res);
            Console.ReadLine();

        }
    }
}
