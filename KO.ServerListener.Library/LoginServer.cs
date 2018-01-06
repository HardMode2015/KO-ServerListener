using System;
using System.Threading;
using System.Net.Sockets;


namespace KO.ServerListener.Library
{
    public sealed class LoginServer : Server
    {
        /// <summery>
        /// Stores the thread of the login server listener.
        /// </summery>
        public Thread thread { get; set; }

        /// <summery>
        /// Indication weather the server is being listen or not.
        /// </summery>
        private bool isServerListening;
        
        /// <summery>
        /// Getter for the listening status.
        /// </summery>
        public bool IsListening => isServerListening;

        /// <summery>
        /// Constructor
        /// </summery>
        public LoginServer(string hostIp, int frequencyMiliseconds = 500) : base(hostIp, frequencyMiliseconds)
        {
     
        }

        /// <summery>
        /// Starts to listen to the login server.
        /// </summery>
        public override void StartListening()
        {
            isServerListening = true;
            thread = new Thread(Listen);
            thread.Start();
            ThreadsCount++;
        }

        /// <summery>
        /// Stops to listen to the login server.
        /// </summery>
        public override void StopListening()
        {
            Console.WriteLine("Aborting thread {0}...", thread.ManagedThreadId);
            isServerListening = false;
        }

        /// <summery>
        /// Pings the LoginServer to check for availbility.
        /// </summery>
        private void Listen()
        {
            bool isServerAvailable = false;

            do
            {
                Thread.Sleep(this.frequencyMiliseconds);

                using (TcpClient client = new TcpClient())
                {
                    try
                    {
                        isServerAvailable = client.ConnectAsync(hostIp, Defines.LOGIN_SERVER).Wait(2000);
                    }
                    catch { }

                    OnLoginServerState(isServerAvailable);
                }

            } while (this.isServerListening);
        }
    }
}