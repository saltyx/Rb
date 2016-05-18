using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace ChinaBlock
{
    class BlindItem
    {
        public int durationTime;
        public int alreadyDuration;
        bool isStarted;

        public BlindItem(int duration)
        {
            durationTime = duration;
            alreadyDuration = 0;
            isStarted = false;
        }



        public void StartEffect()
        {
            isStarted = true;
        }



        public bool checkDuration()
        {
            if (alreadyDuration >= durationTime)
                return true;
            alreadyDuration++;
            return false;
        }

        public bool getStartStatus()
        {
            return isStarted;
        }

        public void unEffect()
        {
            if (isStarted)
            {
                //gameField.Redraw();
                alreadyDuration = 0;
                isStarted = false;
            }
        }
    }
}
