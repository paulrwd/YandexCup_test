using System;
using System.Collections.Generic;
using System.Text;

namespace YandexCup_test
{
    class Random_for_test
    {
        public static int Number1_100()
        {
            Random rnd = new Random();
            int i = rnd.Next(1,100);
            return i;
        }

        public static int Number0_100()
        {
            Random rnd = new Random();
            int i = rnd.Next(0, 100);
            return i;
        }

        public static int Number1_10()
        {
            Random rnd = new Random();
            int i = rnd.Next(1, 10);
            return i;
        }

        public static int Number0_10()
        {
            Random rnd = new Random();
            int i = rnd.Next(0, 10);
            return i;
        }
    }
}
