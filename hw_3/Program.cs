/*Задание 1. 
Найти в строке все возможные  вложения подстроки. (Рассматривали на уроке)

Задание 2. 
Доработать класс STUDENT, начатый на уроке. Добавить несколько разных методов для обработки полей класса
и несколько видов перегруженных операторов ( унарных, бинарных) по собственному усмотрению.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hw_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                WriteLine("Выберете действие, которое хотите произвести:\n " +
                    "1. Найти в строке все вложения подстроки; \n 2. Добавить несколько разных методов " +
                    "для обработки полей класса и несколько видов перегруженных операторов(унарных, бинарных) по " +
                    "собственному усмотрению; \n " +
                    "3. Выйти из программы.");
                string posnum = ReadLine();

                switch (posnum)
                {
                    case "1":
                        {
                            WriteLine("Найти в строке все возможные  вложения подстроки.\n " +
                                "Введите строку, в которой необходимо осуществить поиск:");
                            string str = ReadLine();
                            WriteLine("Введите искомую строку: ");
                            string searchStr = ReadLine();

                            int index = 0;
                            int cout = 0;
                            while ((index = str.IndexOf(searchStr, index)) != -1)
                            {
                                Write($"{index} ");
                                index += searchStr.Length;
                                cout++;
                            }

                            if (cout == 0)
                                WriteLine("В строке нет данной подстроки!");
                            WriteLine();
                        }

                        break;

                    case "2":
                        {
                            WriteLine("Класс Student.");
                            Student st = new Student("Ann", "Eroshina", 35, 10);
                            Student st1 = new Student("Oleg", "Eroshin", 10, 11);

                            WriteLine("Список студентов:");
                            WriteLine(st); 
                            WriteLine(st1);
                            WriteLine();
                            WriteLine($"Средний возраст студентов (через перегрузку +) {(st + st1) / 2}");
                            WriteLine();
                            WriteLine("Распечатать отсортированный список самодельным методом Sort с использованием " +
                                "перегрузки оператора < :");
                            Student.Sort(st1, st);
                            WriteLine();
                            WriteLine($"Средние баллы студентов равны? {st == st1}");
                            WriteLine($"Средние баллы студентов неравны?{st != st1}");
                            WriteLine();
                            Student.Best(st, st1);
                            WriteLine();
                        }
                        break;

                    case "3":
                        return;

                    default:
                        WriteLine("Вы выбрали несуществующий пункт меню. Выберите снова.");
                        continue;
                }
            }
        }
    }
}