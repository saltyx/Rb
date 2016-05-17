using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MetroFramework.Forms;

namespace ChinaBlock
{
    public partial class LocalDoubleFight : MetroForm
    {
        private Block currentBlockInPlayer1; //玩家一当前在运行的方块
        private Block currentBlockInPlayer2; //玩家二当前在运行的方块
        private Block nextBlockInPlayer1;   //下一个即将出现的方块
        private Block nextBlockInPlayer2;  //二下一个即将出现的方块
        private GameField gameFieldInPlayer1 = new GameField();
        private GameField gameFieldInPlayer2 = new GameField();
        private Point startLocationInPlayer1 = new Point(GameField.SquareSize * 4, 0);  //玩家一方块产生的位置
        private Point startLocationInPlayer2 = new Point(GameField.SquareSize * 4, 0);  //玩家二方块产生的位置
        private int scoreInPlayer1 = 0;            //玩家积分
        private int scoreInPlayer2 = 0;
        private bool stillRuning = false; //游戏运行开关
        private enum speeds {
            slower=1000,
            slow=800,
            quick=500,
            quicker=350,
            quickest=250
        }; //游戏速度，数字越小越快
        public LocalDoubleFight()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GameField.BackColor = picBackGround1.BackColor;
            gameFieldInPlayer1.winHandle = picBackGround1.Handle;
            gameFieldInPlayer2.winHandle = picBackGround2.Handle;
            timer1.Interval = (int)speeds.slower;
            //获取自定义设置
            getSettings();
        }
        /*加载窗体时从配置文件Setting.ini中读取游戏设置*/
        private void getSettings()
        {
            if (!File.Exists("Setting.ini"))
                return;
            FileStream fs = new FileStream("Setting.ini", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string line1=sr.ReadLine();
            string line2=sr.ReadLine();
            string line3=sr.ReadLine();
            if (line1 != null && line1.Split('=').Length > 1)
            {
                GameField.BackColor = Color.FromArgb(int.Parse(line1.Split('=')[1]));
                picBackGround1.BackColor = GameField.BackColor;

            }
            if (line2 != null && line2.Split('=').Length > 1)
            { 
                 GameField.BlockForeColor = strToColor(line2.Split('=')[1]);
            }
            if (line3 != null && line3.Split('=').Length > 1)
            {
                GameField.BlockBackColor = strToColor(line3.Split('=')[1]);
            }
            sr.Close();
            fs.Close();
        }
        /*如果游戏设置被更改，将新的设置保存到Setting.ini*/
        private void saveSettings()
        {
            FileStream fs = new FileStream("Setting.ini", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("GameFieldColor="+ GameField.BackColor.ToArgb());
            sw.WriteLine("BlockFroeColor=" + colorToStr(GameField.BlockForeColor));
            sw.WriteLine("BlockBackColor=" + colorToStr(GameField.BlockBackColor));
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        /*将字符串变回成颜色数组*/
        private Color[] strToColor(string str)
        {
            string[] strs = str.Split(',');
            if ((strs.Length-1) != 7)
                return null;
            Color[] colors=new Color[7];
            for (int i = 0; i < strs.Length - 1; i++)
                colors[i] = Color.FromArgb(int.Parse(strs[i]));
            return colors;
        }
        /*将颜色变成可读字符串*/
        private string colorToStr(Color[] colors)
        {
            string result = "";
            for (int i = 0; i < colors.Length; i++)
                result += colors[i].ToArgb() + ",";
            return result;
        }
        
        /*键盘操作*/
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad6: if (!currentBlockInPlayer2.right(gameFieldInPlayer2)) GameField.PlaySound("CanNotDo"); break;//2向右移动
                case Keys.NumPad4: if (!currentBlockInPlayer2.left(gameFieldInPlayer2)) GameField.PlaySound("CanNotDo"); break; //2向左移动
                case Keys.NumPad8: currentBlockInPlayer2.Rotate(gameFieldInPlayer2); break; //2旋转
                case Keys.NumPad5: while (currentBlockInPlayer2.down(gameFieldInPlayer2)) ; break; //2向下加速
                case Keys.W: currentBlockInPlayer1.Rotate(gameFieldInPlayer1); break; //1旋转
                case Keys.A: if (!currentBlockInPlayer1.left(gameFieldInPlayer1)) GameField.PlaySound("CanNotDo"); break; //1向左移动
                case Keys.S: while (currentBlockInPlayer1.down(gameFieldInPlayer1)) ; break; //1向下加速
                case Keys.D: if (!currentBlockInPlayer1.right(gameFieldInPlayer1)) GameField.PlaySound("CanNotDo"); break;//1向右移动
                case Keys.Space:                           //空格：暂停
                    timer1.Enabled = !timer1.Enabled;
                    if (!timer1.Enabled)
                        showMsg("暂 停");
                    else
                        msg.SendToBack();
                    break;
                case Keys.Enter: //回车继续游戏
                    beginGame();
                    break;
            }
            picBackGround1.Focus();
        }

        /*游戏时钟*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!stillRuning)
                return;
            
            //1检测是否还可以下移
            if (!currentBlockInPlayer1.down(gameFieldInPlayer1))
            {
                if (currentBlockInPlayer1.Top() == 0)
                {//1如果到顶则游戏结束
                    showMsg("Game Over！玩家二获胜");
                    stillRuning = false;
                    timer1.Stop();
                    return;
                }
                //1否则计算分数并继续
                int eraseLines = gameFieldInPlayer1.CheckLines();
                if (eraseLines > 0)
                {
                    scoreInPlayer1 += GameField.width * eraseLines;
                    t_score1.Text = scoreInPlayer1.ToString();
                    picBackGround1.Invalidate();
                    Application.DoEvents();
                    gameFieldInPlayer1.Redraw();
                }
                //1产生下一个block
                currentBlockInPlayer1 = new Block(startLocationInPlayer1, nextBlockInPlayer1.blockType);
                currentBlockInPlayer1.Draw(gameFieldInPlayer1.winHandle);
                pic_preView1.Refresh();
                nextBlockInPlayer1 = new Block(new Point(80, 50), Block.BlockTypes.undefined);
                nextBlockInPlayer1.Draw(pic_preView1.Handle);
            }
            currentBlockInPlayer1.down(gameFieldInPlayer1);

            //2检测是否还可以下移
            if (!currentBlockInPlayer2.down(gameFieldInPlayer2))
            {
                if (currentBlockInPlayer2.Top() == 0)
                {//2如果到顶则游戏结束
                    showMsg("Game Over！玩家一获胜");
                    stillRuning = false;
                    timer1.Stop();
                    return;
                }
                //2否则计算分数并继续
                int eraseLines = gameFieldInPlayer2.CheckLines();
                if (eraseLines > 0)
                {
                    scoreInPlayer2 += GameField.width * eraseLines;
                    t_score2.Text = scoreInPlayer2.ToString();
                    picBackGround2.Invalidate();
                    Application.DoEvents();
                    gameFieldInPlayer2.Redraw();
                }
                //2产生下一个block
                currentBlockInPlayer2 = new Block(startLocationInPlayer2, nextBlockInPlayer2.blockType);
                currentBlockInPlayer2.Draw(gameFieldInPlayer2.winHandle);
                pic_preView2.Refresh();
                nextBlockInPlayer2 = new Block(new Point(80, 50), Block.BlockTypes.undefined);
                nextBlockInPlayer2.Draw(pic_preView2.Handle);
            }
            currentBlockInPlayer2.down(gameFieldInPlayer2);
        }

         /*窗口重绘*/
        private void Form1_Activated(object sender, EventArgs e)
        {
            picBackGround1.Invalidate();
            picBackGround2.Invalidate();
            Application.DoEvents();
            gameFieldInPlayer1.Redraw();
            gameFieldInPlayer2.Redraw();
        }
        /*关闭窗体时，提示是否保存设置*/
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GameField.isChanged&&MessageBox.Show("设置已改变，是否在退出前保存？","提示",MessageBoxButtons.YesNo) == DialogResult.Yes)
                saveSettings();
        }
