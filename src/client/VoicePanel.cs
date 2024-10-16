using System.Runtime.Versioning;

namespace NorSID;

[SupportedOSPlatform("windows")]
public partial class VoicePanel : UserControl
{
    public VoicePanel()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Reads the current voice settings.
    /// </summary>
    /// <returns></returns>
    public VoiceEventArgs GetVoiceData()
    {
        return new VoiceEventArgs()
        {
            ControlFlags =
                (btWfNoise.GetValue() ? API.SidControlFlag.Noise : 0) |
                (btWfSaw.GetValue() ? API.SidControlFlag.Saw : 0) |
                (btWfTri.GetValue() ? API.SidControlFlag.Triangle : 0) |
                (btWfSquare.GetValue() ? API.SidControlFlag.Square : 0) |
                (btSync.GetValue() ? API.SidControlFlag.Sync : 0) |
                (btRingmod.GetValue() ? API.SidControlFlag.Ringmod : 0),
            Mute = btMute.GetValue(),
            Filter = btFilt.GetValue(),
            Attack = tbAttack.Value,
            Decay = tbDecay.Value,
            Sustain = tbSustain.Value,
            Release = tbRelease.Value,
            PulseWidth = tbPulseWidth.Value,
            Tune = tbTune.Value,
            Transpose = tbTranspose.Value,
            Shift = tbShift.Value,
        };
    }

    /// <summary>
    /// Sets voice settings.
    /// </summary>
    /// <param name="data"></param>
    public void SetVoiceData(VoiceEventArgs data)
    {
        btWfNoise.SetValue(data.ControlFlags.HasFlag(API.SidControlFlag.Noise));
        btWfSaw.SetValue(data.ControlFlags.HasFlag(API.SidControlFlag.Saw));
        btWfTri.SetValue(data.ControlFlags.HasFlag(API.SidControlFlag.Triangle));
        btWfSquare.SetValue(data.ControlFlags.HasFlag(API.SidControlFlag.Square));
        btSync.SetValue(data.ControlFlags.HasFlag(API.SidControlFlag.Sync));
        btRingmod.SetValue(data.ControlFlags.HasFlag(API.SidControlFlag.Ringmod));
        btMute.SetValue(data.Mute);
        btFilt.SetValue(data.Filter);
        tbAttack.Value = data.Attack;
        tbDecay.Value = data.Decay;
        tbSustain.Value = data.Sustain;
        tbRelease.Value = data.Release;
        tbPulseWidth.Value = data.PulseWidth;
        tbTune.Value = data.Tune;
        tbTranspose.Value = data.Transpose;
        tbShift.Value = data.Shift;

        btWfNoise.SetToggleButtonBackground();
        btWfSaw.SetToggleButtonBackground();
        btWfTri.SetToggleButtonBackground();
        btWfSquare.SetToggleButtonBackground();
        btSync.SetToggleButtonBackground();
        btRingmod.SetToggleButtonBackground();
        btMute.SetToggleButtonBackground();
        btFilt.SetToggleButtonBackground();
    }

    void OnVoiceChanged(VoiceOption option)
    {
        if (VoiceChanged != null && !disableCtrlEvents)
        {
            var vd = GetVoiceData();
            vd.Option = option;
            VoiceChanged(this, vd);
        }
    }

    bool disableCtrlEvents = false;

    int _VoiceNumber;

    public int VoiceNumber
    {
        get { return _VoiceNumber; }
        set
        { 
        if (value < 1 || value > 3)
                value = 1;
            _VoiceNumber = value;
            lTitle.Text = string.Format("VOICE {0}", value);
        }
    }

    /// <summary>
    /// Voice changed event.
    /// </summary>
    public event VoiceEventHandler VoiceChanged = null;

    #region Event handlers

    private void btWfNoise_Click(object sender, EventArgs e)
    {
        ToggleButtonManager.ChangeToggleButtonState(sender as Button);
        OnVoiceChanged(VoiceOption.Waveform);
    }

    private void btWfTri_Click(object sender, EventArgs e)
    {
        ToggleButtonManager.ChangeToggleButtonState(sender as Button);
        OnVoiceChanged(VoiceOption.Waveform);
    }

