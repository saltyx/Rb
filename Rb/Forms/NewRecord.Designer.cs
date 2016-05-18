namespace ChinaBlock
{
    partial class NewRecord
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
            this.gameScoreBox = new MetroFramework.Controls.MetroTextBox();
            this.gamerNameBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // gameScoreBox
            // 
            this.gameScoreBox.Enabled = false;
            this.gameScoreBox.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.gameScoreBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.gameScoreBox.Location = new System.Drawing.Point(154, 92);
            this.gameScoreBox.Multiline = false;
            this.gameScoreBox.Name = "gameScoreBox";
            this.gameScoreBox.SelectedText = "";
            this.gameScoreBox.Size = new System.Drawing.Size(124, 23);
            this.gameScoreBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.gameScoreBox.StyleManager = null;
            this.gameScoreBox.TabIndex = 0;
            this.gameScoreBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gameScoreBox.UseStyleColors = false;
            // 
            // gamerNameBox
            // 
            this.gamerNameBox.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.gamerNameBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.gamerNameBox.Location = new System.Drawing.Point(154, 151);
            this.gamerNameBox.Multiline = false;
            this.gamerNameBox.Name = "gamerNameBox";
            this.gamerNameBox.SelectedText = "";
            this.gamerNameBox.Size = new System.Drawing.Size(124, 23);
            this.gamerNameBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.gamerNameBox.StyleManager = null;
            this.gamerNameBox.TabIndex = 1;
            this.gamerNameBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gamerNameBox.UseStyleColors = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(64, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "您的分数：";
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
            this.metroLabel2.Location = new System.Drawing.Point(36, 151);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(107, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "您的尊姓大名：";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = false;
            this.metroButton1.Location = new System.Drawing.Point(68, 215);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.StyleManager = null;
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "确定";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = false;
            this.metroButton2.Location = new System.Drawing.Point(167, 215);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.StyleManager = null;
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "取消";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // NewRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 287);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.gamerNameBox);
            this.Controls.Add(this.gameScoreBox);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "NewRecord";
            this.Text = "记录分数";
            this.Load += new System.EventHandler(this.NewRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox gameScoreBox;
        private MetroFramework.Controls.MetroTextBox gamerNameBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}