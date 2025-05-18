namespace LiteCap.UI
{
    partial class LiteCapture
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
            this.components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Guna2BorderlessForm border;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LiteCapture));
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.fullscreen = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label3 = new System.Windows.Forms.Label();
            this.specificwindow = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.window = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.outputformat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.recquality = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtOutputPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkAudio = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkHighQuality = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkHideWhileRecording = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCpu = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.startrec = new Guna.UI2.WinForms.Guna2Button();
            this.stoprec = new Guna.UI2.WinForms.Guna2Button();
            this.systemStatsTimer = new System.Windows.Forms.Timer(this.components);
            this.cmbResolution = new Guna.UI2.WinForms.Guna2ComboBox();
            this.toastDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.nmrFps = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            border = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmrFps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // border
            // 
            border.ContainerControl = this;
            border.DockForm = false;
            border.DockIndicatorTransparencyValue = 0.6D;
            border.HasFormShadow = false;
            border.TransparentWhileDrag = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "LiteCapture";
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.Animated = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BorderColor = System.Drawing.Color.Transparent;
            this.exit.FillColor = System.Drawing.Color.Transparent;
            this.exit.ForeColor = System.Drawing.Color.Transparent;
            this.exit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exit.IconColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(418, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(36, 24);
            this.exit.TabIndex = 1;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.Animated = true;
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BorderColor = System.Drawing.Color.Transparent;
            this.minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimize.FillColor = System.Drawing.Color.Transparent;
            this.minimize.ForeColor = System.Drawing.Color.Transparent;
            this.minimize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimize.IconColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(376, 4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(36, 24);
            this.minimize.TabIndex = 2;
            // 
            // fullscreen
            // 
            this.fullscreen.Animated = true;
            this.fullscreen.Checked = true;
            this.fullscreen.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.fullscreen.CheckedState.BorderRadius = 2;
            this.fullscreen.CheckedState.BorderThickness = 0;
            this.fullscreen.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fullscreen.CheckMarkColor = System.Drawing.Color.Silver;
            this.fullscreen.ForeColor = System.Drawing.Color.Transparent;
            this.fullscreen.Location = new System.Drawing.Point(12, 79);
            this.fullscreen.Name = "fullscreen";
            this.fullscreen.Size = new System.Drawing.Size(25, 25);
            this.fullscreen.TabIndex = 4;
            this.fullscreen.UncheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.fullscreen.UncheckedState.BorderRadius = 2;
            this.fullscreen.UncheckedState.BorderThickness = 0;
            this.fullscreen.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fullscreen.CheckedChanged += new System.EventHandler(this.fullscreen_CheckedChanged);
            this.fullscreen.Click += new System.EventHandler(this.fullscreen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(41, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Full Screen";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(12, 62);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(433, 10);
            this.guna2Separator1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(204, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Specific Window";
            // 
            // specificwindow
            // 
            this.specificwindow.Animated = true;
            this.specificwindow.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.specificwindow.CheckedState.BorderRadius = 2;
            this.specificwindow.CheckedState.BorderThickness = 0;
            this.specificwindow.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.specificwindow.CheckMarkColor = System.Drawing.Color.Silver;
            this.specificwindow.ForeColor = System.Drawing.Color.Transparent;
            this.specificwindow.Location = new System.Drawing.Point(175, 79);
            this.specificwindow.Name = "specificwindow";
            this.specificwindow.Size = new System.Drawing.Size(25, 25);
            this.specificwindow.TabIndex = 7;
            this.specificwindow.UncheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.specificwindow.UncheckedState.BorderRadius = 2;
            this.specificwindow.UncheckedState.BorderThickness = 0;
            this.specificwindow.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.specificwindow.CheckedChanged += new System.EventHandler(this.specificwindow_CheckedChanged);
            this.specificwindow.Click += new System.EventHandler(this.specificwindow_Click_1);
            // 
            // window
            // 
            this.window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.window.BorderColor = System.Drawing.Color.DimGray;
            this.window.BorderRadius = 5;
            this.window.BorderThickness = 0;
            this.window.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.window.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.window.DisabledState.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.window.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.window.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.window.FillColor = System.Drawing.Color.Black;
            this.window.FocusedColor = System.Drawing.Color.Black;
            this.window.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.window.FocusedState.FillColor = System.Drawing.Color.Black;
            this.window.FocusedState.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.window.FocusedState.ForeColor = System.Drawing.Color.White;
            this.window.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.window.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.window.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.window.HoverState.FillColor = System.Drawing.Color.Black;
            this.window.HoverState.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.window.HoverState.ForeColor = System.Drawing.Color.White;
            this.window.ItemHeight = 30;
            this.window.ItemsAppearance.BackColor = System.Drawing.Color.Transparent;
            this.window.ItemsAppearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.window.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.window.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Gray;
            this.window.Location = new System.Drawing.Point(12, 137);
            this.window.Name = "window";
            this.window.Size = new System.Drawing.Size(433, 36);
            this.window.TabIndex = 9;
            this.window.SelectedIndexChanged += new System.EventHandler(this.window_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(11, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Select Window";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 2;
            this.guna2Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Silver;
            this.guna2Button1.Location = new System.Drawing.Point(14, 189);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(111, 30);
            this.guna2Button1.TabIndex = 11;
            this.guna2Button1.Text = "Choose Output";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label5.Location = new System.Drawing.Point(14, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Format : ";
            // 
            // outputformat
            // 
            this.outputformat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.outputformat.BorderColor = System.Drawing.Color.White;
            this.outputformat.BorderRadius = 2;
            this.outputformat.BorderThickness = 0;
            this.outputformat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.outputformat.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.outputformat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.outputformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputformat.FillColor = System.Drawing.Color.Black;
            this.outputformat.FocusedColor = System.Drawing.Color.Black;
            this.outputformat.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.outputformat.FocusedState.FillColor = System.Drawing.Color.Black;
            this.outputformat.FocusedState.ForeColor = System.Drawing.Color.White;
            this.outputformat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.outputformat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.outputformat.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.outputformat.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.outputformat.ItemHeight = 30;
            this.outputformat.Items.AddRange(new object[] {
            "MP4",
            "MKV",
            "AVI",
            "WEBM",
            "MOV",
            "FLV"});
            this.outputformat.ItemsAppearance.BackColor = System.Drawing.Color.Black;
            this.outputformat.ItemsAppearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputformat.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.outputformat.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Gray;
            this.outputformat.Location = new System.Drawing.Point(76, 228);
            this.outputformat.Name = "outputformat";
            this.outputformat.Size = new System.Drawing.Size(86, 36);
            this.outputformat.StartIndex = 1;
            this.outputformat.TabIndex = 13;
            // 
            // recquality
            // 
            this.recquality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.recquality.BorderColor = System.Drawing.Color.White;
            this.recquality.BorderRadius = 2;
            this.recquality.BorderThickness = 0;
            this.recquality.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.recquality.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.recquality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.recquality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recquality.FillColor = System.Drawing.Color.Black;
            this.recquality.FocusedColor = System.Drawing.Color.Black;
            this.recquality.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.recquality.FocusedState.FillColor = System.Drawing.Color.Black;
            this.recquality.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.recquality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.recquality.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.recquality.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.recquality.ItemHeight = 30;
            this.recquality.Items.AddRange(new object[] {
            "100%",
            "90%",
            "80%",
            "70%",
            "60%",
            "50%",
            "40%",
            "30%",
            "20%",
            "10%"});
            this.recquality.ItemsAppearance.BackColor = System.Drawing.Color.Black;
            this.recquality.ItemsAppearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recquality.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.recquality.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Gray;
            this.recquality.Location = new System.Drawing.Point(229, 228);
            this.recquality.Name = "recquality";
            this.recquality.Size = new System.Drawing.Size(86, 36);
            this.recquality.StartIndex = 1;
            this.recquality.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label6.Location = new System.Drawing.Point(166, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Quality : ";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Separator2.FillThickness = 2;
            this.guna2Separator2.Location = new System.Drawing.Point(12, 277);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(425, 10);
            this.guna2Separator2.TabIndex = 16;
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Animated = true;
            this.txtOutputPath.BackColor = System.Drawing.Color.Transparent;
            this.txtOutputPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOutputPath.BorderRadius = 4;
            this.txtOutputPath.BorderThickness = 2;
            this.txtOutputPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOutputPath.DefaultText = "";
            this.txtOutputPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOutputPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOutputPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOutputPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOutputPath.FillColor = System.Drawing.Color.Transparent;
            this.txtOutputPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOutputPath.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.txtOutputPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtOutputPath.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtOutputPath.Location = new System.Drawing.Point(137, 189);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtOutputPath.PlaceholderText = "Output Path";
            this.txtOutputPath.SelectedText = "";
            this.txtOutputPath.Size = new System.Drawing.Size(308, 30);
            this.txtOutputPath.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label7.Location = new System.Drawing.Point(41, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Record Audio";
            // 
            // chkAudio
            // 
            this.chkAudio.Animated = true;
            this.chkAudio.Checked = true;
            this.chkAudio.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.chkAudio.CheckedState.BorderRadius = 2;
            this.chkAudio.CheckedState.BorderThickness = 0;
            this.chkAudio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkAudio.CheckMarkColor = System.Drawing.Color.Silver;
            this.chkAudio.ForeColor = System.Drawing.Color.Transparent;
            this.chkAudio.Location = new System.Drawing.Point(12, 295);
            this.chkAudio.Name = "chkAudio";
            this.chkAudio.Size = new System.Drawing.Size(25, 25);
            this.chkAudio.TabIndex = 18;
            this.chkAudio.UncheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.chkAudio.UncheckedState.BorderRadius = 2;
            this.chkAudio.UncheckedState.BorderThickness = 0;
            this.chkAudio.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkAudio.CheckedChanged += new System.EventHandler(this.chkAudio_CheckedChanged);
            this.chkAudio.Click += new System.EventHandler(this.chkAudio_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label8.Location = new System.Drawing.Point(41, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Default Resolution";
            // 
            // chkHighQuality
            // 
            this.chkHighQuality.Animated = true;
            this.chkHighQuality.Checked = true;
            this.chkHighQuality.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.chkHighQuality.CheckedState.BorderRadius = 2;
            this.chkHighQuality.CheckedState.BorderThickness = 0;
            this.chkHighQuality.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkHighQuality.CheckMarkColor = System.Drawing.Color.Silver;
            this.chkHighQuality.ForeColor = System.Drawing.Color.Transparent;
            this.chkHighQuality.Location = new System.Drawing.Point(12, 326);
            this.chkHighQuality.Name = "chkHighQuality";
            this.chkHighQuality.Size = new System.Drawing.Size(25, 25);
            this.chkHighQuality.TabIndex = 20;
            this.chkHighQuality.UncheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.chkHighQuality.UncheckedState.BorderRadius = 2;
            this.chkHighQuality.UncheckedState.BorderThickness = 0;
            this.chkHighQuality.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkHighQuality.CheckedChanged += new System.EventHandler(this.cmbResolution_CheckedChanged);
            this.chkHighQuality.Click += new System.EventHandler(this.chkHighQuality_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label9.Location = new System.Drawing.Point(41, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Hide LiteCap While Recording";
            // 
            // chkHideWhileRecording
            // 
            this.chkHideWhileRecording.Animated = true;
            this.chkHideWhileRecording.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.chkHideWhileRecording.CheckedState.BorderRadius = 2;
            this.chkHideWhileRecording.CheckedState.BorderThickness = 0;
            this.chkHideWhileRecording.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkHideWhileRecording.CheckMarkColor = System.Drawing.Color.Silver;
            this.chkHideWhileRecording.ForeColor = System.Drawing.Color.Transparent;
            this.chkHideWhileRecording.Location = new System.Drawing.Point(12, 357);
            this.chkHideWhileRecording.Name = "chkHideWhileRecording";
            this.chkHideWhileRecording.Size = new System.Drawing.Size(25, 25);
            this.chkHideWhileRecording.TabIndex = 22;
            this.chkHideWhileRecording.UncheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.chkHideWhileRecording.UncheckedState.BorderRadius = 2;
            this.chkHideWhileRecording.UncheckedState.BorderThickness = 0;
            this.chkHideWhileRecording.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Separator3.FillThickness = 2;
            this.guna2Separator3.Location = new System.Drawing.Point(12, 399);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(425, 10);
            this.guna2Separator3.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label10.Location = new System.Drawing.Point(14, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "CPU :";
            // 
            // lblCpu
            // 
            this.lblCpu.AutoSize = true;
            this.lblCpu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCpu.Location = new System.Drawing.Point(57, 421);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(38, 16);
            this.lblCpu.TabIndex = 26;
            this.lblCpu.Text = "000%";
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblRam.Location = new System.Drawing.Point(247, 421);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(93, 16);
            this.lblRam.TabIndex = 28;
            this.lblRam.Text = "170MB / 16GB";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label13.Location = new System.Drawing.Point(204, 421);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "RAM :";
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Separator4.FillThickness = 2;
            this.guna2Separator4.Location = new System.Drawing.Point(12, 446);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(425, 10);
            this.guna2Separator4.TabIndex = 29;
            // 
            // startrec
            // 
            this.startrec.Animated = true;
            this.startrec.BorderRadius = 2;
            this.startrec.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.startrec.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.startrec.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.startrec.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.startrec.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.startrec.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startrec.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.startrec.ForeColor = System.Drawing.Color.Silver;
            this.startrec.Location = new System.Drawing.Point(12, 458);
            this.startrec.Name = "startrec";
            this.startrec.Size = new System.Drawing.Size(140, 30);
            this.startrec.TabIndex = 30;
            this.startrec.Text = "Record";
            this.startrec.Click += new System.EventHandler(this.startrec_Click);
            // 
            // stoprec
            // 
            this.stoprec.Animated = true;
            this.stoprec.BorderRadius = 2;
            this.stoprec.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.stoprec.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.stoprec.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.stoprec.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.stoprec.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.stoprec.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stoprec.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.stoprec.ForeColor = System.Drawing.Color.White;
            this.stoprec.Location = new System.Drawing.Point(12, 458);
            this.stoprec.Name = "stoprec";
            this.stoprec.Size = new System.Drawing.Size(140, 30);
            this.stoprec.TabIndex = 31;
            this.stoprec.Text = "Stop Record";
            this.stoprec.Click += new System.EventHandler(this.stoprec_Click);
            // 
            // systemStatsTimer
            // 
            this.systemStatsTimer.Enabled = true;
            this.systemStatsTimer.Interval = 1000;
            this.systemStatsTimer.Tick += new System.EventHandler(this.systemStatsTimer_Tick);
            // 
            // cmbResolution
            // 
            this.cmbResolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbResolution.BorderColor = System.Drawing.Color.White;
            this.cmbResolution.BorderRadius = 2;
            this.cmbResolution.BorderThickness = 0;
            this.cmbResolution.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbResolution.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.cmbResolution.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResolution.FillColor = System.Drawing.Color.Black;
            this.cmbResolution.FocusedColor = System.Drawing.Color.Black;
            this.cmbResolution.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.cmbResolution.FocusedState.FillColor = System.Drawing.Color.Black;
            this.cmbResolution.FocusedState.ForeColor = System.Drawing.Color.White;
            this.cmbResolution.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbResolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbResolution.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.cmbResolution.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.cmbResolution.ItemHeight = 30;
            this.cmbResolution.Items.AddRange(new object[] {
            "960 x 540",
            "1280 x 720",
            "1600 x 900",
            "1920 x1080",
            "2560 x1440",
            "3840 x 2160"});
            this.cmbResolution.ItemsAppearance.BackColor = System.Drawing.Color.Black;
            this.cmbResolution.ItemsAppearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbResolution.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.cmbResolution.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Gray;
            this.cmbResolution.Location = new System.Drawing.Point(171, 320);
            this.cmbResolution.Name = "cmbResolution";
            this.cmbResolution.Size = new System.Drawing.Size(128, 36);
            this.cmbResolution.StartIndex = 3;
            this.cmbResolution.TabIndex = 32;
            this.cmbResolution.SelectedIndexChanged += new System.EventHandler(this.cmbResolution_SelectedIndexChanged);
            // 
            // toastDialog
            // 
            this.toastDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.toastDialog.Caption = "BRUUUH OFFICIAL";
            this.toastDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.toastDialog.Parent = this;
            this.toastDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.toastDialog.Text = "Lite Capture";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(326, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "Fps : ";
            // 
            // nmrFps
            // 
            this.nmrFps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nmrFps.BorderRadius = 2;
            this.nmrFps.BorderThickness = 0;
            this.nmrFps.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmrFps.FillColor = System.Drawing.Color.Black;
            this.nmrFps.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.nmrFps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.nmrFps.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nmrFps.Location = new System.Drawing.Point(365, 228);
            this.nmrFps.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nmrFps.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmrFps.Name = "nmrFps";
            this.nmrFps.Size = new System.Drawing.Size(80, 36);
            this.nmrFps.TabIndex = 34;
            this.nmrFps.UpDownButtonFillColor = System.Drawing.Color.Black;
            this.nmrFps.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nmrFps.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(130, 14);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(48, 39);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 35;
            this.guna2PictureBox1.TabStop = false;
            // 
            // LiteCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(457, 499);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.nmrFps);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbResolution);
            this.Controls.Add(this.guna2Separator4);
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblCpu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.guna2Separator3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chkHideWhileRecording);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkHighQuality);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkAudio);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.recquality);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.outputformat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.window);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.specificwindow);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullscreen);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startrec);
            this.Controls.Add(this.stoprec);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LiteCapture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "BRUUUH OFFICIAL LITE RECORDER";
            this.Text = "LiteCapture";
            this.Load += new System.EventHandler(this.LiteCapture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrFps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox exit;
        private Guna.UI2.WinForms.Guna2ControlBox minimize;
        private Guna.UI2.WinForms.Guna2CustomCheckBox fullscreen;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CustomCheckBox specificwindow;
        private Guna.UI2.WinForms.Guna2ComboBox window;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox outputformat;
        private Guna.UI2.WinForms.Guna2ComboBox recquality;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2TextBox txtOutputPath;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkAudio;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkHighQuality;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkHideWhileRecording;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCpu;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private Guna.UI2.WinForms.Guna2Button startrec;
        private Guna.UI2.WinForms.Guna2Button stoprec;
        private System.Windows.Forms.Timer systemStatsTimer;
        private Guna.UI2.WinForms.Guna2ComboBox cmbResolution;
        private Guna.UI2.WinForms.Guna2MessageDialog toastDialog;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmrFps;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}