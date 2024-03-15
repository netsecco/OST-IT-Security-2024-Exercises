namespace SYMENC_AES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxKey = new TextBox();
            textBoxIV = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxCleartext = new TextBox();
            buttonEncrypt = new Button();
            textBoxCipherText = new TextBox();
            textBoxDecryptedText = new TextBox();
            buttonDecrypt = new Button();
            SuspendLayout();
            // 
            // textBoxKey
            // 
            textBoxKey.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxKey.Location = new Point(53, 50);
            textBoxKey.MaxLength = 32;
            textBoxKey.Name = "textBoxKey";
            textBoxKey.Size = new Size(382, 30);
            textBoxKey.TabIndex = 6;
            textBoxKey.Text = "00112233445566778899AABBCCDDEEFF";
            // 
            // textBoxIV
            // 
            textBoxIV.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIV.Location = new Point(53, 104);
            textBoxIV.MaxLength = 32;
            textBoxIV.Name = "textBoxIV";
            textBoxIV.Size = new Size(382, 30);
            textBoxIV.TabIndex = 7;
            textBoxIV.Text = "00112233445566778899AABBCCDDEEFF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(35, 21);
            label1.TabIndex = 10;
            label1.Text = "Key";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(24, 21);
            label2.TabIndex = 11;
            label2.Text = "IV";
            // 
            // textBoxCleartext
            // 
            textBoxCleartext.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCleartext.Location = new Point(53, 172);
            textBoxCleartext.MaxLength = 0;
            textBoxCleartext.Multiline = true;
            textBoxCleartext.Name = "textBoxCleartext";
            textBoxCleartext.ScrollBars = ScrollBars.Vertical;
            textBoxCleartext.Size = new Size(735, 81);
            textBoxCleartext.TabIndex = 12;
            textBoxCleartext.Text = resources.GetString("textBoxCleartext.Text");
            // 
            // buttonEncrypt
            // 
            buttonEncrypt.Location = new Point(364, 268);
            buttonEncrypt.Name = "buttonEncrypt";
            buttonEncrypt.Size = new Size(92, 27);
            buttonEncrypt.TabIndex = 13;
            buttonEncrypt.Text = "Encrypt";
            buttonEncrypt.UseVisualStyleBackColor = true;
            buttonEncrypt.Click += buttonEncrypt_Click;
            // 
            // textBoxCipherText
            // 
            textBoxCipherText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCipherText.Location = new Point(53, 311);
            textBoxCipherText.MaxLength = 0;
            textBoxCipherText.Multiline = true;
            textBoxCipherText.Name = "textBoxCipherText";
            textBoxCipherText.ScrollBars = ScrollBars.Vertical;
            textBoxCipherText.Size = new Size(735, 81);
            textBoxCipherText.TabIndex = 14;
            // 
            // textBoxDecryptedText
            // 
            textBoxDecryptedText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDecryptedText.Location = new Point(53, 437);
            textBoxDecryptedText.MaxLength = 0;
            textBoxDecryptedText.Multiline = true;
            textBoxDecryptedText.Name = "textBoxDecryptedText";
            textBoxDecryptedText.ScrollBars = ScrollBars.Vertical;
            textBoxDecryptedText.Size = new Size(735, 81);
            textBoxDecryptedText.TabIndex = 15;
            // 
            // buttonDecrypt
            // 
            buttonDecrypt.Location = new Point(364, 398);
            buttonDecrypt.Name = "buttonDecrypt";
            buttonDecrypt.Size = new Size(92, 27);
            buttonDecrypt.TabIndex = 16;
            buttonDecrypt.Text = "Decrypt";
            buttonDecrypt.UseVisualStyleBackColor = true;
            buttonDecrypt.Click += buttonDecrypt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 585);
            Controls.Add(buttonDecrypt);
            Controls.Add(textBoxDecryptedText);
            Controls.Add(textBoxCipherText);
            Controls.Add(buttonEncrypt);
            Controls.Add(textBoxCleartext);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxIV);
            Controls.Add(textBoxKey);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxKey;
        private TextBox textBoxIV;
        private Label label1;
        private Label label2;
        private TextBox textBoxCleartext;
        private Button buttonEncrypt;
        private TextBox textBoxCipherText;
        private TextBox textBoxDecryptedText;
        private Button buttonDecrypt;
    }
}