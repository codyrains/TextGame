using System;

namespace CocoTextAdventureGameOfTheYearAddition
{
    public class Program
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

            Console.WriteLine("You wake up in a tavern, clueless of the time, with a large man hovering over you.");
            Console.WriteLine("'This is my table, and you're sitting in my seat!' he says, as spit flies out of his mouth and onto your cheek.");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1. Punch him right in the kisser.");
            Console.WriteLine("2. Blow his mind with a magic display.");
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
                        Console.WriteLine("The rest of the crowd in the tavern pause in silence for a moment, until you are surprised with a roar of cheering!");
                        Console.WriteLine("Those cheers are shortly followed up with a few brawls spread out through the tavern. Looks like you know how to get the people going!");
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

                case "3":
                case "Pee a little":
                case "pee":
                    {
                        Console.WriteLine("You pee your pants a little, but not too much for anyone to notice");
                        Console.WriteLine("Your face begins to blush, projecting a soft pink hue.");
                        Console.WriteLine("The man yells 'Well? What are you waiting for? My Birfday's tonight and I want to get dizzy off dis ale!'");
                        Console.WriteLine("You decide to take your L, as you agree to get up and move to a different table.");
                        Console.WriteLine("As you find a new place to sit, you hear the man scream 'Oi! Why is meh seat wet?'");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        second();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I don't understand that command...");
                        Console.WriteLine("Press 'Enter' to try again.");
                        Console.ReadLine();
                        first();
                        break;
                    }
            }
        }

        public static void second()
        {
            Random rnd = new Random();
            string[] secOptions = {"On your way to find a new place to sit, you see a drunk man obnoxiously singing a song at a table. There is one extra seat across from him.",
            "On your way to find a new place to sit, you see a man in a shadowy robe at a table all by himself. There is one extra seat across from him.",
            "On your way to find a new place to sit, you see a small dwarf fiddling with his belongings. There is one extra seat across from him."};
            int randomNumber = rnd.Next(0, 3);
            string secText = secOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);
            Console.WriteLine("Do you sit at the table? Yes or No?");
            Console.WriteLine("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "yes" || secChoice == "y")
            {
                third();
            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine("You decide to leave the area to avoid anymore disruption and head upstairs to your room.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                gameOver();
            }
            else
            {
                Console.WriteLine("I don't understand that command...");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.ReadLine();
                second();
            }

        }

        public static void third()
        {
            int age;

            Console.WriteLine("You sit down at the table. Your seat is a little wobbly but it'll get the job done!");
            Console.WriteLine("They look you in the eyes as if they are surprised that someone wanted to sit with them.");
            Console.WriteLine("How old are you?");
            Console.Write("Age: ");
            int.TryParse(Console.ReadLine(), out age);

            while (age < 21)
            {
                Console.WriteLine("Uh...I'm no snitch but I'm pretty sure you need to be at least 21 to get into a tavern...");
                Console.WriteLine("How old are you? (It's a video game you can lie so we can get to the good part)");
                Console.Write("Age: ");
                int.TryParse(Console.ReadLine(), out age);
            }

            string secChoice;

            Console.WriteLine("'Fantastic!' they say. 'Would you care to have my extra drink and join me for a game of dice?' Yes or No.");
            Console.WriteLine("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "yes" || secChoice == "y")
            {
                // dice game method here
                Console.WriteLine("Excellent! We will each roll a dice and whoever rolls higher wins the round! We will play 7 total rounds. Good luck!");
                dice();
            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine("You decide to leave the area to avoid anymore disruption and head upstairs to your room.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                gameOver();
            }
            else
            {
                Console.WriteLine("I don't understand that command...");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.ReadLine();
                second();
            }
        }

        public static void dice()
        {
            int playerRandomNum;
            int randyRandomNum;

            int playerPoints = 0;
            int randyPoints = 0;

            Random random = new Random();
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Press any key to roll the dice!");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                randyRandomNum = random.Next(1, 7);
                Console.WriteLine("Randy rolled a " + randyRandomNum);

                if (playerRandomNum > randyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("You win this round...");
                }
                else if (playerRandomNum < randyRandomNum)
                {
                    randyPoints++;
                    Console.WriteLine("oooo looks like Randy gotcha this time :)");
                }
                else
                {
                    Console.WriteLine("It's a draw... Randy doesn't look too happy about that... don't look him in the eyes for too long.");
                }

                Console.WriteLine("The score is now - You : " + playerPoints + ". Randy : " + randyPoints + ".");
                Console.WriteLine();
            }

            if (playerPoints > randyPoints)
            {
                Console.WriteLine("You won against Randy!! Enjoy your sweet sweet victory!");
            }
            else if (playerPoints < randyPoints)
            {
                Console.WriteLine("Uh oh...looks like Randy won the game! He'll never let you live this one down.");
            }
            else
            {
                Console.WriteLine("It's a draw!! Randy reaches his hand out for a good ol shake, but pulls it away at the last second.");
            }

            Console.ReadKey();
            youWin();
        }

        public static void gameOver()
        {
            Console.Clear();
            Console.WriteLine("After a long night of random interactions, conversations, and a few too many drinks, you decide to close your eyes for a well deserved nights sleep.");
            Console.WriteLine("Until next time, adventurer!");
            Console.WriteLine("Press 'Enter' to play again.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

        public static void youWin()
        {
            Console.Clear();
            Console.WriteLine("You enjoy the rest of your night and you make some friends along the way.");
            Console.WriteLine("You decide to go to your room for some well deserved sleep.");
            Console.WriteLine("Until next time, adventurer!");
            Console.WriteLine("Press 'Enter' to play again.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }
    }
}
