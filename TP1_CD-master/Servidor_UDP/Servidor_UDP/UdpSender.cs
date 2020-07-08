using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Security.Cryptography;

namespace Servidor_UDP
{
    class UdpSender
    {
        private UdpClient _client;

        public int Port = 6969;
        public bool Running { get; set; } = false;

        public List<string> FicheirosTransfer;

        //NAO FAÇO PUTO DE IDEIA PARA QUE ISTO SERVE MAS ACHO QUE TEM A VER COM O CHECKSUM
        private MD5 _hasher;

        public UdpSender ()
        {
            _client = new UdpClient(Port, AddressFamily.InterNetwork);
            _hasher = MD5.Create();
            FicheirosTransfer = new List<string>(Directory.EnumerateFiles(
                         "C:/Users/bruno/OneDrive/Documentos/TP1_CD/Servidor_UDP/Servidor_UDP/Ficheiros"));
        }
        public void MostraFicheiros()
        {
            if (FicheirosTransfer.Count != 0)
            {
                foreach (string s in FicheirosTransfer)
                    Console.WriteLine("  {0}", s);
            }
            else
                Console.WriteLine("I don't have any files to transfer.");
        }

        public int FileRequest()
        {



            return 1;
        }
    }
}
