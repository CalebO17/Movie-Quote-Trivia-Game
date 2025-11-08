namespace PersonalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            startGameBtn = new Button();
            celebLbl3 = new Label();
            celebLbl2 = new Label();
            celebLbl1 = new Label();
            quoteTxtBox1 = new TextBox();
            choose1Btn = new Button();
            celebPbx1 = new PictureBox();
            celebPbx2 = new PictureBox();
            celebPbx3 = new PictureBox();
            redX1 = new PictureBox();
            redX2 = new PictureBox();
            redX3 = new PictureBox();
            choose3Btn = new Button();
            scoreLbl = new Label();
            scoreNumbLbl = new Label();
            skipPbx = new PictureBox();
            hintPbx = new PictureBox();
            choose2Btn = new Button();
            movieGameTitleLbl = new Label();
            quoteLbl = new TextBox();
            ((System.ComponentModel.ISupportInitialize)celebPbx1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)celebPbx2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)celebPbx3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redX1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redX2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redX3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)skipPbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hintPbx).BeginInit();
            SuspendLayout();
            // 
            // startGameBtn
            // 
            startGameBtn.BackgroundImageLayout = ImageLayout.Stretch;
            startGameBtn.FlatStyle = FlatStyle.Flat;
            startGameBtn.Font = new Font("Rockwell Extra Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startGameBtn.Location = new Point(361, 218);
            startGameBtn.Name = "startGameBtn";
            startGameBtn.Size = new Size(730, 340);
            startGameBtn.TabIndex = 0;
            startGameBtn.Text = "Start Game";
            startGameBtn.UseVisualStyleBackColor = true;
            startGameBtn.Click += startGameBtn_Click;
            // 
            // celebLbl3
            // 
            celebLbl3.AutoSize = true;
            celebLbl3.Font = new Font("Modern No. 20", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            celebLbl3.Location = new Point(1110, 652);
            celebLbl3.Name = "celebLbl3";
            celebLbl3.Size = new Size(153, 25);
            celebLbl3.TabIndex = 1;
            celebLbl3.Text = "Celeb name 3";
            celebLbl3.Visible = false;
            // 
            // celebLbl2
            // 
            celebLbl2.AutoSize = true;
            celebLbl2.Font = new Font("Modern No. 20", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            celebLbl2.Location = new Point(591, 652);
            celebLbl2.Name = "celebLbl2";
            celebLbl2.Size = new Size(153, 25);
            celebLbl2.TabIndex = 2;
            celebLbl2.Text = "Celeb name 2";
            celebLbl2.Visible = false;
            // 
            // celebLbl1
            // 
            celebLbl1.AutoSize = true;
            celebLbl1.Font = new Font("Modern No. 20", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            celebLbl1.Location = new Point(72, 652);
            celebLbl1.Name = "celebLbl1";
            celebLbl1.Size = new Size(153, 25);
            celebLbl1.TabIndex = 3;
            celebLbl1.Text = "Celeb name 1";
            celebLbl1.Visible = false;
            // 
            // quoteTxtBox1
            // 
            quoteTxtBox1.BackColor = Color.DodgerBlue;
            quoteTxtBox1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            quoteTxtBox1.Location = new Point(459, 83);
            quoteTxtBox1.Multiline = true;
            quoteTxtBox1.Name = "quoteTxtBox1";
            quoteTxtBox1.Size = new Size(548, 127);
            quoteTxtBox1.TabIndex = 7;
            quoteTxtBox1.Visible = false;
            // 
            // choose1Btn
            // 
            choose1Btn.Location = new Point(72, 218);
            choose1Btn.Name = "choose1Btn";
            choose1Btn.Size = new Size(213, 91);
            choose1Btn.TabIndex = 8;
            choose1Btn.Text = "Choose";
            choose1Btn.UseVisualStyleBackColor = true;
            choose1Btn.Visible = false;
            choose1Btn.Click += choose1Btn_Click;
            // 
            // celebPbx1
            // 
            celebPbx1.BackgroundImageLayout = ImageLayout.None;
            celebPbx1.Location = new Point(72, 343);
            celebPbx1.Name = "celebPbx1";
            celebPbx1.Size = new Size(213, 282);
            celebPbx1.SizeMode = PictureBoxSizeMode.StretchImage;
            celebPbx1.TabIndex = 11;
            celebPbx1.TabStop = false;
            celebPbx1.Visible = false;
            // 
            // celebPbx2
            // 
            celebPbx2.BackgroundImageLayout = ImageLayout.None;
            celebPbx2.Location = new Point(591, 343);
            celebPbx2.Name = "celebPbx2";
            celebPbx2.Size = new Size(213, 282);
            celebPbx2.SizeMode = PictureBoxSizeMode.StretchImage;
            celebPbx2.TabIndex = 12;
            celebPbx2.TabStop = false;
            celebPbx2.Visible = false;
            // 
            // celebPbx3
            // 
            celebPbx3.BackgroundImageLayout = ImageLayout.None;
            celebPbx3.Location = new Point(1110, 343);
            celebPbx3.Name = "celebPbx3";
            celebPbx3.Size = new Size(213, 282);
            celebPbx3.SizeMode = PictureBoxSizeMode.StretchImage;
            celebPbx3.TabIndex = 13;
            celebPbx3.TabStop = false;
            celebPbx3.Visible = false;
            // 
            // redX1
            // 
            redX1.BackColor = Color.Transparent;
            redX1.Image = (Image)resources.GetObject("redX1.Image");
            redX1.Location = new Point(1147, 66);
            redX1.Name = "redX1";
            redX1.Size = new Size(66, 65);
            redX1.SizeMode = PictureBoxSizeMode.StretchImage;
            redX1.TabIndex = 14;
            redX1.TabStop = false;
            redX1.Visible = false;
            // 
            // redX2
            // 
            redX2.BackColor = Color.Transparent;
            redX2.BackgroundImageLayout = ImageLayout.None;
            redX2.Image = Properties.Resources.redx_removebg_preview;
            redX2.Location = new Point(1240, 66);
            redX2.Name = "redX2";
            redX2.Size = new Size(66, 65);
            redX2.SizeMode = PictureBoxSizeMode.StretchImage;
            redX2.TabIndex = 15;
            redX2.TabStop = false;
            redX2.Visible = false;
            // 
            // redX3
            // 
            redX3.BackColor = Color.Transparent;
            redX3.Image = Properties.Resources.redx_removebg_preview;
            redX3.Location = new Point(1334, 66);
            redX3.Name = "redX3";
            redX3.Size = new Size(66, 65);
            redX3.SizeMode = PictureBoxSizeMode.StretchImage;
            redX3.TabIndex = 16;
            redX3.TabStop = false;
            redX3.Visible = false;
            // 
            // choose3Btn
            // 
            choose3Btn.Location = new Point(1110, 218);
            choose3Btn.Name = "choose3Btn";
            choose3Btn.Size = new Size(213, 91);
            choose3Btn.TabIndex = 19;
            choose3Btn.Text = "Choose";
            choose3Btn.UseVisualStyleBackColor = true;
            choose3Btn.Visible = false;
            choose3Btn.Click += choose3Btn_Click;
            // 
            // scoreLbl
            // 
            scoreLbl.AutoSize = true;
            scoreLbl.Location = new Point(10, 3);
            scoreLbl.Name = "scoreLbl";
            scoreLbl.Size = new Size(73, 32);
            scoreLbl.TabIndex = 21;
            scoreLbl.Text = "Score";
            // 
            // scoreNumbLbl
            // 
            scoreNumbLbl.AutoSize = true;
            scoreNumbLbl.Cursor = Cursors.Hand;
            scoreNumbLbl.Location = new Point(10, 45);
            scoreNumbLbl.Name = "scoreNumbLbl";
            scoreNumbLbl.Size = new Size(62, 32);
            scoreNumbLbl.TabIndex = 22;
            scoreNumbLbl.Text = "0/10";
            // 
            // skipPbx
            // 
            skipPbx.BackColor = Color.Transparent;
            skipPbx.Image = Properties.Resources.Skip;
            skipPbx.Location = new Point(288, 728);
            skipPbx.Name = "skipPbx";
            skipPbx.Size = new Size(101, 97);
            skipPbx.SizeMode = PictureBoxSizeMode.StretchImage;
            skipPbx.TabIndex = 23;
            skipPbx.TabStop = false;
            skipPbx.Visible = false;
            skipPbx.Click += skipPbx_Click;
            // 
            // hintPbx
            // 
            hintPbx.BackColor = Color.Transparent;
            hintPbx.Image = Properties.Resources.questionMark;
            hintPbx.Location = new Point(459, 728);
            hintPbx.Name = "hintPbx";
            hintPbx.Size = new Size(101, 97);
            hintPbx.SizeMode = PictureBoxSizeMode.StretchImage;
            hintPbx.TabIndex = 24;
            hintPbx.TabStop = false;
            hintPbx.Visible = false;
            hintPbx.Click += hintPbx_Click;
            // 
            // choose2Btn
            // 
            choose2Btn.Location = new Point(591, 218);
            choose2Btn.Name = "choose2Btn";
            choose2Btn.Size = new Size(213, 91);
            choose2Btn.TabIndex = 18;
            choose2Btn.Text = "Choose";
            choose2Btn.UseVisualStyleBackColor = true;
            choose2Btn.Visible = false;
            choose2Btn.Click += choose2Btn_Click;
            // 
            // movieGameTitleLbl
            // 
            movieGameTitleLbl.AutoSize = true;
            movieGameTitleLbl.BackColor = Color.DodgerBlue;
            movieGameTitleLbl.Font = new Font("Gill Sans Ultra Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieGameTitleLbl.Location = new Point(436, 115);
            movieGameTitleLbl.Name = "movieGameTitleLbl";
            movieGameTitleLbl.Size = new Size(597, 69);
            movieGameTitleLbl.TabIndex = 25;
            movieGameTitleLbl.Text = "Movie Quote Game!";
            // 
            // quoteLbl
            // 
            quoteLbl.BackColor = Color.White;
            quoteLbl.Font = new Font("Franklin Gothic Medium Cond", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quoteLbl.Location = new Point(646, 3);
            quoteLbl.Multiline = true;
            quoteLbl.Name = "quoteLbl";
            quoteLbl.Size = new Size(158, 74);
            quoteLbl.TabIndex = 26;
            quoteLbl.Text = "Quote:";
            quoteLbl.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_11_08_150135;
            ClientSize = new Size(1442, 848);
            Controls.Add(quoteLbl);
            Controls.Add(movieGameTitleLbl);
            Controls.Add(hintPbx);
            Controls.Add(skipPbx);
            Controls.Add(scoreNumbLbl);
            Controls.Add(scoreLbl);
            Controls.Add(choose3Btn);
            Controls.Add(choose2Btn);
            Controls.Add(redX3);
            Controls.Add(redX2);
            Controls.Add(redX1);
            Controls.Add(celebPbx3);
            Controls.Add(celebPbx2);
            Controls.Add(celebPbx1);
            Controls.Add(choose1Btn);
            Controls.Add(quoteTxtBox1);
            Controls.Add(celebLbl1);
            Controls.Add(celebLbl2);
            Controls.Add(celebLbl3);
            Controls.Add(startGameBtn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)celebPbx1).EndInit();
            ((System.ComponentModel.ISupportInitialize)celebPbx2).EndInit();
            ((System.ComponentModel.ISupportInitialize)celebPbx3).EndInit();
            ((System.ComponentModel.ISupportInitialize)redX1).EndInit();
            ((System.ComponentModel.ISupportInitialize)redX2).EndInit();
            ((System.ComponentModel.ISupportInitialize)redX3).EndInit();
            ((System.ComponentModel.ISupportInitialize)skipPbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)hintPbx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startGameBtn;
        private Label celebLbl3;
        private Label celebLbl2;
        private Label celebLbl1;
        private TextBox quoteTxtBox1;
        private Button choose1Btn;
        private PictureBox celebPbx1;
        private PictureBox celebPbx2;
        private PictureBox celebPbx3;
        private PictureBox redX1;
        private PictureBox redX2;
        private PictureBox redX3;
        private Button choose3Btn;
        private Label scoreLbl;
        private Label scoreNumbLbl;
        private PictureBox skipPbx;
        private PictureBox hintPbx;
        private Button choose2Btn;
        private Label movieGameTitleLbl;
        private TextBox quoteLbl;
    }
}
