using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class controller
    {
        private Board Game;
        private Player P1, P2;
        public controller()
        {
            P1 = new Player("kha");
            P2 = new Player("nhan");
            Game = new Board(3, 4, 6);
        }
        public void playgame()
        {
            Game.printGame();
            while(true)
            {
                Console.WriteLine(P1.GetName() + "a turn ");
                P1.PickBall(Game);
                Game.printGame();
                if(Game.isgameover())
                {
                    Console.WriteLine(P1.GetName() + "loses ");
                    Console.WriteLine(P2.GetName() + " wins ");
                    break;
                }
                Console.WriteLine(P2.GetName() + "a turn");
                P2.PickBall(Game);
                Game.printGame();
                if(Game.isgameover())
                {
                    Console.WriteLine(P2.GetName() + "loses ");
                    Console.WriteLine(P1.GetName() + " wins ");
                    break;
                }
            }
        }
    }
}