    private void btWfSaw_Click(object sender, EventArgs e)
    {
        ToggleButtonManager.ChangeToggleButtonState(sender as Button);
        OnVoiceChanged(VoiceOption.Waveform);
    }

    private void btWfSquare_Click(object sender, EventArgs e)
    {
        ToggleButtonManager.ChangeToggleButtonState(sender as Button);
        OnVoiceChanged(VoiceOption.Waveform);
    }

    private void btRingmod_Click(object sender, EventArgs e)
    {
        ToggleButtonManager.ChangeToggleButtonState(sender as Button);
        OnVoiceChanged(VoiceOption.Waveform);
    }

    private void btSync_Click(object sender, EventArgs e)
    {
        ToggleButtonManager.ChangeToggleButtonState(sender as Button);
        OnVoiceChanged(VoiceOption.Control);
    }

    private void btMute_Click(object sender, EventArgs e)
    {
        ToggleButtonManager.ChangeToggleButtonState(sender as Button);
        OnVoiceChanged(VoiceOption.Mute);
    }

    private void btFilt_Click(object sender, EventArgs e)
    {
        ToggleButtonManager.ChangeToggleButtonState(sender as Button);
        OnVoiceChanged(VoiceOption.Filter);
    }

    private void tbAttack_ValueChanged(object sender, EventArgs e)
    {
        OnVoiceChanged(VoiceOption.AttacDecay);
    }

    private void tbDecay_ValueChanged(object sender, EventArgs e)
    {
        OnVoiceChanged(VoiceOption.AttacDecay);
    }

    private void tbSustain_ValueChanged(object sender, EventArgs e)
    {
        OnVoiceChanged(VoiceOption.SustainRelease);
    }

    private void tbRelease_ValueChanged(object sender, EventArgs e)
    {
        OnVoiceChanged(VoiceOption.SustainRelease);
    }

    private void tbPulseWidth_ValueChanged(object sender, EventArgs e)
    {
        OnVoiceChanged(VoiceOption.PulseWidth);
    }

    private void tbTune_ValueChanged(object sender, EventArgs e)
    {
        OnVoiceChanged(VoiceOption.TuneOrTranspose);
    }

    private void tbTranspose_ValueChanged(object sender, EventArgs e)
    {
        OnVoiceChanged(VoiceOption.TuneOrTranspose);
    }

    private void tbShift_ValueChanged(object sender, EventArgs e)
    {
        OnVoiceChanged(VoiceOption.Shift);
    }

    #endregion

    public void Reset()
    {
        disableCtrlEvents = true;

        btWfNoise.SetValue(false);
        btWfSquare.SetValue(false);
        btWfSaw.SetValue(false);
        btWfTri.SetValue(false);
        btRingmod.SetValue(false);
        btSync.SetValue(false);
        btMute.SetValue(false);
        btFilt.SetValue(false);
        tbAttack.Value = 0;
        tbDecay.Value = 0;
        tbSustain.Value = 0;
        tbRelease.Value = 0;
        tbPulseWidth.Value = 0;
        tbTune.Value = 0;
        tbTranspose.Value = 0;
        tbShift.Value = 0;

        disableCtrlEvents = false;
    }
}

/// <summary>
/// Voice data part identifiers.
/// </summary>
public enum VoiceOption
{
    Waveform,
    Control,
    Mute,
    Filter,
    AttacDecay,
    SustainRelease,
    PulseWidth,
    TuneOrTranspose,
    Shift,
}

/// <summary>
/// Voice event args.
/// Collects voice data currently mixed on the UI.
/// </summary>
public class VoiceEventArgs
{
    public VoiceOption Option { get; set; }
    public API.SidControlFlag ControlFlags { get; set; }
    public int Attack { get; set; }
    public int Decay { get; set; }
    public int Sustain { get; set; }
    public int Release { get; set; }
    public int PulseWidth { get; set; }
    public int Tune { get; set; }
    public int Transpose { get; set; }
    public int Shift { get; set; }
    public bool Filter { get; set; }
    public bool Mute { get; set; }
}

/// <summary>
/// Voice event handler delegate
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
public delegate void VoiceEventHandler(object sender, VoiceEventArgs e);
