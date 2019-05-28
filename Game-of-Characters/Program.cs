using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] wordy = word.ToCharArray();
            int length = wordy.Length;
            for (int i = 0; i < length; i++)
            {
                if (wordy[i]==')')
                {
                    for (int j = i-1; j >= 0; j--)
                    {
                        if (wordy[j]=='(')
                        {
                            char[] wordyTemp = new char[i - j - 1];
                            int z = i - 1;
                            int v = j + 1;
                            for (int k = 0; k < i-j-1; k++)
                            {
                                wordyTemp[k] = wordy[z];
                                z--;
                            }
                            for (int t = 0; t < i-j-1; t++)
                            {
                                wordy[v] = wordyTemp[t];
                                v++;
                            }
                            wordy[i] = '/';
                            wordy[j] = '/';
                            i = -1; j = 0;
                            break;
                        }
                    }
                }
            }
            string wordFinal = new string(wordy);
            Console.WriteLine(wordFinal.Replace("/",string.Empty));
            Console.Read();
        }
    }
}
//Examples to copy: ab(dc)e(ih(fg))j, (ay(dan)um), (eb)r(n(ca)k)