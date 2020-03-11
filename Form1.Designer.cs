namespace CrypterAIO
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qRCoderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MassEncryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MassDecryptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.encryptOutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.encryptSecret = new System.Windows.Forms.TextBox();
            this.encryptString = new System.Windows.Forms.TextBox();
            this.gBencryption = new System.Windows.Forms.GroupBox();
            this.gBdecryption = new System.Windows.Forms.GroupBox();
            this.decryptSecret = new System.Windows.Forms.TextBox();
            this.decryptString = new System.Windows.Forms.TextBox();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.decryptOutput = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gBqrcoder = new System.Windows.Forms.GroupBox();
            this.qrSecret = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.qrPicture = new System.Windows.Forms.PictureBox();
            this.qrOutput = new System.Windows.Forms.RichTextBox();
            this.qrInput = new System.Windows.Forms.RichTextBox();
            this.qrDecode = new System.Windows.Forms.Button();
            this.qrEncode = new System.Windows.Forms.Button();
            this.sfd1 = new System.Windows.Forms.SaveFileDialog();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.gBmassEncrypt = new System.Windows.Forms.GroupBox();
            this.gBmassdecrypt = new System.Windows.Forms.GroupBox();
            this.massDeSecret = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.massDeOutput = new System.Windows.Forms.RichTextBox();
            this.massDeString = new System.Windows.Forms.RichTextBox();
            this.massDecode = new System.Windows.Forms.Button();
            this.massSecret = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.massOutput = new System.Windows.Forms.RichTextBox();
            this.massString = new System.Windows.Forms.RichTextBox();
            this.massEncode = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gBencryption.SuspendLayout();
            this.gBdecryption.SuspendLayout();
            this.gBqrcoder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrPicture)).BeginInit();
            this.gBmassEncrypt.SuspendLayout();
            this.gBmassdecrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptToolStripMenuItem,
            this.decryptToolStripMenuItem,
            this.qRCoderToolStripMenuItem,
            this.MassEncryptToolStripMenuItem,
            this.MassDecryptToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.encryptToolStripMenuItem.Text = "Encrypt";
            this.encryptToolStripMenuItem.Click += new System.EventHandler(this.encryptToolStripMenuItem_Click);
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.decryptToolStripMenuItem.Text = "Decrypt";
            this.decryptToolStripMenuItem.Click += new System.EventHandler(this.decryptToolStripMenuItem_Click);
            // 
            // qRCoderToolStripMenuItem
            // 
            this.qRCoderToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.qRCoderToolStripMenuItem.Name = "qRCoderToolStripMenuItem";
            this.qRCoderToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.qRCoderToolStripMenuItem.Text = "QR-Coder";
            this.qRCoderToolStripMenuItem.Click += new System.EventHandler(this.qRCoderToolStripMenuItem_Click);
            // 
            // MassEncryptToolStripMenuItem
            // 
            this.MassEncryptToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MassEncryptToolStripMenuItem.Name = "MassEncryptToolStripMenuItem";
            this.MassEncryptToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.MassEncryptToolStripMenuItem.Text = "Mass Encrypt";
            this.MassEncryptToolStripMenuItem.Click += new System.EventHandler(this.MassEncryptToolStripMenuItem_Click);
            // 
            // MassDecryptToolStripMenuItem1
            // 
            this.MassDecryptToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MassDecryptToolStripMenuItem1.Name = "MassDecryptToolStripMenuItem1";
            this.MassDecryptToolStripMenuItem1.Size = new System.Drawing.Size(117, 24);
            this.MassDecryptToolStripMenuItem1.Text = "Mass Decrypt";
            this.MassDecryptToolStripMenuItem1.Click += new System.EventHandler(this.MassDecryptToolStripMenuItem1_Click);
            // 
            // encryptBtn
            // 
            this.encryptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.encryptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.encryptBtn.ForeColor = System.Drawing.Color.Black;
            this.encryptBtn.Location = new System.Drawing.Point(14, 109);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(584, 34);
            this.encryptBtn.TabIndex = 1;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = false;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // encryptOutput
            // 
            this.encryptOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.encryptOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.encryptOutput.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.encryptOutput.Location = new System.Drawing.Point(14, 149);
            this.encryptOutput.Name = "encryptOutput";
            this.encryptOutput.Size = new System.Drawing.Size(584, 222);
            this.encryptOutput.TabIndex = 2;
            this.encryptOutput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "String:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Secret:";
            // 
            // encryptSecret
            // 
            this.encryptSecret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.encryptSecret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.encryptSecret.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.encryptSecret.Location = new System.Drawing.Point(76, 30);
            this.encryptSecret.Name = "encryptSecret";
            this.encryptSecret.Size = new System.Drawing.Size(522, 22);
            this.encryptSecret.TabIndex = 5;
            // 
            // encryptString
            // 
            this.encryptString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.encryptString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.encryptString.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.encryptString.Location = new System.Drawing.Point(76, 66);
            this.encryptString.Name = "encryptString";
            this.encryptString.Size = new System.Drawing.Size(522, 22);
            this.encryptString.TabIndex = 6;
            // 
            // gBencryption
            // 
            this.gBencryption.Controls.Add(this.encryptSecret);
            this.gBencryption.Controls.Add(this.encryptString);
            this.gBencryption.Controls.Add(this.encryptBtn);
            this.gBencryption.Controls.Add(this.encryptOutput);
            this.gBencryption.Controls.Add(this.label2);
            this.gBencryption.Controls.Add(this.label1);
            this.gBencryption.ForeColor = System.Drawing.Color.White;
            this.gBencryption.Location = new System.Drawing.Point(12, 41);
            this.gBencryption.Name = "gBencryption";
            this.gBencryption.Size = new System.Drawing.Size(614, 388);
            this.gBencryption.TabIndex = 7;
            this.gBencryption.TabStop = false;
            this.gBencryption.Text = "Encryption";
            // 
            // gBdecryption
            // 
            this.gBdecryption.Controls.Add(this.decryptSecret);
            this.gBdecryption.Controls.Add(this.decryptString);
            this.gBdecryption.Controls.Add(this.decryptBtn);
            this.gBdecryption.Controls.Add(this.decryptOutput);
            this.gBdecryption.Controls.Add(this.label3);
            this.gBdecryption.Controls.Add(this.label4);
            this.gBdecryption.ForeColor = System.Drawing.Color.White;
            this.gBdecryption.Location = new System.Drawing.Point(12, 41);
            this.gBdecryption.Name = "gBdecryption";
            this.gBdecryption.Size = new System.Drawing.Size(614, 388);
            this.gBdecryption.TabIndex = 8;
            this.gBdecryption.TabStop = false;
            this.gBdecryption.Text = "Decryption";
            // 
            // decryptSecret
            // 
            this.decryptSecret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.decryptSecret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decryptSecret.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.decryptSecret.Location = new System.Drawing.Point(76, 30);
            this.decryptSecret.Name = "decryptSecret";
            this.decryptSecret.Size = new System.Drawing.Size(522, 22);
            this.decryptSecret.TabIndex = 5;
            // 
            // decryptString
            // 
            this.decryptString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.decryptString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decryptString.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.decryptString.Location = new System.Drawing.Point(76, 66);
            this.decryptString.Name = "decryptString";
            this.decryptString.Size = new System.Drawing.Size(522, 22);
            this.decryptString.TabIndex = 6;
            // 
            // decryptBtn
            // 
            this.decryptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.decryptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.decryptBtn.ForeColor = System.Drawing.Color.Black;
            this.decryptBtn.Location = new System.Drawing.Point(14, 109);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(584, 34);
            this.decryptBtn.TabIndex = 1;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = false;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // decryptOutput
            // 
            this.decryptOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.decryptOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decryptOutput.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.decryptOutput.Location = new System.Drawing.Point(14, 149);
            this.decryptOutput.Name = "decryptOutput";
            this.decryptOutput.Size = new System.Drawing.Size(584, 222);
            this.decryptOutput.TabIndex = 2;
            this.decryptOutput.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Secret:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "String:";
            // 
            // gBqrcoder
            // 
            this.gBqrcoder.Controls.Add(this.qrSecret);
            this.gBqrcoder.Controls.Add(this.label5);
            this.gBqrcoder.Controls.Add(this.qrPicture);
            this.gBqrcoder.Controls.Add(this.qrOutput);
            this.gBqrcoder.Controls.Add(this.qrInput);
            this.gBqrcoder.Controls.Add(this.qrDecode);
            this.gBqrcoder.Controls.Add(this.qrEncode);
            this.gBqrcoder.ForeColor = System.Drawing.Color.White;
            this.gBqrcoder.Location = new System.Drawing.Point(12, 41);
            this.gBqrcoder.Name = "gBqrcoder";
            this.gBqrcoder.Size = new System.Drawing.Size(614, 388);
            this.gBqrcoder.TabIndex = 9;
            this.gBqrcoder.TabStop = false;
            this.gBqrcoder.Text = "QR-Coder";
            // 
            // qrSecret
            // 
            this.qrSecret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.qrSecret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qrSecret.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.qrSecret.Location = new System.Drawing.Point(76, 24);
            this.qrSecret.Name = "qrSecret";
            this.qrSecret.Size = new System.Drawing.Size(522, 22);
            this.qrSecret.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Secret:";
            // 
            // qrPicture
            // 
            this.qrPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.qrPicture.InitialImage = null;
            this.qrPicture.Location = new System.Drawing.Point(458, 232);
            this.qrPicture.Name = "qrPicture";
            this.qrPicture.Size = new System.Drawing.Size(140, 140);
            this.qrPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrPicture.TabIndex = 10;
            this.qrPicture.TabStop = false;
            // 
            // qrOutput
            // 
            this.qrOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.qrOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qrOutput.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.qrOutput.Location = new System.Drawing.Point(14, 232);
            this.qrOutput.Name = "qrOutput";
            this.qrOutput.Size = new System.Drawing.Size(433, 140);
            this.qrOutput.TabIndex = 9;
            this.qrOutput.Text = "";
            // 
            // qrInput
            // 
            this.qrInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.qrInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qrInput.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.qrInput.Location = new System.Drawing.Point(14, 58);
            this.qrInput.Name = "qrInput";
            this.qrInput.Size = new System.Drawing.Size(584, 110);
            this.qrInput.TabIndex = 8;
            this.qrInput.Text = "Enter String Here...";
            this.qrInput.Click += new System.EventHandler(this.qrInput_Click);
            // 
            // qrDecode
            // 
            this.qrDecode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.qrDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qrDecode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.qrDecode.ForeColor = System.Drawing.Color.Black;
            this.qrDecode.Location = new System.Drawing.Point(310, 183);
            this.qrDecode.Name = "qrDecode";
            this.qrDecode.Size = new System.Drawing.Size(288, 34);
            this.qrDecode.TabIndex = 7;
            this.qrDecode.Text = "Decode";
            this.qrDecode.UseVisualStyleBackColor = false;
            this.qrDecode.Click += new System.EventHandler(this.qrDecode_Click);
            // 
            // qrEncode
            // 
            this.qrEncode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.qrEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qrEncode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.qrEncode.ForeColor = System.Drawing.Color.Black;
            this.qrEncode.Location = new System.Drawing.Point(14, 183);
            this.qrEncode.Name = "qrEncode";
            this.qrEncode.Size = new System.Drawing.Size(281, 34);
            this.qrEncode.TabIndex = 1;
            this.qrEncode.Text = "Encode";
            this.qrEncode.UseVisualStyleBackColor = false;
            this.qrEncode.Click += new System.EventHandler(this.qrEncode_Click);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // gBmassEncrypt
            // 
            this.gBmassEncrypt.Controls.Add(this.massSecret);
            this.gBmassEncrypt.Controls.Add(this.label7);
            this.gBmassEncrypt.Controls.Add(this.massOutput);
            this.gBmassEncrypt.Controls.Add(this.massString);
            this.gBmassEncrypt.Controls.Add(this.massEncode);
            this.gBmassEncrypt.ForeColor = System.Drawing.Color.White;
            this.gBmassEncrypt.Location = new System.Drawing.Point(12, 41);
            this.gBmassEncrypt.Name = "gBmassEncrypt";
            this.gBmassEncrypt.Size = new System.Drawing.Size(614, 388);
            this.gBmassEncrypt.TabIndex = 13;
            this.gBmassEncrypt.TabStop = false;
            this.gBmassEncrypt.Text = "Mass Encrypt";
            // 
            // gBmassdecrypt
            // 
            this.gBmassdecrypt.Controls.Add(this.massDeSecret);
            this.gBmassdecrypt.Controls.Add(this.label8);
            this.gBmassdecrypt.Controls.Add(this.massDeOutput);
            this.gBmassdecrypt.Controls.Add(this.massDeString);
            this.gBmassdecrypt.Controls.Add(this.massDecode);
            this.gBmassdecrypt.ForeColor = System.Drawing.Color.White;
            this.gBmassdecrypt.Location = new System.Drawing.Point(12, 41);
            this.gBmassdecrypt.Name = "gBmassdecrypt";
            this.gBmassdecrypt.Size = new System.Drawing.Size(614, 388);
            this.gBmassdecrypt.TabIndex = 14;
            this.gBmassdecrypt.TabStop = false;
            this.gBmassdecrypt.Text = "Mass Decrypt";
            // 
            // massDeSecret
            // 
            this.massDeSecret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.massDeSecret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.massDeSecret.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.massDeSecret.Location = new System.Drawing.Point(76, 24);
            this.massDeSecret.Name = "massDeSecret";
            this.massDeSecret.Size = new System.Drawing.Size(522, 22);
            this.massDeSecret.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Secret:";
            // 
            // massDeOutput
            // 
            this.massDeOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.massDeOutput.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.massDeOutput.Location = new System.Drawing.Point(14, 232);
            this.massDeOutput.Name = "massDeOutput";
            this.massDeOutput.RightMargin = 1000;
            this.massDeOutput.Size = new System.Drawing.Size(584, 140);
            this.massDeOutput.TabIndex = 9;
            this.massDeOutput.Text = "";
            this.massDeOutput.WordWrap = false;
            // 
            // massDeString
            // 
            this.massDeString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.massDeString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.massDeString.ForeColor = System.Drawing.Color.Gray;
            this.massDeString.Location = new System.Drawing.Point(14, 58);
            this.massDeString.Name = "massDeString";
            this.massDeString.RightMargin = 1000;
            this.massDeString.Size = new System.Drawing.Size(584, 128);
            this.massDeString.TabIndex = 8;
            this.massDeString.Text = "Enter string here, lines seperate strings...";
            this.massDeString.Click += new System.EventHandler(this.massDeString_Click);
            // 
            // massDecode
            // 
            this.massDecode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.massDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.massDecode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.massDecode.ForeColor = System.Drawing.Color.Black;
            this.massDecode.Location = new System.Drawing.Point(14, 192);
            this.massDecode.Name = "massDecode";
            this.massDecode.Size = new System.Drawing.Size(584, 34);
            this.massDecode.TabIndex = 1;
            this.massDecode.Text = "Decrypt";
            this.massDecode.UseVisualStyleBackColor = false;
            this.massDecode.Click += new System.EventHandler(this.massDecode_Click);
            // 
            // massSecret
            // 
            this.massSecret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.massSecret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.massSecret.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.massSecret.Location = new System.Drawing.Point(76, 24);
            this.massSecret.Name = "massSecret";
            this.massSecret.Size = new System.Drawing.Size(522, 22);
            this.massSecret.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Secret:";
            // 
            // massOutput
            // 
            this.massOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.massOutput.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.massOutput.Location = new System.Drawing.Point(14, 232);
            this.massOutput.Name = "massOutput";
            this.massOutput.RightMargin = 1000;
            this.massOutput.Size = new System.Drawing.Size(584, 140);
            this.massOutput.TabIndex = 9;
            this.massOutput.Text = "";
            this.massOutput.WordWrap = false;
            // 
            // massString
            // 
            this.massString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.massString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.massString.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.massString.Location = new System.Drawing.Point(14, 58);
            this.massString.Name = "massString";
            this.massString.RightMargin = 1000;
            this.massString.Size = new System.Drawing.Size(584, 128);
            this.massString.TabIndex = 8;
            this.massString.Text = "Enter string here, lines seperate strings...";
            this.massString.Click += new System.EventHandler(this.massString_Click);
            // 
            // massEncode
            // 
            this.massEncode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.massEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.massEncode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.massEncode.ForeColor = System.Drawing.Color.Black;
            this.massEncode.Location = new System.Drawing.Point(14, 192);
            this.massEncode.Name = "massEncode";
            this.massEncode.Size = new System.Drawing.Size(584, 34);
            this.massEncode.TabIndex = 1;
            this.massEncode.Text = "Encrypt";
            this.massEncode.UseVisualStyleBackColor = false;
            this.massEncode.Click += new System.EventHandler(this.massEncode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(640, 446);
            this.Controls.Add(this.gBmassdecrypt);
            this.Controls.Add(this.gBmassEncrypt);
            this.Controls.Add(this.gBqrcoder);
            this.Controls.Add(this.gBdecryption);
            this.Controls.Add(this.gBencryption);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CrypterAIO - SelfMade#0001";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gBencryption.ResumeLayout(false);
            this.gBencryption.PerformLayout();
            this.gBdecryption.ResumeLayout(false);
            this.gBdecryption.PerformLayout();
            this.gBqrcoder.ResumeLayout(false);
            this.gBqrcoder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrPicture)).EndInit();
            this.gBmassEncrypt.ResumeLayout(false);
            this.gBmassEncrypt.PerformLayout();
            this.gBmassdecrypt.ResumeLayout(false);
            this.gBmassdecrypt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qRCoderToolStripMenuItem;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.RichTextBox encryptOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox encryptSecret;
        private System.Windows.Forms.TextBox encryptString;
        private System.Windows.Forms.GroupBox gBencryption;
        private System.Windows.Forms.GroupBox gBdecryption;
        private System.Windows.Forms.TextBox decryptSecret;
        private System.Windows.Forms.TextBox decryptString;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.RichTextBox decryptOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gBqrcoder;
        private System.Windows.Forms.RichTextBox qrOutput;
        private System.Windows.Forms.RichTextBox qrInput;
        private System.Windows.Forms.Button qrDecode;
        private System.Windows.Forms.Button qrEncode;
        private System.Windows.Forms.SaveFileDialog sfd1;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.PictureBox qrPicture;
        private System.Windows.Forms.TextBox qrSecret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem MassEncryptToolStripMenuItem;
        private System.Windows.Forms.GroupBox gBmassEncrypt;
        private System.Windows.Forms.TextBox massSecret;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox massOutput;
        private System.Windows.Forms.RichTextBox massString;
        private System.Windows.Forms.Button massEncode;
        private System.Windows.Forms.ToolStripMenuItem MassDecryptToolStripMenuItem1;
        private System.Windows.Forms.GroupBox gBmassdecrypt;
        private System.Windows.Forms.TextBox massDeSecret;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox massDeOutput;
        private System.Windows.Forms.RichTextBox massDeString;
        private System.Windows.Forms.Button massDecode;
    }
}

