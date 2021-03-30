using System;

namespace _0330
{
    class Program
    {
        class Product
        {
            public static int counter = 0;
            public int id;
            public string name;
            public int price;

            public Product(string name, int price)
            {
                Product.counter = counter + 1;
                this.id = counter;
                this.name = name;
                this.price = price;
            }
        }
        class Box
        {
            private int width;
            private int height;

            public Box(int width, int height)
            {
                if (width > 0 || height > 0)
                {
                    this.width = width;
                    this.height = height;

                }
                else
                    Console.WriteLine("자연수를 입력해주세요");
            }
            public int Area()
            {
                return this.width * this.height;
            }

            public int GetWidth() { return width; }
            public int GetHeight() { return height; }

            public void SetWidth(int width)
            {
                if (width > 0) { this.width = width; }
                else { Console.WriteLine("너비는 자연수를 입력해주세요"); }
            }
            public void SetHeight(int height)
            {
                if (height > 0) { this.height = height; }
                else { Console.WriteLine("너비는 자연수를 입력해주세요"); }
            }
        }
        static void Change(int input)
        {
            input = 20;
        }
        class Test
        {
            public int value = 10;
        }
        static void Change2(Test input)
        {
            input.value = 20;
        }

        static void Main(string[] args)
        {/*
            Multi multi = new Multi();
            Console.WriteLine(multi.Power(30));
            Console.WriteLine(multi.Gob(40, 30));

            Multi multi = new Multi();
            Console.WriteLine(multi.PlusPl(1, 100));
            Console.WriteLine(multi.GobGob(1, 10));
            Console.WriteLine(MyMath.Abs(-10));
            Console.WriteLine(MyMath.Abs(-10.213));
            Console.WriteLine(MyMath.Abs(21474836470));
            Console.WriteLine(MyMath.Abs(2147483647036));
            MyMath.
           Product productA = new Product("감자", 2000);
            Product productB = new Product("고구마", 3000);

            Console.WriteLine(productA.id + " : " + productA.name);
            Console.WriteLine(productB.id + " : " + productB.name);
            Console.WriteLine(Product.counter+ "개 생산되었습니다.");*/

            /*Box box = new Box(14, 20);
            Console.WriteLine(box.Area());
            Console.WriteLine(box.GetWidth()); 
            Console.WriteLine(box.GetHeight());
            box.SetHeight(30);
            box.SetWidth(39);
            Console.WriteLine(box.Area());*///겟터 셋터 예제 6-28
            /*
                        Box1 box = new Box1(30, 102);
                        Console.WriteLine(box.Area());
                        Console.ReadLine
                        box.Width = -300;
                        box.Height = 0;//겟터셋터 예제 6-29*/
            int a = 10;
            Change(a);
            Console.WriteLine(a);
            Test test = new Test();
            test.value = 10;
            Change2(test);
            Console.WriteLine(test.value);
        }
    }
}
