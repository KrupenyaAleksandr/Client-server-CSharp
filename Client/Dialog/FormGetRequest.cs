using ClassLibraryBackend;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        string notFound = "\"isSuccess\":false";
        (string, string) airplaneDetails;
        public FormGetRequest()
        {
            InitializeComponent();
        }

        public string Response
        {
            get
            {
                return jsonResponse;
            }
        }

        public (string, string) Details
        {
            get
            {
                return airplaneDetails;
            }
        }
        public void setSocket(ref Socket socket)
        {
            sSender = socket;
        }

        private void buttonRequestCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonRequestOK_Click(object sender, EventArgs e)
        {
            if (textBoxKey.Text == "")
            {
                MessageBox.Show("Некорректный запрос");
                DialogResult = DialogResult.None;
            }
            else
            {
                request.Key = textBoxKey.Text;
                request.Type = RequestType.Get;
                try
                {
                    jsonRequest = JsonConvert.SerializeObject(request);
                    msg = Encoding.UTF8.GetBytes(jsonRequest);
                    sSender.Send(msg);
                    int bytesRec = sSender.Receive(bytes);
                    jsonResponse = Encoding.UTF8.GetString(bytes, 0, bytesRec);
                    if (jsonResponse.Contains(notFound))
                    {
                        MessageBox.Show("Ключ не найден");
                        DialogResult = DialogResult.None;
                    }
                    else
                    {
                        JObject airplaneObject = JObject.Parse(jsonResponse);
                        airplaneDetails = (airplaneObject["Airplane"]["Manufacturer"].ToString(), airplaneObject["Airplane"]["Model"].ToString());
                        DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Непредвиденная ошибка: {0}", ex.Message));
                }
            }
        }
    }
}
