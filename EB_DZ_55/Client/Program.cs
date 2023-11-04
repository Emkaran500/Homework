﻿using System.Net;
using System.Net.Sockets;
using System.Text;

const string serverIp = "127.0.0.1";
const int port = 9999;
int correctNumber;
int guessNumber;

IPAddress address = IPAddress.Parse(serverIp);
IPEndPoint endPoint = new IPEndPoint(address, port);

Socket clientSocket = new Socket(
    addressFamily: AddressFamily.InterNetwork,
    socketType: SocketType.Stream,
    protocolType: ProtocolType.Tcp);

await clientSocket.ConnectAsync(endPoint);

byte[] buffer = new byte[1024];