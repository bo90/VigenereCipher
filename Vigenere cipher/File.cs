using System;
using System.IO;
using System.Collections;

namespace VigenereCipher {
    class File {
        public string fileName = string.Empty;

        public File(string fileName) {
            this.fileName = fileName;
        }

        public string ReadFile() {
            try {
                StreamReader sr = new StreamReader(this.fileName, System.Text.Encoding.UTF8);
               // StreamReader sr = new StreamReader(this.fileName, System.Text.Encoding.GetEncoding(1251));
                
                string res = string.Empty;
                //чтение файла с ASCII
                byte[] B = System.IO.File.ReadAllBytes(this.fileName);
                string outStr = System.Text.Encoding.Default.GetString(B);

                byte[] b = System.Text.Encoding.Default.GetBytes(outStr);
                outStr = System.Text.Encoding.Default.GetString(b);

                //string line = sr.ReadLine();
                //while (line != null) {
                //    res += line + Convert.ToChar(13);
                //    line = sr.ReadLine();
                //}


                sr.Close();

                return outStr; //res;
            } catch (Exception) {
                return "";
            }
        }

        public void WriteFile(string text) {
            try {
                StreamWriter sw = new StreamWriter(this.fileName);
                sw.WriteLine(text, System.Text.Encoding.UTF8);
                sw.Close();
            } catch(Exception) {

            }
        }
    }
}
