using System;

namespace KO.ServerListener.Library
{
    public abstract class Server
    {
        /// <summary>
        /// Getter for the current date time.
        /// </summary>
        protected static string TimeStamp => DateTime.Now.ToString("T");

        /// <summary>
        /// Stores the running threads count.
        /// </summary>
        public static int ThreadsCount = 0;

        /// <summary>
        /// Stores the host ip address.
        /// </summary>
        protected readonly string hostIp;

        /// <summary>
        /// Stores the frequency the call will be made.
        /// minimum frequency is set to 500 miliseconds.
        /// </summary>
        protected readonly int frequencyMiliseconds;

        /// <summary>
        /// Declare the events.
        /// </summary>
        public event Action<ServerEventArgs> LoginServerState;
        public event Action<ServerEventArgs> GameServerState;

        /// <summary>
        /// Constructor Overloading.
        /// </summary>
        public Server()
        {

        }

        /// <summary>
        /// - Initalize the host ip address.
        /// - Initalize the frequency in miliseconds for each call.
        /// </summary>
        public Server(string hostIp, int frequencyMiliseconds)
        {
            this.hostIp = hostIp;
            this.frequencyMiliseconds = frequencyMiliseconds < 500 ? 500 : frequencyMiliseconds;
        }

        public abstract void StartListening();
        public abstract void StopListening();

        protected virtual void OnLoginServerState(bool isServerAvailable)
        {
            LoginServerState?.Invoke(new ServerEventArgs(isServerAvailable));
        }

        protected virtual void OnGameServerState(bool isServerAvailable)
        {
            GameServerState?.Invoke(new ServerEventArgs(isServerAvailable));
        }

    }
}
