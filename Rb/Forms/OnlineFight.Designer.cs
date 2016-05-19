namespace ChinaBlock
{
    partial class OnlineFight
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startGameBtn = new MetroFramework.Controls.MetroButton();
            this.connectGameBtn = new MetroFramework.Controls.MetroButton();
            this.readyBtn = new MetroFramework.Controls.MetroButton();
            this.connectBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.t_score = new System.Windows.Forms.Label();
            this.pic_preView = new System.Windows.Forms.PictureBox();
            this.picBackGround = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.BlindItemCountInPlayer11 = new System.Windows.Forms.Label();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.connectBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.BlindItemTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_preView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // startGameBtn
            // 
            this.startGameBtn.Highlight = false;
            this.startGameBtn.Location = new System.Drawing.Point(208, 95);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(75, 23);
            this.startGameBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.startGameBtn.StyleManager = null;
            this.startGameBtn.TabIndex = 0;
            this.startGameBtn.Text = "开设房间";
            this.startGameBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // connectGameBtn
            // 
            this.connectGameBtn.Highlight = false;
            this.connectGameBtn.Location = new System.Drawing.Point(208, 124);
            this.connectGameBtn.Name = "connectGameBtn";
            this.connectGameBtn.Size = new System.Drawing.Size(75, 23);
            this.connectGameBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.connectGameBtn.StyleManager = null;
            this.connectGameBtn.TabIndex = 1;
            this.connectGameBtn.Text = "连接房间";
            this.connectGameBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.connectGameBtn.Click += new System.EventHandler(this.connectGameBtn_Click);
            // 
            // readyBtn
            // 
            this.readyBtn.Enabled = false;
            this.readyBtn.Highlight = false;
            this.readyBtn.Location = new System.Drawing.Point(118, 163);
            this.readyBtn.Name = "readyBtn";
            this.readyBtn.Size = new System.Drawing.Size(75, 23);
            this.readyBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.readyBtn.StyleManager = null;
            this.readyBtn.TabIndex = 2;
            this.readyBtn.Text = "准备";
            this.readyBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.readyBtn.Click += new System.EventHandler(this.readyBtn_Click);
            // 
            // connectBox2
            // 
            this.connectBox2.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.connectBox2.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.connectBox2.Location = new System.Drawing.Point(43, 124);
            this.connectBox2.Multiline = false;
            this.connectBox2.Name = "connectBox2";
            this.connectBox2.SelectedText = "";
            this.connectBox2.Size = new System.Drawing.Size(150, 23);
            this.connectBox2.Style = MetroFramework.MetroColorStyle.Blue;
            this.connectBox2.StyleManager = null;
            this.connectBox2.TabIndex = 3;
            this.connectBox2.Text = "127.0.0.1";
            this.connectBox2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.connectBox2.UseStyleColors = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(407, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "您的分数：";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(379, 273);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "下一个：";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // t_score
            // 
            this.t_score.AutoSize = true;
            this.t_score.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.t_score.ForeColor = System.Drawing.Color.Green;
            this.t_score.Location = new System.Drawing.Point(490, 98);
            this.t_score.Name = "t_score";
            this.t_score.Size = new System.Drawing.Size(16, 16);
            this.t_score.TabIndex = 12;
            this.t_score.Text = "0";
            // 
            // pic_preView
            // 
            this.pic_preView.BackColor = System.Drawing.Color.LightGray;
            this.pic_preView.Location = new System.Drawing.Point(379, 369);
            this.pic_preView.Name = "pic_preView";
            this.pic_preView.Size = new System.Drawing.Size(186, 125);
            this.pic_preView.TabIndex = 11;
            this.pic_preView.TabStop = false;
            // 
            // picBackGround
            // 
            this.picBackGround.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picBackGround.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBackGround.Location = new System.Drawing.Point(43, 202);
            this.picBackGround.Name = "picBackGround";
            this.picBackGround.Size = new System.Drawing.Size(240, 400);
            this.picBackGround.TabIndex = 10;
            this.picBackGround.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(265, 605);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "0";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.CustomBackground = false;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel8.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel8.Location = new System.Drawing.Point(180, 605);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(79, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel8.StyleManager = null;
            this.metroLabel8.TabIndex = 30;
            this.metroLabel8.Text = "禁手道具：";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel8.UseStyleColors = false;
            // 
            // BlindItemCountInPlayer11
            // 
            this.BlindItemCountInPlayer11.AutoSize = true;
            this.BlindItemCountInPlayer11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BlindItemCountInPlayer11.ForeColor = System.Drawing.Color.Green;
            this.BlindItemCountInPlayer11.Location = new System.Drawing.Point(145, 605);
            this.BlindItemCountInPlayer11.Name = "BlindItemCountInPlayer11";
            this.BlindItemCountInPlayer11.Size = new System.Drawing.Size(16, 16);
            this.BlindItemCountInPlayer11.TabIndex = 29;
            this.BlindItemCountInPlayer11.Text = "0";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.CustomBackground = false;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel6.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel6.Location = new System.Drawing.Point(60, 605);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(79, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.StyleManager = null;
            this.metroLabel6.TabIndex = 28;
            this.metroLabel6.Text = "蒙眼道具：";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel6.UseStyleColors = false;
            // 
            // connectBox1
            // 
            this.connectBox1.Enabled = false;
            this.connectBox1.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.connectBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.connectBox1.Location = new System.Drawing.Point(43, 95);
            this.connectBox1.Multiline = false;
            this.connectBox1.Name = "connectBox1";
            this.connectBox1.SelectedText = "";
            this.connectBox1.Size = new System.Drawing.Size(150, 23);
            this.connectBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.connectBox1.StyleManager = null;
            this.connectBox1.TabIndex = 32;
            this.connectBox1.Text = "开设房间后产生的地址";
            this.connectBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.connectBox1.UseStyleColors = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = false;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel3.Location = new System.Drawing.Point(407, 128);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.StyleManager = null;
            this.metroLabel3.TabIndex = 34;
            this.metroLabel3.Text = "对方分数：";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(490, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "0";
            // 
            // BlindItemTimer
            // 
            this.BlindItemTimer.Interval = 1100;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OnlineFight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 647);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.connectBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.BlindItemCountInPlayer11);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.t_score);
            this.Controls.Add(this.pic_preView);
            this.Controls.Add(this.picBackGround);
            this.Controls.Add(this.connectBox2);
            this.Controls.Add(this.readyBtn);
            this.Controls.Add(this.connectGameBtn);
            this.Controls.Add(this.startGameBtn);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "OnlineFight";
            this.Text = "网络对战";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnlineFight_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_preView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton startGameBtn;
        private MetroFramework.Controls.MetroButton connectGameBtn;
        private MetroFramework.Controls.MetroButton readyBtn;
        private MetroFramework.Controls.MetroTextBox connectBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label t_score;
        private System.Windows.Forms.PictureBox pic_preView;
        private System.Windows.Forms.PictureBox picBackGround;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.Label BlindItemCountInPlayer11;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox connectBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer BlindItemTimer;
        private System.Windows.Forms.Timer timer1;
    }
}