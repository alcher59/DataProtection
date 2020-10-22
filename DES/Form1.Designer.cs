namespace DES
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
            this.textBoxDecodeKeyWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEncodeKeyWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDecipher = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.textBox_enc = new System.Windows.Forms.TextBox();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.textBox_dec = new System.Windows.Forms.TextBox();
            this.label_enc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDecodeKeyWord
            // 
            this.textBoxDecodeKeyWord.Location = new System.Drawing.Point(152, 56);
            this.textBoxDecodeKeyWord.Name = "textBoxDecodeKeyWord";
            this.textBoxDecodeKeyWord.ReadOnly = true;
            this.textBoxDecodeKeyWord.Size = new System.Drawing.Size(133, 20);
            this.textBoxDecodeKeyWord.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ключ для дешифрования:";
            // 
            // textBoxEncodeKeyWord
            // 
            this.textBoxEncodeKeyWord.Location = new System.Drawing.Point(22, 56);
            this.textBoxEncodeKeyWord.Name = "textBoxEncodeKeyWord";
            this.textBoxEncodeKeyWord.Size = new System.Drawing.Size(121, 20);
            this.textBoxEncodeKeyWord.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ключ для шифрования:";
            // 
            // buttonDecipher
            // 
            this.buttonDecipher.Location = new System.Drawing.Point(152, 111);
            this.buttonDecipher.Name = "buttonDecipher";
            this.buttonDecipher.Size = new System.Drawing.Size(133, 23);
            this.buttonDecipher.TabIndex = 8;
            this.buttonDecipher.Text = "Расшифровать";
            this.buttonDecipher.UseVisualStyleBackColor = true;
            this.buttonDecipher.Click += new System.EventHandler(this.buttonDecipher_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(22, 111);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(121, 23);
            this.buttonEncrypt.TabIndex = 7;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // textBox_enc
            // 
            this.textBox_enc.Location = new System.Drawing.Point(17, 242);
            this.textBox_enc.Multiline = true;
            this.textBox_enc.Name = "textBox_enc";
            this.textBox_enc.Size = new System.Drawing.Size(315, 143);
            this.textBox_enc.TabIndex = 13;
            // 
            // textBox_code
            // 
            this.textBox_code.Location = new System.Drawing.Point(335, 56);
            this.textBox_code.Multiline = true;
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.ReadOnly = true;
            this.textBox_code.Size = new System.Drawing.Size(315, 143);
            this.textBox_code.TabIndex = 13;
            // 
            // textBox_dec
            // 
            this.textBox_dec.Location = new System.Drawing.Point(338, 242);
            this.textBox_dec.Multiline = true;
            this.textBox_dec.Name = "textBox_dec";
            this.textBox_dec.ReadOnly = true;
            this.textBox_dec.Size = new System.Drawing.Size(315, 143);
            this.textBox_dec.TabIndex = 13;
            // 
            // label_enc
            // 
            this.label_enc.AutoSize = true;
            this.label_enc.Location = new System.Drawing.Point(14, 216);
            this.label_enc.Name = "label_enc";
            this.label_enc.Size = new System.Drawing.Size(83, 13);
            this.label_enc.TabIndex = 14;
            this.label_enc.Text = "Введите текст:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Шифр:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Расшифрованный текст:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 401);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_enc);
            this.Controls.Add(this.textBox_dec);
            this.Controls.Add(this.textBox_code);
            this.Controls.Add(this.textBox_enc);
            this.Controls.Add(this.textBoxDecodeKeyWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEncodeKeyWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDecipher);
            this.Controls.Add(this.buttonEncrypt);
            this.Name = "Form1";
            this.Text = "DES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDecodeKeyWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEncodeKeyWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDecipher;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.TextBox textBox_enc;
        private System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.TextBox textBox_dec;
        private System.Windows.Forms.Label label_enc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

