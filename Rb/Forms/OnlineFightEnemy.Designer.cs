namespace ChinaBlock
{
    partial class OnlineFightEnemy
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
            this.picBackGroundEnemy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBackGroundEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // picBackGroundEnemy
            // 
            this.picBackGroundEnemy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picBackGroundEnemy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBackGroundEnemy.Location = new System.Drawing.Point(52, 67);
            this.picBackGroundEnemy.Name = "picBackGroundEnemy";
            this.picBackGroundEnemy.Size = new System.Drawing.Size(240, 400);
            this.picBackGroundEnemy.TabIndex = 1;
            this.picBackGroundEnemy.TabStop = false;
            // 
            // OnlineFightEnemy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 490);
            this.Controls.Add(this.picBackGroundEnemy);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "OnlineFightEnemy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "对方情况";
            ((System.ComponentModel.ISupportInitialize)(this.picBackGroundEnemy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackGroundEnemy;
    }
}