using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VigenereCipher {
    public partial class Form1 : Form {
        public static List<char> alphabetRU = new List<char>();
        public static List<char> alphabetEN = new List<char>();

        public Form1() {
            InitializeComponent();

            for (int i = 1072; i < 1104; ++i) {
                if (i == 1078)
                    alphabetRU.Add(Convert.ToChar(1105));

                alphabetRU.Add(Convert.ToChar(i));
            }

            for (int i = 97; i < 123; ++i)
                alphabetEN.Add(Convert.ToChar(i));
        }

        private void openFromFileBtn_Click(object sender, EventArgs e) {
            openFileDialog.ShowDialog();
        }

        private void saveToFileBtn_Click(object sender, EventArgs e) {
            saveFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e) {
            File input = new File(openFileDialog.FileName);
            string text = input.ReadFile();
            inputText.Text =   text;            
        }

        

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e) {
            File output = new File(saveFileDialog.FileName);
            string text = outputText.Text;
            output.WriteFile(text);
        }

        private void encryptBtn_Click(object sender, EventArgs e) {
            string text = inputText.Text;
            string r = string.Empty;
            //ReadRuss(text, ref r);

            string res = string.Empty;
            ReadRuss(text, ref r);
            Vigenere vg = new Vigenere(vigenereKeyEdt.Text);
            res = vg.Encrypt(r);
            //ReadRuss(res, ref r);
            outputText.Text = res;
        }   

        /*чтение строки и определение русская буква или нет*/
        private void ReadRuss(string inText, ref string OutText)
        {
            string line = default(string);
            for(int i = 0; i < inText.Length; i++)
            {
                char c = inText[i];
                if ((c >= 'А') && (c <= 'Я') || (c >= 'а') && (c <= 'я') || (c == ' ')
                    || (c == '!') || (c == '.') || (c == ',') || (c=='?') || (c=='\n')||
                    (c == 'Й')|| (c=='й'))
                {
                    line = line + c;
                }   
            }
            OutText = line;
        }

        private void decryptBtn_Click(object sender, EventArgs e) {
            string text = outputText.Text;
            string res = string.Empty;
            Vigenere vg = new Vigenere(vigenereKeyEdt.Text);
            res = vg.Decrypt(text);
            inputText.Text = res;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void сasiskiBtn_Click(object sender, EventArgs e)
        {
            Casiski cs = new Casiski();

            casiskiText.Text= cs.TakeCasiski(outputText.Text);
        }
    }
}
