using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ChinaBlock
{
    class Tool
    {
        public Square square;//道具实质上也用方块来表示
        private const int squareSize = GameField.SquareSize; //小方块的边长
        public enum ToolKinds
        {
            undefined=0,
            bomb=1,
            stop=2,
            black=3
        };
        public ToolKinds toolKind;
        private Color foreColor;
        private Color backColor;
        public Tool(Point thisLocation, ToolKinds tKind)
        {
            Random rand = new Random();
            if (tKind == ToolKinds.undefined)
            {
                toolKind = (ToolKinds)(rand.Next(4) + 1);
            }
            else
                toolKind = tKind;
            //设置道具的颜色
            int i = (int)toolKind - 1;
            foreColor = GameField.BlockForeColor[i];
            backColor = GameField.BlockBackColor[i];
            Size squareS = new Size(squareSize, squareSize);
            square = new Square(squareS, foreColor, backColor);
            square.location = new Point(thisLocation.X, thisLocation.Y);
        }

             /*道具*/
        public void Draw(System.IntPtr winHandle)
        {
            square.Draw(winHandle);
    
        }
        /*擦道具*/
        public void Erase(System.IntPtr winHandle)
        {
            square.Erase(winHandle);
        }
        /*移动*/
        public bool down(GameField ownerGameField)
        {
            //检测是否可以下移
            if (ownerGameField.isEmpty(square.location.X / squareSize, square.location.Y / squareSize + 1) )
            {
                Erase(ownerGameField.winHandle);
                square.location = new Point(square.location.X, square.location.Y + squareSize);
                Draw(ownerGameField.winHandle);
                return true;
            }
            else  //如果不能下移了
            {
                ownerGameField.stopSquare(square, square.location.X / squareSize, square.location.Y / squareSize);
                return false; //表示可以弹出下一个block了
            }
        }
       
        public bool left(GameField ownerGameField)
        {
            //检测是否可以左移
            if (ownerGameField.isEmpty(square.location.X / squareSize - 1, square.location.Y / squareSize))
            {
                Erase(ownerGameField.winHandle);
                square.location = new Point(square.location.X - squareSize, square.location.Y);
                Draw(ownerGameField.winHandle);
                return true;
            }
            else  //如果不能左移了
            {
                return false;
            }
        }
        public bool right(GameField ownerGameField)
        {
            //检测是否可以右移
            if (ownerGameField.isEmpty(square.location.X / squareSize + 1, square.location.Y / squareSize))
            {
                Erase(ownerGameField.winHandle);
                square.location = new Point(square.location.X + squareSize, square.location.Y); 
                Draw(ownerGameField.winHandle);
                return true;
            }
            else  //如果不能右移了
            {
                return false;
            }
        }
        /*检测是否到顶*/
        public int Top()
        {
            return square.location.Y;
        }
    }
}
