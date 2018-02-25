using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MultiServer
{
    class Program
    {
        private static readonly Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static readonly List<Socket> clientSockets = new List<Socket>();
        private const int BUFFER_SIZE = 2048;
        private const int PORT = 100;
        private static readonly byte[] buffer = new byte[BUFFER_SIZE];

        static void Main()
        {
            Console.Title = "Server";
            SetupServer();
            Console.ReadLine(); 
            CloseAllSockets();
        }

        private static void SetupServer()
        {
            Console.WriteLine("Поднимаем сервер...");
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, PORT)); // устанавливаем конечную точку привязки
            serverSocket.Listen(0);
            serverSocket.BeginAccept(AcceptCallback, null);
            Console.WriteLine("Поднятие сервера выполнено успешно");
        }

        /// <summary>
        /// Close all connected client (we do not need to shutdown the server socket as its connections
        /// are already closed with the clients).
        /// </summary>
        private static void CloseAllSockets()
        {
            foreach (Socket socket in clientSockets)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }

            serverSocket.Close();
        }

        private static void AcceptCallback(IAsyncResult AR)
        {
            Socket socket;

            try
            {
                socket = serverSocket.EndAccept(AR);
            }
            catch (ObjectDisposedException) // I cannot seem to avoid this (on exit when properly closing sockets)
            {
                return;
            }

            clientSockets.Add(socket);
            socket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, socket);
            Console.WriteLine("Клиент подключен, ждем запроса...");
            serverSocket.BeginAccept(AcceptCallback, null);
        }

        private static void ReceiveCallback(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received;

            try
            {
                received = current.EndReceive(AR);
            }
            catch (SocketException)
            {
                Console.WriteLine("Клиент завершил соединение");
                // закрытие сокетоа
                current.Close();
                clientSockets.Remove(current);
                return;
            }

            byte[] recBuf = new byte[received];
            Array.Copy(buffer, recBuf, received);
            string text = Encoding.UTF8.GetString(recBuf);
            //  Console.WriteLine("Received Text: " + text);

            string t = Encoding.UTF8.GetString(buffer);

            string[] masv = t.Split('|');

            if (masv[0] == "1")
            {
                string result = Convert.ToString(Mathlib.Cosinus(Convert.ToInt32(masv[1])));
                Console.WriteLine(result);

                byte[] data = Encoding.UTF8.GetBytes(result);
                current.Send(data);

            }
            if (masv[0] == "2")
            {
                string result = Convert.ToString(Math.Sqrt(Convert.ToInt32(masv[1])));
                Console.WriteLine(result);

                byte[] data = Encoding.UTF8.GetBytes(result);
                current.Send(data);
            }
            if (masv[0] == "3")
            {
                string result = Convert.ToString(Math.Log10(Convert.ToInt32(masv[1])));
                Console.WriteLine(result);
                byte[] data = Encoding.UTF8.GetBytes(result);
                current.Send(data);

            }
            if (masv[0] == "4")
            {
                string result = Convert.ToString(Math.Pow(Convert.ToInt32(masv[1]), 2));
                Console.WriteLine(result);

                byte[] data = Encoding.UTF8.GetBytes(result);
                current.Send(data);
            }





            else if (masv[0].ToLower() == "exit") // Client wants to exit gracefully
              {
                  // Always Shutdown before closing
                  current.Shutdown(SocketShutdown.Both);
                  current.Close();
                  clientSockets.Remove(current);
                  Console.WriteLine("Client disconnected");
                  return;
              }
             

            current.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, current);
        }
       
}
}
