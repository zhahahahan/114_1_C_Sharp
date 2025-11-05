namespace WindowsFormsApp1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.JuiceradioButton = new System.Windows.Forms.RadioButton();
            this.BlacktearadioButton = new System.Windows.Forms.RadioButton();
            this.milktearadioButton = new System.Windows.Forms.RadioButton();
            this.CoffeeradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hamSanradioButton = new System.Windows.Forms.RadioButton();
            this.jellySanradioButton = new System.Windows.Forms.RadioButton();
            this.tunaSanradioButton = new System.Windows.Forms.RadioButton();
            this.sendbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.JuiceradioButton);
            this.groupBox1.Controls.Add(this.BlacktearadioButton);
            this.groupBox1.Controls.Add(this.milktearadioButton);
            this.groupBox1.Controls.Add(this.CoffeeradioButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 357);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "飲料";
            // 
            // JuiceradioButton
            // 
            this.JuiceradioButton.AutoSize = true;
            this.JuiceradioButton.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.JuiceradioButton.Location = new System.Drawing.Point(75, 285);
            this.JuiceradioButton.Name = "JuiceradioButton";
            this.JuiceradioButton.Size = new System.Drawing.Size(103, 36);
            this.JuiceradioButton.TabIndex = 7;
            this.JuiceradioButton.TabStop = true;
            this.JuiceradioButton.Text = "果汁";
            this.JuiceradioButton.UseVisualStyleBackColor = true;
            // 
            // BlacktearadioButton
            // 
            this.BlacktearadioButton.AutoSize = true;
            this.BlacktearadioButton.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BlacktearadioButton.Location = new System.Drawing.Point(75, 195);
            this.BlacktearadioButton.Name = "BlacktearadioButton";
            this.BlacktearadioButton.Size = new System.Drawing.Size(103, 36);
            this.BlacktearadioButton.TabIndex = 6;
            this.BlacktearadioButton.TabStop = true;
            this.BlacktearadioButton.Text = "紅茶";
            this.BlacktearadioButton.UseVisualStyleBackColor = true;
            // 
            // milktearadioButton
            // 
            this.milktearadioButton.AutoSize = true;
            this.milktearadioButton.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.milktearadioButton.Location = new System.Drawing.Point(75, 117);
            this.milktearadioButton.Name = "milktearadioButton";
            this.milktearadioButton.Size = new System.Drawing.Size(103, 36);
            this.milktearadioButton.TabIndex = 5;
            this.milktearadioButton.TabStop = true;
            this.milktearadioButton.Text = "奶茶";
            this.milktearadioButton.UseVisualStyleBackColor = true;
            // 
            // CoffeeradioButton
            // 
            this.CoffeeradioButton.AutoSize = true;
            this.CoffeeradioButton.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CoffeeradioButton.Location = new System.Drawing.Point(75, 36);
            this.CoffeeradioButton.Name = "CoffeeradioButton";
            this.CoffeeradioButton.Size = new System.Drawing.Size(103, 36);
            this.CoffeeradioButton.TabIndex = 4;
            this.CoffeeradioButton.TabStop = true;
            this.CoffeeradioButton.Text = "咖啡";
            this.CoffeeradioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hamSanradioButton);
            this.groupBox2.Controls.Add(this.jellySanradioButton);
            this.groupBox2.Controls.Add(this.tunaSanradioButton);
            this.groupBox2.Location = new System.Drawing.Point(402, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 357);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "三明治";
            // 
            // hamSanradioButton
            // 
            this.hamSanradioButton.AutoSize = true;
            this.hamSanradioButton.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hamSanradioButton.Location = new System.Drawing.Point(42, 165);
            this.hamSanradioButton.Name = "hamSanradioButton";
            this.hamSanradioButton.Size = new System.Drawing.Size(199, 36);
            this.hamSanradioButton.TabIndex = 10;
            this.hamSanradioButton.TabStop = true;
            this.hamSanradioButton.Text = "火腿三明治";
            this.hamSanradioButton.UseVisualStyleBackColor = true;
            // 
            // jellySanradioButton
            // 
            this.jellySanradioButton.AutoSize = true;
            this.jellySanradioButton.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.jellySanradioButton.Location = new System.Drawing.Point(42, 249);
            this.jellySanradioButton.Name = "jellySanradioButton";
            this.jellySanradioButton.Size = new System.Drawing.Size(199, 36);
            this.jellySanradioButton.TabIndex = 9;
            this.jellySanradioButton.TabStop = true;
            this.jellySanradioButton.Text = "果醬三明治";
            this.jellySanradioButton.UseVisualStyleBackColor = true;
            // 
            // tunaSanradioButton
            // 
            this.tunaSanradioButton.AutoSize = true;
            this.tunaSanradioButton.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tunaSanradioButton.Location = new System.Drawing.Point(42, 72);
            this.tunaSanradioButton.Name = "tunaSanradioButton";
            this.tunaSanradioButton.Size = new System.Drawing.Size(199, 36);
            this.tunaSanradioButton.TabIndex = 8;
            this.tunaSanradioButton.TabStop = true;
            this.tunaSanradioButton.Text = "鮪魚三明治";
            this.tunaSanradioButton.UseVisualStyleBackColor = true;
            // 
            // sendbutton
            // 
            this.sendbutton.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sendbutton.Location = new System.Drawing.Point(116, 438);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(171, 92);
            this.sendbutton.TabIndex = 10;
            this.sendbutton.Text = "送出訂單";
            this.sendbutton.UseVisualStyleBackColor = true;
            this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitbutton.Location = new System.Drawing.Point(444, 426);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(171, 92);
            this.exitbutton.TabIndex = 11;
            this.exitbutton.Text = "離開";
            this.exitbutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 617);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.sendbutton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton JuiceradioButton;
        private System.Windows.Forms.RadioButton BlacktearadioButton;
        private System.Windows.Forms.RadioButton milktearadioButton;
        private System.Windows.Forms.RadioButton CoffeeradioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton hamSanradioButton;
        private System.Windows.Forms.RadioButton jellySanradioButton;
        private System.Windows.Forms.RadioButton tunaSanradioButton;
        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.Button exitbutton;
    }
}

