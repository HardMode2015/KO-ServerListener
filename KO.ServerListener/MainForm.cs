using System;
using System.Drawing;
using System.Windows.Forms;
using KO.ServerListener.Library;

namespace KO.ServerListener
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Getter for the current date time.
        /// </summary>
        public string TimeStamp => DateTime.Now.ToString("T");

        /// <summary>
        /// Stores the loginServer object.
        /// </summary>
        private LoginServer loginServer;

        /// <summary>
        /// Stores the gameServer object.
        /// </summary>
        private GameServer gameServer;

        /// <summary>
        /// Intialize the form component.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the ping request has been sent,
        /// this method will be called with the status.
        /// so we can update the GUI accordantly.
        /// </summary>
        private void LoginServerState(ServerEventArgs e)
        {
            if (e.IsServerAvailable)
            {
                if (this.cbxLoginServer.Checked)
                {
                    Activate();
                    Console.Beep();
                }

                lbxLogger.Items.Add($"[{TimeStamp}] - Login server is reachable!");
                statusLoginServer.Text = "Online";
                statusLoginServer.BackColor = Color.Green;
            }
            else
            {
                lbxLogger.Items.Add($"[{TimeStamp}] - Login server is unreachable...");
                statusLoginServer.Text = "Offline";
                statusLoginServer.BackColor = Color.Red;
            }

            lbxLogger.SelectedIndex = lbxLogger.Items.Count - 1;

        }

        /// <summary>
        /// When the ping request has been sent,
        /// this method will be called with the status,
        /// so we can update the GUI accordantly.
        /// </summary>
        private void GameServerState(ServerEventArgs e)
        {
            if (e.IsServerAvailable)
            {
                if (cbxGameServer.Checked)
                {
                    Activate();
                    Console.Beep();
                }

                lbxLogger.Items.Add($"[{TimeStamp}] - Game server is reachable!");
                statusGameServer.Text = "Online";
                statusGameServer.BackColor = Color.Green;
            }
            else
            {
                lbxLogger.Items.Add($"[{TimeStamp}] - Game server is unreachable...");
                statusGameServer.Text = "Offline";
                statusGameServer.BackColor = Color.Red;
            }

            lbxLogger.SelectedIndex = lbxLogger.Items.Count - 1;
        }

        /// <summary>
        /// When clicking on the start button event listener.
        /// </summary>
        private void btnStart_Click(object sender, EventArgs e)
        {
            int frequencyMiliseconds;
            int.TryParse(tbxFrequency.Text, out frequencyMiliseconds);

            btnStart.Enabled     = false;
            btnStop.Enabled      = true;
            btnClear.Enabled     = false;
            tbxHostIp.Enabled    = false;
            tbxFrequency.Enabled = false;

            loginServer = new LoginServer(tbxHostIp.Text, frequencyMiliseconds);
            gameServer = new GameServer(tbxHostIp.Text, frequencyMiliseconds);

            loginServer.LoginServerState += (args) => InvokeMethod(args, () => LoginServerState(args));
            gameServer.GameServerState += (args) => InvokeMethod(args, () => GameServerState(args));

            loginServer.StartListening();
            gameServer.StartListening();
        }  

        /// <summary>
        /// Invoking method in a thread safe manner.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="args">Generic EventArgs that are passed to the event. </param>
        /// <param name="action">A callback method that will get executed by joining the thread pool on the form. </param>
        public void InvokeMethod<T>(T args, Action action) where T : EventArgs
        {
            if (InvokeRequired) BeginInvoke(action);
        }

        /// <summary>
        /// When clicking on the stop button event listener.
        /// </summary>
        private void btnStop_Click(object sender, EventArgs e)
        {
            loginServer.StopListening();
            gameServer.StopListening();

            btnStart.Enabled     = true;
            btnStop.Enabled      = false;
            btnClear.Enabled     = true;
            tbxHostIp.Enabled    = true;
            tbxFrequency.Enabled = true;
        }

        /// <summary>
        /// When clicking on the clear button event listener,
        /// To clean the console.
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            lbxLogger.Items.Clear();
        }

        /// <summary>
        /// When the window is being closed event listener.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            lbxLogger.Items.Add($"[{TimeStamp}] - Closing working threads before application closes.");

            if (loginServer != null)
            {
                loginServer.StopListening();
                loginServer.thread.Join();
            }

            if (gameServer != null)
            {
                gameServer.StopListening();
                gameServer.thread.Join();
            }
        }
    }
}
