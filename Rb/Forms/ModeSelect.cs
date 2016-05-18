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
using ChinaBlock.Forms;

namespace ChinaBlock
{
    public partial class ModeSelect : MetroForm
    {
        public ModeSelect()
        {
            InitializeComponent();
        }

        private void ModeSelect_Load(object sender, EventArgs e)
        {

        }

        private void gameClose(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            LocalSingleFight lsf = new LocalSingleFight();
            lsf.FormClosed += gameClose;
            lsf.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            LocalDoubleFight ldf = new LocalDoubleFight();
            ldf.FormClosed += gameClose;
            ldf.Show();
            this.Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            OnlineFight of = new OnlineFight();
            of.FormClosed += gameClose;
            of.Show();
            this.Hide();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            FormRecord frm = new FormRecord();
            frm.ShowDialog();
        }
    }
}
