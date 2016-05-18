using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ChinaBlock
{
    //本类为道具类
    abstract class ItemBase
    {
        public Point location;
        public Size size;
        public Color itemColor;
        bool gotByPlayer = false;
        public enum itemTypes
        {
            undefined = 0,
            blind = 1,
            bomb = 2
        };
        public itemTypes itemType;

        public ItemBase(Size initSize, Color initColor)
        {
            size = initSize;
            itemColor = initColor;
        }

        public ItemBase(Point thisLocation, itemTypes iType)
        { 
            //当itemType为undefined时，随机产生道具
            Random rand = new Random();
            if (iType == itemTypes.undefined)
            {
                itemType = (itemTypes)(rand.Next(1) + 1);
            }
            else
                itemType = iType;
            
            itemColor = GameField.BlockForeColor[1];
            size = new Size(GameField.SquareSize, GameField.SquareSize);
            

            
        }

        //画道具块
        public void Draw(System.IntPtr winHandle)
        {
            Graphics g = Graphics.FromHwnd(winHandle);
            GraphicsPath gp = new GraphicsPath();
            Rectangle rec = new Rectangle(location, size);
            gp.AddRectangle(rec);
            Color[] surroundColor = new Color[] { itemColor };
            PathGradientBrush pb = new PathGradientBrush(gp);
            pb.CenterColor = itemColor;
            pb.SurroundColors = surroundColor;
            g.FillPath(pb, gp);
        }
        //擦除道具块
        public void Erase(System.IntPtr winHandle)
        {
            Graphics g = Graphics.FromHwnd(winHandle);
            Rectangle rec = new Rectangle(location, size);
            g.FillRectangle(new SolidBrush(GameField.BackColor), rec);
        }
    }
}
