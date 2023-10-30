using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryBackend;
using Newtonsoft.Json;
using Client.Dialog;

namespace Client
{
    public partial class FormMain : Form
    {
        private Socket senderSocket = null;
        byte[] bytes = new byte[10240];
        string jsonRequest;
        byte[] msg;
        int bytesRec;

        readonly FormAddRequest formAddRequest = new FormAddRequest();
        readonly FormGetRequest formGetRequest = new FormGetRequest();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            // Соединяемся с удаленным устройством
            // Устанавливаем удаленную точку для сокета
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);
            senderSocket = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                senderSocket.Connect(ipEndPoint);
                buttonDisconnect.Enabled = true;
                buttonRequestAdd.Enabled = true;
                buttonRequestGet.Enabled = true;
                buttonRequestDelete.Enabled = true;
                buttonRequestUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Произошла ошибка при подключении: {0}", ex.Message));
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            Request request = new Request
            {
                Type = RequestType.Disconnect,
            };
            jsonRequest = JsonConvert.SerializeObject(request);
            msg = Encoding.UTF8.GetBytes(jsonRequest);
            senderSocket.Send(msg);
            senderSocket.Shutdown(SocketShutdown.Both);
            senderSocket.Close();
        }

        private void buttonRequestAdd_Click(object sender, EventArgs e)
        {
            formAddRequest.setSocket(ref senderSocket);
            if (formAddRequest.ShowDialog() == DialogResult.OK)
            {
                textBoxResponse.Text = formAddRequest.getResponse;
            }
        }

        private void buttonRequestGet_Click(object sender, EventArgs e)
        {
            formGetRequest.setSocket(ref senderSocket);
            if (formGetRequest.ShowDialog() == DialogResult.OK)
            {
                textBoxResponse.Text = formGetRequest.getResponse;
            }
        }
    }
}
