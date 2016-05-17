using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChinaBlock
{
    public partial class setGameFieldBgColor : Form
    {
        public setGameFieldBgColor()
        {
            InitializeComponent();
        }

        private void setGameFieldBgColor_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = GameField.BackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameField.BackColor = pictureBox1.BackColor;
            //游戏设置已改变
            GameField.isChanged = true;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        
    }
}