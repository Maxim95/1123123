namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tP1_textBox3 = new System.Windows.Forms.TextBox();
            this.tP1_textBox2 = new System.Windows.Forms.TextBox();
            this.tP1_textBox1 = new System.Windows.Forms.TextBox();
            this.tP1_label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tP2_textBox3 = new System.Windows.Forms.TextBox();
            this.tP2_label1 = new System.Windows.Forms.Label();
            this.tP2_button2 = new System.Windows.Forms.Button();
            this.tP2_textBox2 = new System.Windows.Forms.TextBox();
            this.tP2_textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tP3_button2 = new System.Windows.Forms.Button();
            this.tP3_label1 = new System.Windows.Forms.Label();
            this.tP3_textBox1 = new System.Windows.Forms.TextBox();
            this.tP3_textBox2 = new System.Windows.Forms.TextBox();
            this.tP3_textBox3 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(567, 434);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage1.Controls.Add(this.tP1_textBox3);
            this.tabPage1.Controls.Add(this.tP1_textBox2);
            this.tabPage1.Controls.Add(this.tP1_textBox1);
            this.tabPage1.Controls.Add(this.tP1_label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(559, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сложение";
            // 
            // tP1_textBox3
            // 
            this.tP1_textBox3.Location = new System.Drawing.Point(201, 313);
            this.tP1_textBox3.Name = "tP1_textBox3";
            this.tP1_textBox3.Size = new System.Drawing.Size(170, 22);
            this.tP1_textBox3.TabIndex = 4;
            // 
            // tP1_textBox2
            // 
            this.tP1_textBox2.Location = new System.Drawing.Point(201, 155);
            this.tP1_textBox2.Name = "tP1_textBox2";
            this.tP1_textBox2.Size = new System.Drawing.Size(170, 22);
            this.tP1_textBox2.TabIndex = 3;
            // 
            // tP1_textBox1
            // 
            this.tP1_textBox1.Location = new System.Drawing.Point(201, 81);
            this.tP1_textBox1.Name = "tP1_textBox1";
            this.tP1_textBox1.Size = new System.Drawing.Size(170, 22);
            this.tP1_textBox1.TabIndex = 2;
            // 
            // tP1_label1
            // 
            this.tP1_label1.AutoSize = true;
            this.tP1_label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tP1_label1.Location = new System.Drawing.Point(248, 26);
            this.tP1_label1.Name = "tP1_label1";
            this.tP1_label1.Size = new System.Drawing.Size(108, 18);
            this.tP1_label1.TabIndex = 1;
            this.tP1_label1.Text = "Введите 2 числа";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(239, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.tP2_textBox3);
            this.tabPage2.Controls.Add(this.tP2_label1);
            this.tabPage2.Controls.Add(this.tP2_button2);
            this.tabPage2.Controls.Add(this.tP2_textBox2);
            this.tabPage2.Controls.Add(this.tP2_textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(559, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вычитание";
            // 
            // tP2_textBox3
            // 
            this.tP2_textBox3.Location = new System.Drawing.Point(207, 328);
            this.tP2_textBox3.Name = "tP2_textBox3";
            this.tP2_textBox3.Size = new System.Drawing.Size(164, 21);
            this.tP2_textBox3.TabIndex = 4;
            // 
            // tP2_label1
            // 
            this.tP2_label1.AutoSize = true;
            this.tP2_label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tP2_label1.Location = new System.Drawing.Point(245, 31);
            this.tP2_label1.Name = "tP2_label1";
            this.tP2_label1.Size = new System.Drawing.Size(108, 18);
            this.tP2_label1.TabIndex = 3;
            this.tP2_label1.Text = "Введите 2 числа";
            // 
            // tP2_button2
            // 
            this.tP2_button2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tP2_button2.Location = new System.Drawing.Point(237, 224);
            this.tP2_button2.Name = "tP2_button2";
            this.tP2_button2.Size = new System.Drawing.Size(110, 47);
            this.tP2_button2.TabIndex = 2;
            this.tP2_button2.Text = "Вычислить";
            this.tP2_button2.UseVisualStyleBackColor = true;
            this.tP2_button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tP2_textBox2
            // 
            this.tP2_textBox2.Location = new System.Drawing.Point(207, 152);
            this.tP2_textBox2.Name = "tP2_textBox2";
            this.tP2_textBox2.Size = new System.Drawing.Size(164, 21);
            this.tP2_textBox2.TabIndex = 1;
            // 
            // tP2_textBox1
            // 
            this.tP2_textBox1.Location = new System.Drawing.Point(207, 78);
            this.tP2_textBox1.Name = "tP2_textBox1";
            this.tP2_textBox1.Size = new System.Drawing.Size(164, 21);
            this.tP2_textBox1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tP3_textBox3);
            this.tabPage3.Controls.Add(this.tP3_textBox2);
            this.tabPage3.Controls.Add(this.tP3_textBox1);
            this.tabPage3.Controls.Add(this.tP3_label1);
            this.tabPage3.Controls.Add(this.tP3_button2);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(559, 407);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Умножение";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tP3_button2
            // 
            this.tP3_button2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tP3_button2.Location = new System.Drawing.Point(234, 239);
            this.tP3_button2.Name = "tP3_button2";
            this.tP3_button2.Size = new System.Drawing.Size(114, 43);
            this.tP3_button2.TabIndex = 0;
            this.tP3_button2.Text = "Вычислить";
            this.tP3_button2.UseVisualStyleBackColor = true;
            this.tP3_button2.Click += new System.EventHandler(this.tP3_button2_Click);
            // 
            // tP3_label1
            // 
            this.tP3_label1.AutoSize = true;
            this.tP3_label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tP3_label1.Location = new System.Drawing.Point(240, 31);
            this.tP3_label1.Name = "tP3_label1";
            this.tP3_label1.Size = new System.Drawing.Size(108, 18);
            this.tP3_label1.TabIndex = 1;
            this.tP3_label1.Text = "Введите 2 числа";
            // 
            // tP3_textBox1
            // 
            this.tP3_textBox1.Location = new System.Drawing.Point(194, 92);
            this.tP3_textBox1.Name = "tP3_textBox1";
            this.tP3_textBox1.Size = new System.Drawing.Size(175, 21);
            this.tP3_textBox1.TabIndex = 2;
            // 
            // tP3_textBox2
            // 
            this.tP3_textBox2.Location = new System.Drawing.Point(194, 157);
            this.tP3_textBox2.Name = "tP3_textBox2";
            this.tP3_textBox2.Size = new System.Drawing.Size(175, 21);
            this.tP3_textBox2.TabIndex = 3;
            // 
            // tP3_textBox3
            // 
            this.tP3_textBox3.Location = new System.Drawing.Point(194, 330);
            this.tP3_textBox3.Name = "tP3_textBox3";
            this.tP3_textBox3.Size = new System.Drawing.Size(175, 21);
            this.tP3_textBox3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 461);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tP1_textBox3;
        private System.Windows.Forms.TextBox tP1_textBox2;
        private System.Windows.Forms.TextBox tP1_textBox1;
        private System.Windows.Forms.Label tP1_label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tP2_textBox3;
        private System.Windows.Forms.Label tP2_label1;
        private System.Windows.Forms.Button tP2_button2;
        private System.Windows.Forms.TextBox tP2_textBox2;
        private System.Windows.Forms.TextBox tP2_textBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tP3_textBox3;
        private System.Windows.Forms.TextBox tP3_textBox2;
        private System.Windows.Forms.TextBox tP3_textBox1;
        private System.Windows.Forms.Label tP3_label1;
        private System.Windows.Forms.Button tP3_button2;
    }
}

