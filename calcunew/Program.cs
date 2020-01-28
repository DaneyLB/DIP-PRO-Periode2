using System;

namespace calcunew
{
    class Program
    {
        static void Main(string[] args)
        {
            Player myPlayer = new Player();
            Player anotherPlayer = new Player("Pietje");
            Player thirdPlayer = new Player();

            myPlayer.Jump();
            anotherPlayer.Shoot(4);
            thirdPlayer.Shoot(1);
        }
    }
}
