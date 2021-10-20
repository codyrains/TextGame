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
            Console.WriteLine("2. Blow his mind with a magic display.'");
            Console.WriteLine("3. Pee a little bit.'");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "punch him right in the kisser":
                case "punch him":
                case "punch":
                    {
                        Console.WriteLine("You swing your fist at the drunkards face with a left hook that would even impress the likes of the great Sir Muhammad Ali himself!");
                        Console.WriteLine("The rest of the crowd in the tavern pause in silence for a moment, until you are surprised with a roar of cheering! Those cheers are shortly followed up with a few brawls spread out through the tavern. Looks like you know how to get the people going!");
                        Console.WriteLine("The Barkeep of the tavern comes over to investigate the source of the original dispute.");
                        Console.WriteLine("When he sees the man knocked out cold, he grabs your hand, and raises it to the ceiling!");
                        Console.WriteLine("You are offered free drinks for the rest of the night, and decide to take the barkeep up on his offer.");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        gameOver();
                        break;
                    }
                case "2":
                case "blow his mind with magic":
                case "magic":
                    {
                        Console.WriteLine("You snap your fingers, creating a small burst of flame that sprouts from the tip of whatever finger you wish.");
                        Console.WriteLine("The man looks at you in awe, and says 'Oooooo' followed with an 'Ahhhhhhh'. Looks like he has never seen anything like this before.");
                        Console.WriteLine("'Can you teach me how to do that?' he asks.");
                        Console.WriteLine("You respond with a strong 'No' without breaking eye contact.");
                        Console.WriteLine("The mans face immediately sours up, as he walks away mumbling profanity under his breath.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        second();
                        break;
                    }
            }
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
