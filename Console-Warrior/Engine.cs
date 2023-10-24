using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Warrior
{
    
    internal class Engine
    {
        

        //Start position
        internal int StartPosX { get; set; }
        internal int StartPosY { get; set; }
        public Engine(int startPosX = 25, int startPosY = 15)
        {
            StartPosX = startPosX;
            StartPosY = startPosY;
        }

        internal void Control()
        {
            while (true)
            {
                Console.SetCursorPosition(StartPosX, StartPosY);
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    var exitMessagePosX = 5;
                    var exitMessagePosY = 26;
                    Console.SetCursorPosition(exitMessagePosX, exitMessagePosY);
                    Console.Write("\r\nYou are about to exit the game, are you sure? (y/n): "); // add this as a seperate mehtod in another class with a window
                    var exit = Console.ReadLine();
                    if (exit == "y" || exit == "Y")
                    {
                        Console.WriteLine("Thanks for playing!");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if ((keyInfo.Key == ConsoleKey.W || keyInfo.Key == ConsoleKey.UpArrow))
                {
                    StartPosY--;
                }
                else if ((keyInfo.Key == ConsoleKey.A || keyInfo.Key == ConsoleKey.LeftArrow))
                {
                    StartPosX--;
                }
                else if ((keyInfo.Key == ConsoleKey.S || keyInfo.Key == ConsoleKey.DownArrow))
                {
                    StartPosY++;
                }
                else if ((keyInfo.Key == ConsoleKey.D || keyInfo.Key == ConsoleKey.RightArrow))
                {
                    StartPosX++;
                }

                Console.SetCursorPosition(StartPosX, StartPosY);

            }
        }
    }
}
