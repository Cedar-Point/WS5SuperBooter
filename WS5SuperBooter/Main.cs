using System;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace WS5SuperBooter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.shut_down_cool_5;
        }
        private async void BtnReboot_Click(object sender, EventArgs e)
        {
            TcpClient connection = new TcpClient();
            BackColor = Color.Yellow;
            try
            {
                Ping ping = new Ping();
                PingReply reply = await ping.SendPingAsync(tbReboot.Text, 1);
                if (reply.Status == IPStatus.Success)
                {
                    await connection.ConnectAsync(tbReboot.Text, 50123);
                    NetworkStream stream = connection.GetStream();
                    byte[] buffer = Encoding.ASCII.GetBytes(Properties.Resources.RebootMessage);
                    await stream.WriteAsync(buffer, 0, buffer.Length);
                    await stream.FlushAsync();
                    stream.Close();
                    connection.Close();
                    bool rebooted = false;
                    for (int count = 100; count > 0; count--)
                    {
                        if (count % 2 == 0)
                        {
                            BackColor = Color.Blue;
                        }
                        else
                        {
                            BackColor = Color.DarkBlue;
                        }
                        reply = await ping.SendPingAsync(tbReboot.Text, 1);
                        if (reply.Status != IPStatus.Success)
                        {
                            rebooted = true;
                            break;
                        }
                        await Task.Delay(100);
                    }
                    if (rebooted)
                    {
                        BackColor = Color.Green;
                    }
                    else
                    {
                        BackColor = Color.Red;
                    }
                }
                else
                {
                    BackColor = Color.Red;
                }
            }
            catch(Exception)
            {
                BackColor = Color.Red;
            }
        }
    }
}
