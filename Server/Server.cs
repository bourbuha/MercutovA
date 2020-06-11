﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using CommonNet3;

namespace Server
{
    class Server
    {

        class ConnectedClient
        {
            public Socket cSocket;
            private NetMessaging net;
            public static List<ConnectedClient> clients = new List<ConnectedClient>();
            public static List<Integral> integrals = new List<Integral>();
            public string Name { get; private set; }
            public ConnectedClient(Socket s)
            {
                cSocket = s;
                net = new NetMessaging(cSocket);
                net.MessageCmdReceived += OnMessage;
                net.MessageCmdReceived1 += OnAnswer;
                new Thread(() =>
                {
                    try
                    {

                        net.Communicate();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Не удалось получить данные от клиента :(");
                        //clients.Remove(this);
                    }
                }).Start();
            }
            private void OnAnswer(string command, string data)
            {
                string[] num = data.Split(new char[] { ' ' });
                
                integrals[integrals.Count - 1].answer = num[3];
            }
            private void OnMessage(string command, string data)
            {
                string[] num = data.Split(new char[] { ' ' });
                bool cont = false;
                for (int i = 0; i < integrals.Count; i++)
                {
                    if (integrals[i].a==int.Parse(num[0]) && integrals[i].b==int.Parse(num[1])&& integrals[i].n==int.Parse(num[2]))
                    {
                        cont = true;
                        string data1 = "";
                        data1 += integrals[i].answer;
                        this.net.SendData("MESSAGE", data1);
                        break;
                    }
                }
                if (!cont)
                {
                   Integral m = new Integral(int.Parse(num[0]), int.Parse(num[1]), int.Parse(num[2]));
                    integrals.Add(m);
                    this.net.SendData("ERROR", "В базе не найдено");
                }


            }
            
        }

        private String host;
        private Socket sSocket;
        private const int port = 8034;
        public Server()
        {

            Console.WriteLine("Получение локального адреса сервера");
            try
            {
                host = Dns.GetHostName();
                Console.WriteLine("Имя хоста: {0}", host);
                sSocket = new Socket(SocketType.Stream, ProtocolType.Tcp);
                foreach (var addr in Dns.GetHostEntry(host).AddressList)
                {
                    try
                    {
                        sSocket.Bind(
                            new IPEndPoint(addr, port)
                        );
                        Console.WriteLine("Сокет связан с: {0}:{1}", addr, port);
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Не удалось связать с: {0}:{1}", addr, port);
                    }
                }

                sSocket.Listen(10);
                Console.WriteLine("Прослушивание началось...");
                while (true)
                {
                    Console.WriteLine("Ожидание нового подключения...");
                    var cSocket = sSocket.Accept();
                    Console.WriteLine("Соединение с клиентом установлено!");
                    new ConnectedClient(cSocket);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Что-то пошло не так... :(");
            }
        }
    }
}
