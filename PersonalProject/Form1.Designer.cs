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
            startGameBtn = new Button();
            actorLbl3 = new Label();
            actorLbl2 = new Label();
            actorLbl1 = new Label();
            celebrityListBox = new ListBox();
            SuspendLayout();
            // 
            // startGameBtn
            // 
            startGameBtn.Location = new Point(641, 147);
            startGameBtn.Name = "startGameBtn";
            startGameBtn.Size = new Size(150, 46);
            startGameBtn.TabIndex = 0;
            startGameBtn.Text = "Start Game";
            startGameBtn.UseVisualStyleBackColor = true;
            startGameBtn.Click += startGameBtn_Click;
            // 
            // actorLbl3
            // 
            actorLbl3.AutoSize = true;
            actorLbl3.Location = new Point(272, 334);
            actorLbl3.Name = "actorLbl3";
            actorLbl3.Size = new Size(0, 32);
            actorLbl3.TabIndex = 1;
            // 
            // actorLbl2
            // 
            actorLbl2.AutoSize = true;
            actorLbl2.Location = new Point(692, 328);
            actorLbl2.Name = "actorLbl2";
            actorLbl2.Size = new Size(0, 32);
            actorLbl2.TabIndex = 2;
            // 
            // actorLbl1
            // 
            actorLbl1.AutoSize = true;
            actorLbl1.Location = new Point(1060, 344);
            actorLbl1.Name = "actorLbl1";
            actorLbl1.Size = new Size(0, 32);
            actorLbl1.TabIndex = 3;
            // 
            // celebrityListBox
            // 
            celebrityListBox.FormattingEnabled = true;
            celebrityListBox.Location = new Point(448, 476);
            celebrityListBox.Name = "celebrityListBox";
            celebrityListBox.Size = new Size(982, 164);
            celebrityListBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 848);
            Controls.Add(celebrityListBox);
            Controls.Add(actorLbl1);
            Controls.Add(actorLbl2);
            Controls.Add(actorLbl3);
            Controls.Add(startGameBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startGameBtn;
        private Label actorLbl3;
        private Label actorLbl2;
        private Label actorLbl1;
        private ListBox celebrityListBox;
    }
}
