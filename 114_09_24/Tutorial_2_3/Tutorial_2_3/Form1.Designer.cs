namespace Tutorial_2_3
{
    partial class hi
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
            label1 = new Label();
            translationLabel = new Label();
            italianButton = new Button();
            spanishButton = new Button();
            germanButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("華康超明體", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(102, 41);
            label1.Name = "label1";
            label1.Size = new Size(596, 48);
            label1.TabIndex = 0;
            label1.Text = "選擇一個語言，我會說早安";
            // 
            // translationLabel
            // 
            translationLabel.BorderStyle = BorderStyle.Fixed3D;
            translationLabel.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            translationLabel.Location = new Point(146, 135);
            translationLabel.Name = "translationLabel";
            translationLabel.Size = new Size(482, 100);
            translationLabel.TabIndex = 1;
            translationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // italianButton
            // 
            italianButton.Font = new Font("微軟正黑體", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            italianButton.Location = new Point(80, 301);
            italianButton.Name = "italianButton";
            italianButton.Size = new Size(142, 59);
            italianButton.TabIndex = 2;
            italianButton.Text = "義大利文";
            italianButton.UseVisualStyleBackColor = true;
            italianButton.Click += italian_Click;
            // 
            // spanishButton
            // 
            spanishButton.Font = new Font("微軟正黑體", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            spanishButton.Location = new Point(328, 301);
            spanishButton.Name = "spanishButton";
            spanishButton.Size = new Size(142, 59);
            spanishButton.TabIndex = 3;
            spanishButton.Text = "西班牙文";
            spanishButton.UseVisualStyleBackColor = true;
            spanishButton.Click += spanishButton_Click;
            // 
            // germanButton
            // 
            germanButton.Font = new Font("微軟正黑體", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            germanButton.Location = new Point(577, 301);
            germanButton.Name = "germanButton";
            germanButton.Size = new Size(133, 59);
            germanButton.TabIndex = 4;
            germanButton.Text = "德文";
            germanButton.UseVisualStyleBackColor = true;
            germanButton.Click += germanButton_Click;
            // 
            // hi
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(germanButton);
            Controls.Add(spanishButton);
            Controls.Add(italianButton);
            Controls.Add(translationLabel);
            Controls.Add(label1);
            Name = "hi";
            Text = "語言翻譯器";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label translationLabel;
        private Button italianButton;
        private Button spanishButton;
        private Button germanButton;
    }
}
