using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace ProjetoLavi.Servico.ComunicacaoCLP
{
    public class UdpSocket : IDisposable
    {
        private static int ListenPort = 77;
        private static String[] CLPIP;
        private static List<CLPclass> listaIP = new List<CLPclass>();

        private static int _messageReceived = 0;

        public static void ReceiveCallback(IAsyncResult ar)
        {
            UdpClient u = (UdpClient)((UdpState)(ar.AsyncState)).u;
            IPEndPoint e = (IPEndPoint)((UdpState)(ar.AsyncState)).e;

            Byte[] receiveBytes = u.EndReceive(ar, ref e);
            //string receiveString = Encoding.ASCII.GetString(receiveBytes);
            CLPIP = Encoding.ASCII.GetString(receiveBytes, 0, receiveBytes.Length).Split('|');


            listaIP.Add(new CLPclass
            {
                IP = CLPIP[0],
                Nome = CLPIP[1]
            });
            CLPIP = null;


            //Console.WriteLine("Received: {0}", receiveString);
            _messageReceived++;
        }

        public static RetornoIP ReceiveMessages()
        {
            try
            {
                // Receive a message and write it to the console.
                IPEndPoint e = new IPEndPoint(IPAddress.Any, ListenPort);
                UdpClient u = new UdpClient(e);

                UdpState s = new UdpState
                {
                    e = e,
                    u = u
                };



                // Do some work while we wait for a message. For this example,
                // we'll just sleep
                while (_messageReceived >= 1000)
                //for (int i = 10; i <= 10; i++)
                {
                    u.BeginReceive(ReceiveCallback, s);
                    Thread.Sleep(100);
                }

                return new RetornoIP
                {
                    Mensagem = string.Empty,
                    Tipo = 0,
                    ClPclasses = listaIP
                };
            }
            catch (Exception e)
            {
                return new RetornoIP
                {
                    Mensagem = e.Message,
                    Tipo = 1,
                    ClPclasses = new List<CLPclass>()
                };
            }


        }

        public void SendUdp(string dstIp, byte[] data)
        {
            using (var c = new UdpClient(ListenPort))
            {
                
                c.Send(data, data.Length, dstIp, ListenPort);
            }

        }

        // private static WaitCallback BuscaClp(UdpClient listener, IPEndPoint groupEP)
        // {
        //    byte[] bytes = listener.Receive(ref groupEP);
        //    CLPIP = Encoding.ASCII.GetString(bytes, 0, bytes.Length).Split('|');
        //}
        public RetornoIP StartListenerAsync()
        {
            try
            {

                Task.Run(async () =>
                {
                    using (var udpClient = new UdpClient(ListenPort))
                    {
                        var count = 0;
                        while (true)
                        {
                            if (count <= 1000)
                                count++;
                            else
                                break;

                            var receivedResults = await udpClient.ReceiveAsync();
                            var retorno = Encoding.ASCII.GetString(receivedResults.Buffer).Split('|');

                            if (retorno[0].Equals(string.Empty))
                                continue;

                            listaIP.Add(new CLPclass
                            {
                                IP = retorno[0],
                                Nome = retorno[1]
                            });
                        }
                    }
                });

                return new RetornoIP
                {
                    ClPclasses = listaIP,
                    Mensagem = string.Empty,
                    Tipo = 0

                };
            }
            catch (Exception e)
            {

                return new RetornoIP
                {
                    Mensagem = e.Message,
                    Tipo = 1,
                    ClPclasses = new List<CLPclass>()
                };
            }
        }


        public async Task<RetornoIP> StartListener()
        {
            UdpClient listener = new UdpClient(ListenPort);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, ListenPort);

            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    UdpReceiveResult bytes = await listener.ReceiveAsync();
                    var retorno = Encoding.ASCII.GetString(bytes.Buffer).Split('|');

                    // ThreadPool.QueueUserWorkItem(BuscaClp(listener, groupEP));

                    if (CLPIP != null && CLPIP[0].Equals(string.Empty))
                        continue;
                    listaIP.Add(new CLPclass
                    {
                        IP = retorno[0],
                        Nome = retorno[1]
                    });
                    retorno = null;
                    Thread.Sleep(5);

                }
                return new RetornoIP
                {
                    Mensagem = string.Empty,
                    Tipo = 0,
                    ClPclasses = listaIP
                };
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());
                return new RetornoIP
                {
                    Mensagem = e.Message,
                    Tipo = 1,
                    ClPclasses = new List<CLPclass>()
                };
            }
            finally
            {
                listener.Close();
            }
        }

        public void Dispose()
        {
            GC.Collect();
            GC.SuppressFinalize(this);

        }

    }
}