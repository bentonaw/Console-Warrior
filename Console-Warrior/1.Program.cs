namespace Console_Warrior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Engine gameEngine = new Engine();
            gameEngine.Control();

            Console.BufferHeight = 5;
            Console.BufferWidth = 3;

            UI gameStartUI = new UI(200,50);

            Maps startMap = new Maps();
            startMap.Map();
            startMap.PrintMap(startMap.map);


        }
    }
}