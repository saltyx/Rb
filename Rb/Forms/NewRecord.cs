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
    public partial class NewRecord : MetroForm
    {
        private int score;
        private string user;
        public NewRecord()
        {
            InitializeComponent();
        }

        public int getScore()
        {
            return score;
        }

        private void NewRecord_Load(object sender, EventArgs e)
        {
            gameScoreBox.Text = score.ToString();
        }

        public void setScore(int playerScore)
        {
            score = playerScore;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlHelper data = new SqlHelper();
            user = gamerNameBox.Text;
            data.ExcuteSql(string.Format("INSERT INTO singleR VALUES('{0}', {1})", user, score));
        }

      
    }
}
