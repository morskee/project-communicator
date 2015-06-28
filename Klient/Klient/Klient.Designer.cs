namespace Klient
{
    partial class Klient
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
            this.txtOtrzymywane = new System.Windows.Forms.RichTextBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdWyslij = new System.Windows.Forms.Button();
            this.txtWysylane = new System.Windows.Forms.RichTextBox();
            this.cmdPolacz = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Polaczenie = new System.ComponentModel.BackgroundWorker();
            this.Odbieranie = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.komunikatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infrormacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakoñczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOtrzymywane
            // 
            this.txtOtrzymywane.BackColor = System.Drawing.SystemColors.Window;
            this.txtOtrzymywane.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOtrzymywane.Location = new System.Drawing.Point(12, 30);
            this.txtOtrzymywane.Name = "txtOtrzymywane";
            this.txtOtrzymywane.ReadOnly = true;
            this.txtOtrzymywane.Size = new System.Drawing.Size(355, 243);
            this.txtOtrzymywane.TabIndex = 24;
            this.txtOtrzymywane.Text = "";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.ForeColor = System.Drawing.Color.Black;
            this.txtLog.Location = new System.Drawing.Point(376, 168);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(98, 174);
            this.txtLog.TabIndex = 23;
            this.txtLog.TabStop = false;
            this.txtLog.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Log";
            // 
            // cmdWyslij
            // 
            this.cmdWyslij.BackColor = System.Drawing.Color.LemonChiffon;
            this.cmdWyslij.Enabled = false;
            this.cmdWyslij.Location = new System.Drawing.Point(278, 348);
            this.cmdWyslij.Name = "cmdWyslij";
            this.cmdWyslij.Size = new System.Drawing.Size(89, 32);
            this.cmdWyslij.TabIndex = 21;
            this.cmdWyslij.Text = "Wyslij";
            this.cmdWyslij.UseVisualStyleBackColor = false;
            this.cmdWyslij.Click += new System.EventHandler(this.cmdWyslij_Click);
            // 
            // txtWysylane
            // 
            this.txtWysylane.BackColor = System.Drawing.Color.White;
            this.txtWysylane.ForeColor = System.Drawing.Color.Black;
            this.txtWysylane.Location = new System.Drawing.Point(12, 279);
            this.txtWysylane.Name = "txtWysylane";
            this.txtWysylane.Size = new System.Drawing.Size(355, 63);
            this.txtWysylane.TabIndex = 20;
            this.txtWysylane.Text = "";
            this.txtWysylane.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWysylane_KeyPress);
            // 
            // cmdPolacz
            // 
            this.cmdPolacz.BackColor = System.Drawing.Color.LemonChiffon;
            this.cmdPolacz.Location = new System.Drawing.Point(376, 111);
            this.cmdPolacz.Name = "cmdPolacz";
            this.cmdPolacz.Size = new System.Drawing.Size(98, 38);
            this.cmdPolacz.TabIndex = 29;
            this.cmdPolacz.Text = "Po³¹cz";
            this.cmdPolacz.UseVisualStyleBackColor = false;
            this.cmdPolacz.Click += new System.EventHandler(this.cmdPolacz_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(376, 85);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(44, 20);
            this.txtPort.TabIndex = 28;
            this.txtPort.Text = "8000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nr portu";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(376, 46);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(98, 20);
            this.txtIP.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Adres IP";
            // 
            // Polaczenie
            // 
            this.Polaczenie.WorkerSupportsCancellation = true;
            this.Polaczenie.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Polaczenie_DoWork);
            // 
            // Odbieranie
            // 
            this.Odbieranie.WorkerSupportsCancellation = true;
            this.Odbieranie.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Odbieranie_DoWork);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(376, 349);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(98, 31);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button1.Location = new System.Drawing.Point(183, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 33;
            this.button1.Text = "Wyczyœæ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Orange;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.komunikatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // komunikatorToolStripMenuItem
            // 
            this.komunikatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infrormacjeToolStripMenuItem,
            this.zakoñczToolStripMenuItem});
            this.komunikatorToolStripMenuItem.Name = "komunikatorToolStripMenuItem";
            this.komunikatorToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.komunikatorToolStripMenuItem.Text = "Komunikator";
            // 
            // infrormacjeToolStripMenuItem
            // 
            this.infrormacjeToolStripMenuItem.Name = "infrormacjeToolStripMenuItem";
            this.infrormacjeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.infrormacjeToolStripMenuItem.Text = "Infrormacje";
            this.infrormacjeToolStripMenuItem.Click += new System.EventHandler(this.infrormacjeToolStripMenuItem_Click);
            // 
            // zakoñczToolStripMenuItem
            // 
            this.zakoñczToolStripMenuItem.Name = "zakoñczToolStripMenuItem";
            this.zakoñczToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zakoñczToolStripMenuItem.Text = "Zakoñcz";
            this.zakoñczToolStripMenuItem.Click += new System.EventHandler(this.zakoñczToolStripMenuItem_Click);
            // 
            // Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(484, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cmdPolacz);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOtrzymywane);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdWyslij);
            this.Controls.Add(this.txtWysylane);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Klient";
            this.Text = "Klient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Klient_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtOtrzymywane;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdWyslij;
        private System.Windows.Forms.RichTextBox txtWysylane;
        private System.Windows.Forms.Button cmdPolacz;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker Polaczenie;
        private System.ComponentModel.BackgroundWorker Odbieranie;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem komunikatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infrormacjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakoñczToolStripMenuItem;
    }
}

