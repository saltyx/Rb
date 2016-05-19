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
    public partial class OnlineFightEnemy : MetroForm
    {
        GameField enemyGameField = new GameField();

        public OnlineFightEnemy()
        {
            InitializeComponent();
        }

        public void setFieldBitBlock(int[] bitBlock)
        {
            enemyGameField.arrBitBlock = bitBlock;
        }


        private void OnlineFightEnemy_Load(object sender, EventArgs e)
        {
            timer1.Start();

            for(int x = 0; x < GameField.width; x++)
            {
                for(int y = 0; y < GameField.height; y++)
                {
                    enemyGameField.arriveBlock[x, y] = new Square(new Size(GameField.SquareSize, GameField.SquareSize), Color.Beige, Color.SkyBlue);
                    enemyGameField.arriveBlock[x, y].location = new Point(x*GameField.SquareSize, y*GameField.SquareSize);
                }
            }
            GameField.BackColor = picBackGroundEnemy.BackColor;
            enemyGameField.winHandle = picBackGroundEnemy.Handle;
            //颜色设置
            GameField.BackColor = Color.WhiteSmoke;
            GameField.BlockForeColor = new Color[] { Color.SkyBlue, Color.SkyBlue, Color.SkyBlue, Color.SkyBlue, Color.SkyBlue, Color.SkyBlue, Color.SkyBlue };
            GameField.BlockBackColor = new Color[] { Color.DimGray, Color.DimGray, Color.DimGray, Color.DimGray, Color.DimGray, Color.DimGray, Color.DimGray };
            enemyGameField.Redraw();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            enemyGameField.Redraw();
        }
    }
}
