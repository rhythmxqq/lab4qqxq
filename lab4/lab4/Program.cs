using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    struct Student
    {
        public string Name;
        public string Familia;
        public string FatherName;
        public int Number;
        public int[] ot4enki = new int[5];
        public int MidOt4enki;

        public Student()
        {

        }
        public int Midl()
        {
            int i = 0;
            for (int x = 0; x < 5; x++)
            {
                i = i + ot4enki[x];
            }
            i = i / 5;
            return i;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            Random ran = new Random();
            string[] Familia = { "qq", "xxx", "zxc", "stas", "vasya" };
            string[] Name = { "a", "b", "c", "d", "f" };

            Student[] Students = new Student[10];
            for (int y = 0; y < 10; y++)
            {
                Students[y] = new Student();
            }

            for (int y = 0; y < 10; y++)
            {
                Students[y].Name = Familia[ran.Next(0, 4)];
                Students[y].Familia = Name[ran.Next(0, 4)];
                Students[y].FatherName = Name[ran.Next(0, 4)];
                Students[y].Number = ran.Next(0, 4);
                for (int t = 0; t < 5; t++)
                {
                    Students[y].ot4enki[t] = ran.Next(2, 6);

                }
                Students[y].MidOt4enki = Students[y].Midl();
            }

            Console.WriteLine("Чтобы вывести всех учеников нажмите F1");
            ConsoleKey key = Console.ReadKey().Key;

            if (key == ConsoleKey.F1)

            {
                for (int y = 0; y < 10; y++)
                {
                    Console.WriteLine("Имя " + Students[y].Name + " " + Students[y].Familia + "." + Students[y].FatherName);
                    Console.WriteLine("Оценки:\nМатематика:{0} \nЯзык:{1} \nЛитература:{2} \nИстория:{3} \nГеография:{4}", Students[y].ot4enki[0], Students[y].ot4enki[1], Students[y].ot4enki[2], Students[y].ot4enki[3], Students[y].ot4enki[4]);
                    Console.WriteLine("Средний балл:" + Students[y].MidOt4enki);
                    Console.WriteLine("Номер группы:" + Students[y].Number);
                    Console.WriteLine("");
                }

                Console.ReadLine();
            }

            if (Console.ReadKey().Key == ConsoleKey.F2)
            {
                for (int u = 0; u < 10; u++)
                {
                    if (Students[u].MidOt4enki >= 4)
                    {
                        Console.WriteLine("Имя " + Students[u].Name + " " + Students[u].Familia + "." + Students[u].FatherName);
                        Console.WriteLine("оценки:\nМатематика:{0} \nЯзык:{1} \nЛитература:{2} \nИстория:{3} \nГеография:{4}", Students[u].ot4enki[0], Students[u].ot4enki[1], Students[u].ot4enki[2], Students[u].ot4enki[3], Students[u].ot4enki[4]);
                        Console.WriteLine("Средний балл:" + Students[u].MidOt4enki);
                        Console.WriteLine("Номер группы:" + Students[u].Number);
                        Console.WriteLine("");
                    }
                }
                Console.ReadLine();
            }
        }
    }
}