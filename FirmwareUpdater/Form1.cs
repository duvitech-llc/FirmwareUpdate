using libusbK;
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

        private KHOT_PARAMS hotInitParams;
        private HUD_STATE _currentState = HUD_STATE.NotDetected;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        delegate void SetUiCallback(HUD_STATE state);

        private void setUI(HUD_STATE state)
        {
            if (this.btnReboot.InvokeRequired)
            {
                SetUiCallback d = new SetUiCallback(setUI);
                this.Invoke(d, new object[] { state });
            }
            else
            {

                _currentState = HUD_STATE.Application;

                switch (state)
                {
                    case HUD_STATE.NotDetected:
                        btnReboot.Enabled = false;
                        btnProgram.Enabled = false;
                        lblHudStatus.ForeColor = Color.Red;
                        lblHudStatus.Text = "HUD NOT CONNECTED";
                        break;
                    case HUD_STATE.Application:
                        btnReboot.Enabled = true;
                        btnProgram.Enabled = false;
                        lblHudStatus.ForeColor = Color.Green;
                        lblHudStatus.Text = "HUD CONNECTED";
                        break;
                    case HUD_STATE.Bootloader:
                        btnReboot.Enabled = false;
                        btnProgram.Enabled = true;
                        lblHudStatus.ForeColor = Color.Blue;
                        lblHudStatus.Text = "BOOT LOADER MODE";
                        break;
                    default:
                        break;
                }
            }
        }


        private void OnHotPlug(KHOT_HANDLE hotHandle,
                                      KLST_DEVINFO_HANDLE deviceInfo,
                                      KLST_SYNC_FLAG plugType)
        {
            string plugText;

            int totalPluggedDeviceCount = (int)hotHandle.GetContext().ToInt64();
            if (totalPluggedDeviceCount == int.MaxValue)
            {
                Console.WriteLine("OnHotPlug is being called for the first time on handle:{0}", hotHandle.Pointer);
                totalPluggedDeviceCount = 0;
            }

            switch (plugType)
            {
                case KLST_SYNC_FLAG.ADDED:
                    plugText = "Arrival";
                    totalPluggedDeviceCount++;
                    if (deviceInfo.DeviceID.Contains("VID_2DC4&PID_0200"))
                    {
                        setUI(HUD_STATE.Application);
                    }
                    else if (deviceInfo.DeviceID.Contains("VID_0483&PID_5740"))
                    {
                        setUI(HUD_STATE.Bootloader);
                    }
                    break;
                case KLST_SYNC_FLAG.REMOVED:
                    plugText = "Removal";
                    totalPluggedDeviceCount--;
                    if ((deviceInfo.DeviceID.Contains("VID_2DC4&PID_0200")) ||
                        (deviceInfo.DeviceID.Contains("VID_0483&PID_5740")))
                    {
                        setUI(HUD_STATE.NotDetected);
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException("plugType");
            }

            hotHandle.SetContext(new IntPtr(totalPluggedDeviceCount));

            Console.WriteLine("\n[OnHotPlug] Device {0}:{1} \n",
                              plugText,
                              deviceInfo);
            Console.WriteLine("Total Plugged Device Count: {0}",
                              totalPluggedDeviceCount);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _currentState = HUD_STATE.NotDetected;

            cbFirmwareSelector.Items.Add("Darwin Proto Firmware");
            cbFirmwareSelector.Items.Add("Darwin FW 4.20");
            cbFirmwareSelector.Items.Add("Darwin FW 4.21");
            cbFirmwareSelector.Items.Add("Select Custom File");

            setUI(_currentState);

            hotInitParams = new KHOT_PARAMS();

            // In the real world, you would want to filter for only *your* device(s).
            hotInitParams.PatternMatch.DeviceInterfaceGUID = "*";

            // The PLUG_ALL_ON_INIT flag will force plug events for matching devices that are already connected.
            hotInitParams.Flags = KHOT_FLAG.PLUG_ALL_ON_INIT;

            hotInitParams.OnHotPlug = OnHotPlug;

            // You may set your initial hot handle user context like this.
            // This example is using it to count connected devices and detect the first OnHotPlug event (Int32.MaxValue).
            AllKFunctions.LibK_SetDefaultContext(KLIB_HANDLE_TYPE.HOTK, new IntPtr(Int32.MaxValue));

            // Start hot-plug detection.
            HotK hot = new HotK(ref hotInitParams);

            tbStatus.Text = "Firmware Updater application started";

        }
    }
}