#region 菜单……
        /*开始游戏*/
        private void 开始ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            beginGame();
        }
        //开始游戏的方法
        private void beginGame()
        {
            msg.SendToBack();   //将提示窗口隐藏
            开始ToolStripMenuItem.Enabled = false;
            暂停ToolStripMenuItem1.Enabled = true;
            结束ToolStripMenuItem.Enabled = true;
            if (currentBlockInPlayer1 == null && currentBlockInPlayer2 == null)
            {//第一次开始
                currentBlockInPlayer1 = new Block(startLocationInPlayer1, Block.BlockTypes.undefined);
                currentBlockInPlayer1.Draw(gameFieldInPlayer1.winHandle);
                nextBlockInPlayer1 = new Block(new Point(80, 50), Block.BlockTypes.undefined);
                nextBlockInPlayer1.Draw(pic_preView1.Handle);
                /////////////////////////////////
                currentBlockInPlayer2 = new Block(startLocationInPlayer2, Block.BlockTypes.undefined);
                currentBlockInPlayer2.Draw(gameFieldInPlayer2.winHandle);
                nextBlockInPlayer2 = new Block(new Point(80, 50), Block.BlockTypes.undefined);
                nextBlockInPlayer2.Draw(pic_preView2.Handle);
                /////////////////////////////////
                stillRuning = true;
                timer1.Start();
            }
            else
            {
                timer1.Enabled = true;
            }
        }

        /*暂停游戏*/
        private void 暂停ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            showMsg("暂 停");
            开始ToolStripMenuItem.Enabled = true;
            暂停ToolStripMenuItem1.Enabled = false;
        }

        /*结束游戏*/
        private void 结束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stillRuning = false;
            timer1.Stop();
            currentBlockInPlayer1 = null;
            currentBlockInPlayer2 = null;
            gameFieldInPlayer1.arriveBlock = new Square[GameField.width, GameField.height]; //清空所有小方块
            gameFieldInPlayer1.arrBitBlock = new int[GameField.height];

            gameFieldInPlayer2.arriveBlock = new Square[GameField.width, GameField.height]; //清空所有小方块
            gameFieldInPlayer2.arrBitBlock = new int[GameField.height];
            showMsg("结 束");
            结束ToolStripMenuItem.Enabled = false;
            暂停ToolStripMenuItem1.Enabled = false;
            开始ToolStripMenuItem.Enabled = true;
            picBackGround1.Refresh();
            picBackGround2.Refresh();
            pic_preView1.Refresh();
            pic_preView2.Refresh();
        }

        /*重新开始一盘*/
        private void 重新开始ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            picBackGround1.Refresh();   //刷新游戏区
            picBackGround2.Refresh();
            pic_preView1.Refresh();     //刷新预览区
            pic_preView2.Refresh();
            gameFieldInPlayer1.arriveBlock = new Square[GameField.width, GameField.height]; //清空所有小方块
            gameFieldInPlayer1.arrBitBlock = new int[GameField.height];

            gameFieldInPlayer2.arriveBlock = new Square[GameField.width, GameField.height]; //清空所有小方块
            gameFieldInPlayer2.arrBitBlock = new int[GameField.height];

            scoreInPlayer1 = 0;           //重新计算积分
            t_score1.Text = "0";
            scoreInPlayer2 = 0;           //重新计算积分
            t_score2.Text = "0";
            msg.SendToBack();   //将提示窗口隐藏

            currentBlockInPlayer1 = new Block(startLocationInPlayer1, Block.BlockTypes.undefined);
            currentBlockInPlayer1.Draw(gameFieldInPlayer1.winHandle);
            currentBlockInPlayer2 = new Block(startLocationInPlayer2, Block.BlockTypes.undefined);
            currentBlockInPlayer2.Draw(gameFieldInPlayer2.winHandle);


            nextBlockInPlayer1 = new Block(new Point(80, 50), Block.BlockTypes.undefined);
            nextBlockInPlayer1.Draw(pic_preView1.Handle);
            nextBlockInPlayer2 = new Block(new Point(80, 50), Block.BlockTypes.undefined);
            nextBlockInPlayer2.Draw(pic_preView2.Handle);

            开始ToolStripMenuItem.Enabled = false;
            暂停ToolStripMenuItem1.Enabled = true;
            结束ToolStripMenuItem.Enabled = true;
            stillRuning = true;
            timer1.Start();
        }

        /*退出游戏*/
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stillRuning = false;
            timer1.Stop();
            this.Close();
        }

        /*显示提示框*/
        private void showMsg(string str)
        {
            msg.Text = str;
            msg.Left = picBackGround1.Left + picBackGround1.Width + msg.Width / 2;
            msg.BringToFront();
        }
        /*操作说明*/
        private void 操作说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help helps = new help();
            helps.Show();
        }
        /*关于*/
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about ab = new about();
            ab.Show();
        }

        /*背景颜色设置*/
        private void 背景颜色设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setGameFieldBgColor sb = new setGameFieldBgColor();
            sb.ShowDialog();
            picBackGround1.BackColor = GameField.BackColor;
            picBackGround2.BackColor = GameField.BackColor;
        }
        /*方块颜色设置*/
        private void 方块颜色设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setBlockColor sb = new setBlockColor();
            sb.ShowDialog();
        }
        /*速度选择较慢*/
        private void 较慢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeChecked(较慢ToolStripMenuItem);
            timer1.Interval = (int)speeds.slower;
        }
        /*速度选择慢*/
        private void 慢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeChecked(慢ToolStripMenuItem);
            timer1.Interval = (int)speeds.slow;
        }
        /*速度选择快*/
        private void 快ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeChecked(快ToolStripMenuItem);
            timer1.Interval = (int)speeds.quick;
        }
        /*速度选择较快*/
        private void 较快ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeChecked(较快ToolStripMenuItem);
            timer1.Interval = (int)speeds.quicker;
        }
        /*速度选择非常快*/
        private void 非常快ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeChecked(非常快ToolStripMenuItem);
            timer1.Interval = (int)speeds.quickest;
        }
        /*速度选择需要用到的方法*/
        public void changeChecked(ToolStripMenuItem oo)
        {
            较慢ToolStripMenuItem.Checked = false;
            慢ToolStripMenuItem.Checked = false;
            快ToolStripMenuItem.Checked = false;
            较快ToolStripMenuItem.Checked = false;
            非常快ToolStripMenuItem.Checked = false;
            oo.Checked = true;
        }
        private void 恢复默认设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameField.BackColor = Color.WhiteSmoke;
            picBackGround1.BackColor = Color.WhiteSmoke;
            picBackGround2.BackColor = Color.WhiteSmoke;
            GameField.BlockForeColor = new Color[] { Color.SkyBlue, Color.SkyBlue, Color.SkyBlue, Color.SkyBlue, Color.SkyBlue, Color.SkyBlue, Color.SkyBlue };
            GameField.BlockBackColor = new Color[] { Color.DimGray, Color.DimGray, Color.DimGray, Color.DimGray, Color.DimGray, Color.DimGray, Color.DimGray };
            saveSettings();
            GameField.isChanged = false;

        }
        #endregion

    }
}