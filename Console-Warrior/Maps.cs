using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Warrior
{
    enum MapObjects
    {
        None,
        Player, 
        Companion, 
        Enemy, 
        Boss, 
        Chest, 
        Door, 
        Wall,
    }
    internal class Maps
    {
        //internal int MapX { get; set; } = 10;
        //internal int MapY { get; set; } = 10;
        
        internal MapObjects[,] map = new MapObjects[60,60];

        //internal int StartMapX()
        //{
        //    return 200;
        //}
        //internal int StartMapY()
        //{
        //    return 50;
        //}


        internal void Map() 
        { 
            for (int x = 0; x< 10; x++) // top and bottom wall(rows)
            {
                map[x, 0] = MapObjects.Wall;
                map[x, 9] = MapObjects.Wall;
            }

            for (int y = 0; y < 10; y++) // left and right wall(columns)
            {
                map[0, y] = MapObjects.Wall;
                map[9, y] = MapObjects.Wall;
            }
        }

        public void PrintMap(MapObjects[,] map)
        {
            // Loopar igenom varje rad i arrayen
            for (int y = 0; y < 10; y++)
            {
                // Loopar igenom varje kolumn i arrayen
                for (int x = 0; x < 10; x++)
                {
                    // Använder en switch-sats för att bestämma vilket tecken som ska skrivas ut
                    switch (map[x, y])
                    {
                        case MapObjects.None:
                            Console.Write(" ");
                            break;
                        case MapObjects.Player:
                            Console.Write("P");
                            break;
                        case MapObjects.Companion:
                            Console.Write("#");
                            break;
                        case MapObjects.Enemy:
                            Console.Write("E");
                            break;                        
                        case MapObjects.Boss:
                            Console.Write("B");
                            break;                        
                        case MapObjects.Chest:
                            Console.Write("C");
                            break;                        
                        case MapObjects.Door:
                            Console.Write("D");
                            break;                        
                        case MapObjects.Wall:
                            Console.Write("W");
                            break;
                    }
                }
                // Skriver ut en ny rad efter varje rad i arrayen
                Console.WriteLine();
            }
        }
    }
}
