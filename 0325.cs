using System;
using System.Threading;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool state = true;
            int x = 5, y = 5;

            /*    while (state)
                {
                    ConsoleKeyInfo info = Console.ReadKey();

                    switch (info.Key)
                    {
                        case ConsoleKey.UpArrow:
                            y--;
                            Console.Clear();
                            Console.SetCursorPosition(x, y);
                            Console.WriteLine("@");
                            break;

                        case ConsoleKey.DownArrow:
                            y++;
                            Console.Clear();
                            Console.SetCursorPosition(x, y);
                            Console.WriteLine("@");
                            break;

                        case ConsoleKey.LeftArrow:
                            x--;
                            Console.Clear();
                            Console.SetCursorPosition(x, y);
                            Console.WriteLine("@");
                            break;

                        case ConsoleKey.RightArrow:
                            x++;
                            Console.Clear();
                            Console.SetCursorPosition(x, y);
                            Console.WriteLine("@");
                            break;

                    }
                }*/
            /*int i = 0;
            while (i<10)
            {
                Console.WriteLine("출력");
                i++;
            }*///예제 10

            /*for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10-i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1 ; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }*/// 예제 11
            /*int[] num = new int[5];
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("숫자를 입력해주세요.");
                num[i] = int.Parse(Console.ReadLine());
            }
            int Max = num[0];
            int Min = num[0];

            for (int i = 1; i < 5; i++)
            {
                if (Max <= num[i])
                    Max = num[i];
            }
            for (int i = 1; i < 5; i++)
            {
                if (Min >= num[i])
                    Min = num[i];
            }

            Console.WriteLine("가장 큰 수 :" + Max);
            Console.WriteLine("가장 작은 수 : " + Min);*/

            int[] num1 = new int[1000];
            num1[0] = 1;
            num1[1] = 1;
            int total = 1;
            int opt = int.Parse(Console.ReadLine());
            int i = 0, j = 0;
            //while (num1[i] != 0)

            for (int k = 0; k < 6; k++)            {
                if(num1[i] == num1[i + 1])
                {
                    total++;
                    i++;
                }
                else
                {
                    num1[i + 1] = total;
                    num1[i + 2] = num1[i + 1];
                    num1[i+3]=
                }
                num1[j] = num1[i - 1];
                num1[j + 1] = total;
                j += 2;

            }

            for (i = 0; num1[i] != 0; i++)
            {
                Console.Write(num1[i] + " ");
            }

            #region 연습문제 13

            // 첫 번째 수열 입력
            string start = "1";

            // 계산 시작
            for (int i = 0; i < 20; i++)
            {
                // 출력
                Console.WriteLine((i + 1) + "번째: " + start);

                // 읽고 말하기 수열 계산
                string end = "";
                //말하기 수열 연속자리 비교를 위한 변수
                char number = start[0];
                //각각의 숫자 세기 위해
                int count = 0;
                for (int j = 0; j < start.Length; j++)
                {
                    //연속 숫자가 다르면 end 에 문자열 붙이고
                    //num에 다른 숫자를 대입
                    //횟수(count)는 여기서 부터 시작이므로 1 로 초기화
                    if (number != start[j])
                    {
                        end = end + number + count;
                        number = start[j];
                        count = 1;
                    }
                    else   //연속 숫자의 갯수를 센다
                    {
                        count++;
                    }
                }
                end = end + number + count;

                // 다음 단계 준비
                start = end;
            }

            #endregion
        }
    }
}
        }


    }
}


