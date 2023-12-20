using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_Cipher_WPF
{
    public class BCipher : Cipher
    {
        string coding;

        public BCipher(string coding)
        {
            Console.WriteLine("Use only Lower case");
            this.coding = coding;
        }
        public override void Decode(string str) //Метод Decode это по сути метод Encode 
                                                //но примененный два раза. Поэтому логика методов не отличается от слова совсем
        {
            string res = "";
            int min = 0;
            int max = 0;
            int dif = 0;

            if (str[0] >= 1072 && str[0] <= 1103)
            {
                min = 1072;
                max = 1103;
                int des = 0;

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] <= min + 16)
                    {
                        des = str[i] - min;
                        res += (char)(max - des);
                    }

                    else
                    {
                        des = max - str[i];
                        res += (char)(min + des);
                    }

                }

            }

            else
            {
                min = (int)'a';
                max = (int)'z';
                int des = 0;

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] <= min + 13)
                    {
                        des = str[i] - min;
                        res += (char)(max - des);
                    }

                    else
                    {
                        des = max - str[i];
                        res += (char)(min + des);
                    }

                }

            }

            Console.WriteLine($"After decoding cipher is: {res}");

        }

        //Суть данного метода по логике состоит в том, что если буква находится до середины 
        // алфавита, то она отнимается с конца. Цифры в условии это буквы в int представлении 
        // (int)
        public override string Encode()
        {
            string res = "";
            int min = 0;
            int max = 0;
            int dif = 0;

            if (coding[0] >= 1072 && coding[0] <= 1103)
            {
                min = 1072;
                max = 1103;
                int des = 0;

                for (int i = 0; i < coding.Length; i++)
                {
                    if (coding[i] <= min + 16)
                    {
                        des = coding[i] - min;
                        res += (char)(max - des);
                    }

                    else
                    {
                        des = max - coding[i];
                        res += (char)(min + des);
                    }

                }

            }

            else
            {
                min = (int)'a';
                max = (int)'z';
                int des = 0;

                for (int i = 0; i < coding.Length; i++)
                {
                    if (coding[i] <= min + 13)
                    {
                        des = coding[i] - min;
                        res += (char)(max - des);
                    }

                    else
                    {
                        des = max - coding[i];
                        res += (char)(min + des);
                    }

                }

            }

            return res;
        }
    }
}
