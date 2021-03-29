using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student() { name = "윤인성", grade = 1 });
            list.Add(new Student() { name = "윤아린", grade = 2 });
            list.Add(new Student() { name = "인성", grade = 4 });
            list.Add(new Student() { name = "윤인성", grade = 1 });
            list.Add(new Student() { name = "윤성", grade = 3 });
            list.Add(new Student() { name = "성", grade = 7 });
            list.Add(new Student() { name = "윤", grade = 1 });

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i].grade > 1)
                    list.RemoveAt(i);
            }

            foreach (var item in list)
                Console.WriteLine(item.name + " : " + item.grade);

            List<Unit> unit = new List<Unit>();
            unit.Add(new Unit()
            { name = "SCV", mineral = 50, supply = 1, attack = 5, life = 45 });

            List<Book> book = new List<Book>();

            book.Add(new Book()
            { name = "PHP 프로그래밍 입분", 
                first = "2013년 5월 20일",
                design = "여동일", 
                editor = "김이화", 
                headeditor = "김현용", 
                opener = "김태헌", 
                place = "한빛아카데미", 
                producer = "김이화", 
                writer = "김태헌" });


            Pet pet1 = new Pet() { name = "구름", age = 7 };
            Pet pet2 = new Pet() { name = "별", age = 1 };
            List<Person> person = new List<Person>();

            person.Add(new Person() { name = "윤인성", address = "서울특별시 강서구", pet = pet1.name + pet1.age + pet2.name + pet2.age });

            
            Random random = new Random();

            double a = (int)(random.NextDouble() * 100);

            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > a)
                    Console.WriteLine(num + "보다 작은 수입니다.");
                else if (num < a)
                    Console.WriteLine(num + "보다 큰 수입니다.");
                else
                {
                    Console.WriteLine("정답입니다!");
                    break;
                }

            }
            Console.WriteLine("A의 값 :" + a);
        }
    }


}
