using System;

namespace mookjji
{
    class MookJji
    {
        int a = 0;
        int win, lose, draw;
        public void Random(int a)
        {
            Random rand = new Random();
            win = rand.Next(1, 4);
            do
            {
                lose = rand.Next(1, 4);
            } while (lose != win);

            do
            {
                draw = rand.Next(1, 4);
            } while (draw != win && draw != lose);
            if (a == win)
            { Console.WriteLine("승리!");}
            if (a == lose)
            { Console.WriteLine("패배!"); }
            if (a == draw)
            { Console.WriteLine("무승부!"); }


        }
      
    class Program
        {
            static void Main(string[] args)
            {
                MookJji jji = new MookJji();

                int mook = int.Parse(Console.ReadLine());
                jji.Random(mook);
               
            }
        }
    }
}
