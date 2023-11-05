using ClassLibraryBackend;
using ClassLibraryBackend.Exception;
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
    public partial class FormAddRequest : Form
    {
        Request request = new Request();
        string jsonRequest;
        byte[] msg;
        Socket sSender = null;
        byte[] bytes = new byte[10240];
        string jsonResponse;
        public FormAddRequest()
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
        private void buttonRequestOK_Click(object sender, EventArgs e)
        {
            request.Airplane = new Airplane();
            request.Key = textBoxKey.Text;
            request.Airplane.Manufacturer = textBoxManufacturer.Text;
            request.Airplane.Model = textBoxModel.Text;
            request.Type = RequestType.Add;
            if (!request.isValid)
            {
                MessageBox.Show("Неккоректный запрос.");
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
                    MessageBox.Show(string.Format("Непредвиденная ошибка: {0}", ex.Message));
                }
            }
        }

        private void buttonRequestCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
