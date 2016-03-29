using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketServidor {
    class ServerSocket {
        static IPEndPoint ipEnd;
        static Socket socketServidor;
        public static string caminhoRecepcaoArquivos = @"C:\Dados\";
        public static string mensagemServidor = "Serviço encerrado!";
        public static void IniciarServidor() {
            try {
                string ipServidor = "172.23.17.23.153";
                ipEnd = new IPEndPoint(IPAddress.Parse(ipServidor),5656);
                socketServidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                socketServidor.Bind(ipEnd);
            } catch (Exception ex) {

            }
            try {
                socketServidor.Listen(100);
                Socket clientSocket = socketServidor.Accept();
                clientSocket.ReceiveBufferSize = 16384;

                byte[] dadosCliente = new byte[1024 * 5000];
                int tamanhoByteRecebido = clientSocket.Receive(dadosCliente, dadosCliente.Length,0);
                int tamanhoNomeArquivo = BitConverter.ToInt32(dadosCliente, 0);
                string nomeArquivo = Encoding.UTF8.GetString(dadosCliente, 4, tamanhoNomeArquivo);
                BinaryWriter bWriter = new BinaryWriter(File.Open(caminhoRecepcaoArquivos + nomeArquivo, FileMode.Append));
                bWriter.Write(dadosCliente,4+);
            } catch { }
        }
    }
}
