using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ChinaBlock
{
    public partial class help : MetroForm
    {
        public help()
        {
            InitializeComponent();
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}