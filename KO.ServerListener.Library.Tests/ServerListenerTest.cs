using System;
using System.Threading;
using System.Diagnostics;
using NUnit.Framework;
using KO.ServerListener.Library;

namespace KO.ServerListener.Library.Tests
{
    [TestFixture]
    public class ServerListenerTest
    {
        [Test]
        public void WhenCallingStartANewThreadIsStarting()
        {
            GameServer gameServer = new GameServer("147.135.254.165", 500);
            LoginServer loginServer = new LoginServer("147.135.254.165", 500);

            gameServer.StartListening();
            loginServer.StartListening();

            Assert.AreEqual(2, Server.ThreadsCount);

            gameServer.StopListening();
            loginServer.StopListening();
            gameServer.thread.Join();
            loginServer.thread.Join();
        }
    }
}
