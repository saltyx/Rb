using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ChinaBlock
{
    /*
     * 本类为小正方形方块实体类
     * 每个block由四个颜色相同的square组成
     */
    class Square
    {
        public Point location;
        public Size size;
        public Color foreColor;
        public Color backColor;
        public Square(Size initSize,Color initForeColor,Color initBackColor)
        {
            size = initSize;
            foreColor = initForeColor;
            backColor = initBackColor;
        }
        //画方块
        public void Draw(System.IntPtr winHandle)
        {
            Graphics g = Graphics.FromHwnd(winHandle);
            GraphicsPath gp = new GraphicsPath();
            Rectangle rec = new Rectangle(location, size);
            gp.AddRectangle(rec);
            Color[] surroundColor = new Color[] { backColor };
            PathGradientBrush pb = new PathGradientBrush(gp);
            pb.CenterColor = foreColor;
            pb.SurroundColors = surroundColor;
            g.FillPath(pb, gp);
        }
        //擦除方块
        public void Erase(System.IntPtr winHandle)
        {
            Graphics g = Graphics.FromHwnd(winHandle);
            Rectangle rec = new Rectangle(location,size);
            g.FillRectangle(new SolidBrush(GameField.BackColor),rec);
        }
    }
}
