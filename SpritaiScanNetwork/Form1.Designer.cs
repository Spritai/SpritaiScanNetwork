namespace SpritaiScanNetwork
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            portStart = new NumericUpDown();
            portEnd = new NumericUpDown();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            btnScan = new MaterialSkin.Controls.MaterialButton();
            listBoxResults = new MaterialSkin.Controls.MaterialListBox();
            progressBar = new MaterialSkin.Controls.MaterialProgressBar();
            txtBaseIP = new MaterialSkin.Controls.MaterialMaskedTextBox();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            numericIpStart = new NumericUpDown();
            numericIpEnd = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)portStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)portEnd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericIpStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericIpEnd).BeginInit();
            SuspendLayout();
            // 
            // portStart
            // 
            portStart.Location = new Point(123, 83);
            portStart.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            portStart.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            portStart.Name = "portStart";
            portStart.Size = new Size(120, 23);
            portStart.TabIndex = 0;
            portStart.Value = new decimal(new int[] { 20, 0, 0, 0 });
            portStart.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // portEnd
            // 
            portEnd.Location = new Point(123, 112);
            portEnd.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            portEnd.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            portEnd.Name = "portEnd";
            portEnd.Size = new Size(120, 23);
            portEnd.TabIndex = 1;
            portEnd.Value = new decimal(new int[] { 80, 0, 0, 0 });
            portEnd.ValueChanged += portEnd_ValueChanged;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(25, 83);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(88, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Port Start -->";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(25, 112);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(81, 19);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Port End -->";
            // 
            // btnScan
            // 
            btnScan.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnScan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnScan.Depth = 0;
            btnScan.HighEmphasis = true;
            btnScan.Icon = null;
            btnScan.Location = new Point(25, 240);
            btnScan.Margin = new Padding(4, 6, 4, 6);
            btnScan.MouseState = MaterialSkin.MouseState.HOVER;
            btnScan.Name = "btnScan";
            btnScan.NoAccentTextColor = Color.Empty;
            btnScan.Size = new Size(109, 36);
            btnScan.TabIndex = 4;
            btnScan.Text = "Start Scan";
            btnScan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnScan.UseAccentColor = false;
            btnScan.UseVisualStyleBackColor = true;
            btnScan.Click += btnScan_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.BackColor = Color.White;
            listBoxResults.BorderColor = Color.LightGray;
            listBoxResults.Depth = 0;
            listBoxResults.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            listBoxResults.Location = new Point(286, 83);
            listBoxResults.MouseState = MaterialSkin.MouseState.HOVER;
            listBoxResults.Name = "listBoxResults";
            listBoxResults.SelectedIndex = -1;
            listBoxResults.SelectedItem = null;
            listBoxResults.Size = new Size(403, 336);
            listBoxResults.TabIndex = 5;
            listBoxResults.SelectedIndexChanged += listBoxResults_SelectedIndexChanged;
            // 
            // progressBar
            // 
            progressBar.Depth = 0;
            progressBar.Location = new Point(286, 420);
            progressBar.MouseState = MaterialSkin.MouseState.HOVER;
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(403, 5);
            progressBar.TabIndex = 6;
            progressBar.Click += progressBar_Click;
            // 
            // txtBaseIP
            // 
            txtBaseIP.AllowPromptAsInput = true;
            txtBaseIP.AnimateReadOnly = false;
            txtBaseIP.AsciiOnly = false;
            txtBaseIP.BackgroundImageLayout = ImageLayout.None;
            txtBaseIP.BeepOnError = false;
            txtBaseIP.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtBaseIP.Depth = 0;
            txtBaseIP.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBaseIP.HidePromptOnLeave = false;
            txtBaseIP.HideSelection = true;
            txtBaseIP.InsertKeyMode = InsertKeyMode.Default;
            txtBaseIP.LeadingIcon = null;
            txtBaseIP.Location = new Point(25, 141);
            txtBaseIP.Mask = "";
            txtBaseIP.MaxLength = 32767;
            txtBaseIP.MouseState = MaterialSkin.MouseState.OUT;
            txtBaseIP.Name = "txtBaseIP";
            txtBaseIP.PasswordChar = '\0';
            txtBaseIP.PrefixSuffixText = null;
            txtBaseIP.PromptChar = '_';
            txtBaseIP.ReadOnly = false;
            txtBaseIP.RejectInputOnFirstFailure = false;
            txtBaseIP.ResetOnPrompt = true;
            txtBaseIP.ResetOnSpace = true;
            txtBaseIP.RightToLeft = RightToLeft.No;
            txtBaseIP.SelectedText = "";
            txtBaseIP.SelectionLength = 0;
            txtBaseIP.SelectionStart = 0;
            txtBaseIP.ShortcutsEnabled = true;
            txtBaseIP.Size = new Size(218, 48);
            txtBaseIP.SkipLiterals = true;
            txtBaseIP.TabIndex = 7;
            txtBaseIP.TabStop = false;
            txtBaseIP.Text = "192.168.1";
            txtBaseIP.TextAlign = HorizontalAlignment.Left;
            txtBaseIP.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtBaseIP.TrailingIcon = null;
            txtBaseIP.UseSystemPasswordChar = false;
            txtBaseIP.ValidatingType = null;
            txtBaseIP.Click += txtBaseIP_Click;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(25, 288);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(107, 36);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save in TXT";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // numericIpStart
            // 
            numericIpStart.Location = new Point(25, 195);
            numericIpStart.Maximum = new decimal(new int[] { 254, 0, 0, 0 });
            numericIpStart.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericIpStart.Name = "numericIpStart";
            numericIpStart.Size = new Size(120, 23);
            numericIpStart.TabIndex = 9;
            numericIpStart.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericIpStart.ValueChanged += numericIpStart_ValueChanged;
            // 
            // numericIpEnd
            // 
            numericIpEnd.Location = new Point(151, 195);
            numericIpEnd.Maximum = new decimal(new int[] { 254, 0, 0, 0 });
            numericIpEnd.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericIpEnd.Name = "numericIpEnd";
            numericIpEnd.Size = new Size(120, 23);
            numericIpEnd.TabIndex = 10;
            numericIpEnd.Value = new decimal(new int[] { 254, 0, 0, 0 });
            numericIpEnd.ValueChanged += numericIpEnd_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericIpEnd);
            Controls.Add(numericIpStart);
            Controls.Add(btnSave);
            Controls.Add(txtBaseIP);
            Controls.Add(progressBar);
            Controls.Add(listBoxResults);
            Controls.Add(btnScan);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(portEnd);
            Controls.Add(portStart);
            Name = "Form1";
            Text = "Spritai's Scan Network";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)portStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)portEnd).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericIpStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericIpEnd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown portStart;
        private NumericUpDown portEnd;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btnScan;
        private MaterialSkin.Controls.MaterialListBox listBoxResults;
        private MaterialSkin.Controls.MaterialProgressBar progressBar;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtBaseIP;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private NumericUpDown numericIpStart;
        private NumericUpDown numericIpEnd;
    }
}
