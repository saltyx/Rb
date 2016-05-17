using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ChinaBlock
{
    class Block
    {
        public Square square1;  //组成block的四个小方块
        public Square square2;
        public Square square3;
        public Square square4;


        private const int squareSize = GameField.SquareSize; //小方块的边长
        public enum BlockTypes
        {
            undefined = 0,
            square = 1,
            line = 2,
            J = 3,
            L = 4,
            T = 5,
            Z = 6,
            S = 7
        };//一共有7种形状
        public BlockTypes blockType;  //方块的形状
        //七个小方块的颜色数组
        private Color foreColor;
        private Color backColor;
        //方块的方向
        public enum RotateDirections
        {
            North = 1,
            East = 2,
            South = 3,
            West = 4
        };
        public RotateDirections myRotation = RotateDirections.North;
        
        public Block(Point thisLocation,BlockTypes bType)
        { //当blockType为undefined时，随机产生方块形状
            Random rand=new Random();
            if (bType == BlockTypes.undefined)
            {
                blockType = (BlockTypes)(rand.Next(7) + 1);
            }
            else
                blockType = bType;
            //设置四小方块的颜色
            int i=(int)blockType-1;
            foreColor = GameField.BlockForeColor[i];
            backColor = GameField.BlockBackColor[i];
            Size squareS=new Size(squareSize,squareSize);
            square1 = new Square(squareS, foreColor, backColor);
            square2 = new Square(squareS, foreColor, backColor);
            square3 = new Square(squareS, foreColor, backColor);
            square4 = new Square(squareS, foreColor, backColor);

            //设置小方块的位置，组合成指定形状的一个大方块
            switch (blockType)
            {
                case BlockTypes.square:
                    //组合成正方形
                    square1.location = new Point(thisLocation.X, thisLocation.Y);
                    square2.location = new Point(thisLocation.X + squareSize, thisLocation.Y);
                    square3.location = new Point(thisLocation.X,thisLocation.Y+squareSize);
                    square4.location = new Point(thisLocation.X+squareSize,thisLocation.Y+squareSize);
                    break;
                case BlockTypes.line:
                    //组合成线形
                    square1.location = new Point(thisLocation.X, thisLocation.Y);
                    square2.location = new Point(thisLocation.X + squareSize, thisLocation.Y);
                    square3.location = new Point(thisLocation.X + 2 * squareSize, thisLocation.Y);
                    square4.location = new Point(thisLocation.X + 3 * squareSize, thisLocation.Y);
                    break;
                case BlockTypes.J:
                    //组合成J形
                    square1.location = new Point(thisLocation.X + squareSize, thisLocation.Y);
                    square2.location = new Point(thisLocation.X + squareSize, thisLocation.Y + squareSize);
                    square3.location = new Point(thisLocation.X + squareSize, thisLocation.Y + 2 * squareSize);
                    square4.location = new Point(thisLocation.X, thisLocation.Y + 2 * squareSize);
                    break;
                case BlockTypes.L:
                    //组合成l形
                    square1.location = new Point(thisLocation.X, thisLocation.Y);
                    square2.location = new Point(thisLocation.X, thisLocation.Y + squareSize);
                    square3.location = new Point(thisLocation.X, thisLocation.Y + 2 * squareSize);
                    square4.location = new Point(thisLocation.X + squareSize, thisLocation.Y + 2 * squareSize);
                    break;
                case BlockTypes.T:
                    //组合成T形
                    square1.location = new Point(thisLocation.X, thisLocation.Y);
                    square2.location = new Point(thisLocation.X + squareSize, thisLocation.Y);
                    square3.location = new Point(thisLocation.X + 2*squareSize, thisLocation.Y);
                    square4.location = new Point(thisLocation.X + squareSize, thisLocation.Y +squareSize);
                    break;
                case BlockTypes.Z:
                    //组合成z形
                    square1.location = new Point(thisLocation.X, thisLocation.Y);
                    square2.location = new Point(thisLocation.X + squareSize, thisLocation.Y);
                    square3.location = new Point(thisLocation.X + squareSize, thisLocation.Y + squareSize);
                    square4.location = new Point(thisLocation.X + 2*squareSize, thisLocation.Y + squareSize);
                    break;
                case BlockTypes.S:
                    //组合成S形
                    square1.location = new Point(thisLocation.X, thisLocation.Y + squareSize);
                    square2.location = new Point(thisLocation.X + squareSize, thisLocation.Y + squareSize);
                    square3.location = new Point(thisLocation.X + squareSize, thisLocation.Y);
                    square4.location = new Point(thisLocation.X + 2 * squareSize, thisLocation.Y);
                    break;
            }
        }
        //含有自定义颜色的重载
        public Block(Point thisLocation, BlockTypes bType,Color fc,Color bc)
        { //当blockType为undefined时，随机产生方块形状
            Random rand = new Random();
            if (bType == BlockTypes.undefined)
            {
                blockType = (BlockTypes)(rand.Next(7) + 1);
            }
            else
                blockType = bType;
            //设置四小方块的颜色
            Size squareS = new Size(squareSize, squareSize);
            square1 = new Square(squareS, fc, bc);
            square2 = new Square(squareS, fc, bc);
            square3 = new Square(squareS, fc, bc);
            square4 = new Square(squareS, fc, bc);

            //设置小方块的位置，组合成指定形状的一个大方块
            switch (blockType)
            {
                case BlockTypes.square:
                    //组合成正方形
                    square1.location = new Point(thisLocation.X, thisLocation.Y);
                    square2.location = new Point(thisLocation.X + squareSize, thisLocation.Y);
                    square3.location = new Point(thisLocation.X, thisLocation.Y + squareSize);
                    square4.location = new Point(thisLocation.X + squareSize, thisLocation.Y + squareSize);
                    break;
                case BlockTypes.line:
                    //组合成线形
                    square1.location = new Point(thisLocation.X, thisLocation.Y);
                    square2.location = new Point(thisLocation.X + squareSize, thisLocation.Y);
                    square3.location = new Point(thisLocation.X + 2 * squareSize, thisLocation.Y);
                    square4.location = new Point(thisLocation.X + 3 * squareSize, thisLocation.Y);
                    break;
                case BlockTypes.J:
                    //组合成J形
                    square1.location = new Point(thisLocation.X + squareSize, thisLocation.Y);
                    square2.location = new Point(thisLocation.X + squareSize, thisLocation.Y + squareSize);
                    square3.location = new Point(thisLocation.X + squareSize, thisLocation.Y + 2 * squareSize);
                    square4.location = new Point(thisLocation.X, thisLocation.Y + 2 * squareSize);
                    break;
                case BlockTypes.L:
                    //组合成l形
                    square1.location = new Point(thisLocation.X, thisLocation.Y);
                    square2.location = new Point(thisLocation.X, thisLocation.Y + squareSize);
                    square3.location = new Point(thisLocation.X, thisLocation.Y + 2 * squareSize);
                    square4.location = new Point(thisLocation.X + squareSize, thisLocation.Y + 2 * squareSize);
                    break;
                case BlockTypes.T:
                    //组合成T形
                    square1.location = new Point(thisLocation.X, thisLocation.Y);
                    square2.location = new Point(thisLocation.X + squareSize, thisLocation.Y);
                    square3.location = new Point(thisLocation.X + 2 * squareSize, thisLocation.Y);
                    square4.location = new Point(thisLocation.X + squareSize, thisLocation.Y + squareSize);
                    break;
                case BlockTypes.Z:
                    //组合成z形
                    square1.location = new Point(thisLocation.X, thisLocation.Y);
                    square2.location = new Point(thisLocation.X + squareSize, thisLocation.Y);
                    square3.location = new Point(thisLocation.X + squareSize, thisLocation.Y + squareSize);
                    square4.location = new Point(thisLocation.X + 2 * squareSize, thisLocation.Y + squareSize);
                    break;
                case BlockTypes.S:
                    //组合成S形
                    square1.location = new Point(thisLocation.X, thisLocation.Y + squareSize);
                    square2.location = new Point(thisLocation.X + squareSize, thisLocation.Y + squareSize);
                    square3.location = new Point(thisLocation.X + squareSize, thisLocation.Y);
                    square4.location = new Point(thisLocation.X + 2 * squareSize, thisLocation.Y);
                    break;
            }
        }

        /*画方块*/
        public void Draw(System.IntPtr winHandle)
        {
            square1.Draw(winHandle);
            square2.Draw(winHandle);
            square3.Draw(winHandle);
            square4.Draw(winHandle);
        }
        /*擦方块*/
        public void Erase(System.IntPtr winHandle)
        {
            square1.Erase(winHandle);
            square2.Erase(winHandle);
            square3.Erase(winHandle);
            square4.Erase(winHandle);
        }

        /*移动*/
        public bool down(GameField ownerGameField)
        {
            //检测是否可以下移
            if (ownerGameField.isEmpty(square1.location.X / squareSize, square1.location.Y / squareSize + 1) &&
                ownerGameField.isEmpty(square2.location.X / squareSize, square2.location.Y / squareSize + 1) &&
                ownerGameField.isEmpty(square3.location.X / squareSize, square3.location.Y / squareSize + 1) &&
                ownerGameField.isEmpty(square4.location.X / squareSize, square4.location.Y / squareSize + 1))
            {
                Erase(ownerGameField.winHandle);
                square1.location = new Point(square1.location.X, square1.location.Y + squareSize);
                square2.location = new Point(square2.location.X, square2.location.Y + squareSize);
                square3.location = new Point(square3.location.X, square3.location.Y + squareSize);
                square4.location = new Point(square4.location.X, square4.location.Y + squareSize);
                Draw(ownerGameField.winHandle);
                return true;
            }
            else  //如果不能下移了
            {
                ownerGameField.stopSquare(square1, square1.location.X / squareSize, square1.location.Y / squareSize);
                ownerGameField.stopSquare(square2, square2.location.X / squareSize, square2.location.Y / squareSize);
                ownerGameField.stopSquare(square3, square3.location.X / squareSize, square3.location.Y / squareSize);
                ownerGameField.stopSquare(square4, square4.location.X / squareSize, square4.location.Y / squareSize);
                return false; //表示可以弹出下一个block了
            }
        }
        public bool left(GameField ownerGameField)
        {
            //检测是否可以左移
            if (ownerGameField.isEmpty(square1.location.X / squareSize-1, square1.location.Y / squareSize) &&
                ownerGameField.isEmpty(square2.location.X / squareSize-1, square2.location.Y / squareSize) &&
                ownerGameField.isEmpty(square3.location.X / squareSize-1, square3.location.Y / squareSize) &&
                ownerGameField.isEmpty(square4.location.X / squareSize-1, square4.location.Y / squareSize))
            {
                Erase(ownerGameField.winHandle);
                square1.location = new Point(square1.location.X - squareSize, square1.location.Y);
                square2.location = new Point(square2.location.X - squareSize, square2.location.Y);
                square3.location = new Point(square3.location.X - squareSize, square3.location.Y);
                square4.location = new Point(square4.location.X - squareSize, square4.location.Y);
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
            if (ownerGameField.isEmpty(square1.location.X / squareSize +1, square1.location.Y / squareSize) &&
                ownerGameField.isEmpty(square2.location.X / squareSize +1, square2.location.Y / squareSize) &&
                ownerGameField.isEmpty(square3.location.X / squareSize +1, square3.location.Y / squareSize) &&
                ownerGameField.isEmpty(square4.location.X / squareSize +1, square4.location.Y / squareSize))
            {
                Erase(ownerGameField.winHandle);
                square1.location = new Point(square1.location.X + squareSize, square1.location.Y );
                square2.location = new Point(square2.location.X + squareSize, square2.location.Y);
                square3.location = new Point(square3.location.X + squareSize, square3.location.Y);
                square4.location = new Point(square4.location.X + squareSize, square4.location.Y);
                Draw(ownerGameField.winHandle);
                return true;
            }
            else  //如果不能右移了
            {
                return false; 
            }
        }
        /*旋转block*/
        public void Rotate(GameField ownerGameField)
        {
           //保存每个小块的位置
            Point oldPosition1 = square1.location;
            Point oldPosition2 = square2.location;
            Point oldPosition3 = square3.location;
            Point oldPosition4 = square4.location;
            //保存当前的方向
            RotateDirections oldRotation = myRotation;
            //开始试着旋转方块，旋转方向：顺时针方向 旋转中心点为形状拐点
            Erase(ownerGameField.winHandle);
            switch(blockType)
            {
                case BlockTypes.square:
                    break;
                case BlockTypes.line:
                    //直线的旋转只有两种方向
                    switch (myRotation)
                    {
                        case RotateDirections.North:
                            myRotation = RotateDirections.East;
                            square1.location = new Point(square2.location.X-squareSize,square2.location.Y);
                            square3.location = new Point(square2.location.X+squareSize,square2.location.Y);
                            square4.location = new Point(square2.location.X + 2 * squareSize, square2.location.Y);
                            break;
                        case RotateDirections.East:
                            myRotation = RotateDirections.North;
                            square1.location = new Point(square2.location.X,square2.location.Y-squareSize);
                            square3.location = new Point(square2.location.X, square2.location.Y +squareSize);
                            square4.location = new Point(square2.location.X, square2.location.Y + 2 * squareSize);
                            break;
                    }
                    break;
                case BlockTypes.J:
                    //J形方块有四种旋转方向
                    switch (myRotation)
                    {
                        case RotateDirections.North:
                            myRotation = RotateDirections.East;
                            square1.location = new Point(square3.location.X+2*squareSize,square3.location.Y);
                            square2.location = new Point(square3.location.X+squareSize,square3.location.Y);
                            square4.location = new Point(square3.location.X,square3.location.Y-squareSize);
                            break;
                        case RotateDirections.East:
                            myRotation = RotateDirections.South;
                            square1.location = new Point(square3.location.X,square3.location.Y+2*squareSize);
                            square2.location = new Point(square3.location.X,square3.location.Y+squareSize);
                            square4.location = new Point(square3.location.X+squareSize,square3.location.Y);
                            break;
                        case RotateDirections.South:
                            myRotation = RotateDirections.West;
                            square1.location = new Point(square3.location.X-2*squareSize,square3.location.Y);
                            square2.location = new Point(square3.location.X-squareSize,square3.location.Y);
                            square4.location = new Point(square3.location.X,square3.location.Y+squareSize);
                            break;
                        case RotateDirections.West:
                            myRotation = RotateDirections.North;
                            square1.location = new Point(square3.location.X,square3.location.Y-2*squareSize);
                            square2.location = new Point(square3.location.X,square3.location.Y-squareSize);
                            square4.location = new Point(square3.location.X-squareSize,square3.location.Y);
                            break;
                    }
                    break;
                case BlockTypes.L:
                    //L形方块有四种旋转方向
                    switch (myRotation)
                    {
                        case RotateDirections.North:
                            myRotation = RotateDirections.East;
                            square1.location = new Point(square3.location.X+2*squareSize,square3.location.Y);
                            square2.location = new Point(square3.location.X+squareSize, square3.location.Y);
                            square4.location = new Point(square3.location.X, square3.location.Y+squareSize);
                            break;
                        case RotateDirections.East:
                            myRotation = RotateDirections.South;
                            square1.location = new Point(square3.location.X, square3.location.Y + 2 * squareSize);
                            square2.location = new Point(square3.location.X, square3.location.Y + squareSize);
                            square4.location = new Point(square3.location.X - squareSize, square3.location.Y);
                            break;
                        case RotateDirections.South:
                            myRotation = RotateDirections.West;
                            square1.location = new Point(square3.location.X - 2 * squareSize, square3.location.Y);
                            square2.location = new Point(square3.location.X - squareSize, square3.location.Y);
                            square4.location = new Point(square3.location.X, square3.location.Y - squareSize);
                            break;
                        case RotateDirections.West:
                            myRotation = RotateDirections.North;
                            square1.location = new Point(square3.location.X, square3.location.Y - 2 * squareSize);
                            square2.location = new Point(square3.location.X, square3.location.Y - squareSize);
                            square4.location = new Point(square3.location.X + squareSize, square3.location.Y);
                            break;
                    }
                    break;
                case BlockTypes.T:
                    //T形方块也有四种旋转方向
                    switch (myRotation)
                    {
                        case RotateDirections.North:
                            myRotation = RotateDirections.East;
                            square1.location = new Point(square2.location.X,square2.location.Y-squareSize);
                            square3.location = new Point(square2.location.X, square2.location.Y+squareSize);
                            square4.location = new Point(square2.location.X-squareSize, square2.location.Y);
                            break;
                        case RotateDirections.East:
                            myRotation = RotateDirections.South;
                            square1.location = new Point(square2.location.X+squareSize, square2.location.Y);
                            square3.location = new Point(square2.location.X-squareSize, square2.location.Y);
                            square4.location = new Point(square2.location.X, square2.location.Y-squareSize);
                            break;
                        case RotateDirections.South:
                            myRotation = RotateDirections.West;
                            square1.location = new Point(square2.location.X, square2.location.Y+squareSize);
                            square3.location = new Point(square2.location.X, square2.location.Y-squareSize);
                            square4.location = new Point(square2.location.X+squareSize, square2.location.Y);
                            break;
                        case RotateDirections.West:
                            myRotation = RotateDirections.North;
                            square1.location = new Point(square2.location.X-squareSize, square2.location.Y);
                            square3.location = new Point(square2.location.X+squareSize, square2.location.Y);
                            square4.location = new Point(square2.location.X, square2.location.Y+squareSize);
                            break;
                    }
                    break;
                case BlockTypes.Z:
                   //Z形方块有两种旋转方向
                    switch (myRotation)
                    {
                        case RotateDirections.North:
                            myRotation = RotateDirections.East;
                            square1.location = new Point(square2.location.X, square2.location.Y - squareSize);
                            square3.location = new Point(square2.location.X - squareSize, square2.location.Y);
                            square4.location = new Point(square2.location.X - squareSize, square2.location.Y + squareSize);
                            break;
                        case RotateDirections.East:
                            myRotation = RotateDirections.North;
                            square1.location = new Point(square2.location.X-squareSize, square2.location.Y);
                            square3.location = new Point(square2.location.X, square2.location.Y+squareSize);
                            square4.location = new Point(square2.location.X+squareSize, square2.location.Y+squareSize);
                            break;
                    }
                    break;
                case BlockTypes.S:
                  //S形方块有两种旋转方向
                    switch (myRotation)
                    {
                        case RotateDirections.North:
                            myRotation = RotateDirections.East;
                            square1.location = new Point(square3.location.X+squareSize,square3.location.Y+squareSize);
                            square2.location = new Point(square3.location.X+squareSize, square3.location.Y);
                            square4.location = new Point(square3.location.X, square3.location.Y-squareSize);
                            break;
                        case RotateDirections.East:
                            myRotation = RotateDirections.North;
                            square1.location = new Point(square3.location.X-squareSize, square3.location.Y+squareSize);
                            square2.location = new Point(square3.location.X, square3.location.Y+squareSize);
                            square4.location = new Point(square3.location.X+squareSize, square3.location.Y);
                            break;
                    }
                    break;
            }
            //旋转之后检测位置是否冲突
            if (!(ownerGameField.isEmpty(square1.location.X / squareSize, square1.location.Y / squareSize)&&
                ownerGameField.isEmpty(square2.location.X / squareSize, square2.location.Y / squareSize)&&
                ownerGameField.isEmpty(square3.location.X / squareSize, square3.location.Y / squareSize)&&
                ownerGameField.isEmpty(square4.location.X / squareSize, square4.location.Y / squareSize)))
            {//如果有冲突则回到原来的状态
                myRotation = oldRotation;
                square1.location = oldPosition1;
                square2.location = oldPosition2;
                square3.location = oldPosition3;
                square4.location = oldPosition4;
            }
            Draw(ownerGameField.winHandle);
        }
        /*检测是否到顶*/
        public int Top()
        {
            return Math.Min(square1.location.Y,Math.Min(square2.location.Y,Math.Min(square3.location.Y,square4.location.Y)));
        }
    }
}
