﻿using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

const string serverIp = "127.0.0.1";
const int port = 9999;
Dictionary<Socket, int> correctNums = new Dictionary<Socket, int>();

IPAddress address = IPAddress.Parse(serverIp);
IPEndPoint endPoint = new IPEndPoint(address, port);



Socket serverSocket = new Socket(
    addressFamily: AddressFamily.InterNetwork,
    socketType: SocketType.Stream,
    protocolType: ProtocolType.Tcp);

serverSocket.Bind(endPoint);
serverSocket.Listen(backlog: 5);
Console.WriteLine("Server opened!\n");

while(true)
{
    Socket clientSocket = await serverSocket.AcceptAsync();
    correctNums.Add(clientSocket, Random.Shared.Next(0, 101));
    Console.WriteLine($"{clientSocket.RemoteEndPoint} correct number: {correctNums.First(predicate: (numPair) => numPair.Key == clientSocket).Value}");

    ThreadPool.QueueUserWorkItem(async (socket) => {
        try
        {
            var buffer = new byte[1024];

            while (true)
            {
                var size = await socket.ReceiveAsync(buffer);
                var requestMessage = Encoding.Unicode.GetString(buffer, 0, size);
                string responseMessage;
                byte[] responseMessageInBytes;
                if (int.TryParse(requestMessage, out int result))
                {
                    if (correctNums.Any(predicate: (numPair) => numPair.Key == clientSocket && numPair.Value == result))
                    {
                        responseMessage = "Congratulations! You are correct!";
                        responseMessageInBytes = Encoding.Unicode.GetBytes(responseMessage);
                        correctNums.Remove(clientSocket);
                        await socket.SendAsync(responseMessageInBytes);
                    }
                    else
                    {
                        KeyValuePair<Socket, int> correctPair = correctNums.First(predicate: (numPair) => numPair.Key == clientSocket);
                        if (result > correctPair.Value)
                        {
                            responseMessage = "Your number is greater than correct number.";
                            responseMessageInBytes = Encoding.Unicode.GetBytes(responseMessage);
                            await socket.SendAsync(responseMessageInBytes);
                        }
                        else
                        {
                            responseMessage = "Your number is lower than correct number.";
                            responseMessageInBytes = Encoding.Unicode.GetBytes(responseMessage);
                            await socket.SendAsync(responseMessageInBytes);
                        }
                    }
                }
                else
                {
                    responseMessage = "Incorrect input!";
                    responseMessageInBytes = Encoding.Unicode.GetBytes(responseMessage);
                    await socket.SendAsync(responseMessageInBytes);
                }
            }
        }
        catch (SocketException)
        {
            Console.WriteLine($"Client {socket.RemoteEndPoint} disconnected!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"System error in {socket.RemoteEndPoint} client.\n{ex}");
        }
    }, clientSocket, false);
}