namespace CrabGame2
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bg = new System.Windows.Forms.PictureBox();
            this.crab = new System.Windows.Forms.PictureBox();
            this.monkey = new System.Windows.Forms.PictureBox();
            this.kaki = new System.Windows.Forms.PictureBox();
            this.lychee = new System.Windows.Forms.PictureBox();
            this.lychee2 = new System.Windows.Forms.PictureBox();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monkey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lychee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lychee2)).BeginInit();
            this.SuspendLayout();
            // 
            // bg
            // 
            this.bg.Image = ((System.Drawing.Image)(resources.GetObject("bg.Image")));
            this.bg.Location = new System.Drawing.Point(0, 0);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(783, 461);
            this.bg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg.TabIndex = 0;
            this.bg.TabStop = false;
            // 
            // crab
            // 
            this.crab.Image = ((System.Drawing.Image)(resources.GetObject("crab.Image")));
            this.crab.Location = new System.Drawing.Point(308, 331);
            this.crab.Name = "crab";
            this.crab.Size = new System.Drawing.Size(147, 118);
            this.crab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crab.TabIndex = 1;
            this.crab.TabStop = false;
            // 
            // monkey
            // 
            this.monkey.Image = ((System.Drawing.Image)(resources.GetObject("monkey.Image")));
            this.monkey.Location = new System.Drawing.Point(326, 0);
            this.monkey.Name = "monkey";
            this.monkey.Size = new System.Drawing.Size(129, 103);
            this.monkey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monkey.TabIndex = 2;
            this.monkey.TabStop = false;
            // 
            // kaki
            // 
            this.kaki.Image = ((System.Drawing.Image)(resources.GetObject("kaki.Image")));
            this.kaki.Location = new System.Drawing.Point(145, 66);
            this.kaki.Name = "kaki";
            this.kaki.Size = new System.Drawing.Size(65, 62);
            this.kaki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kaki.TabIndex = 3;
            this.kaki.TabStop = false;
            // 
            // lychee
            // 
            this.lychee.Image = ((System.Drawing.Image)(resources.GetObject("lychee.Image")));
            this.lychee.Location = new System.Drawing.Point(343, 109);
            this.lychee.Name = "lychee";
            this.lychee.Size = new System.Drawing.Size(65, 62);
            this.lychee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lychee.TabIndex = 4;
            this.lychee.TabStop = false;
            // 
            // lychee2
            // 
            this.lychee2.Image = ((System.Drawing.Image)(resources.GetObject("lychee2.Image")));
            this.lychee2.Location = new System.Drawing.Point(597, 90);
            this.lychee2.Name = "lychee2";
            this.lychee2.Size = new System.Drawing.Size(65, 62);
            this.lychee2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lychee2.TabIndex = 5;
            this.lychee2.TabStop = false;
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.Font = new System.Drawing.Font("Meiryo UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelGameOver.Location = new System.Drawing.Point(294, 174);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(187, 81);
            this.labelGameOver.TabIndex = 6;
            this.labelGameOver.Text = "WIN";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelScore.Location = new System.Drawing.Point(13, 186);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(141, 35);
            this.labelScore.TabIndex = 7;
            this.labelScore.Text = "Points: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.lychee2);
            this.Controls.Add(this.lychee);
            this.Controls.Add(this.kaki);
            this.Controls.Add(this.monkey);
            this.Controls.Add(this.crab);
            this.Controls.Add(this.bg);
            this.Name = "Form1";
            this.Text = "CrabGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monkey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lychee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lychee2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bg;
        private System.Windows.Forms.PictureBox crab;
        private System.Windows.Forms.PictureBox monkey;
        private System.Windows.Forms.PictureBox kaki;
        private System.Windows.Forms.PictureBox lychee;
        private System.Windows.Forms.PictureBox lychee2;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelScore;
    }
}

