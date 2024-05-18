using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите день недели от 1 до 7: ");
            byte day = Convert.ToByte(Console.ReadLine());
            if (day >= 7)
            {
                Console.WriteLine("Неверный формат дня недели");
                return;
            }
            Console.Write("Введите время в 24 формате: ");
            byte dayTime = Convert.ToByte(Console.ReadLine());

            

            Console.WriteLine(getInformation((Day)day, dayTime));
        }
        enum Day
        {
            понедельник,
            вторник,
            среда,
            четверг,
            пятница,
            суббота,
            воскресенье
        }
        enum DayTime
        {
            утро,
            обед,
            вечер,
            ночь
        }
        static string getInformation(Day day, byte dayTime)
        {
            if (dayTime >= 7 && dayTime <= 12) { return $"Сейчас {day}, {DayTime.утро}"; }
            if (dayTime >= 13 && dayTime <= 18) { return $"Сейчас {day}, {DayTime.обед}"; }
            if (dayTime >= 19 && dayTime <= 23) { return $"Сейчас {day}, {DayTime.вечер}"; }
            if (dayTime >= 24) { return "Неверный формат даты/времени"; }
            return $"Сейчас {day}, {DayTime.ночь}";
        }
    }
}
