namespace NorSID
{
    partial class VoicePanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lTitle = new System.Windows.Forms.Label();
            this.btWfNoise = new System.Windows.Forms.Button();
            this.btWfTri = new System.Windows.Forms.Button();
            this.btWfSaw = new System.Windows.Forms.Button();
            this.btWfSquare = new System.Windows.Forms.Button();
            this.tbAttack = new System.Windows.Forms.TrackBar();
            this.tbDecay = new System.Windows.Forms.TrackBar();
            this.tbSustain = new System.Windows.Forms.TrackBar();
            this.tbRelease = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lD = new System.Windows.Forms.Label();
            this.lS = new System.Windows.Forms.Label();
            this.lR = new System.Windows.Forms.Label();
            this.btRingmod = new System.Windows.Forms.Button();
            this.btSync = new System.Windows.Forms.Button();
            this.btMute = new System.Windows.Forms.Button();
            this.btFilt = new System.Windows.Forms.Button();
            this.tbPulseWidth = new System.Windows.Forms.TrackBar();
            this.lPW = new System.Windows.Forms.Label();
            this.tbTune = new System.Windows.Forms.TrackBar();
            this.tbTranspose = new System.Windows.Forms.TrackBar();
            this.tbShift = new System.Windows.Forms.TrackBar();
            this.lTune = new System.Windows.Forms.Label();
            this.lTranspose = new System.Windows.Forms.Label();
            this.lShift = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDecay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSustain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRelease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPulseWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTune)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTranspose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbShift)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.BackColor = System.Drawing.Color.Black;
            this.lTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lTitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTitle.ForeColor = System.Drawing.Color.White;
            this.lTitle.Location = new System.Drawing.Point(0, 0);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(379, 26);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "Voice 1";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btWfNoise
            // 
            this.btWfNoise.BackgroundImage = global::NorSID.Properties.Resources.toggle_button_small_off;
            this.btWfNoise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btWfNoise.FlatAppearance.BorderSize = 0;
            this.btWfNoise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btWfNoise.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btWfNoise.ForeColor = System.Drawing.Color.White;
            this.btWfNoise.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btWfNoise.Location = new System.Drawing.Point(20, 43);
            this.btWfNoise.Name = "btWfNoise";
            this.btWfNoise.Size = new System.Drawing.Size(41, 28);
            this.btWfNoise.TabIndex = 1;
            this.btWfNoise.Text = "NOISE";
            this.btWfNoise.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btWfNoise.UseVisualStyleBackColor = true;
            this.btWfNoise.Click += new System.EventHandler(this.btWfNoise_Click);
            // 
            // btWfTri
            // 
            this.btWfTri.BackgroundImage = global::NorSID.Properties.Resources.toggle_button_small_off;
            this.btWfTri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btWfTri.FlatAppearance.BorderSize = 0;
            this.btWfTri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btWfTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btWfTri.ForeColor = System.Drawing.Color.White;
            this.btWfTri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btWfTri.Location = new System.Drawing.Point(67, 43);
            this.btWfTri.Name = "btWfTri";
            this.btWfTri.Size = new System.Drawing.Size(41, 28);
            this.btWfTri.TabIndex = 1;
            this.btWfTri.Text = "TRI";
            this.btWfTri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btWfTri.UseVisualStyleBackColor = true;
            this.btWfTri.Click += new System.EventHandler(this.btWfTri_Click);
            // 
            // btWfSaw
            // 
            this.btWfSaw.BackgroundImage = global::NorSID.Properties.Resources.toggle_button_small_off;
            this.btWfSaw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btWfSaw.FlatAppearance.BorderSize = 0;
            this.btWfSaw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btWfSaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btWfSaw.ForeColor = System.Drawing.Color.White;
            this.btWfSaw.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btWfSaw.Location = new System.Drawing.Point(114, 43);
            this.btWfSaw.Name = "btWfSaw";
            this.btWfSaw.Size = new System.Drawing.Size(41, 28);
            this.btWfSaw.TabIndex = 1;
            this.btWfSaw.Text = "SAW";
            this.btWfSaw.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btWfSaw.UseVisualStyleBackColor = true;
            this.btWfSaw.Click += new System.EventHandler(this.btWfSaw_Click);
            // 
            // btWfSquare
            // 
            this.btWfSquare.BackgroundImage = global::NorSID.Properties.Resources.toggle_button_small_off;
            this.btWfSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btWfSquare.FlatAppearance.BorderSize = 0;
            this.btWfSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btWfSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btWfSquare.ForeColor = System.Drawing.Color.White;
            this.btWfSquare.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btWfSquare.Location = new System.Drawing.Point(161, 43);
            this.btWfSquare.Name = "btWfSquare";
            this.btWfSquare.Size = new System.Drawing.Size(41, 28);
            this.btWfSquare.TabIndex = 1;
            this.btWfSquare.Text = "SQU.";
            this.btWfSquare.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btWfSquare.UseVisualStyleBackColor = true;
            this.btWfSquare.Click += new System.EventHandler(this.btWfSquare_Click);
            // 
            // tbAttack
            // 
            this.tbAttack.Location = new System.Drawing.Point(218, 35);
            this.tbAttack.Maximum = 15;
            this.tbAttack.Name = "tbAttack";
            this.tbAttack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbAttack.Size = new System.Drawing.Size(45, 62);
            this.tbAttack.TabIndex = 2;
            this.tbAttack.ValueChanged += new System.EventHandler(this.tbAttack_ValueChanged);
            // 
            // tbDecay
            // 
            this.tbDecay.Location = new System.Drawing.Point(257, 35);
            this.tbDecay.Maximum = 15;
            this.tbDecay.Name = "tbDecay";
            this.tbDecay.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbDecay.Size = new System.Drawing.Size(45, 62);
            this.tbDecay.TabIndex = 2;
            this.tbDecay.ValueChanged += new System.EventHandler(this.tbDecay_ValueChanged);
            // 
            // tbSustain
            // 
            this.tbSustain.Location = new System.Drawing.Point(298, 35);
            this.tbSustain.Maximum = 15;
            this.tbSustain.Name = "tbSustain";
            this.tbSustain.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbSustain.Size = new System.Drawing.Size(45, 62);
            this.tbSustain.TabIndex = 2;
            this.tbSustain.ValueChanged += new System.EventHandler(this.tbSustain_ValueChanged);
            // 
            // tbRelease
            // 
            this.tbRelease.Location = new System.Drawing.Point(340, 35);
            this.tbRelease.Maximum = 15;
            this.tbRelease.Name = "tbRelease";
            this.tbRelease.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbRelease.Size = new System.Drawing.Size(45, 62);
            this.tbRelease.TabIndex = 2;
            this.tbRelease.ValueChanged += new System.EventHandler(this.tbRelease_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(223, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 10);
            this.label1.TabIndex = 3;
            this.label1.Text = "A";
            // 
            // lD
            // 
            this.lD.AutoSize = true;
            this.lD.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lD.ForeColor = System.Drawing.Color.White;
            this.lD.Location = new System.Drawing.Point(261, 93);
            this.lD.Name = "lD";
            this.lD.Size = new System.Drawing.Size(11, 10);
            this.lD.TabIndex = 3;
            this.lD.Text = "D";
            // 
            // lS
            // 
            this.lS.AutoSize = true;
            this.lS.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lS.ForeColor = System.Drawing.Color.White;
            this.lS.Location = new System.Drawing.Point(303, 93);
            this.lS.Name = "lS";
            this.lS.Size = new System.Drawing.Size(10, 10);
            this.lS.TabIndex = 3;
            this.lS.Text = "S";
            // 
            // lR
            // 
            this.lR.AutoSize = true;
            this.lR.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lR.ForeColor = System.Drawing.Color.White;
            this.lR.Location = new System.Drawing.Point(345, 93);
            this.lR.Name = "lR";
            this.lR.Size = new System.Drawing.Size(11, 10);
            this.lR.TabIndex = 3;
            this.lR.Text = "R";
            // 
            // btRingmod
            // 
            this.btRingmod.BackgroundImage = global::NorSID.Properties.Resources.toggle_button_small_off;
            this.btRingmod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btRingmod.FlatAppearance.BorderSize = 0;
            this.btRingmod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRingmod.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btRingmod.ForeColor = System.Drawing.Color.White;
            this.btRingmod.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRingmod.Location = new System.Drawing.Point(20, 77);
            this.btRingmod.Name = "btRingmod";
            this.btRingmod.Size = new System.Drawing.Size(41, 28);
            this.btRingmod.TabIndex = 1;
            this.btRingmod.Text = "RING";
            this.btRingmod.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRingmod.UseVisualStyleBackColor = true;
            this.btRingmod.Click += new System.EventHandler(this.btRingmod_Click);
            // 
            // btSync
            // 
            this.btSync.BackgroundImage = global::NorSID.Properties.Resources.toggle_button_small_off;
            this.btSync.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSync.FlatAppearance.BorderSize = 0;
            this.btSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btSync.ForeColor = System.Drawing.Color.White;
            this.btSync.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSync.Location = new System.Drawing.Point(67, 77);
            this.btSync.Name = "btSync";
            this.btSync.Size = new System.Drawing.Size(41, 28);
            this.btSync.TabIndex = 1;
            this.btSync.Text = "SYNC";
            this.btSync.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSync.UseVisualStyleBackColor = true;
            this.btSync.Click += new System.EventHandler(this.btSync_Click);
            // 
            // btMute
            // 
            this.btMute.BackgroundImage = global::NorSID.Properties.Resources.toggle_button_small_off;
            this.btMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btMute.FlatAppearance.BorderSize = 0;
            this.btMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMute.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btMute.ForeColor = System.Drawing.Color.White;
            this.btMute.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMute.Location = new System.Drawing.Point(114, 77);
            this.btMute.Name = "btMute";
            this.btMute.Size = new System.Drawing.Size(41, 28);
            this.btMute.TabIndex = 1;
            this.btMute.Text = "MUTE";
            this.btMute.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMute.UseVisualStyleBackColor = true;
            this.btMute.Click += new System.EventHandler(this.btMute_Click);
            // 
            // btFilt
            // 
            this.btFilt.BackgroundImage = global::NorSID.Properties.Resources.toggle_button_small_off;
            this.btFilt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btFilt.FlatAppearance.BorderSize = 0;
            this.btFilt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btFilt.ForeColor = System.Drawing.Color.White;
            this.btFilt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btFilt.Location = new System.Drawing.Point(161, 77);
            this.btFilt.Name = "btFilt";
            this.btFilt.Size = new System.Drawing.Size(41, 28);
            this.btFilt.TabIndex = 1;
            this.btFilt.Text = "FILT";
            this.btFilt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btFilt.UseVisualStyleBackColor = true;
            this.btFilt.Click += new System.EventHandler(this.btFilt_Click);
            // 
            // tbPulseWidth
            // 
            this.tbPulseWidth.Location = new System.Drawing.Point(12, 111);
            this.tbPulseWidth.Maximum = 2047;
            this.tbPulseWidth.Name = "tbPulseWidth";
            this.tbPulseWidth.Size = new System.Drawing.Size(96, 45);
            this.tbPulseWidth.SmallChange = 64;
            this.tbPulseWidth.TabIndex = 2;
            this.tbPulseWidth.ValueChanged += new System.EventHandler(this.tbPulseWidth_ValueChanged);
            // 
            // lPW
            // 
            this.lPW.AutoSize = true;
            this.lPW.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lPW.ForeColor = System.Drawing.Color.White;
            this.lPW.Location = new System.Drawing.Point(51, 143);
            this.lPW.Name = "lPW";
            this.lPW.Size = new System.Drawing.Size(17, 10);
            this.lPW.TabIndex = 3;
            this.lPW.Text = "PW";
            // 
            // tbTune
            // 
            this.tbTune.Location = new System.Drawing.Point(114, 111);
            this.tbTune.Maximum = 257;
            this.tbTune.Name = "tbTune";
            this.tbTune.Size = new System.Drawing.Size(88, 45);
            this.tbTune.SmallChange = 10;
            this.tbTune.TabIndex = 2;
            this.tbTune.ValueChanged += new System.EventHandler(this.tbTune_ValueChanged);
            // 
            // tbTranspose
            // 
            this.tbTranspose.Location = new System.Drawing.Point(201, 111);
            this.tbTranspose.Maximum = 6;
            this.tbTranspose.Name = "tbTranspose";
            this.tbTranspose.Size = new System.Drawing.Size(89, 45);
            this.tbTranspose.TabIndex = 2;
            this.tbTranspose.ValueChanged += new System.EventHandler(this.tbTranspose_ValueChanged);
            // 
            // tbShift
            // 
            this.tbShift.Location = new System.Drawing.Point(287, 111);
            this.tbShift.Maximum = 15;
            this.tbShift.Name = "tbShift";
            this.tbShift.Size = new System.Drawing.Size(87, 45);
            this.tbShift.TabIndex = 2;
            this.tbShift.ValueChanged += new System.EventHandler(this.tbShift_ValueChanged);
            // 
            // lTune
            // 
            this.lTune.AutoSize = true;
            this.lTune.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTune.ForeColor = System.Drawing.Color.White;
            this.lTune.Location = new System.Drawing.Point(147, 143);
            this.lTune.Name = "lTune";
            this.lTune.Size = new System.Drawing.Size(27, 10);
            this.lTune.TabIndex = 3;
            this.lTune.Text = "TUNE";
            // 
            // lTranspose
            // 
            this.lTranspose.AutoSize = true;
            this.lTranspose.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTranspose.ForeColor = System.Drawing.Color.White;
            this.lTranspose.Location = new System.Drawing.Point(229, 143);
            this.lTranspose.Name = "lTranspose";
            this.lTranspose.Size = new System.Drawing.Size(37, 10);
            this.lTranspose.TabIndex = 3;
            this.lTranspose.Text = "TRANSP";
            // 
            // lShift
            // 
            this.lShift.AutoSize = true;
            this.lShift.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lShift.ForeColor = System.Drawing.Color.White;
            this.lShift.Location = new System.Drawing.Point(315, 143);
            this.lShift.Name = "lShift";
            this.lShift.Size = new System.Drawing.Size(28, 10);
            this.lShift.TabIndex = 3;
            this.lShift.Text = "SHIFT";
            // 
            // VoicePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lShift);
            this.Controls.Add(this.lTranspose);
            this.Controls.Add(this.lTune);
            this.Controls.Add(this.lPW);
            this.Controls.Add(this.lR);
            this.Controls.Add(this.lS);
            this.Controls.Add(this.lD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbShift);
            this.Controls.Add(this.tbTranspose);
            this.Controls.Add(this.tbTune);
            this.Controls.Add(this.tbPulseWidth);
            this.Controls.Add(this.tbRelease);
            this.Controls.Add(this.tbSustain);
            this.Controls.Add(this.tbDecay);
            this.Controls.Add(this.tbAttack);
            this.Controls.Add(this.btFilt);
            this.Controls.Add(this.btWfSquare);
            this.Controls.Add(this.btMute);
            this.Controls.Add(this.btSync);
            this.Controls.Add(this.btWfSaw);
            this.Controls.Add(this.btRingmod);
            this.Controls.Add(this.btWfTri);
            this.Controls.Add(this.btWfNoise);
            this.Controls.Add(this.lTitle);
            this.Name = "VoicePanel";
            this.Size = new System.Drawing.Size(379, 160);
            ((System.ComponentModel.ISupportInitialize)(this.tbAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDecay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSustain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRelease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPulseWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTune)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTranspose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Button btWfNoise;
        private System.Windows.Forms.Button btWfTri;
        private System.Windows.Forms.Button btWfSaw;
        private System.Windows.Forms.Button btWfSquare;
        private System.Windows.Forms.TrackBar tbAttack;
        private System.Windows.Forms.TrackBar tbDecay;
        private System.Windows.Forms.TrackBar tbSustain;
        private System.Windows.Forms.TrackBar tbRelease;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lD;
        private System.Windows.Forms.Label lS;
        private System.Windows.Forms.Label lR;
        private System.Windows.Forms.Button btRingmod;
        private System.Windows.Forms.Button btSync;
        private System.Windows.Forms.Button btMute;
        private System.Windows.Forms.Button btFilt;
        private System.Windows.Forms.TrackBar tbPulseWidth;
        private System.Windows.Forms.Label lPW;
        private System.Windows.Forms.TrackBar tbTune;
        private System.Windows.Forms.TrackBar tbTranspose;
        private System.Windows.Forms.TrackBar tbShift;
        private System.Windows.Forms.Label lTune;
        private System.Windows.Forms.Label lTranspose;
        private System.Windows.Forms.Label lShift;
    }
}
