namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(89, 72);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(237, 20);
            this.display.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Diag";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ChooseOperation);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "P";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ChooseOperation);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(251, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "S";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ChooseOperation);
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(411, 122);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(100, 20);
            this.Answer.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(89, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(170, 205);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(251, 205);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "3";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(89, 234);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "4";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(170, 234);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "5";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Default;
            this.button9.Location = new System.Drawing.Point(251, 234);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 11;
            this.button9.Text = "6";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(89, 263);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 12;
            this.button10.Text = "7";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(170, 263);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 13;
            this.button11.Text = "8";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(251, 263);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 14;
            this.button12.Text = "9";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(170, 292);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 15;
            this.button13.Text = "0";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(251, 292);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 16;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(332, 165);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(35, 150);
            this.button14.TabIndex = 17;
            this.button14.Text = "C";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 438);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button14;
    }
}

