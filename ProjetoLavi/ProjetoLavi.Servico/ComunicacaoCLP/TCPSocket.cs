using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace ProjetoLavi.Servico.ComunicacaoCLP
{
    public class TCPSocket
    {
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream;

        public TCPSocket()
        {
            clientSocket.Connect("192.168.1.99", 77);            
            serverStream = clientSocket.GetStream();
        }

        public Boolean SendSocket(String Data)
        {
            try
            {
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(Data);
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public String ReceiveSocket()
        {
            try
            {
                byte[] inStream = new byte[100025];
                serverStream.Read(inStream, 0, (Int32)clientSocket.ReceiveBufferSize);
                return Encoding.ASCII.GetString(inStream).Replace(Convert.ToChar(0).ToString(),String.Empty);
                
            }
            catch (Exception e)
            {
                return "Erro Gerado: " + e.Message;
            }
        }

    }
}