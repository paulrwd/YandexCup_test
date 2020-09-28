using System;
using System.Collections.Generic;
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
            List<int> mas_repeat = new List<int>();
           
            string[] second = Console.ReadLine().Split(' ');

            for (int i = 0; i < count; i++)
            {
                mas[i] = int.Parse(second[i]);                
            }

            mas = mas.OrderBy(x => x).ToArray();

            int p = 0;
            int c = 1;
            bool marker_rep = false;

            foreach (int i in mas)
            {
                marker_rep = false;
                foreach(int j in mas_repeat)
                {
                    if(j == i)
                    {
                        marker_rep = true;
                    }
                }
                if (marker_rep == false)
                {
                    mas_repeat.Add(i);
                }
            }


            if (mas_repeat.Count >= count_wakeup)
            {
               foreach (int i in mas_repeat)
               {
                  p++;
                  if (p >= count_wakeup)
                  {
                      res = i;
                      break;
                  }                        
               }               
            }
            else
            {
                p = mas_repeat.Count;
                while (p < count_wakeup)
                {
                    foreach (int i in mas)
                    {
                        marker_rep = false;
                        res = i + (c*period);
                        
                        foreach(int j in mas_repeat)
                        {
                            if(j == res)
                            {
                                marker_rep = true;
                            }
                        }
                            if(marker_rep == false)
                        {
                            mas_repeat.Add(res);
                            p++;
                        }
                         
                        if (p >= count_wakeup)
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
