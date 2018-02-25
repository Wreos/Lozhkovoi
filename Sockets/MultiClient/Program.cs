using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace MultiClient
{
    class Program
    {
    
        private static readonly Socket ClientSocket = new Socket
            (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private const int PORT = 100;

        static void Main()
        {
            Console.Title = "Client";
            ConnectToServer();
            RequestLoop();
            Exit();
        }

        private static void ConnectToServer()
        {
            int attempts = 0;

            while (!ClientSocket.Connected)
            {
                try
                {
                    attempts++;
                    Console.WriteLine("Connection attempt " + attempts);
                    // Change IPAddress.Loopback to a remote IP to connect to a remote host.
                    ClientSocket.Connect(IPAddress.Loopback, PORT);
                }
                catch (SocketException) 
                {
                    Console.Clear();
                }
            }

            Console.Clear();
            Console.WriteLine("Connected");
        }

        private static void RequestLoop()
        {
            Console.WriteLine(@"hello , type 5 for exit");

            while (true)
            {
                SendRequest();
                ReceiveResponse();
            }
        }

        /// <summary>
        /// Close socket and exit program.
        /// </summary>
        private static void Exit()
        {
            SendString("exit",0); // Tell the server we are exiting
            ClientSocket.Shutdown(SocketShutdown.Both);
            ClientSocket.Close();
            Environment.Exit(0);
        }

        private static void SendRequest()
        {
            
            Console.WriteLine("Отправьте запрос: 1 -вычислить синус \n 2 - получить корень из числа \n 3- натуральный логарифм \n 4 - умножить число само на себя ");
            string request = Console.ReadLine();
            double par = 0;
            try
            {
                switch (request)
                {
                    case "1":
                        Console.WriteLine("Введите параметр в радианах");
                        par = Convert.ToDouble(Console.ReadLine());
                        break;

                    case "2":
                        Console.WriteLine("Введите число, для которого необходимо получить корень");
                        par = Convert.ToDouble(Console.ReadLine());
                        break;
                    case "3":
                        Console.WriteLine("Введите число, для которого нужно найти логарифм");
                        par = Convert.ToDouble(Console.ReadLine());
                        break;
                    case "4":
                        Console.WriteLine("Введите число");
                        par = Convert.ToDouble(Console.ReadLine());
                        break;
                    case "exit":
                        Console.WriteLine("Вы нажали выход");
                        Exit();
                        break;

                    default:
                        Console.WriteLine("Некорректный запрос, введите запрос от 1 до 5");
                        SendRequest();
                        break;

                }






               /* if (request != "" || Convert.ToInt32(request) <= 5)
                {
                    if (request == "1")
                    {
                        Console.WriteLine("Введите параметр в радианах");
                        par = Convert.ToDouble(Console.ReadLine());
                    }
                    if (request == "2")
                    {
                        Console.WriteLine("Введите число, для которого необходимо получить корень");
                        par = Convert.ToDouble(Console.ReadLine());
                    }
                    if (request == "3")
                    {
                        Console.WriteLine("Введите число, для которого нужно найти логарифм");
                        par = Convert.ToDouble(Console.ReadLine());
                    }
                    if (request == "4")
                    {
                        Console.WriteLine("Введите число");
                        par = Convert.ToDouble(Console.ReadLine());
                    }

                    if (request == "5")
                    {
                        Exit();
                    }
                    else if (request == "" || Convert.ToInt32(request) > 5)
                    {
                        Console.WriteLine("Недопустимый запрос");

                        SendRequest();

                    }

                  if (request.ToLower() == "exit")
                    {
                        Exit();
                    }



                } */
            }
            catch (FormatException e)
            {
                //Console.Clear();
                Console.WriteLine("\nИван Васильевич, вы пытались...");
                SendRequest();
            }


                SendString(request,par);

           


          
        }

       
        
        private static void SendString(string request,double par)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(request+"|"+par);
            ClientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        private static void ReceiveResponse()
        {
            var buffer = new byte[2048];
            int received = ClientSocket.Receive(buffer, SocketFlags.None);
            if (received == 0) return;
            var data = new byte[received];
            Array.Copy(buffer, data, received);
            string text = Encoding.UTF8.GetString(data);
            Console.WriteLine(text);
        }
    }
}
