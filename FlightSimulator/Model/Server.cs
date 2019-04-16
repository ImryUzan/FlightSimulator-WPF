/**using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using FlightSimulator.ViewModels;

namespace FlightSimulator.Model
{
    public class Server
    {
        FlightBoardViewModel flightBoardViewModel;
        private readonly object locker;
        public Dictionary<string, double> pathRead = new Dictionary<string, double>();

        public Server()
        {
            // flightBoardViewModel = new FlightBoardViewModel();
            locker = new Object();
        }




        public FlightBoardViewModel FlightBoardViewModelOfProg
        {
            get
            {
                return flightBoardViewModel;
            }
            set
            {
                flightBoardViewModel = value;
            }
        }


        public void connectServer()
        {

            


            TcpListener server = null;
            try
            {
                // Set the TcpListener on port 13000.
                Int32 port = 5400;
               // IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                IPAddress localAddr = IPAddress.Parse(ApplicationSettingsModel.Instance.FlightServerIP);
                // TcpListener server = new TcpListener(port);
               // server = new TcpListener(localAddr, port);
                server = new TcpListener(localAddr, ApplicationSettingsModel.Instance.FlightInfoPort);
                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[256];
                String data = null;
                List<string> toSend = new List<string>();

                // Enter the listening loop.
                // while (true)
                // {
                Console.Write("Waiting for a connection... ");

                // Perform a blocking call to accept requests.
                // You could also user server.AcceptSocket() here.
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Connected!");

                data = null;

                // Get a stream object for reading and writing
                NetworkStream stream = client.GetStream();

                int i;
                Thread thread = new Thread(() =>
                {
                    // Loop to receive all the data sent by the client.
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // Translate data bytes to a ASCII string.
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        Console.WriteLine("Received: {0}", data);

                        // Process the data sent by the client.
                        toSend = this.Parser(data);
                        data = data.ToUpper();
                        lock (locker)
                        {
                            flightBoardViewModel.Lat = Convert.ToDouble(toSend[0]);
                            flightBoardViewModel.Lon = Convert.ToDouble(toSend[1]);
                        }


                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                        // Send back a response.
                        // stream.Write(msg, 0, msg.Length);
                        // Console.WriteLine("Sent: {0}", data);
                    }

                    // Shutdown and end connection
                    client.Close();
                });
                thread.Start();
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }
            Console.WriteLine("\nHit enter to continue...");
            Console.Read();
            return;
        }

       public List<string> Parser(string information)
        {
            List<string> result = information.Split(',').ToList();
            return result;
        }


        public void setData()
        {

            this.pathRead.Add("/instrumentation/airspeed-indicator/indicated-speed-kt", 0);
            this.pathRead.Add("/instrumentation/altimeter/indicated-altitude-ft", 0);
            this.pathRead.Add("/instrumentation/altimeter/pressure-alt-ft", 0);
            this.pathRead.Add("/instrumentation/attitude-indicator/indicated-pitch-deg", 0);
            this.pathRead.Add("/instrumentation/attitude-indicator/indicated-roll-deg", 0);
            this.pathRead.Add("/instrumentation/attitude-indicator/internal-pitch-deg", 0);
            this.pathRead.Add("/instrumentation/attitude-indicator/internal-roll-deg", 0);
            this.pathRead.Add("/instrumentation/encoder/indicated-altitude-ft", 0);
            this.pathRead.Add("/instrumentation/encoder/pressure-alt-ft", 0);
            this.pathRead.Add("/instrumentation/gps/indicated-altitude-ft", 0);
            this.pathRead.Add("/instrumentation/gps/indicated-ground-speed-kt", 0);
            this.pathRead.Add("/instrumentation/gps/indicated-vertical-speed", 0);
            this.pathRead.Add("/instrumentation/heading-indicator/indicated-heading-deg", 0);
            this.pathRead.Add("/instrumentation/magnetic-compass/indicated-heading-deg", 0);
            this.pathRead.Add("/instrumentation/slip-skid-ball/indicated-slip-skid", 0);
            this.pathRead.Add("/instrumentation/turn-indicator/indicated-turn-rate", 0);
            this.pathRead.Add("/instrumentation/vertical-speed-indicator/indicated-speed-fpm", 0);
            this.pathRead.Add("/controls/flight/aileron", 0);
            this.pathRead.Add("/controls/flight/elevator", 0);
            this.pathRead.Add("/controls/flight/rudder", 0);
            this.pathRead.Add("/controls/flight/flaps", 0);
            this.pathRead.Add("/controls/engines/current-engine/throttle", 0);
            this.pathRead.Add("/engines/engine/rpm", 0);
        }

        public void setDict(List<double> vector1)
        {
            this.pathRead["/instrumentation/airspeed-indicator/indicated-speed-kt"] = vector1[0];
            this.pathRead["/instrumentation/altimeter/indicated-altitude-ft"] = vector1[1];
            this.pathRead["/instrumentation/altimeter/pressure-alt-ft"] = vector1[2];
            this.pathRead["/instrumentation/attitude-indicator/indicated-pitch-deg"] = vector1[3];
            this.pathRead["/instrumentation/attitude-indicator/indicated-roll-deg"] = vector1[4];
            this.pathRead["/instrumentation/attitude-indicator/internal-pitch-deg"] = vector1[5];
            this.pathRead["/instrumentation/attitude-indicator/internal-roll-deg"] = vector1[6];
            this.pathRead["/instrumentation/encoder/indicated-altitude-ft"] = vector1[7];
            this.pathRead["/instrumentation/encoder/pressure-alt-ft"] = vector1[8];
            this.pathRead["/instrumentation/gps/indicated-altitude-ft"] = vector1[9];
            this.pathRead["/instrumentation/gps/indicated-ground-speed-kt"] = vector1[10];
            this.pathRead["/instrumentation/gps/indicated-vertical-speed"] = vector1[11];
            this.pathRead["/instrumentation/heading-indicator/indicated-heading-deg"] = vector1[12];
            this.pathRead["/instrumentation/magnetic-compass/indicated-heading-deg"] = vector1[13];
            this.pathRead["/instrumentation/slip-skid-ball/indicated-slip-skid"] = vector1[14];
            this.pathRead["/instrumentation/turn-indicator/indicated-turn-rate"] = vector1[15];
            this.pathRead["/instrumentation/vertical-speed-indicator/indicated-speed-fpm"] = vector1[16];
            this.pathRead["/controls/flight/aileron"] = vector1[17];
            this.pathRead["/controls/flight/elevator"] = vector1[18];
            this.pathRead["/controls/flight/rudder"] = vector1[19];
            this.pathRead["/controls/flight/flaps"] = vector1[20];
            this.pathRead["/controls/engines/current-engine/throttle"] = vector1[21];
            this.pathRead["/engines/engine/rpm"] = vector1[22];
        }

    }
}**/
