using System;

namespace KO.ServerListener.Library
{
    public class ServerEventArgs : EventArgs
    {
        /// <summary>
        /// Indication to know if server is available.
        /// </summary>
        public bool IsServerAvailable { get; }

        public ServerEventArgs(bool isServerAvailable)
        {
            IsServerAvailable = isServerAvailable;
        }
    }
}
