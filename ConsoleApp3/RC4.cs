using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class RC4
    {

        byte[] S = new byte[256];

        int x = 0;
        int y = 0;

        public RC4(byte[] key)
        {
            Init(key);
        }

        public void Init(byte[] key)
        {
            int KeyLength = key.Length;
            byte temp;
            for (int i = 0; i < 256; i++)
            {
                S[i] = (byte)i;
            }
            
            int j = 0;
            for (int i = 0; i < 256; i++)
            {
                j = (j + S[i] + key[i % KeyLength]) % 256;
                                                          // S.Swap(i, j);
                temp = S[i];
                S[i] = S[j];
                S[j] = temp;
            }

        }

        private byte KeyItem()
        {
            byte temp;
            x = (x + 1) % 256;
            y = (y + S[x]) % 256;
            temp = S[y];
            S[y] = S[x];
            S[x] = temp;
            return S[(S[x] + S[y]) % 256];
        }

        public byte[] Encode(byte[] dataB, int size)
        {
            byte[] data = dataB.Take(size).ToArray();
            byte[] cipher = new byte[data.Length];
            for (int m = 0; m < data.Length; m++)
            {
                cipher[m] = (byte)(data[m] ^ KeyItem());
            }
            return cipher;

        }

        public byte[] Decode(byte[] dataB, int size)
        {
            return Encode(dataB, size);
        }
    }
}
