namespace ChinaBlock
{
    partial class LocalSingleFight
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
            this.components = new System.ComponentModel.Container();
            this.picBackGround = new System.Windows.Forms.PictureBox();
            this.pic_preView = new System.Windows.Forms.PictureBox();
            this.t_score = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.游戏设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.速度设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.较慢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.慢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.快ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.较快ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.非常快ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景颜色设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.方块颜色设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.恢复默认设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.结束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.msg = new System.Windows.Forms.Label();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.itemTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_preView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBackGround
            // 
            this.picBackGround.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picBackGround.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBackGround.Location = new System.Drawing.Point(19, 106);
            this.picBackGround.Name = "picBackGround";
            this.picBackGround.Size = new System.Drawing.Size(240, 400);
            this.picBackGround.TabIndex = 0;
            this.picBackGround.TabStop = false;
            // 
            // pic_preView
            // 
            this.pic_preView.BackColor = System.Drawing.Color.LightGray;
            this.pic_preView.Location = new System.Drawing.Point(303, 332);
            this.pic_preView.Name = "pic_preView";
            this.pic_preView.Size = new System.Drawing.Size(186, 125);
            this.pic_preView.TabIndex = 2;
            this.pic_preView.TabStop = false;
            // 
            // t_score
            // 
            this.t_score.AutoSize = true;
            this.t_score.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.t_score.ForeColor = System.Drawing.Color.Green;
            this.t_score.Location = new System.Drawing.Point(413, 176);
            this.t_score.Name = "t_score";
            this.t_score.Size = new System.Drawing.Size(16, 16);
            this.t_score.TabIndex = 4;
            this.t_score.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.游戏设置ToolStripMenuItem,
            this.控制ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 游戏设置ToolStripMenuItem
            // 
            this.游戏设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.速度设置ToolStripMenuItem,
            this.背景颜色设置ToolStripMenuItem,
            this.方块颜色设置ToolStripMenuItem,
            this.恢复默认设置ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.退出ToolStripMenuItem});
            this.游戏设置ToolStripMenuItem.Name = "游戏设置ToolStripMenuItem";
            this.游戏设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.游戏设置ToolStripMenuItem.Text = "游戏设置";
            // 
            // 速度设置ToolStripMenuItem
            // 
            this.速度设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.较慢ToolStripMenuItem,
            this.慢ToolStripMenuItem,
            this.快ToolStripMenuItem,
            this.较快ToolStripMenuItem,
            this.非常快ToolStripMenuItem});
            this.速度设置ToolStripMenuItem.Name = "速度设置ToolStripMenuItem";
            this.速度设置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.速度设置ToolStripMenuItem.Text = "速度设置";
            // 
            // 较慢ToolStripMenuItem
            // 
            this.较慢ToolStripMenuItem.Checked = true;
            this.较慢ToolStripMenuItem.CheckOnClick = true;
            this.较慢ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.较慢ToolStripMenuItem.Name = "较慢ToolStripMenuItem";
            this.较慢ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.较慢ToolStripMenuItem.Text = "较慢";
            this.较慢ToolStripMenuItem.Click += new System.EventHandler(this.较慢ToolStripMenuItem_Click);
            // 
            // 慢ToolStripMenuItem
            // 
            this.慢ToolStripMenuItem.CheckOnClick = true;
            this.慢ToolStripMenuItem.Name = "慢ToolStripMenuItem";
            this.慢ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.慢ToolStripMenuItem.Text = "慢";
            this.慢ToolStripMenuItem.Click += new System.EventHandler(this.慢ToolStripMenuItem_Click);
            // 
            // 快ToolStripMenuItem
            // 
            this.快ToolStripMenuItem.CheckOnClick = true;
            this.快ToolStripMenuItem.Name = "快ToolStripMenuItem";
            this.快ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.快ToolStripMenuItem.Text = "快";
            this.快ToolStripMenuItem.Click += new System.EventHandler(this.快ToolStripMenuItem_Click);
            // 
            // 较快ToolStripMenuItem
            // 
            this.较快ToolStripMenuItem.CheckOnClick = true;
            this.较快ToolStripMenuItem.Name = "较快ToolStripMenuItem";
            this.较快ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.较快ToolStripMenuItem.Text = "较快";
            this.较快ToolStripMenuItem.Click += new System.EventHandler(this.较快ToolStripMenuItem_Click);
            // 
            // 非常快ToolStripMenuItem
            // 
            this.非常快ToolStripMenuItem.CheckOnClick = true;
            this.非常快ToolStripMenuItem.Name = "非常快ToolStripMenuItem";
            this.非常快ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.非常快ToolStripMenuItem.Text = "非常快";
            this.非常快ToolStripMenuItem.Click += new System.EventHandler(this.非常快ToolStripMenuItem_Click);
            // 
            // 背景颜色设置ToolStripMenuItem
            // 
            this.背景颜色设置ToolStripMenuItem.Name = "背景颜色设置ToolStripMenuItem";
            this.背景颜色设置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.背景颜色设置ToolStripMenuItem.Text = "背景颜色设置";
            this.背景颜色设置ToolStripMenuItem.Click += new System.EventHandler(this.背景颜色设置ToolStripMenuItem_Click);
            // 
            // 方块颜色设置ToolStripMenuItem
            // 
            this.方块颜色设置ToolStripMenuItem.Name = "方块颜色设置ToolStripMenuItem";
            this.方块颜色设置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.方块颜色设置ToolStripMenuItem.Text = "方块颜色设置";
            this.方块颜色设置ToolStripMenuItem.Click += new System.EventHandler(this.方块颜色设置ToolStripMenuItem_Click);
            // 
            // 恢复默认设置ToolStripMenuItem
            // 
            this.恢复默认设置ToolStripMenuItem.Name = "恢复默认设置ToolStripMenuItem";
            this.恢复默认设置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.恢复默认设置ToolStripMenuItem.Text = "恢复默认设置";
            this.恢复默认设置ToolStripMenuItem.Click += new System.EventHandler(this.恢复默认设置ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 控制ToolStripMenuItem
            // 
            this.控制ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.暂停ToolStripMenuItem1,
            this.结束ToolStripMenuItem,
            this.重新开始ToolStripMenuItem});
            this.控制ToolStripMenuItem.Name = "控制ToolStripMenuItem";
            this.控制ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.控制ToolStripMenuItem.Text = "控制";
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.开始ToolStripMenuItem.Text = "开始";
            this.开始ToolStripMenuItem.Click += new System.EventHandler(this.开始ToolStripMenuItem1_Click);
            // 
            // 暂停ToolStripMenuItem1
            // 
            this.暂停ToolStripMenuItem1.Enabled = false;
            this.暂停ToolStripMenuItem1.Name = "暂停ToolStripMenuItem1";
            this.暂停ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.暂停ToolStripMenuItem1.Text = "暂停";
            this.暂停ToolStripMenuItem1.Click += new System.EventHandler(this.暂停ToolStripMenuItem1_Click);
            // 
            // 结束ToolStripMenuItem
            // 
            this.结束ToolStripMenuItem.Enabled = false;
            this.结束ToolStripMenuItem.Name = "结束ToolStripMenuItem";
            this.结束ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.结束ToolStripMenuItem.Text = "结束";
            this.结束ToolStripMenuItem.Click += new System.EventHandler(this.结束ToolStripMenuItem_Click);
            // 
            // 重新开始ToolStripMenuItem
            // 
            this.重新开始ToolStripMenuItem.Name = "重新开始ToolStripMenuItem";
            this.重新开始ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.重新开始ToolStripMenuItem.Text = "重新开始";
            this.重新开始ToolStripMenuItem.Click += new System.EventHandler(this.重新开始ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem,
            this.操作说明ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 操作说明ToolStripMenuItem
            // 
            this.操作说明ToolStripMenuItem.Name = "操作说明ToolStripMenuItem";
            this.操作说明ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.操作说明ToolStripMenuItem.Text = "操作说明";
            this.操作说明ToolStripMenuItem.Click += new System.EventHandler(this.操作说明ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.BackColor = System.Drawing.Color.White;
            this.msg.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.msg.Location = new System.Drawing.Point(126, 173);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(39, 20);
            this.msg.TabIndex = 7;
            this.msg.Text = "msg";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.OwnerForm = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(303, 276);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = this.metroStyleManager1;
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "下一个：";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(330, 173);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = this.metroStyleManager1;
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "分数：";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // itemTimer
            // 
            this.itemTimer.Interval = 5000;
            this.itemTimer.Tick += new System.EventHandler(this.itemTimer_Tick);
            // 
            // LocalSingleFight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 540);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.t_score);
            this.Controls.Add(this.pic_preView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picBackGround);
            this.Controls.Add(this.msg);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LocalSingleFight";
            this.StyleManager = this.metroStyleManager1;
            this.Text = "俄罗斯方块";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_preView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackGround;
        private System.Windows.Forms.PictureBox pic_preView;
        private System.Windows.Forms.Label t_score;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 游戏设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 速度设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景颜色设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 控制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 结束ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新开始ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.ToolStripMenuItem 方块颜色设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 较慢ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 慢ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 快ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 较快ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 非常快ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 恢复默认设置ToolStripMenuItem;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Timer itemTimer;
    }
}

