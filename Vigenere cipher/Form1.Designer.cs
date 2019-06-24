namespace VigenereCipher {
    partial class Form1 {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.vigenereKeyEdt = new System.Windows.Forms.TextBox();
            this.openFromFileBtn = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.RichTextBox();
            this.saveToFileBtn = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.сasiskiBtn = new System.Windows.Forms.Button();
            this.casiskiText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // vigenereKeyEdt
            // 
            this.vigenereKeyEdt.Location = new System.Drawing.Point(136, 294);
            this.vigenereKeyEdt.Margin = new System.Windows.Forms.Padding(2);
            this.vigenereKeyEdt.Name = "vigenereKeyEdt";
            this.vigenereKeyEdt.Size = new System.Drawing.Size(568, 20);
            this.vigenereKeyEdt.TabIndex = 0;
            this.vigenereKeyEdt.Text = "кот";
            // 
            // openFromFileBtn
            // 
            this.openFromFileBtn.Location = new System.Drawing.Point(11, 318);
            this.openFromFileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.openFromFileBtn.Name = "openFromFileBtn";
            this.openFromFileBtn.Size = new System.Drawing.Size(135, 34);
            this.openFromFileBtn.TabIndex = 1;
            this.openFromFileBtn.Text = "Загрузить из файла исходный текст";
            this.openFromFileBtn.UseVisualStyleBackColor = true;
            this.openFromFileBtn.Click += new System.EventHandler(this.openFromFileBtn_Click);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(11, 27);
            this.inputText.Margin = new System.Windows.Forms.Padding(2);
            this.inputText.Name = "inputText";
            this.inputText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.inputText.Size = new System.Drawing.Size(693, 120);
            this.inputText.TabIndex = 0;
            this.inputText.Text = "";
            // 
            // saveToFileBtn
            // 
            this.saveToFileBtn.Location = new System.Drawing.Point(428, 320);
            this.saveToFileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveToFileBtn.Name = "saveToFileBtn";
            this.saveToFileBtn.Size = new System.Drawing.Size(135, 34);
            this.saveToFileBtn.TabIndex = 2;
            this.saveToFileBtn.Text = "Сохранить в файл зашифрованный текст";
            this.saveToFileBtn.UseVisualStyleBackColor = true;
            this.saveToFileBtn.Click += new System.EventHandler(this.saveToFileBtn_Click);
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(11, 167);
            this.outputText.Margin = new System.Windows.Forms.Padding(2);
            this.outputText.Name = "outputText";
            this.outputText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.outputText.Size = new System.Drawing.Size(693, 120);
            this.outputText.TabIndex = 1;
            this.outputText.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Текстовый файл (*.txt)|*.txt";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "Зашифрованный текст.txt";
            this.saveFileDialog.Filter = "Текстовый файл (*.txt)|*.txt";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(289, 318);
            this.decryptBtn.Margin = new System.Windows.Forms.Padding(2);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(135, 34);
            this.decryptBtn.TabIndex = 1;
            this.decryptBtn.Text = "Расшифровать";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(150, 318);
            this.encryptBtn.Margin = new System.Windows.Forms.Padding(2);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(135, 34);
            this.encryptBtn.TabIndex = 0;
            this.encryptBtn.Text = "Зашифровать";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Исходный текст:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Зашифрованный текст:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ключевое слово:";
            // 
            // сasiskiBtn
            // 
            this.сasiskiBtn.Location = new System.Drawing.Point(569, 320);
            this.сasiskiBtn.Name = "сasiskiBtn";
            this.сasiskiBtn.Size = new System.Drawing.Size(135, 34);
            this.сasiskiBtn.TabIndex = 7;
            this.сasiskiBtn.Text = "Анализ зашифрованного текста";
            this.сasiskiBtn.UseVisualStyleBackColor = true;
            this.сasiskiBtn.Click += new System.EventHandler(this.сasiskiBtn_Click);
            // 
            // casiskiText
            // 
            this.casiskiText.Location = new System.Drawing.Point(709, 27);
            this.casiskiText.Name = "casiskiText";
            this.casiskiText.Size = new System.Drawing.Size(208, 327);
            this.casiskiText.TabIndex = 8;
            this.casiskiText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 361);
            this.Controls.Add(this.casiskiText);
            this.Controls.Add(this.сasiskiBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vigenereKeyEdt);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.saveToFileBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openFromFileBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Шифр Виженера";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.RichTextBox inputText;
        private System.Windows.Forms.Button openFromFileBtn;
        private System.Windows.Forms.Button saveToFileBtn;
        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.TextBox vigenereKeyEdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button сasiskiBtn;
        private System.Windows.Forms.RichTextBox casiskiText;
    }
}

