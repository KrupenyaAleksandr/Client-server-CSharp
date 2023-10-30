using ClassLibraryBackend;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Dialog
{
    public partial class FormGetRequest : Form
    {
        Request request = new Request();
        string jsonRequest;
        byte[] msg;
        Socket sSender = null;
        byte[] bytes = new byte[10240];
        string jsonResponse;
        public FormGetRequest()
        {
            InitializeComponent();
        }

        public string getResponse
        {
            get
            {
                return jsonResponse;
            }
        }
        public void setSocket(ref Socket socket)
        {
            sSender = socket;
        }

        private void buttonOKRequest_Click(object sender, EventArgs e)
        {
            request.Key = textBoxKey.Text;
            request.Type = RequestType.Get;
            if (request.Key == string.Empty)
            {
                MessageBox.Show("Некорректный запрос.");
            }
            else
            {
                try
                {
                    jsonRequest = JsonConvert.SerializeObject(request);
                    msg = Encoding.UTF8.GetBytes(jsonRequest);
                    sSender.Send(msg);
                    int bytesRec = sSender.Receive(bytes);
                    jsonResponse = Encoding.UTF8.GetString(bytes, 0, bytesRec);
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonRequestCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
