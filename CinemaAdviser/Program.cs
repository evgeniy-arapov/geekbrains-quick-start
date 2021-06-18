using System;

namespace CinemaAdviser
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Дружище, ща я тебе расскажу как жить!");
            Console.WriteLine("Вот тя как звать?");
            string name = Console.ReadLine();
            
            Console.WriteLine("Ну здорово, " + name);
            
            Console.WriteLine("Вот тебе в каком жанре кинчики нра?");
            string genre = Console.ReadLine();
            if (genre == "комедия")
            {
                Console.WriteLine("Вооооот, можешь запалить че нить из этого:");
                Console.WriteLine("* Два с половиной человека");
                Console.WriteLine("И жизть сразу станет лучше!");
            }
            else
            {
                Console.WriteLine("Ну кажись тебе уже ничего не поможет...");
            }
            
        }
    }
}
















































































