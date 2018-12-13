using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    using System.Net.Sockets;

    public class Printer 
    {
        public void Print(string ipAddress, int port, IList<string> linesToPrint)
        {
            // Create a socket object
            Socket pSocket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            // Set a timeout for attemps to connect, here set to 1500 miliseconds
            pSocket.SendTimeout = 1500;
            // Connect to the specified ip address and port
            pSocket.Connect(ipAddress, port);

            List<byte> outputList = new List<byte>();
            foreach (string txt in linesToPrint)
            {
                // Convert the strings to list of bytes
                outputList.AddRange(System.Text.Encoding.UTF8.GetBytes(txt));
                // Add ECS/POS Print and line feed command
                outputList.Add(0x0A); 
            }

            // Send the command to the printer
            pSocket.Send(outputList.ToArray());

            // Close the connection once done
            pSocket.Close();
        }
    }
}
