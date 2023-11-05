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
    public partial class FormDeleteRequest : Form
    {
        Request request = new Request();
        string jsonRequest;
        byte[] msg;
        Socket sSender = null;
        byte[] bytes = new byte[10240];
        string jsonResponse;
        public FormDeleteRequest()
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
            request.Type = RequestType.Delete;
            request.Key = textBoxKey.Text;
            if (request.Key == string.Empty)
            {
                MessageBox.Show("Некорректный запрос");
            }
            else
            {
                try
                {
                    
                    jsonRequest = JsonConvert.SerializeObject(request);
                    msg = Encoding.UTF8.GetBytes(jsonRequest);
                    sSender.Send(msg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Непредвиденная ошибка: {0}", ex.Message));
                }
            }
        }
    }
}
