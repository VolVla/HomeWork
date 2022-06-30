using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            char playerIcon = '@';
            Player player = new Player();
            Render Render = new Render();

            Render.DrawPlayerPosition(player.PositionX, player.PositionY, playerIcon);
        }
    }

    class Player
    {
        private int _positionX = 10;
        private int _positionY = 15;
        public int PositionX 
        {
            get 
            {
                return _positionX; 
            } 
            private set 
            { 
                _positionX = value; 
            } 
        }
        public int PositionY
        {
            get
            {
                return _positionY;
            }
            private set
            {
                _positionY = value;
            }
        }

        public void PlayerPosition(int positionX,int positionY)
        {
            PositionX = _positionX;
            PositionY = _positionY;
        }
    }

    class Render
    {
        public void DrawPlayerPosition(int positionX, int positionY,char playerIcon)
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(playerIcon);
        }
    }
}
