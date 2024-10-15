using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorSID
{
    public partial class SetupDialog : Form
    {
        /// <summary>
        /// Name of the  currently selected COM port
        /// </summary>
        public static string ComPortName = null;

        [Flags]
        public enum ChangeStatus
        {
            None = 0,
            PortChanged = 1,
        }

        public ChangeStatus ChangedOptions { get; set; }

        public SetupDialog()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            skipEventHandler = true;
            cbComPort.Items.AddRange(SerialPort.GetPortNames());
            cbComPort.SelectedItem = SetupDialog.ComPortName;
            skipEventHandler = false;

            this.ChangedOptions = ChangeStatus.None;
        }

        bool skipEventHandler = false;

        private void cbComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skipEventHandler)
                return;

            SerialPort port = null;
            try
            {
                port = new SerialPort(cbComPort.SelectedItem.ToString(), 38400);
                port.Encoding = Encoding.ASCII;
                port.Open();
                port.ReadTimeout = 2000;
                port.Write("i");
                var msg = port.ReadLine();

                if (msg.StartsWith("NorSID."))
                {
                    lNorSID.Text = msg;
                    SetupDialog.ComPortName = cbComPort.SelectedItem.ToString();
                    this.ChangedOptions |= ChangeStatus.PortChanged;
                }
                else
                {
                    SetupDialog.ComPortName = null;
                    MessageBox.Show(msg);
                }
            }
            catch
            {
                SetupDialog.ComPortName = null;
                MessageBox.Show("Invalid port. The port may be used by another application or no device is connected.");
            }
            finally
            {
                if (port != null && port.IsOpen)
                    port.Close();
            }
        }
    }
}
