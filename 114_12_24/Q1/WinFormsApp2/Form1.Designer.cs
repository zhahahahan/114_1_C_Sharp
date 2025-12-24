namespace WinFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblComputerTitle;
        private System.Windows.Forms.Label lblPlayerTitle;
        private System.Windows.Forms.Panel panelComputer;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.PictureBox pbComputerHand;
        private System.Windows.Forms.PictureBox pbPlayerHand;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnExit;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblComputerTitle = new Label();
            lblPlayerTitle = new Label();
            panelComputer = new Panel();
            pbComputerHand = new PictureBox();
            panelPlayer = new Panel();
            pbPlayerHand = new PictureBox();
            lblResult = new Label();
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            btnExit = new Button();
            panelComputer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbComputerHand).BeginInit();
            panelPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPlayerHand).BeginInit();
            SuspendLayout();
            // 
            // lblComputerTitle
            // 
            lblComputerTitle.Font = new Font("微軟正黑體", 16F);
            lblComputerTitle.Location = new Point(80, 18);
            lblComputerTitle.Name = "lblComputerTitle";
            lblComputerTitle.Size = new Size(220, 40);
            lblComputerTitle.TabIndex = 0;
            lblComputerTitle.Text = "電腦出";
            lblComputerTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayerTitle
            // 
            lblPlayerTitle.Font = new Font("微軟正黑體", 16F);
            lblPlayerTitle.Location = new Point(500, 18);
            lblPlayerTitle.Name = "lblPlayerTitle";
            lblPlayerTitle.Size = new Size(220, 40);
            lblPlayerTitle.TabIndex = 1;
            lblPlayerTitle.Text = "玩家出";
            lblPlayerTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelComputer
            // 
            panelComputer.Anchor = AnchorStyles.Top;
            panelComputer.BackColor = Color.BurlyWood;
            panelComputer.BorderStyle = BorderStyle.FixedSingle;
            panelComputer.Controls.Add(pbComputerHand);
            panelComputer.Location = new Point(80, 70);
            panelComputer.Name = "panelComputer";
            panelComputer.Size = new Size(260, 100);
            panelComputer.TabIndex = 2;
            // 
            // pbComputerHand
            // 
            pbComputerHand.Dock = DockStyle.Fill;
            pbComputerHand.Image = Properties.Resources.paper_computer;
            pbComputerHand.Location = new Point(0, 0);
            pbComputerHand.Name = "pbComputerHand";
            pbComputerHand.Size = new Size(258, 98);
            pbComputerHand.SizeMode = PictureBoxSizeMode.Zoom;
            pbComputerHand.TabIndex = 0;
            pbComputerHand.TabStop = false;
            // 
            // panelPlayer
            // 
            panelPlayer.Anchor = AnchorStyles.Top;
            panelPlayer.BackColor = Color.BurlyWood;
            panelPlayer.BorderStyle = BorderStyle.FixedSingle;
            panelPlayer.Controls.Add(pbPlayerHand);
            panelPlayer.Location = new Point(460, 70);
            panelPlayer.Name = "panelPlayer";
            panelPlayer.Size = new Size(260, 100);
            panelPlayer.TabIndex = 3;
            // 
            // pbPlayerHand
            // 
            pbPlayerHand.Dock = DockStyle.Fill;
            pbPlayerHand.Image = Properties.Resources.paper_player;
            pbPlayerHand.Location = new Point(0, 0);
            pbPlayerHand.Name = "pbPlayerHand";
            pbPlayerHand.Size = new Size(258, 98);
            pbPlayerHand.SizeMode = PictureBoxSizeMode.Zoom;
            pbPlayerHand.TabIndex = 0;
            pbPlayerHand.TabStop = false;
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.Top;
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("微軟正黑體", 22F);
            lblResult.Location = new Point(140, 190);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(520, 56);
            lblResult.TabIndex = 4;
            lblResult.Text = "請出拳";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRock
            // 
            btnRock.Font = new Font("微軟正黑體", 18F);
            btnRock.Location = new Point(110, 270);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(150, 60);
            btnRock.TabIndex = 5;
            btnRock.Text = "石頭";
            btnRock.Click += btnRock_Click;
            // 
            // btnPaper
            // 
            btnPaper.Font = new Font("微軟正黑體", 18F);
            btnPaper.Location = new Point(325, 270);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(150, 60);
            btnPaper.TabIndex = 6;
            btnPaper.Text = "布";
            btnPaper.Click += btnPaper_Click;
            // 
            // btnScissors
            // 
            btnScissors.Font = new Font("微軟正黑體", 18F);
            btnScissors.Location = new Point(540, 270);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(150, 60);
            btnScissors.TabIndex = 7;
            btnScissors.Text = "剪刀";
            btnScissors.Click += btnScissors_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("微軟正黑體", 16F);
            btnExit.Location = new Point(290, 360);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(220, 48);
            btnExit.TabIndex = 8;
            btnExit.Text = "結束遊戲";
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 520);
            Controls.Add(lblComputerTitle);
            Controls.Add(lblPlayerTitle);
            Controls.Add(panelComputer);
            Controls.Add(panelPlayer);
            Controls.Add(lblResult);
            Controls.Add(btnRock);
            Controls.Add(btnPaper);
            Controls.Add(btnScissors);
            Controls.Add(btnExit);
            Font = new Font("微軟正黑體", 10F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "剪刀石頭布";
            Load += Form1_Load;
            panelComputer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbComputerHand).EndInit();
            panelPlayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbPlayerHand).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
