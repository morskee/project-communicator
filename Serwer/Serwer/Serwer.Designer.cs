namespace Serwer
{
    partial class frmSerwer
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
            this.cmdSluchaj = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOtrzymywane = new System.Windows.Forms.RichTextBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdWyslij = new System.Windows.Forms.Button();
            this.txtWysylane = new System.Windows.Forms.RichTextBox();
            this.Polaczenie = new System.ComponentModel.BackgroundWorker();
            this.Odbieranie = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.komunikatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakoñczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSluchaj
            // 
            this.cmdSluchaj.BackColor = System.Drawing.Color.LemonChiffon;
            this.cmdSluchaj.Location = new System.Drawing.Point(376, 69);
            this.cmdSluchaj.Name = "cmdSluchaj";
            this.cmdSluchaj.Size = new System.Drawing.Size(96, 38);
            this.cmdSluchaj.TabIndex = 19;
            this.cmdSluchaj.Text = "Czekaj na po³¹czenie";
            this.cmdSluchaj.UseVisualStyleBackColor = false;
            this.cmdSluchaj.Click += new System.EventHandler(this.cmdSluchaj_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(376, 43);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(44, 20);
            this.txtPort.TabIndex = 18;
            this.txtPort.Text = "8000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nr portu";
            // 
            // txtOtrzymywane
            // 
            this.txtOtrzymywane.BackColor = System.Drawing.SystemColors.Window;
            this.txtOtrzymywane.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOtrzymywane.Location = new System.Drawing.Point(12, 27);
            this.txtOtrzymywane.Name = "txtOtrzymywane";
            this.txtOtrzymywane.ReadOnly = true;
            this.txtOtrzymywane.Size = new System.Drawing.Size(355, 243);
            this.txtOtrzymywane.TabIndex = 16;
            this.txtOtrzymywane.Text = "";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.ForeColor = System.Drawing.Color.Black;
            this.txtLog.Location = new System.Drawing.Point(376, 126);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(96, 216);
            this.txtLog.TabIndex = 15;
            this.txtLog.TabStop = false;
            this.txtLog.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Log";
            // 
            // cmdWyslij
            // 
            this.cmdWyslij.BackColor = System.Drawing.Color.LemonChiffon;
            this.cmdWyslij.Enabled = false;
            this.cmdWyslij.Location = new System.Drawing.Point(278, 348);
            this.cmdWyslij.Name = "cmdWyslij";
            this.cmdWyslij.Size = new System.Drawing.Size(89, 32);
            this.cmdWyslij.TabIndex = 13;
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
            this.txtWysylane.TabIndex = 12;
            this.txtWysylane.Text = "";
            this.txtWysylane.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWysylane_KeyPress);
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
            this.progressBar1.Location = new System.Drawing.Point(376, 348);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(96, 31);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button1.Location = new System.Drawing.Point(182, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 32;
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
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // komunikatorToolStripMenuItem
            // 
            this.komunikatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacjeToolStripMenuItem,
            this.zakoñczToolStripMenuItem});
            this.komunikatorToolStripMenuItem.Name = "komunikatorToolStripMenuItem";
            this.komunikatorToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.komunikatorToolStripMenuItem.Text = "Komunikator";
            // 
            // informacjeToolStripMenuItem
            // 
            this.informacjeToolStripMenuItem.Name = "informacjeToolStripMenuItem";
            this.informacjeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.informacjeToolStripMenuItem.Text = "Informacje";
            // 
            // zakoñczToolStripMenuItem
            // 
            this.zakoñczToolStripMenuItem.Name = "zakoñczToolStripMenuItem";
            this.zakoñczToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zakoñczToolStripMenuItem.Text = "Zakoñcz";
            // 
            // frmSerwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(484, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cmdSluchaj);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOtrzymywane);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdWyslij);
            this.Controls.Add(this.txtWysylane);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmSerwer";
            this.Text = "Serwer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSerwer_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSluchaj;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtOtrzymywane;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdWyslij;
        private System.Windows.Forms.RichTextBox txtWysylane;
        private System.ComponentModel.BackgroundWorker Polaczenie;
        private System.ComponentModel.BackgroundWorker Odbieranie;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem komunikatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakoñczToolStripMenuItem;

    }
}

