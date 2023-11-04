﻿using System.Net;
using System.Net.Sockets;
using System.Text;

const string serverIp = "127.0.0.1";
const int port = 9999;
int attempts = 5;

IPAddress address = IPAddress.Parse(serverIp);
IPEndPoint endPoint = new IPEndPoint(address, port);

Socket clientSocket = new Socket(
    addressFamily: AddressFamily.InterNetwork,
    socketType: SocketType.Stream,
    protocolType: ProtocolType.Tcp);

await clientSocket.ConnectAsync(endPoint);

byte[] buffer = new byte[1024];

ThreadPool.QueueUserWorkItem(async (obj) =>
{
    try
    {
        while (true)
        {
            var size = await clientSocket.ReceiveAsync(buffer);
            var msg = Encoding.Unicode.GetString(buffer, 0, size);
            if (msg == "Congratulations! You are correct!")
            {
                Environment.Exit(0);
            }
            else
            {
                attempts--;
                Console.WriteLine($"Attempts: {attempts}");
                if (attempts <= 0)
                {
                    Console.WriteLine("Sorry you have failed!");
                    Environment.Exit(-1);
                }
            }
        }
    }
    catch (SocketException)
    {
        Console.WriteLine("Disconnected from server!");
        Environment.Exit(-2);
    }
    catch (Exception ex)
    {
        Console.WriteLine("System error: " + ex);
        Environment.Exit(-3);
    }
}, null);

try
{
    Console.WriteLine("Input the number, that you think is correct\n");
    while (true)
    {
        string guess = Console.ReadLine() ?? string.Empty;
        var guessInBytes = Encoding.Unicode.GetBytes(guess);

        await clientSocket.SendAsync(guessInBytes);
    }
}
catch (SocketException)
{
    Console.WriteLine("Disconnected from server!");
    Environment.Exit(-2);
}
catch (Exception ex)
{
    Console.WriteLine("System error: " + ex);
    Environment.Exit(-3);
}
finally
{
    clientSocket.Dispose();
}