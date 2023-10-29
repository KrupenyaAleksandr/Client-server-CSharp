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
        public FormAddRequest()
        {
            InitializeComponent();
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
                    DialogResult = DialogResult.OK;
                }
                catch (System.Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void buttonRequestCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
