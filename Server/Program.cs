using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ClassLibraryBackend;

namespace Server
{
    internal class Program
    {
        private static ConcurrentDictionary<string, Airplane> _airplanes = new ConcurrentDictionary<string, Airplane>();
        static void Main(string[] args)
        {
            // Устанавливаем для сокета локальную конечную точку
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);

            Socket sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                sListener.Bind(ipEndPoint);
                sListener.Listen(10);
                while (true)
                {
                    Console.WriteLine("Ожидаем соединение через порт {0}", ipEndPoint);
                    // Программа приостанавливается, ожидая входящее соединение
                    Socket socket = sListener.Accept();
                    Task taskSocket = new Task(Action, socket);
                    taskSocket.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void Action(object o)
        {
            bool disconnected = false;
            Socket socket = o as Socket;
            if (socket != null)
            {
                while (true)
                {
                    try
                    {
                        // Мы дождались клиента, пытающегося с нами соединиться
                        byte[] bytes = new byte[10240];
                        int bytesRec = socket.Receive(bytes);
                        string json = Encoding.UTF8.GetString(bytes, 0, bytesRec);
                        Response response = new Response { isSuccess = false };
                        try
                        {
                            var request = JsonConvert.DeserializeObject<Request>(json);
                            if (request != null)
                            {
                                response.Key = request.Key;
                                Airplane airplane;
                                switch (request.Type)
                                {
                                    case RequestType.Get:
                                        if (_airplanes.TryGetValue(request.Key, out airplane))
                                        {
                                            response.Airplane = airplane;
                                            response.isSuccess = true;
                                        }
                                        else
                                        {
                                            response.ErrorMessage = "Ключ не найден";
                                        }
                                        break;
                                    case RequestType.Add:
                                        if (_airplanes.ContainsKey(request.Key))
                                        {
                                            response.ErrorMessage = "Самолёт с таким ключем уже существует";
                                        }
                                        else
                                        {
                                            _airplanes.AddOrUpdate(request.Key, request.Airplane, (s, airplane1) => request.Airplane);
                                            response.isSuccess = true;
                                        }
                                        break;
                                    case RequestType.Update:
                                        if (_airplanes.ContainsKey(request.Key))
                                        {
                                            _airplanes.AddOrUpdate(request.Key, request.Airplane, (s, airplane1) => request.Airplane);
                                            response.isSuccess = true;
                                        }
                                        else
                                        {
                                            response.ErrorMessage = "Самолёт с таким ключем не существует";
                                        }
                                        break;
                                    case RequestType.Delete:
                                        if (_airplanes.ContainsKey(request.Key))
                                        {
                                            if (_airplanes.TryRemove(request.Key, out airplane))
                                            {
                                                response.isSuccess = true;
                                            }
                                            else
                                            {
                                                response.ErrorMessage = "Не удалось удалить самолёт";
                                            }
                                        }
                                        else
                                        {
                                            response.ErrorMessage = "Самолёт с таким ключем не существует";
                                        }
                                        break;
                                    case RequestType.Disconnect:
                                        disconnected = true;
                                        break;
                                    default:
                                        throw new ArgumentOutOfRangeException();
                                }
                            }
                        }
                        catch (Exception exception)
                        {
                            response.ErrorMessage = exception.Message;
                        }
                        Console.WriteLine("Полученный json: " + json);
                        if (disconnected) break;
                        var jsonResponse = JsonConvert.SerializeObject(response);
                        byte[] msg = Encoding.UTF8.GetBytes(jsonResponse);
                        Console.Write("Отправленный json: " + jsonResponse);
                        socket.Send(msg);
                    }
                    catch (Exception)
                    {
                        break;
                    }
                }
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }

    }
}
