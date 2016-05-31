using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketServidor {
    class ServerSocket {
        static IPEndPoint ipEnd;
        static Socket socketServidor;
        public static string caminhoRecepcaoArquivos = @"C:\Lixo\";
        public static string mensagemServidor = "Serviço encerrado!";

        public static void IniciarServidor() {
            if (socketServidor != null && socketServidor.Blocking) {
                return;
            } else {
                try {
                    string ipServidor = "172.17.20.151";
                    //IPAddress ip = IPAddress.Parse("172.17.20.151");
                    IPAddress ip = IPAddress.Parse(ipServidor);

                    ipEnd = new IPEndPoint(ip, 5656);
                    socketServidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                    socketServidor.Bind(ipEnd);
                } catch (Exception ex) {
                    mensagemServidor = ex.Message;
                    //throw new Exception("Erro ao Iniciar Servidor!");
                }

                try {
                    socketServidor.Listen(100);
                    Socket clientSocket = socketServidor.Accept();
                    clientSocket.ReceiveBufferSize = 16384;

                    byte[] dadosCliente = new byte[1024 * 5000];
                    int tamanhoByteRecebido = clientSocket.Receive(dadosCliente, dadosCliente.Length, 0);
                    int tamanhoNomeArquivo = BitConverter.ToInt32(dadosCliente, 0);
                    string nomeArquivo = Encoding.UTF8.GetString(dadosCliente, 4, tamanhoNomeArquivo);

                    BinaryWriter bWriter = new BinaryWriter(File.Open(caminhoRecepcaoArquivos + nomeArquivo, FileMode.Append));
                    bWriter.Write(dadosCliente, 4 + tamanhoNomeArquivo, tamanhoByteRecebido - 4 - tamanhoNomeArquivo);

                    while (tamanhoByteRecebido > 0) {
                        tamanhoByteRecebido = clientSocket.Receive(dadosCliente, dadosCliente.Length, 0);
                        if (tamanhoByteRecebido == 0) {
                            bWriter.Close();
                        } else {
                            bWriter.Write(dadosCliente, 0, tamanhoByteRecebido);
                        }
                    }
                    bWriter.Close();
                    mensagemServidor = "Arquivo recebido e arquivado [" + nomeArquivo + "] (" + (tamanhoByteRecebido - 4 - tamanhoNomeArquivo) + " bytes recebido); Servidor Parado";
                } catch (SocketException ex) {
                    throw new Exception("Erro ao receber arquivo!");
                }
            }
        }
    }
}
