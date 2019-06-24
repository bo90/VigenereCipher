using System.Collections.Generic;

namespace VigenereCipher {
    class Vigenere {
        const int lettersRU = 33;
        const int lettersEN = 26;

        private List<char> temp = null;
        private int letters = 0;
        private bool upper = false;
        private string key = string.Empty;

        public Vigenere(string key) {
            this.key = key;
        }

        public string getKey(int len) {
            string res = string.Empty;
            int j = 0;

            for (int i = 0; i < len; ++i) {
                if (j == this.key.Length)
                    j = 0;

                res += this.key[j++];
            }

            return res;
        }

        public void initAlphabet(char ch) {
            if (char.IsUpper(ch)) {
                this.upper = true;
                ch = char.ToLower(ch);
            } else
                this.upper = false;

            if (Form1.alphabetRU.Contains(ch)) {
                this.temp = Form1.alphabetRU;
                this.letters = lettersRU;
            } else if (Form1.alphabetEN.Contains(ch)) {
                this.temp = Form1.alphabetEN;
                this.letters = lettersEN;
            } else
                this.letters = 0;
        }

        public string Encrypt(string text) {
            string res = string.Empty;
            string key = this.getKey(text.Length);
            int iKey = 0;

            for (int i = 0; i < text.Length; ++i) {
                initAlphabet(key[i]);
                iKey = this.temp.IndexOf(char.ToLower(key[i]));

                initAlphabet(text[i]);
                if (this.letters != 0) {
                    int encryptChar = (this.temp.IndexOf(char.ToLower(text[i])) + iKey) % this.letters;

                    if (this.upper)
                        res += char.ToUpper(this.temp[encryptChar]);
                    else
                        res += this.temp[encryptChar];
                } else
                    res += text[i];
            }

            return res;
        }

        public string Decrypt(string text) {
            string res = string.Empty;
            string key = this.getKey(text.Length);
            int iKey = 0;

            for (int i = 0; i < text.Length; ++i) {
                initAlphabet(key[i]);
                iKey = this.temp.IndexOf(char.ToLower(key[i]));

                initAlphabet(text[i]);
                if (this.letters != 0) {
                    int decryptChar = (this.temp.IndexOf(char.ToLower(text[i])) - iKey);
                    decryptChar = (decryptChar % this.letters + this.letters) % this.letters;

                    if (this.upper)
                        res += char.ToUpper(this.temp[decryptChar]);
                    else
                        res += this.temp[decryptChar];
                } else
                    res += text[i];
            }

            return res;
        }
    }
}
