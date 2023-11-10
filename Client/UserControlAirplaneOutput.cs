using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class UserControlAirplaneOutput : UserControl
    {
        public UserControlAirplaneOutput()
        {
            InitializeComponent();
        }
        public string Manufacter
        {
            set
            {
                textBoxManufacturer.Text = value;
            }
        }
        public string Model
        {
            set
            {
                textBoxModel.Text = value;
            }
        }
    }
}
