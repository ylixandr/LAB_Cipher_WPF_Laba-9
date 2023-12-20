using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_Cipher_WPF
{
    public class ACipher : Cipher
    {

        string coding;
        public ACipher(string coding)
        {
            this.coding = coding;
        }

        public override void Decode(string str)
        {
            string res = "";

            for (int i = 0; i < str.Length; i++)
            {

                res += (char)(str[i] - 1);
            }

            Console.WriteLine("Res after decoding is " + res);
        }

        public override string Encode()
        {
            string res = "";
            for (int i = 0; i < coding.Length; i++)
            {
                res += (char)(coding[i] + 1);
            }

            return res;

        }
    }
}
