using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_Cipher_WPF
{
    public interface ICipher
    {
        string Encode();
        string Decode(string str);
    }
}
