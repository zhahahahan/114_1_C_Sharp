namespace Tutorial_2_5
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cardFacePictureBox = new System.Windows.Forms.PictureBox();
            this.cardBackPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardFacePictureBox
            // 
            this.cardFacePictureBox.Image = global::Tutorial_2_5.Properties.Resources.Ace_Hearts;
            this.cardFacePictureBox.Location = new System.Drawing.Point(272, 38);
            this.cardFacePictureBox.Name = "cardFacePictureBox";
            this.cardFacePictureBox.Size = new System.Drawing.Size(219, 304);
            this.cardFacePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardFacePictureBox.TabIndex = 1;
            this.cardFacePictureBox.TabStop = false;
            // 
            // cardBackPictureBox
            // 
            this.cardBackPictureBox.Image = global::Tutorial_2_5.Properties.Resources.Backface_Red;
            this.cardBackPictureBox.Location = new System.Drawing.Point(272, 38);
            this.cardBackPictureBox.Name = "cardBackPictureBox";
            this.cardBackPictureBox.Size = new System.Drawing.Size(219, 304);
            this.cardBackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardBackPictureBox.TabIndex = 0;
            this.cardBackPictureBox.TabStop = false;
            this.cardBackPictureBox.Click += new System.EventHandler(this.cardBackPictureBox_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(459, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 78);
            this.button1.TabIndex = 2;
            this.button1.Text = "顯示正面";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(100, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 78);
            this.button2.TabIndex = 3;
            this.button2.Text = "顯示背面";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 633);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cardFacePictureBox);
            this.Controls.Add(this.cardBackPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardBackPictureBox;
        private System.Windows.Forms.PictureBox cardFacePictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

