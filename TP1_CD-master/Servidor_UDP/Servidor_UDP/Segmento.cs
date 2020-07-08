using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor_UDP
{
    class Segmento
    {
        public int Number { get; set; }
        public byte[] Data { get; set; } = new byte[0];

        public Segmento(int number = 0)
        {
            Number = number;
        }

        public Segmento(byte[] bytes)
        {
            Number = BitConverter.ToInt32(bytes, 0);
            Data = bytes;
        }
        public override string ToString()
        {
            return string.Format(
                "[Block: " + " Number={0}" + "  Size={1}]\n", Number, Data.Length);
        }

        public byte[] GetBytes()
        {
            byte[] numberBytes = BitConverter.GetBytes(Number);

            byte[] bytess = new byte[numberBytes.Length + Data.Length];
            numberBytes.CopyTo(bytess, 0);
            Data.CopyTo(bytess, 4);

            return bytess;
        }
    }
}
