using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VigenereCipher
{
    class Casiski
    {
        public Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

        public string TakeCasiski(string text)
        {
            //text = text.Replace(" ", "");
            string outText = "";
            int tgl = 3;
            string trigram;
            int poz;
            int newPoz;
            for (int i = 0; i <= text.Length - tgl; i++)
            {
                trigram = text.Substring(i, tgl);
               if(!dict.ContainsKey(trigram))
                {
                List<int> point = new List<int>();
                poz = i;
                    
                newPoz= text.IndexOf(trigram, poz + 1);
                    while(newPoz > 0)
                    {

                        point.Add( newPoz-poz);
                        poz = newPoz;
                        newPoz = text.IndexOf(trigram, newPoz + 1);
                    }
                    dict.Add(trigram, point);
                }

                

                
            }
            Dictionary<int, int> nodDict = new Dictionary<int, int>();
            if (dict.Count > 0)
            {
                dict = dict.OrderByDescending(pair => pair.Value.Count).ToDictionary(pair => pair.Key, pair => pair.Value);

                foreach (var v in dict)
                {
                    if (v.Value.Count > 1)
                    {
                        outText = outText + v.Key + ": ";
                        foreach (var l in v.Value)
                        {
                            outText = outText + l.ToString() + " ";

                        }

                        outText = outText + " НОД=" + NOD(v.Value) + Environment.NewLine;
                        if (NOD(v.Value) > 1)
                        {
                            if (!nodDict.ContainsKey(NOD(v.Value)))
                            {
                                nodDict.Add(NOD(v.Value), 1);
                            }
                            else
                            {
                                nodDict[NOD(v.Value)] += 1;
                            }
                        }
                    }
                }
                if (nodDict.Count > 0)
                {
                    int maxValue = nodDict.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
                    outText = "Длина ключевого слова = " + maxValue + Environment.NewLine + outText;
                }
                else
                {
                    outText = "Слишком короткий текст для анализа.";
                }
            }
            else
            {
                outText = "Слишком короткий текст для анализа.";
            }
            return outText;
        }
        private  int Gcd(int a, int b)
        {
            while (a != b)
                if (a > b)
                    a -= b;
                else
                    b -= a;
            return a;

            //return a > 0 ? Gcd(b % a, a) : b;
            //return a == 0 ? b : Gcd(b, b % a);
        }

        private  int NOD(List<int> list)
        {
            int[] array = list.ToArray();
            int gcd = Gcd(array[0], array[1]);
            for (int i = 2; i < array.Length; i++)
                gcd = Gcd(gcd, array[i]);
            return gcd;
        }
    }
}

    

