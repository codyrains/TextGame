using System;

namespace CocoTextAdventureGameOfTheYearAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            gameTitle();
           // first();
        }

        public static void gameTitle()
        {
            Console.WriteLine("Welcome to Coco's Text Adventure (Game of The Year Edition)");
            Console.WriteLine("Press 'Enter' to begin the best experience of your life.");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public static void first()
        {
            string choice;
            Console.WriteLine("You wake up in a tavern, clueless of the time, with a large man hovering over you. 'This is my table, and you're sitting in my seat!' he says, as spit flies out of his mouth and onto your cheek.");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1. Punch him right in the kisser.");
            Console.WriteLine("2. Tell him 'NO, this is my table now.'");
            Console.WriteLine("3. Challenge him to an arm wrestling match. You say 'Winner takes the table!'");
            Console.WriteLine("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();
        }

        public static void second()
        {

        }

        public static void third()
        {

        }

        public static void gameOver()
        {

        }

        public static void youWin()
        {

        }

    }
}
