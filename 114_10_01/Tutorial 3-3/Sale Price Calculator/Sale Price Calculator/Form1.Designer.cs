namespace Sale_Price_Calculator
{
    partial class Form1
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
            this.originalPriceTextBox = new System.Windows.Forms.TextBox();
            this.discountPercentageTextBox = new System.Windows.Forms.TextBox();
            this.originalPricePromptLabel = new System.Windows.Forms.Label();
            this.discPercentagePromptLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.salePriceLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originalPriceTextBox
            // 
            this.originalPriceTextBox.Location = new System.Drawing.Point(699, 62);
            this.originalPriceTextBox.Margin = new System.Windows.Forms.Padding(11);
            this.originalPriceTextBox.Name = "originalPriceTextBox";
            this.originalPriceTextBox.Size = new System.Drawing.Size(388, 55);
            this.originalPriceTextBox.TabIndex = 0;
            this.originalPriceTextBox.TextChanged += new System.EventHandler(this.originalPriceTextBox_TextChanged);
            // 
            // discountPercentageTextBox
            // 
            this.discountPercentageTextBox.Location = new System.Drawing.Point(699, 139);
            this.discountPercentageTextBox.Margin = new System.Windows.Forms.Padding(11);
            this.discountPercentageTextBox.Name = "discountPercentageTextBox";
            this.discountPercentageTextBox.Size = new System.Drawing.Size(388, 55);
            this.discountPercentageTextBox.TabIndex = 1;
            // 
            // originalPricePromptLabel
            // 
            this.originalPricePromptLabel.AutoSize = true;
            this.originalPricePromptLabel.Font = new System.Drawing.Font("華康新特明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.originalPricePromptLabel.Location = new System.Drawing.Point(88, 69);
            this.originalPricePromptLabel.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.originalPricePromptLabel.Name = "originalPricePromptLabel";
            this.originalPricePromptLabel.Size = new System.Drawing.Size(404, 48);
            this.originalPricePromptLabel.TabIndex = 2;
            this.originalPricePromptLabel.Text = "請輸入商品原價：";
            // 
            // discPercentagePromptLabel
            // 
            this.discPercentagePromptLabel.AutoSize = true;
            this.discPercentagePromptLabel.Font = new System.Drawing.Font("華康新特明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.discPercentagePromptLabel.Location = new System.Drawing.Point(53, 155);
            this.discPercentagePromptLabel.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.discPercentagePromptLabel.Name = "discPercentagePromptLabel";
            this.discPercentagePromptLabel.Size = new System.Drawing.Size(452, 48);
            this.discPercentagePromptLabel.TabIndex = 3;
            this.discPercentagePromptLabel.Text = "請輸入折扣百分比：";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("華康新特明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(341, 268);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(164, 48);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "特價：";
            // 
            // salePriceLabel
            // 
            this.salePriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salePriceLabel.Location = new System.Drawing.Point(699, 237);
            this.salePriceLabel.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.salePriceLabel.Name = "salePriceLabel";
            this.salePriceLabel.Size = new System.Drawing.Size(394, 79);
            this.salePriceLabel.TabIndex = 5;
            this.salePriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(178, 418);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(11);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(299, 144);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "計算特價";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(699, 418);
            this.exitButton.Margin = new System.Windows.Forms.Padding(11);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(299, 144);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2187, 1381);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.salePriceLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.discPercentagePromptLabel);
            this.Controls.Add(this.originalPricePromptLabel);
            this.Controls.Add(this.discountPercentageTextBox);
            this.Controls.Add(this.originalPriceTextBox);
            this.Font = new System.Drawing.Font("華康新特明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(11);
            this.Name = "Form1";
            this.Text = "特價計算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox originalPriceTextBox;
        private System.Windows.Forms.TextBox discountPercentageTextBox;
        private System.Windows.Forms.Label originalPricePromptLabel;
        private System.Windows.Forms.Label discPercentagePromptLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label salePriceLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

