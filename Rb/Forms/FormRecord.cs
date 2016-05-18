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
namespace ChinaBlock.Forms
{
    public partial class FormRecord : MetroForm
    {

        public FormRecord()
        {
            InitializeComponent();
        }

        private void FormRecord_Load(object sender, EventArgs e)
        {
            SqlHelper sqlhelper = new SqlHelper();
            DataSet ds = sqlhelper.GetDataSet("select top 10 username as 用户名, score as 得分 from record order by score", "record");
            this.dataGridView1.DataSource = ds.Tables["record"];
        }
    }
}
