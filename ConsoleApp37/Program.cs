/*
Учитывая 2 строки aи b, верните строку вида
short+long+short, где более короткая строка находится 
снаружи, а более длинная — внутри. Строки не будут 
одинаковой длины, но могут быть пустыми ( zerolength ).
Подсказка для пользователей R:
Длина строки не всегда совпадает с количеством символов.
Например: (Ввод1, Ввод2) --> вывод

("1", "22") --> "1221"
("22", "1") --> "1221"
 
Создайте функцию, которая принимает строку и один
символ и возвращает целое число вхождений второго аргумента 
в первый.

Если вхождений не обнаружено, 0 должно быть возвращено 
количество.

("Hello", 'o')  =>  1
("Hello", 'l')  =>  2
("", 'z')       =>  0
 */


using System;
using System.Collections.Generic;
using System.Linq;//библиотека
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //Для работы команды WriteLine();
using System.Globalization; 
namespace ConsoleApp37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //github
            //Работа с датой и временем DateTime
            //Создали объект для хранения времени
            DateTime dateTime = new DateTime();
            WriteLine(dateTime);
            DateTime date1 = new DateTime(1991, 5, 25);//Год месяц число
            WriteLine(date1);
            //год месяц число часы минуты и секунды
            DateTime date2 = new DateTime(2008, 7, 23, 13, 52, 52);
            WriteLine(date2);
            WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
            //Создали объект с текущим временем
            DateTime date3 = DateTime.Now;
            WriteLine(date3.AddHours(3));
            //разность дат
            DateTime date4 = new DateTime(2024, 12, 31, 0, 0, 0);
            WriteLine(date4.Subtract(date3));
            //Метод AddHours дает возможность отнимать отриц.числа
            WriteLine(date3.AddHours(-4));

            WriteLine(date3.ToLongDateString());
            //Метод, который выведет время в формате часы:минуты
            WriteLine(date3.ToShortTimeString());

            //Форматирование даты
            WriteLine($"Полный формат: {date3.ToString("D")}");
            WriteLine($"Краткий формат: {date3.ToString("d")}");
            WriteLine($"Длинный формат: {date3.ToString("F")}");
            WriteLine($"Полный формат без секунд: {date3.ToString("f")}");
            WriteLine($"{date3:f}");
            WriteLine($"{date3:G}");
            WriteLine($"{date3:g}");
            WriteLine($"{date3:M}");
            WriteLine($"{date3:O}");
            WriteLine($"{date3:R}");
            WriteLine($"{date3:s}");
            WriteLine($"{date3:T}");
            WriteLine($"{date3:t}");
            WriteLine($"{date3:U}");
            WriteLine($"{date3:u}");
            WriteLine($"{date3:Y}");

            WriteLine($"день: {date3.Day}");
            WriteLine($"День недели: {date3.DayOfWeek}");
            WriteLine($"День года {date3.DayOfYear}");
            WriteLine($"Номер месяца: {date3.Month}") ;

            //Методы DateTime
            WriteLine(date3.AddMonths(1));
            //Создайте объект даты ,добавьте к дате 1 месяц и 1 час 
            //Нужно вычесть из конца текущего года вашу дату
            date3.AddMonths(1);
            date3.AddHours(1);
            WriteLine(date4.Subtract(date3));

            //Сложите две даты и результат сохраните в 3ю дату
            DateTime data = DateTime.Now;
            //DateTime data22 = new DateTime(2024, 5, 5, 12, 15, 11);
            TimeSpan timeSpan = new TimeSpan(8, 13, 17, 10, 1);
            DateTime resultDate = data + timeSpan;
            WriteLine(resultDate.ToString());

            
        }
    }
}
