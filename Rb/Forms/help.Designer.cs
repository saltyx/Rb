namespace ChinaBlock
{
    partial class help
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 168);
            this.label1.TabIndex = 0;
            this.label1.Text = "控制热键：\r\n\r\n\r\n“←”：向左移动方块；\r\n\r\n“→”：向右移动方块；\r\n\r\n“↓”：向下加速移动方块；\r\n\r\n“↑”：旋转方块；\r\n\r\n“空格”：暂停；\r\n" +
    "\r\n“回车”：开始。\r\n";
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = false;
            this.metroButton1.Location = new System.Drawing.Point(100, 239);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.StyleManager = null;
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "关闭";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 285);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "help";
            this.Text = "操作说明";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}