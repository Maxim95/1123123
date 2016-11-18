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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tP1_label1 = new System.Windows.Forms.Label();
            this.tP1_textBox1 = new System.Windows.Forms.TextBox();
            this.tP1_textBox2 = new System.Windows.Forms.TextBox();
            this.tP1_textBox3 = new System.Windows.Forms.TextBox();
            this.tP2_textBox1 = new System.Windows.Forms.TextBox();
            this.tP2_textBox2 = new System.Windows.Forms.TextBox();
            this.tP2_button2 = new System.Windows.Forms.Button();
            this.tP2_label1 = new System.Windows.Forms.Label();
            this.tP2_textBox3 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(567, 403);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tP1_textBox3);
            this.tabPage1.Controls.Add(this.tP1_textBox2);
            this.tabPage1.Controls.Add(this.tP1_textBox1);
            this.tabPage1.Controls.Add(this.tP1_label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(559, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сложение";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tP2_textBox3);
            this.tabPage2.Controls.Add(this.tP2_label1);
            this.tabPage2.Controls.Add(this.tP2_button2);
            this.tabPage2.Controls.Add(this.tP2_textBox2);
            this.tabPage2.Controls.Add(this.tP2_textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(559, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вычитание";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tP1_label1
            // 
            this.tP1_label1.AutoSize = true;
            this.tP1_label1.Location = new System.Drawing.Point(248, 24);
            this.tP1_label1.Name = "tP1_label1";
            this.tP1_label1.Size = new System.Drawing.Size(90, 13);
            this.tP1_label1.TabIndex = 1;
            this.tP1_label1.Text = "Введите 2 числа";
            // 
            // tP1_textBox1
            // 
            this.tP1_textBox1.Location = new System.Drawing.Point(201, 75);
            this.tP1_textBox1.Name = "tP1_textBox1";
            this.tP1_textBox1.Size = new System.Drawing.Size(170, 20);
            this.tP1_textBox1.TabIndex = 2;
            // 
            // tP1_textBox2
            // 
            this.tP1_textBox2.Location = new System.Drawing.Point(201, 144);
            this.tP1_textBox2.Name = "tP1_textBox2";
            this.tP1_textBox2.Size = new System.Drawing.Size(170, 20);
            this.tP1_textBox2.TabIndex = 3;
            // 
            // tP1_textBox3
            // 
            this.tP1_textBox3.Location = new System.Drawing.Point(201, 291);
            this.tP1_textBox3.Name = "tP1_textBox3";
            this.tP1_textBox3.Size = new System.Drawing.Size(170, 20);
            this.tP1_textBox3.TabIndex = 4;
            // 
            // tP2_textBox1
            // 
            this.tP2_textBox1.Location = new System.Drawing.Point(207, 72);
            this.tP2_textBox1.Name = "tP2_textBox1";
            this.tP2_textBox1.Size = new System.Drawing.Size(164, 20);
            this.tP2_textBox1.TabIndex = 0;
            // 
            // tP2_textBox2
            // 
            this.tP2_textBox2.Location = new System.Drawing.Point(207, 141);
            this.tP2_textBox2.Name = "tP2_textBox2";
            this.tP2_textBox2.Size = new System.Drawing.Size(164, 20);
            this.tP2_textBox2.TabIndex = 1;
            // 
            // tP2_button2
            // 
            this.tP2_button2.Location = new System.Drawing.Point(237, 208);
            this.tP2_button2.Name = "tP2_button2";
            this.tP2_button2.Size = new System.Drawing.Size(110, 44);
            this.tP2_button2.TabIndex = 2;
            this.tP2_button2.Text = "Вычислить";
            this.tP2_button2.UseVisualStyleBackColor = true;
            this.tP2_button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tP2_label1
            // 
            this.tP2_label1.AutoSize = true;
            this.tP2_label1.Location = new System.Drawing.Point(245, 29);
            this.tP2_label1.Name = "tP2_label1";
            this.tP2_label1.Size = new System.Drawing.Size(90, 13);
            this.tP2_label1.TabIndex = 3;
            this.tP2_label1.Text = "Введите 2 числа";
            // 
            // tP2_textBox3
            // 
            this.tP2_textBox3.Location = new System.Drawing.Point(207, 305);
            this.tP2_textBox3.Name = "tP2_textBox3";
            this.tP2_textBox3.Size = new System.Drawing.Size(164, 20);
            this.tP2_textBox3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 428);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
    }
}

