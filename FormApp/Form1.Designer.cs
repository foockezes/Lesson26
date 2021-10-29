namespace FormApp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.memoryClear = new System.Windows.Forms.Button();
            this.memoryRead = new System.Windows.Forms.Button();
            this.memorySave = new System.Windows.Forms.Button();
            this.memoryPlus = new System.Windows.Forms.Button();
            this.memoryMinus = new System.Windows.Forms.Button();
            this.clearLast = new System.Windows.Forms.Button();
            this.Сlear = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.plusOrMinus = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Comma = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.Equlity = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.reciproc = new System.Windows.Forms.Button();
            this.Multple = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.labMemory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // memoryClear
            // 
            this.memoryClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.memoryClear.Location = new System.Drawing.Point(12, 61);
            this.memoryClear.Name = "memoryClear";
            this.memoryClear.Size = new System.Drawing.Size(50, 41);
            this.memoryClear.TabIndex = 2;
            this.memoryClear.Text = "MC";
            this.memoryClear.UseVisualStyleBackColor = true;
            this.memoryClear.Click += new System.EventHandler(this.memoryClear_Click);
            // 
            // memoryRead
            // 
            this.memoryRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.memoryRead.Location = new System.Drawing.Point(68, 61);
            this.memoryRead.Name = "memoryRead";
            this.memoryRead.Size = new System.Drawing.Size(50, 41);
            this.memoryRead.TabIndex = 3;
            this.memoryRead.Text = "MR";
            this.memoryRead.UseVisualStyleBackColor = true;
            this.memoryRead.Click += new System.EventHandler(this.memoryRead_Click);
            // 
            // memorySave
            // 
            this.memorySave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.memorySave.Location = new System.Drawing.Point(124, 61);
            this.memorySave.Name = "memorySave";
            this.memorySave.Size = new System.Drawing.Size(50, 41);
            this.memorySave.TabIndex = 4;
            this.memorySave.Text = "MS";
            this.memorySave.UseVisualStyleBackColor = true;
            this.memorySave.Click += new System.EventHandler(this.memorySave_Click);
            // 
            // memoryPlus
            // 
            this.memoryPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.memoryPlus.Location = new System.Drawing.Point(180, 61);
            this.memoryPlus.Name = "memoryPlus";
            this.memoryPlus.Size = new System.Drawing.Size(50, 41);
            this.memoryPlus.TabIndex = 5;
            this.memoryPlus.Text = "M+";
            this.memoryPlus.UseVisualStyleBackColor = true;
            this.memoryPlus.Click += new System.EventHandler(this.memoryPlus_Click);
            // 
            // memoryMinus
            // 
            this.memoryMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.memoryMinus.Location = new System.Drawing.Point(236, 61);
            this.memoryMinus.Name = "memoryMinus";
            this.memoryMinus.Size = new System.Drawing.Size(50, 41);
            this.memoryMinus.TabIndex = 6;
            this.memoryMinus.Text = "M-";
            this.memoryMinus.UseVisualStyleBackColor = true;
            this.memoryMinus.Click += new System.EventHandler(this.memoryMinus_Click);
            // 
            // clearLast
            // 
            this.clearLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearLast.Location = new System.Drawing.Point(12, 108);
            this.clearLast.Name = "clearLast";
            this.clearLast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clearLast.Size = new System.Drawing.Size(50, 41);
            this.clearLast.TabIndex = 7;
            this.clearLast.Text = "🠔";
            this.clearLast.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clearLast.UseVisualStyleBackColor = true;
            this.clearLast.Click += new System.EventHandler(this.clearLast_Click);
            // 
            // Сlear
            // 
            this.Сlear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Сlear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Сlear.Location = new System.Drawing.Point(68, 108);
            this.Сlear.Name = "Сlear";
            this.Сlear.Size = new System.Drawing.Size(50, 41);
            this.Сlear.TabIndex = 8;
            this.Сlear.Text = "CE";
            this.Сlear.UseVisualStyleBackColor = false;
            this.Сlear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // clearAll
            // 
            this.clearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearAll.Location = new System.Drawing.Point(124, 108);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(50, 41);
            this.clearAll.TabIndex = 9;
            this.clearAll.Text = "C";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // plusOrMinus
            // 
            this.plusOrMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plusOrMinus.Location = new System.Drawing.Point(180, 108);
            this.plusOrMinus.Name = "plusOrMinus";
            this.plusOrMinus.Size = new System.Drawing.Size(50, 41);
            this.plusOrMinus.TabIndex = 10;
            this.plusOrMinus.Text = "±";
            this.plusOrMinus.UseVisualStyleBackColor = true;
            this.plusOrMinus.Click += new System.EventHandler(this.plusOrMinus_Click);
            // 
            // sqrt
            // 
            this.sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sqrt.Location = new System.Drawing.Point(235, 108);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(50, 41);
            this.sqrt.TabIndex = 11;
            this.sqrt.Text = "√";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // Seven
            // 
            this.Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Seven.Location = new System.Drawing.Point(12, 155);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(50, 41);
            this.Seven.TabIndex = 12;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Eight
            // 
            this.Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Eight.Location = new System.Drawing.Point(68, 155);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(50, 41);
            this.Eight.TabIndex = 13;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Nine
            // 
            this.Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nine.Location = new System.Drawing.Point(124, 155);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(50, 41);
            this.Nine.TabIndex = 14;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Div
            // 
            this.Div.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Div.Location = new System.Drawing.Point(180, 155);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(50, 41);
            this.Div.TabIndex = 15;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // percent
            // 
            this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.percent.Location = new System.Drawing.Point(236, 155);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(50, 41);
            this.percent.TabIndex = 16;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = true;
            this.percent.Click += new System.EventHandler(this.percent_Click);
            // 
            // Plus
            // 
            this.Plus.AccessibleName = "";
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Plus.Location = new System.Drawing.Point(180, 296);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(50, 41);
            this.Plus.TabIndex = 30;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Comma
            // 
            this.Comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Comma.Location = new System.Drawing.Point(124, 296);
            this.Comma.Name = "Comma";
            this.Comma.Size = new System.Drawing.Size(50, 41);
            this.Comma.TabIndex = 29;
            this.Comma.Text = ",";
            this.Comma.UseVisualStyleBackColor = true;
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zero.Location = new System.Drawing.Point(12, 296);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(106, 41);
            this.zero.TabIndex = 27;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // Equlity
            // 
            this.Equlity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Equlity.Location = new System.Drawing.Point(235, 249);
            this.Equlity.Name = "Equlity";
            this.Equlity.Size = new System.Drawing.Size(50, 88);
            this.Equlity.TabIndex = 26;
            this.Equlity.Text = "=";
            this.Equlity.UseVisualStyleBackColor = true;
            this.Equlity.Click += new System.EventHandler(this.Equlity_Click);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Minus.Location = new System.Drawing.Point(180, 249);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(50, 41);
            this.Minus.TabIndex = 25;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Three
            // 
            this.Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Three.Location = new System.Drawing.Point(124, 249);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(50, 41);
            this.Three.TabIndex = 24;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Two
            // 
            this.Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Two.Location = new System.Drawing.Point(68, 249);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(50, 41);
            this.Two.TabIndex = 23;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.One.Location = new System.Drawing.Point(12, 249);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(50, 41);
            this.One.TabIndex = 22;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // reciproc
            // 
            this.reciproc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reciproc.Location = new System.Drawing.Point(236, 202);
            this.reciproc.Name = "reciproc";
            this.reciproc.Size = new System.Drawing.Size(50, 41);
            this.reciproc.TabIndex = 21;
            this.reciproc.Text = "1/x";
            this.reciproc.UseVisualStyleBackColor = true;
            this.reciproc.Click += new System.EventHandler(this.reciproc_Click);
            // 
            // Multple
            // 
            this.Multple.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Multple.Location = new System.Drawing.Point(180, 202);
            this.Multple.Name = "Multple";
            this.Multple.Size = new System.Drawing.Size(50, 41);
            this.Multple.TabIndex = 20;
            this.Multple.Text = "*";
            this.Multple.UseVisualStyleBackColor = true;
            this.Multple.Click += new System.EventHandler(this.Multple_Click);
            // 
            // Six
            // 
            this.Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Six.Location = new System.Drawing.Point(124, 202);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(50, 41);
            this.Six.TabIndex = 19;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Five
            // 
            this.Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Five.Location = new System.Drawing.Point(68, 202);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(50, 41);
            this.Five.TabIndex = 18;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Four
            // 
            this.Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Four.Location = new System.Drawing.Point(12, 202);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(50, 41);
            this.Four.TabIndex = 17;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // labMemory
            // 
            this.labMemory.AutoSize = true;
            this.labMemory.Location = new System.Drawing.Point(20, 35);
            this.labMemory.Name = "labMemory";
            this.labMemory.Size = new System.Drawing.Size(0, 15);
            this.labMemory.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(295, 356);
            this.Controls.Add(this.labMemory);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Comma);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.Equlity);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.reciproc);
            this.Controls.Add(this.Multple);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.plusOrMinus);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.Сlear);
            this.Controls.Add(this.clearLast);
            this.Controls.Add(this.memoryMinus);
            this.Controls.Add(this.memoryPlus);
            this.Controls.Add(this.memorySave);
            this.Controls.Add(this.memoryRead);
            this.Controls.Add(this.memoryClear);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button memoryClear;
        private System.Windows.Forms.Button memoryRead;
        private System.Windows.Forms.Button memorySave;
        private System.Windows.Forms.Button memoryPlus;
        private System.Windows.Forms.Button memoryMinus;
        private System.Windows.Forms.Button clearLast;
        private System.Windows.Forms.Button Сlear;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button plusOrMinus;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Comma;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button Equlity;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button reciproc;
        private System.Windows.Forms.Button Multple;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Label labMemory;
    }
}

