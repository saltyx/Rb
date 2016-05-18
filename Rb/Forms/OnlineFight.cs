using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ChinaBlock
{
    public partial class OnlineFight : MetroForm
    {
        //RBsocket rbsocket;
        //RBSocketServer rbserver;
        private Block currentBlock; //当前在运行的方块
        private Block nextBlock;   //下一个即将出现的方块
        private Point startLocation = new Point(GameField.SquareSize * 8, 0);  //方块产生的位置
        private GameField gameField = new GameField();
        private int score = 0;            //玩家积分
        private bool stillRuning = false; //游戏运行开关
        private enum speeds
        {
            slower = 1000,
            slow = 800,
            quick = 500,
            quicker = 350,
            quickest = 250
        }; //游戏速度，数字越小越快

        public OnlineFight()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            GameField.BackColor = picBackGround.BackColor;
            gameField.winHandle = picBackGround.Handle;
            BlindItemTimer.Interval = (int)speeds.slower;
            //颜色设置
            GameField.BackColor = Color.WhiteSmoke;
            GameField.BlockForeColor = new Color[] { Color.SkyBlue, Color.SkyBlue, Color.SkyBlue, Color.SkyBlue, Color.SkyBlue, Color.SkyBlue, Color.SkyBlue };
            GameField.BlockBackColor = new Color[] { Color.DimGray, Color.DimGray, Color.DimGray, Color.DimGray, Color.DimGray, Color.DimGray, Color.DimGray };
        }

        private void OnlineFight_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D: if (!currentBlock.right(gameField)) GameField.PlaySound("CanNotDo"); break;//向右移动
                case Keys.A: if (!currentBlock.left(gameField)) GameField.PlaySound("CanNotDo"); break; //向左移动
                case Keys.W: currentBlock.Rotate(gameField); break; //旋转
                case Keys.S: while (currentBlock.down(gameField)) ; break; //向下加速
            }
            picBackGround.Focus();
        }
        /*键盘操作
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D: if (!currentBlock.right(gameField)) GameField.PlaySound("CanNotDo"); break;//向右移动
                case Keys.A: if (!currentBlock.left(gameField)) GameField.PlaySound("CanNotDo"); break; //向左移动
                case Keys.W: currentBlock.Rotate(gameField); break; //旋转
                case Keys.S: while (currentBlock.down(gameField)) ; break; //向下加速
            }
            picBackGround.Focus();
        }*/

        /*道具时钟*/
        private void itemTimer_Tick(object sender, EventArgs e)
        {
            if (!stillRuning)
                return;
            //testItem = new ItemBase(startLocation, ItemBase.itemTypes.undefined);
            //testItem.Draw(gameField.winHandle);

        }
        /*游戏时钟*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!stillRuning)
                return;

            //检测是否还可以下移
            if (!currentBlock.down(gameField))
            {
                if (currentBlock.Top() == 0)
                {//如果到顶则游戏结束
                    MessageBox.Show("游戏结束");
                    stillRuning = false;
                    timer1.Stop();
                    return;
                }
                //否则计算分数并继续
                int eraseLines = gameField.CheckLines();
                if (eraseLines > 0)
                {
                    score += GameField.width * eraseLines;
                    t_score.Text = score.ToString();
                    picBackGround.Invalidate();
                    Application.DoEvents();
                    gameField.Redraw();
                }
                //产生下一个block
                currentBlock = new Block(startLocation, nextBlock.blockType);
                currentBlock.Draw(gameField.winHandle);
                pic_preView.Refresh();
                nextBlock = new Block(new Point(80, 50), Block.BlockTypes.undefined);
                nextBlock.Draw(pic_preView.Handle);
            }
            currentBlock.down(gameField);
        }

        /*窗口重绘*/
        private void Form1_Activated(object sender, EventArgs e)
        {
            picBackGround.Invalidate();
            Application.DoEvents();
            gameField.Redraw();
        }


        //开始游戏的方法
        private void beginGame()
        {
            
            if (currentBlock == null)
            {//第一次开始
                currentBlock = new Block(startLocation, Block.BlockTypes.undefined);
                currentBlock.Draw(gameField.winHandle);
                nextBlock = new Block(new Point(80, 50), Block.BlockTypes.undefined);
                nextBlock.Draw(pic_preView.Handle);
                stillRuning = true;
                timer1.Start();
            }
            else
            {
                timer1.Enabled = true;
            }
        }
        private void connectGameBtn_Click(object sender, EventArgs e)
        {
            /*OnlineFightEnemy ofe = new OnlineFightEnemy();
            ofe.Left = this.Left + this.Size.Width;
            ofe.Top = this.Top;
            ofe.Show();*/
            beginGame();
            //this.Focus();

        }

        private void readyBtn_Click(object sender, EventArgs e)
        {
            readyBtn.Enabled = false;
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            /*Global.pos_callback = GetPos;
            Global.server_callback = ServerCallBack;
            rbserver = new RBSocketServer("127.0.0.1", 10000);
            connectBox1.Text = "127.0.0.1:10000";


            ////////////////////////
            startGameBtn.Enabled = false;
            connectGameBtn.Enabled = false;
            readyBtn.Enabled = true;*/
        }

        /*
        public GameField GetPos()
        {
            return gameField;
        }

        public void ServerCallBack(string s)
        {
            MessageBox.Show("FROM SERVER CALL BACK:\n" + s);
        }
        */
        
    }
}
