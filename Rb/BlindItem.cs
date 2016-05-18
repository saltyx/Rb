using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBlock
{
    class BlindItem : ItemBase
    {
        public int durationTime;
        public int alreadyDuration;

        public BlindItem(Size initSize, Color initColor) : base(initSize, initColor)
        {
            size = initSize;
            itemColor = initColor;
            durationTime = 3;
        }

        public BlindItem(Size initSize, Color initColor, int initDuration) : base(initSize, initColor)
        {
            size = initSize;
            itemColor = initColor;
            durationTime = initDuration;
        }

        public void Effect(IntPtr winHandle, GameField ownerGameField)
        {
            

        }

        public void unEffect(IntPtr winHandle)
        {

        }
    }
}
