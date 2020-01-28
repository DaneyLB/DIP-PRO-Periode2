using System;

namespace getterstters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Player MyPlayer = new Player();

            Console.WriteLine( "LIVES" + MyPlayer.lives );
            Console.WriteLine( "POINTS" + MyPlayer.points );
            MyPlayer.points += 130;

            Console.WriteLine( "LIVES" + MyPlayer.lives );
            Console.WriteLine( "POINTS" + MyPlayer.points );


        }
    }
}
