using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmwareUpdater
{
    public partial class Form1 : Form
    {
        enum HUD_STATE { NotDetected=0, Application, Bootloader };

        private HUD_STATE _currentState = HUD_STATE.NotDetected;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _currentState = HUD_STATE.NotDetected;



        }
    }
}
