using System;
using System.Collections.Generic;
namespace Laba6_2
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new List<Day>()
            {
            new Day() { name = "Glek", secondname="Petrov", comment="Itsgood", nubmers= 2, day="Monday" },
             new Day() { name = "Glek", secondname = "Petrov", comment = "Itsgood", nubmers = 5, day = "Tuesday" },
             new Day() { name = "Glek", secondname = "Petrov", comment = "Itsgood", nubmers = 10, day = "Friday" },

            };

            while (true)
            {

                Console.Write("Введiть дiю" + " \n");
                Console.WriteLine("Сортувати 'A'");
                Console.WriteLine("Показати всi данi нажми 'B'");
                Console.WriteLine("Сумарна кiлькiсть вiдвiдувачiв 'C'");
                Console.WriteLine("Пошук за назвою 'D'");
                Console.WriteLine("Видалення 'Delete'");
                Console.WriteLine("Почистити конколь 'Enter'/Назад");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A:

                        new Day().A(list);


                        break;

                    case ConsoleKey.B:
                        Console.WriteLine("Name" + "\t" + "Comment" + "\t" + "SName" + "\t" + "How" + "\t" + "Day");
                        foreach (Day item in list)
                        {

                            Console.WriteLine(item.name + "\t" + item.comment + "\t" + item.secondname + "\t" + item.nubmers + "\t" + item.day);
                        }

                        break;

                    case ConsoleKey.C:

                        new Day().C(list);

                        break;


                    case ConsoleKey.Enter:


                        Console.Clear();

                        break;

                    case ConsoleKey.Escape:
                        Environment.Exit(0);

                        break;

                    case ConsoleKey.D:
                        Console.WriteLine("Введіть назву  для пошуку");
                        string s1 = Console.ReadLine();
                        var found = list.Find(item => item.name == s1);
                        Console.WriteLine("Назва =" + found.name + " " + found.secondname);
                        break;

                    case ConsoleKey.Delete:

                        Console.WriteLine("Введить номер елемента який хочете видалити");
                        int s = int.Parse(Console.ReadLine());
                        list.RemoveAt(s);
                        foreach (Exhibition el in list)
                        {
                            Console.WriteLine(el);
                        }
                        break;


                }







            }
        }
    }
}
