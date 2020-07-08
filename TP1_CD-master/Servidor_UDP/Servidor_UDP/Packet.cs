using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor_UDP
{
    class Packet
    {
<<<<<<< HEAD
        //pacote pode ter varios tipos
        public int Ack;
        public int FIN;
        public int RequestFile;
        public int RequestBlock;
        public int SendFile;

        //campos de um packet
        public int PacketType { get; set; }
        public byte[] Payload { get; set; } = new byte[0];

        //contrutores
        public Packet(int packetType)
        {
            //define o tipo de pacote que vai ser enviado
            PacketType = packetType;
        }

        public Packet(byte[]bytes)
        {
            Payload = new Byte[bytes.Length - 4];
            bytes.Skip(4).ToArray().CopyTo(Payload, 0);

        }
=======
        public int PacketType { get; set; }

        public byte[] Payload { get; set; }
>>>>>>> 2253e53d7a739621ddb4f0b9c1360d6097ec62c1
    }
}
