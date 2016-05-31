using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Sockets {
    class ClienteSocket {
        public static string mensagem = "Em espera...";
        public static void EnviarArquivo(string nomeArquivo) {
            try {
                string ip = "172.17.20.151";
                IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse(ip), 5656);
                Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                nomeArquivo = nomeArquivo.Replace('\\', '/');

                string caminho = string.Empty;
                while (nomeArquivo.IndexOf('/') > -1) {
                    caminho += nomeArquivo.Substring(0, nomeArquivo.IndexOf('/') + 1);
                    nomeArquivo = nomeArquivo.Substring(nomeArquivo.IndexOf('/') + 1);
                }
                byte[] nomeArquivoByte = Encoding.UTF8.GetBytes(nomeArquivo);

                if (nomeArquivoByte.Length > 5000 * 1024) {
                    mensagem = "O tamanho do arquivo não pode ser maior que 5MB!";
                    return;
                }

                string caminhoCompleto = caminho + nomeArquivo;

                byte[] fileData = File.ReadAllBytes(caminhoCompleto);
                byte[] clienteData = new byte[4 + nomeArquivo.Length + fileData.Length];
                byte[] nomeArquivoLen = BitConverter.GetBytes(nomeArquivoByte.Length);

                nomeArquivoLen.CopyTo(clienteData, 0);
                nomeArquivoByte.CopyTo(clienteData, 4);
                fileData.CopyTo(clienteData, 4 + nomeArquivoByte.Length);

                clientSocket.Connect(ipEnd);
                clientSocket.Send(clienteData, 0, clienteData.Length, 0);
                clientSocket.Close();
                mensagem = "Arquivo [" + caminhoCompleto + "] transferido...";
            } catch (Exception ex) {
                mensagem = ex.Message + "\nO Servidor não está respondendo!";
            }
        }
    }
}
