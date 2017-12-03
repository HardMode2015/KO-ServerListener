using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using KO.ServerListener.Properties;


namespace KO.ServerListener
{
    public partial class MainForm : Form
    {
        public string TimeStamp => DateTime.Now.ToString("T");

        private string _hostIp;
        private int _frequencyMiliseconds;
        private bool _startListening;

        private readonly int LOGIN_SERVER = 15100;
        private readonly int GAME_SERVER  = 15001;

        Thread[] workers = new Thread[2];

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _hostIp = tbxHostIp.Text;
            int.TryParse(tbxFrequency.Text, out _frequencyMiliseconds);
            if (_frequencyMiliseconds < 500) _frequencyMiliseconds = 500;

            _startListening      = true;
            btnStart.Enabled     = false;
            btnStop.Enabled      = true;
            btnClear.Enabled     = false;
            tbxHostIp.Enabled    = false;
            tbxFrequency.Enabled = false;

            workers[0] = new Thread(StartListeningLoginServer);
            workers[1] = new Thread(StartListeningGameServer);
            foreach (Thread worker in workers)
                worker.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _startListening      = false;
            btnStart.Enabled     = true;
            btnStop.Enabled      = false;
            btnClear.Enabled     = true;
            tbxHostIp.Enabled    = true;
            tbxFrequency.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbxLogger.Items.Clear();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_startListening) return;

            _startListening = false;
            foreach (Thread worker in workers)
            {
                if (worker == null) continue;
                worker.Abort();
                lbxLogger.Items.Add($"[{TimeStamp}] - Closing worker thread {worker.ManagedThreadId} before application closes.");
                lbxLogger.SelectedIndex = lbxLogger.Items.Count - 1;
                Thread.Sleep(750);
            }

            // Free up the main thread so the foreach loop behind get the chance to update the ui.
            Thread tDelayed = new Thread(() => Thread.Sleep(3500));
            tDelayed.Start();
            tDelayed.Join();
        }

        private void StartListeningLoginServer()
        {
            bool isServerReachable = false;

            do
            {
                Thread.Sleep(_frequencyMiliseconds);

                using (TcpClient client = new TcpClient())
                {
                    try
                    {
                        isServerReachable = client.ConnectAsync(_hostIp, LOGIN_SERVER).Wait(2000);
                    }
                    catch { }

                    lock (lbxLogger)
                    {
                        if (!InvokeRequired) continue;
                        bool reachable = isServerReachable;
                        BeginInvoke(new MethodInvoker(() => UpdateLoginServer(reachable)));
                    }
                }
            } while (_startListening);
        }

        private void StartListeningGameServer()
        {
            bool isServerReachable = false;

            do
            {
                Thread.Sleep(_frequencyMiliseconds);

                using (TcpClient client = new TcpClient())
                {
                    try
                    {
                        isServerReachable = client.ConnectAsync(_hostIp, GAME_SERVER).Wait(2000);
                    }
                    catch { }

                    lock (lbxLogger)
                    {
                        if (!InvokeRequired) continue;
                        bool reachable = isServerReachable;
                        BeginInvoke(new MethodInvoker(() => UpdateGameServer(reachable)));
                    }
                }
            } while (_startListening);
        }

        private void UpdateLoginServer(bool isServerReachable)
        {
            if (isServerReachable)
            {
                if (cbxLoginServer.Checked)
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

        private void UpdateGameServer(bool isServerReachable)
        {
            if (isServerReachable)
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
    }
}
