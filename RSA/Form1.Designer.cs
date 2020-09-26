namespace RSA
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
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecipher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.textBox_in = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_out2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_out1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonEncrypt.Location = new System.Drawing.Point(911, 38);
            this.buttonEncrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(200, 41);
            this.buttonEncrypt.TabIndex = 1;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecipher
            // 
            this.buttonDecipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDecipher.Location = new System.Drawing.Point(31, 580);
            this.buttonDecipher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDecipher.Name = "buttonDecipher";
            this.buttonDecipher.Size = new System.Drawing.Size(200, 41);
            this.buttonDecipher.TabIndex = 2;
            this.buttonDecipher.Text = "Расшифровать";
            this.buttonDecipher.UseVisualStyleBackColor = true;
            this.buttonDecipher.Click += new System.EventHandler(this.buttonDecipher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "p:";
            // 
            // textBox_p
            // 
            this.textBox_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_p.Location = new System.Drawing.Point(67, 31);
            this.textBox_p.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(81, 30);
            this.textBox_p.TabIndex = 4;
            this.textBox_p.Text = "107";
            this.textBox_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(167, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "q:";
            // 
            // textBox_q
            // 
            this.textBox_q.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_q.Location = new System.Drawing.Point(216, 31);
            this.textBox_q.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(81, 30);
            this.textBox_q.TabIndex = 6;
            this.textBox_q.Text = "109";
            this.textBox_q.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(21, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "d:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(171, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "n:";
            // 
            // textBox_d
            // 
            this.textBox_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_d.Location = new System.Drawing.Point(71, 36);
            this.textBox_d.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(81, 30);
            this.textBox_d.TabIndex = 11;
            this.textBox_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_n
            // 
            this.textBox_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_n.Location = new System.Drawing.Point(220, 36);
            this.textBox_n.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(81, 30);
            this.textBox_n.TabIndex = 12;
            this.textBox_n.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_in
            // 
            this.textBox_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_in.Location = new System.Drawing.Point(367, 47);
            this.textBox_in.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_in.Multiline = true;
            this.textBox_in.Name = "textBox_in";
            this.textBox_in.Size = new System.Drawing.Size(475, 128);
            this.textBox_in.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(367, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Введите текст:";
            // 
            // textBox_out2
            // 
            this.textBox_out2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_out2.Location = new System.Drawing.Point(267, 588);
            this.textBox_out2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_out2.Name = "textBox_out2";
            this.textBox_out2.Size = new System.Drawing.Size(843, 30);
            this.textBox_out2.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(25, 212);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Шифр:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(261, 545);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Расшифрованный текст:";
            // 
            // textBox_out1
            // 
            this.textBox_out1.Location = new System.Drawing.Point(12, 236);
            this.textBox_out1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_out1.Multiline = true;
            this.textBox_out1.Name = "textBox_out1";
            this.textBox_out1.Size = new System.Drawing.Size(1099, 277);
            this.textBox_out1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_q);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_p);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 91);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Простые числа";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_n);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_d);
            this.groupBox2.Location = new System.Drawing.Point(12, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 91);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Секретный ключ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 671);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_out1);
            this.Controls.Add(this.textBox_out2);
            this.Controls.Add(this.textBox_in);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonDecipher);
            this.Controls.Add(this.buttonEncrypt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "RSA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecipher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.TextBox textBox_in;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_out2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_out1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

