using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor_UDP
{
    class Block
    {

        public int Number { get; set; }
        public byte[] Data { get; set; } = new byte[0];

        //contructors

            //cria um bloco com um numero fornecido
        public Block(int number)
        {
            Number = number;
        }

            // cria um bloco a partir de um array de bytes
        public Block(byte[] bytes)
        {
            //transforma os 4 bytes num numero inteiro
            Number = BitConverter.ToInt32(bytes, 0);
            //avança os 4 primeiros bytes
            Data = bytes.Skip(4).ToArray();
        }

        public byte[] GetBytes()
        {
            byte[] numberBytes = BitConverter.GetBytes(Number);

            //junta todos os dados num array
            byte[] bytes = new byte[numberBytes.Length + Data.Length];
            numberBytes.CopyTo(bytes, 0);
            Data.CopyTo(bytes, 4);

            return bytes;
        }
    }
}
