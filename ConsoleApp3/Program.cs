/*
Добавьте к первому заданию реализацию интерфейса IDisposable.
Добавьте ко второй задаче реализацию деструктора. Напишите
код для тестирования новых возможностей
 */

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> actors = new List<string> { "Актер 1", "Актер 2", "Актер 3" };
            Performance performance1 = new Performance("Ромео и Джульетта", "Национальный театр", "Драма", 120, actors);

            Console.WriteLine(performance1);
            performance1.Dispose();

        }
    }
}
