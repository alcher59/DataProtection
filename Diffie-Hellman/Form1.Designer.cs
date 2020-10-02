namespace Diffie_Hellman
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox_y = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_x = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_enc = new System.Windows.Forms.Button();
            this.textBox_enc = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_dec = new System.Windows.Forms.Button();
            this.textBox_dec = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_crypt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox_y);
            this.groupBox1.Controls.Add(this.maskedTextBox_x);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Простые числа";
            // 
            // maskedTextBox_y
            // 
            this.maskedTextBox_y.Location = new System.Drawing.Point(38, 65);
            this.maskedTextBox_y.Mask = "0000000000000000";
            this.maskedTextBox_y.Name = "maskedTextBox_y";
            this.maskedTextBox_y.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_y.TabIndex = 4;
            this.maskedTextBox_y.Text = "7";
            // 
            // maskedTextBox_x
            // 
            this.maskedTextBox_x.Location = new System.Drawing.Point(38, 33);
            this.maskedTextBox_x.Mask = "0000000000000000";
            this.maskedTextBox_x.Name = "maskedTextBox_x";
            this.maskedTextBox_x.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_x.TabIndex = 4;
            this.maskedTextBox_x.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "x:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_enc);
            this.groupBox2.Controls.Add(this.textBox_enc);
            this.groupBox2.Location = new System.Drawing.Point(208, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 178);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Шифрование";
            // 
            // btn_enc
            // 
            this.btn_enc.Location = new System.Drawing.Point(447, 135);
            this.btn_enc.Name = "btn_enc";
            this.btn_enc.Size = new System.Drawing.Size(75, 37);
            this.btn_enc.TabIndex = 1;
            this.btn_enc.Text = "OK";
            this.btn_enc.UseVisualStyleBackColor = true;
            this.btn_enc.Click += new System.EventHandler(this.btn_enc_Click);
            // 
            // textBox_enc
            // 
            this.textBox_enc.Location = new System.Drawing.Point(7, 20);
            this.textBox_enc.Multiline = true;
            this.textBox_enc.Name = "textBox_enc";
            this.textBox_enc.Size = new System.Drawing.Size(515, 109);
            this.textBox_enc.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_dec);
            this.groupBox3.Controls.Add(this.textBox_dec);
            this.groupBox3.Location = new System.Drawing.Point(208, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(528, 183);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Дешифрование";
            // 
            // btn_dec
            // 
            this.btn_dec.Location = new System.Drawing.Point(446, 134);
            this.btn_dec.Name = "btn_dec";
            this.btn_dec.Size = new System.Drawing.Size(75, 37);
            this.btn_dec.TabIndex = 2;
            this.btn_dec.Text = "OK";
            this.btn_dec.UseVisualStyleBackColor = true;
            this.btn_dec.Click += new System.EventHandler(this.btn_dec_Click);
            // 
            // textBox_dec
            // 
            this.textBox_dec.Location = new System.Drawing.Point(6, 19);
            this.textBox_dec.Multiline = true;
            this.textBox_dec.Name = "textBox_dec";
            this.textBox_dec.Size = new System.Drawing.Size(515, 109);
            this.textBox_dec.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_crypt);
            this.groupBox4.Location = new System.Drawing.Point(12, 124);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(174, 255);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Шифр";
            // 
            // textBox_crypt
            // 
            this.textBox_crypt.Location = new System.Drawing.Point(7, 20);
            this.textBox_crypt.Multiline = true;
            this.textBox_crypt.Name = "textBox_crypt";
            this.textBox_crypt.ReadOnly = true;
            this.textBox_crypt.Size = new System.Drawing.Size(161, 229);
            this.textBox_crypt.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 387);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Diffie-Hellman";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_enc;
        private System.Windows.Forms.TextBox textBox_enc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_dec;
        private System.Windows.Forms.TextBox textBox_dec;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_crypt;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_y;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_x;
    }
}

