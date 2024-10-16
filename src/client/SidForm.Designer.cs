namespace NorSID
{
    partial class SidForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lCutoff = new System.Windows.Forms.Label();
            this.tbResonance = new System.Windows.Forms.TrackBar();
            this.tbCutoff = new System.Windows.Forms.TrackBar();
            this.btHP = new System.Windows.Forms.Button();
            this.btBP = new System.Windows.Forms.Button();
            this.btLP = new System.Windows.Forms.Button();
            this.lFilterTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.btMem8 = new System.Windows.Forms.Button();
            this.btMem7 = new System.Windows.Forms.Button();
            this.btMem6 = new System.Windows.Forms.Button();
            this.btMem5 = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btMem4 = new System.Windows.Forms.Button();
            this.btMem3 = new System.Windows.Forms.Button();
            this.btMem2 = new System.Windows.Forms.Button();
            this.btMem1 = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.btSetup = new System.Windows.Forms.Button();
            this.picKeyboard = new System.Windows.Forms.PictureBox();
            this.voicePanel3 = new NorSID.VoicePanel();
            this.voicePanel2 = new NorSID.VoicePanel();
            this.voicePanel1 = new NorSID.VoicePanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbResonance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCutoff)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKeyboard)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lCutoff);
            this.panel1.Controls.Add(this.tbResonance);
            this.panel1.Controls.Add(this.tbCutoff);
            this.panel1.Controls.Add(this.btHP);
            this.panel1.Controls.Add(this.btBP);
            this.panel1.Controls.Add(this.btLP);
            this.panel1.Controls.Add(this.lFilterTitle);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 111);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(188, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 10);
            this.label1.TabIndex = 4;
            this.label1.Text = "RES";
            // 
            // lCutoff
            // 
            this.lCutoff.AutoSize = true;
            this.lCutoff.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lCutoff.ForeColor = System.Drawing.Color.White;
            this.lCutoff.Location = new System.Drawing.Point(187, 40);
            this.lCutoff.Name = "lCutoff";
            this.lCutoff.Size = new System.Drawing.Size(22, 10);
            this.lCutoff.TabIndex = 4;
            this.lCutoff.Text = "CUT";
            // 
            // tbResonance
            // 
            this.tbResonance.LargeChange = 1;
            this.tbResonance.Location = new System.Drawing.Point(215, 66);
            this.tbResonance.Maximum = 15;
            this.tbResonance.Name = "tbResonance";
            this.tbResonance.Size = new System.Drawing.Size(140, 45);
            this.tbResonance.TabIndex = 3;
            this.tbResonance.ValueChanged += new System.EventHandler(this.tbResonance_ValueChanged);
            // 
            // tbCutoff
            // 
            this.tbCutoff.LargeChange = 100;
            this.tbCutoff.Location = new System.Drawing.Point(215, 35);
            this.tbCutoff.Maximum = 2047;
            this.tbCutoff.Name = "tbCutoff";
            this.tbCutoff.Size = new System.Drawing.Size(140, 45);
            this.tbCutoff.SmallChange = 100;
            this.tbCutoff.TabIndex = 3;
            this.tbCutoff.ValueChanged += new System.EventHandler(this.tbCutoff_ValueChanged);
            // 
            // btHP
            // 
            this.btHP.BackgroundImage = global::NorSID.Properties.Resources.toggle_button_small_off;
            this.btHP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btHP.FlatAppearance.BorderSize = 0;
            this.btHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btHP.ForeColor = System.Drawing.Color.White;
            this.btHP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btHP.Location = new System.Drawing.Point(118, 57);
            this.btHP.Name = "btHP";
            this.btHP.Size = new System.Drawing.Size(41, 28);
            this.btHP.TabIndex = 2;
            this.btHP.Text = "HP";
            this.btHP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btHP.UseVisualStyleBackColor = true;
            this.btHP.Click += new System.EventHandler(this.btHP_Click);
            // 
            // btBP
            // 
            this.btBP.BackgroundImage = global::NorSID.Properties.Resources.toggle_button_small_off;
            this.btBP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btBP.FlatAppearance.BorderSize = 0;
            this.btBP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btBP.ForeColor = System.Drawing.Color.White;
            this.btBP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btBP.Location = new System.Drawing.Point(71, 57);
            this.btBP.Name = "btBP";
            this.btBP.Size = new System.Drawing.Size(41, 28);
            this.btBP.TabIndex = 2;
            this.btBP.Text = "BP";
            this.btBP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btBP.UseVisualStyleBackColor = true;
            this.btBP.Click += new System.EventHandler(this.btBP_Click);
            // 
            // btLP
            // 
            this.btLP.BackgroundImage = global::NorSID.Properties.Resources.toggle_button_small_off;
            this.btLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btLP.FlatAppearance.BorderSize = 0;
            this.btLP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btLP.ForeColor = System.Drawing.Color.White;
            this.btLP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btLP.Location = new System.Drawing.Point(24, 57);
            this.btLP.Name = "btLP";
            this.btLP.Size = new System.Drawing.Size(41, 28);
            this.btLP.TabIndex = 2;
            this.btLP.Text = "LP";
            this.btLP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLP.UseVisualStyleBackColor = true;
            this.btLP.Click += new System.EventHandler(this.btLP_Click);
            // 
            // lFilterTitle
            // 
            this.lFilterTitle.BackColor = System.Drawing.Color.Black;
            this.lFilterTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lFilterTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lFilterTitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lFilterTitle.ForeColor = System.Drawing.Color.White;
            this.lFilterTitle.Location = new System.Drawing.Point(0, 0);
            this.lFilterTitle.Name = "lFilterTitle";
            this.lFilterTitle.Size = new System.Drawing.Size(379, 26);
            this.lFilterTitle.TabIndex = 1;
            this.lFilterTitle.Text = "FILTER";
            this.lFilterTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.tbMsg);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbVolume);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btMem8);
            this.panel2.Controls.Add(this.btMem7);
            this.panel2.Controls.Add(this.btMem6);
            this.panel2.Controls.Add(this.btMem5);
            this.panel2.Controls.Add(this.btSave);
            this.panel2.Controls.Add(this.btMem4);
            this.panel2.Controls.Add(this.btMem3);
            this.panel2.Controls.Add(this.btMem2);
            this.panel2.Controls.Add(this.btMem1);
            this.panel2.Controls.Add(this.btReset);
            this.panel2.Controls.Add(this.btSend);
            this.panel2.Controls.Add(this.btSetup);
            this.panel2.Location = new System.Drawing.Point(390, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 111);
            this.panel2.TabIndex = 1;
            // 
            // tbMsg
            // 
            this.tbMsg.BackColor = System.Drawing.Color.Lime;
            this.tbMsg.Location = new System.Drawing.Point(561, 40);
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(100, 20);
            this.tbMsg.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(312, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 55);
            this.label3.TabIndex = 5;
            this.label3.Text = "NOR-SID\r\nStatus: Not connected...\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(713, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 10);
            this.label2.TabIndex = 4;
            this.label2.Text = "VOL";
            // 
            // tbVolume
            // 
            this.tbVolume.LargeChange = 1;
            this.tbVolume.Location = new System.Drawing.Point(712, 29);
            this.tbVolume.Maximum = 15;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbVolume.Size = new System.Drawing.Size(45, 66);
            this.tbVolume.TabIndex = 3;
            this.tbVolume.ValueChanged += new System.EventHandler(this.tbVolume_ValueChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(764, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "MASTER CONTROL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btMem8
            // 
            this.btMem8.BackgroundImage = global::NorSID.Properties.Resources.toggle_button_small_off;
            this.btMem8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btMem8.FlatAppearance.BorderSize = 0;
            this.btMem8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMem8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btMem8.ForeColor = System.Drawing.Color.White;
            this.btMem8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMem8.Location = new System.Drawing.Point(164, 74);
            this.btMem8.Name = "btMem8";
            this.btMem8.Size = new System.Drawing.Size(41, 28);
            this.btMem8.TabIndex = 2;
            this.btMem8.Text = "8";
            this.btMem8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMem8.UseVisualStyleBackColor = true;
            this.btMem8.Click += new System.EventHandler(this.btMem8_Click);
            // 
            // btMem7
            // 
            this.btMem7.BackgroundImage = global::NorSID.Properties.Resources.toggle_button_small_off;
            this.btMem7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btMem7.FlatAppearance.BorderSize = 0;
            this.btMem7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMem7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btMem7.ForeColor = System.Drawing.Color.White;
            this.btMem7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMem7.Location = new System.Drawing.Point(117, 74);
            this.btMem7.Name = "btMem7";
            this.btMem7.Size = new System.Drawing.Size(41, 28);
            this.btMem7.TabIndex = 2;
            this.btMem7.Text = "7";
            this.btMem7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMem7.UseVisualStyleBackColor = true;
            this.btMem7.Click += new System.EventHandler(this.btMem7_Click);
            // 
            // btMem6
            // 
            this.btMem6.BackgroundImage = global::NorSID.Properties.Resources.toggle_button_small_off;
            this.btMem6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btMem6.FlatAppearance.BorderSize = 0;
            this.btMem6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMem6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btMem6.ForeColor = System.Drawing.Color.White;
            this.btMem6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMem6.Location = new System.Drawing.Point(70, 74);
            this.btMem6.Name = "btMem6";
            this.btMem6.Size = new System.Drawing.Size(41, 28);
            this.btMem6.TabIndex = 2;
            this.btMem6.Text = "6";
            this.btMem6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMem6.UseVisualStyleBackColor = true;
            this.btMem6.Click += new System.EventHandler(this.btMem6_Click);
            // 
            // btMem5
            // 
            this.btMem5.BackgroundImage = global::NorSID.Properties.Resources.toggle_button_small_off;
            this.btMem5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btMem5.FlatAppearance.BorderSize = 0;
            this.btMem5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMem5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btMem5.ForeColor = System.Drawing.Color.White;
            this.btMem5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMem5.Location = new System.Drawing.Point(23, 74);
            this.btMem5.Name = "btMem5";
            this.btMem5.Size = new System.Drawing.Size(41, 28);
            this.btMem5.TabIndex = 2;
            this.btMem5.Text = "5";
            this.btMem5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMem5.UseVisualStyleBackColor = true;
            this.btMem5.Click += new System.EventHandler(this.btMem5_Click);
            // 
            // btSave
            // 
            this.btSave.BackgroundImage = global::NorSID.Properties.Resources.toggle_button_small_off;
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btSave.ForeColor = System.Drawing.Color.White;
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSave.Location = new System.Drawing.Point(241, 46);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(41, 28);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "SAVE";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btMem4
            // 
            this.btMem4.BackgroundImage = global::NorSID.Properties.Resources.toggle_button_small_off;
            this.btMem4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btMem4.FlatAppearance.BorderSize = 0;
            this.btMem4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMem4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btMem4.ForeColor = System.Drawing.Color.White;
            this.btMem4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMem4.Location = new System.Drawing.Point(164, 46);
            this.btMem4.Name = "btMem4";
            this.btMem4.Size = new System.Drawing.Size(41, 28);
            this.btMem4.TabIndex = 2;
            this.btMem4.Text = "4";
            this.btMem4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMem4.UseVisualStyleBackColor = true;
            this.btMem4.Click += new System.EventHandler(this.btMem4_Click);
            // 
            // btMem3
            // 
            this.btMem3.BackgroundImage = global::NorSID.Properties.Resources.toggle_button_small_off;
            this.btMem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btMem3.FlatAppearance.BorderSize = 0;
            this.btMem3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btMem3.ForeColor = System.Drawing.Color.White;
            this.btMem3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMem3.Location = new System.Drawing.Point(117, 46);
            this.btMem3.Name = "btMem3";
            this.btMem3.Size = new System.Drawing.Size(41, 28);
            this.btMem3.TabIndex = 2;
            this.btMem3.Text = "3";
            this.btMem3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMem3.UseVisualStyleBackColor = true;
            this.btMem3.Click += new System.EventHandler(this.btMem3_Click);
            // 
            // btMem2
            // 
            this.btMem2.BackgroundImage = global::NorSID.Properties.Resources.toggle_button_small_off;
            this.btMem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btMem2.FlatAppearance.BorderSize = 0;
            this.btMem2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btMem2.ForeColor = System.Drawing.Color.White;
            this.btMem2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMem2.Location = new System.Drawing.Point(70, 46);
            this.btMem2.Name = "btMem2";
            this.btMem2.Size = new System.Drawing.Size(41, 28);
            this.btMem2.TabIndex = 2;
            this.btMem2.Text = "2";
            this.btMem2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMem2.UseVisualStyleBackColor = true;
            this.btMem2.Click += new System.EventHandler(this.btMem2_Click);
            // 
            // btMem1
            // 
            this.btMem1.BackgroundImage = global::NorSID.Properties.Resources.toggle_button_small_off;
            this.btMem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btMem1.FlatAppearance.BorderSize = 0;
            this.btMem1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btMem1.ForeColor = System.Drawing.Color.White;
            this.btMem1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMem1.Location = new System.Drawing.Point(23, 46);
            this.btMem1.Name = "btMem1";
            this.btMem1.Size = new System.Drawing.Size(41, 28);
            this.btMem1.TabIndex = 2;
            this.btMem1.Text = "1";
            this.btMem1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMem1.UseVisualStyleBackColor = true;
            this.btMem1.Click += new System.EventHandler(this.btMem1_Click);
            // 
            // btReset
            // 
            this.btReset.BackgroundImage = global::NorSID.Properties.Resources.toggle_button_small_off;
            this.btReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btReset.FlatAppearance.BorderSize = 0;
            this.btReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btReset.ForeColor = System.Drawing.Color.White;
            this.btReset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btReset.Location = new System.Drawing.Point(241, 74);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(41, 28);
            this.btReset.TabIndex = 2;
            this.btReset.Text = "RESET";
            this.btReset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btSend
            // 
            this.btSend.BackgroundImage = global::NorSID.Properties.Resources.toggle_button_small_off;
            this.btSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSend.FlatAppearance.BorderSize = 0;
            this.btSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btSend.ForeColor = System.Drawing.Color.White;
            this.btSend.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSend.Location = new System.Drawing.Point(561, 67);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(41, 28);
            this.btSend.TabIndex = 2;
            this.btSend.Text = "SEND";
            this.btSend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btSetup
            // 
            this.btSetup.BackgroundImage = global::NorSID.Properties.Resources.toggle_button_small_off;
            this.btSetup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSetup.FlatAppearance.BorderSize = 0;
            this.btSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btSetup.ForeColor = System.Drawing.Color.White;
            this.btSetup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSetup.Location = new System.Drawing.Point(620, 67);
            this.btSetup.Name = "btSetup";
            this.btSetup.Size = new System.Drawing.Size(41, 28);
            this.btSetup.TabIndex = 2;
            this.btSetup.Text = "SETUP";
            this.btSetup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSetup.UseVisualStyleBackColor = true;
            this.btSetup.Click += new System.EventHandler(this.btSetup_Click);
            // 
            // picKeyboard
            // 
            this.picKeyboard.Image = global::NorSID.Properties.Resources.Keyboard;
            this.picKeyboard.Location = new System.Drawing.Point(5, 286);
            this.picKeyboard.Name = "picKeyboard";
            this.picKeyboard.Size = new System.Drawing.Size(1149, 146);
            this.picKeyboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKeyboard.TabIndex = 2;
            this.picKeyboard.TabStop = false;
            this.picKeyboard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picKeyboard_MouseDown);
            this.picKeyboard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picKeyboard_MouseUp);
            // 
            // voicePanel3
            // 
            this.voicePanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.voicePanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.voicePanel3.Location = new System.Drawing.Point(775, 120);
            this.voicePanel3.Name = "voicePanel3";
            this.voicePanel3.Size = new System.Drawing.Size(379, 160);
            this.voicePanel3.TabIndex = 0;
            this.voicePanel3.VoiceNumber = 3;
            this.voicePanel3.VoiceChanged += new NorSID.VoiceEventHandler(this.voicePanel1_VoiceChanged);
            // 
            // voicePanel2
            // 
            this.voicePanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.voicePanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.voicePanel2.Location = new System.Drawing.Point(390, 120);
            this.voicePanel2.Name = "voicePanel2";
            this.voicePanel2.Size = new System.Drawing.Size(379, 160);
            this.voicePanel2.TabIndex = 0;
            this.voicePanel2.VoiceNumber = 2;
            this.voicePanel2.VoiceChanged += new NorSID.VoiceEventHandler(this.voicePanel1_VoiceChanged);
            // 
            // voicePanel1
            // 
            this.voicePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.voicePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.voicePanel1.Location = new System.Drawing.Point(5, 120);
            this.voicePanel1.Name = "voicePanel1";
            this.voicePanel1.Size = new System.Drawing.Size(379, 160);
            this.voicePanel1.TabIndex = 0;
            this.voicePanel1.VoiceNumber = 1;
            this.voicePanel1.VoiceChanged += new NorSID.VoiceEventHandler(this.voicePanel1_VoiceChanged);
            // 
            // SidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1159, 433);
            this.Controls.Add(this.picKeyboard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.voicePanel3);
            this.Controls.Add(this.voicePanel2);
            this.Controls.Add(this.voicePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SidForm";
            this.Text = "NOR SID";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbResonance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCutoff)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKeyboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VoicePanel voicePanel1;
        private VoicePanel voicePanel2;
        private VoicePanel voicePanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lFilterTitle;
        private System.Windows.Forms.Button btHP;
        private System.Windows.Forms.Button btBP;
        private System.Windows.Forms.Button btLP;
        private System.Windows.Forms.TrackBar tbResonance;
        private System.Windows.Forms.TrackBar tbCutoff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lCutoff;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSetup;
        private System.Windows.Forms.Button btMem8;
        private System.Windows.Forms.Button btMem7;
        private System.Windows.Forms.Button btMem6;
        private System.Windows.Forms.Button btMem5;
        private System.Windows.Forms.Button btMem4;
        private System.Windows.Forms.Button btMem3;
        private System.Windows.Forms.Button btMem2;
        private System.Windows.Forms.Button btMem1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picKeyboard;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btReset;

    }
}

