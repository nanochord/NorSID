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
    public partial class SidForm : Form
    {
        public SidForm()
        {
            InitializeComponent();
        }

        SerialPort ComPort = new SerialPort();

        void WriteSID(string msg)
        {
            if (this.ComPort.IsOpen)
                this.ComPort.Write(msg);
        }

        void Reset()
        {
            WriteSID("r");
            tbVolume.Value = 0;
            tbCutoff.Value = 0;
            tbResonance.Value = 0;
            btLP.SetValue(false);
            btBP.SetValue(false);
            btHP.SetValue(false);

            voicePanel1.Reset();
            voicePanel2.Reset();
            voicePanel3.Reset();
        }

        #region Filter event handlers

        private void btLP_Click(object sender, EventArgs e)
        {
            ToggleButtonManager.ChangeToggleButtonState(sender as Button);
            WriteSID(string.Format("Ff{0}{1}{2}",
                btLP.GetValue() ? '1' : '0',
                btBP.GetValue() ? '1' : '0',
                btHP.GetValue() ? '1' : '0'
                )
            );
        }

        private void btBP_Click(object sender, EventArgs e)
        {
            ToggleButtonManager.ChangeToggleButtonState(sender as Button);
        }

        private void btHP_Click(object sender, EventArgs e)
        {
            ToggleButtonManager.ChangeToggleButtonState(sender as Button);
        }

        private void tbCutoff_ValueChanged(object sender, EventArgs e)
        {
            WriteSID(string.Format("Fc{0:x3}", tbCutoff.Value));
        }

        private void tbResonance_ValueChanged(object sender, EventArgs e)
        {
            WriteSID(string.Format("Fr{0:x1}", tbResonance.Value));
        }

        #endregion

        #region Master event handlers

        void SetMemButtonsState(Button btOn)
        {
            ToggleButtonManager.ChangeToggleButtonState(btOn);

            Button[] memButtons = new Button[]
            {
                btMem1, btMem2, btMem3, btMem4,
                btMem5, btMem6, btMem7, btMem8,
            };

            foreach (var bt in memButtons)
            {
                if (bt != btOn)
                {
                    bt.SetValue(false);
                    bt.SetToggleButtonBackground();
                }
            }
        }

        private void btMem1_Click(object sender, EventArgs e)
        {
            SetMemButtonsState(sender as Button);
        }

        private void btMem2_Click(object sender, EventArgs e)
        {
            SetMemButtonsState(sender as Button);
        }

        private void btMem3_Click(object sender, EventArgs e)
        {
            SetMemButtonsState(sender as Button);
        }

        private void btMem4_Click(object sender, EventArgs e)
        {
            SetMemButtonsState(sender as Button);
        }

        private void btMem5_Click(object sender, EventArgs e)
        {
            SetMemButtonsState(sender as Button);
        }

        private void btMem6_Click(object sender, EventArgs e)
        {
            SetMemButtonsState(sender as Button);
        }

        private void btMem7_Click(object sender, EventArgs e)
        {
            SetMemButtonsState(sender as Button);
        }

        private void btMem8_Click(object sender, EventArgs e)
        {
            SetMemButtonsState(sender as Button);
        }

        private void btSave_Click(object sender, EventArgs e)
        {

        }

        private void btSetup_Click(object sender, EventArgs e)
        {
            SetupDialog dialog = new SetupDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (dialog.ChangedOptions.HasFlag(SetupDialog.ChangeStatus.PortChanged))
                {
                    if (this.ComPort.IsOpen)
                        this.ComPort.Close();
                    this.ComPort.BaudRate = 38400;
                    this.ComPort.PortName = SetupDialog.ComPortName;
                    this.ComPort.Open();
                }
            }
        }

        #endregion

        private void picKeyboard_MouseDown(object sender, MouseEventArgs e)
        {
            // 52
            int a = 18 + (int)Math.Floor(3933.0 * (double)e.X / (double)picKeyboard.Width);

            var vp1d = voicePanel1.GetVoiceData();
            var vp2d = voicePanel2.GetVoiceData();
            var vp3d = voicePanel3.GetVoiceData();

            WriteSID(string.Format("v1f{0}.v2f{1}.v3f{2}.",
                a + vp1d.Tune,
                a + vp2d.Tune,
                a + vp3d.Tune
                )
            );
            WriteSID("v11v21v31");
        }

        private void picKeyboard_MouseUp(object sender, MouseEventArgs e)
        {
            WriteSID("*");
        }

        private void voicePanel1_VoiceChanged(object sender, VoiceEventArgs e)
        {
            VoicePanel vp = sender as VoicePanel;
            switch (e.Option)
            {
                case VoiceOption.Waveform:
                    WriteSID(string.Format("v{0}T{1}{2}{3}{4}",
                        vp.VoiceNumber,
                        e.ControlFlags.HasFlag(API.SidControlFlag.Noise) ? '1' : '0',
                        e.ControlFlags.HasFlag(API.SidControlFlag.Square) ? '1' : '0',
                        e.ControlFlags.HasFlag(API.SidControlFlag.Saw) ? '1' : '0',
                        e.ControlFlags.HasFlag(API.SidControlFlag.Triangle) ? '1' : '0'
                        )
                    );
                    break;
                case VoiceOption.Control:
                    WriteSID(string.Format("v{0}c{1:x1}",
                        vp.VoiceNumber,
                        (int)(e.ControlFlags & (API.SidControlFlag.Ringmod | API.SidControlFlag.Sync))
                        )
                    );
                    break;
                case VoiceOption.Mute:
                    break;
                case VoiceOption.Filter:
                    {
                        var vp1d = voicePanel1.GetVoiceData();
                        var vp2d = voicePanel2.GetVoiceData();
                        var vp3d = voicePanel3.GetVoiceData();

                        WriteSID(string.Format("Fe{0}{1}{2}",
                            vp1d.Filter ? '1' : '0',
                            vp2d.Filter ? '1' : '0',
                            vp3d.Filter ? '1' : '0'
                            )
                        );
                    
                    }
                    break;
                case VoiceOption.AttacDecay:
                case VoiceOption.SustainRelease:
                    WriteSID(string.Format("v{0}a{1:x1}{2:x1}{3:x1}{4:x1}",
                        vp.VoiceNumber,
                        e.Attack, e.Decay, e.Sustain, e.Release
                        )
                    );
                    break;
                case VoiceOption.PulseWidth:
                    WriteSID(string.Format("v{0}p{1:x3}", vp.VoiceNumber, e.PulseWidth));
                    break;
                case VoiceOption.TuneOrTranspose:
                    break;
                case VoiceOption.Shift:
                    break;
                default:
                    break;
            }

        }

        private void tbVolume_ValueChanged(object sender, EventArgs e)
        {
            WriteSID(string.Format("m{0:x1}", tbVolume.Value));
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            WriteSID(tbMsg.Text);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
