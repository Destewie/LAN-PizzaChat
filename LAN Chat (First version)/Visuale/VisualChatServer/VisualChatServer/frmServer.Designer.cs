namespace VisualChatServer
{
    partial class frmServer
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtChat = new System.Windows.Forms.TextBox();
            this.grbAvvio = new System.Windows.Forms.GroupBox();
            this.btnAvvio = new System.Windows.Forms.Button();
            this.lblIPServer = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblBetweenIPandPort = new System.Windows.Forms.Label();
            this.grbFunzioni = new System.Windows.Forms.GroupBox();
            this.btnDisconnettiTutti = new System.Windows.Forms.Button();
            this.btnInvio = new System.Windows.Forms.Button();
            this.lblChat = new System.Windows.Forms.Label();
            this.lblMessaggio = new System.Windows.Forms.Label();
            this.txtMessaggio = new System.Windows.Forms.TextBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indirizzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeUtente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbAvvio.SuspendLayout();
            this.grbFunzioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtChat
            // 
            this.txtChat.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChat.Location = new System.Drawing.Point(38, 147);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ReadOnly = true;
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChat.Size = new System.Drawing.Size(634, 300);
            this.txtChat.TabIndex = 11;
            // 
            // grbAvvio
            // 
            this.grbAvvio.Controls.Add(this.btnAvvio);
            this.grbAvvio.Controls.Add(this.lblIPServer);
            this.grbAvvio.Controls.Add(this.lblPort);
            this.grbAvvio.Controls.Add(this.txtIP);
            this.grbAvvio.Controls.Add(this.txtPort);
            this.grbAvvio.Controls.Add(this.lblBetweenIPandPort);
            this.grbAvvio.Location = new System.Drawing.Point(38, 18);
            this.grbAvvio.Name = "grbAvvio";
            this.grbAvvio.Size = new System.Drawing.Size(337, 93);
            this.grbAvvio.TabIndex = 12;
            this.grbAvvio.TabStop = false;
            this.grbAvvio.Text = "Avvio";
            // 
            // btnAvvio
            // 
            this.btnAvvio.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvvio.Location = new System.Drawing.Point(220, 30);
            this.btnAvvio.Name = "btnAvvio";
            this.btnAvvio.Size = new System.Drawing.Size(89, 40);
            this.btnAvvio.TabIndex = 13;
            this.btnAvvio.Text = "Avvio server";
            this.btnAvvio.UseVisualStyleBackColor = true;
            this.btnAvvio.Click += new System.EventHandler(this.btnAvvio_Click);
            // 
            // lblIPServer
            // 
            this.lblIPServer.AutoSize = true;
            this.lblIPServer.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPServer.Location = new System.Drawing.Point(32, 30);
            this.lblIPServer.Name = "lblIPServer";
            this.lblIPServer.Size = new System.Drawing.Size(68, 17);
            this.lblIPServer.TabIndex = 0;
            this.lblIPServer.Text = "Server IP";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(145, 30);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(36, 17);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(22, 50);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(90, 20);
            this.txtIP.TabIndex = 3;
            this.txtIP.Text = "192.168.1.2";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(134, 50);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(60, 20);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "8881";
            // 
            // lblBetweenIPandPort
            // 
            this.lblBetweenIPandPort.AutoSize = true;
            this.lblBetweenIPandPort.Font = new System.Drawing.Font("Prestige Elite Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetweenIPandPort.Location = new System.Drawing.Point(118, 53);
            this.lblBetweenIPandPort.Name = "lblBetweenIPandPort";
            this.lblBetweenIPandPort.Size = new System.Drawing.Size(12, 12);
            this.lblBetweenIPandPort.TabIndex = 5;
            this.lblBetweenIPandPort.Text = ":";
            // 
            // grbFunzioni
            // 
            this.grbFunzioni.Controls.Add(this.btnDisconnettiTutti);
            this.grbFunzioni.Location = new System.Drawing.Point(390, 18);
            this.grbFunzioni.Name = "grbFunzioni";
            this.grbFunzioni.Size = new System.Drawing.Size(647, 93);
            this.grbFunzioni.TabIndex = 13;
            this.grbFunzioni.TabStop = false;
            this.grbFunzioni.Text = "Funzioni";
            // 
            // btnDisconnettiTutti
            // 
            this.btnDisconnettiTutti.Enabled = false;
            this.btnDisconnettiTutti.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnettiTutti.Location = new System.Drawing.Point(17, 30);
            this.btnDisconnettiTutti.Name = "btnDisconnettiTutti";
            this.btnDisconnettiTutti.Size = new System.Drawing.Size(108, 40);
            this.btnDisconnettiTutti.TabIndex = 0;
            this.btnDisconnettiTutti.Text = "Disconnetti tutti";
            this.btnDisconnettiTutti.UseVisualStyleBackColor = true;
            this.btnDisconnettiTutti.Click += new System.EventHandler(this.btnDisconnettiTutti_Click);
            // 
            // btnInvio
            // 
            this.btnInvio.Enabled = false;
            this.btnInvio.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvio.Location = new System.Drawing.Point(591, 490);
            this.btnInvio.Name = "btnInvio";
            this.btnInvio.Size = new System.Drawing.Size(81, 86);
            this.btnInvio.TabIndex = 17;
            this.btnInvio.Text = "Invia";
            this.btnInvio.UseVisualStyleBackColor = true;
            this.btnInvio.Click += new System.EventHandler(this.btnInvio_Click);
            // 
            // lblChat
            // 
            this.lblChat.AutoSize = true;
            this.lblChat.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChat.Location = new System.Drawing.Point(35, 127);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(42, 17);
            this.lblChat.TabIndex = 16;
            this.lblChat.Text = "Chat:";
            // 
            // lblMessaggio
            // 
            this.lblMessaggio.AutoSize = true;
            this.lblMessaggio.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessaggio.Location = new System.Drawing.Point(35, 470);
            this.lblMessaggio.Name = "lblMessaggio";
            this.lblMessaggio.Size = new System.Drawing.Size(86, 17);
            this.lblMessaggio.TabIndex = 14;
            this.lblMessaggio.Text = "Messaggio:";
            // 
            // txtMessaggio
            // 
            this.txtMessaggio.Enabled = false;
            this.txtMessaggio.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessaggio.Location = new System.Drawing.Point(38, 490);
            this.txtMessaggio.Multiline = true;
            this.txtMessaggio.Name = "txtMessaggio";
            this.txtMessaggio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessaggio.Size = new System.Drawing.Size(547, 86);
            this.txtMessaggio.TabIndex = 15;
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHost.Location = new System.Drawing.Point(699, 127);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(43, 17);
            this.lblHost.TabIndex = 18;
            this.lblHost.Text = "Host:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumClient,
            this.Indirizzo,
            this.NomeUtente});
            this.dataGridView1.Location = new System.Drawing.Point(702, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(335, 428);
            this.dataGridView1.TabIndex = 19;
            // 
            // NumClient
            // 
            this.NumClient.FillWeight = 45.68528F;
            this.NumClient.HeaderText = "N";
            this.NumClient.Name = "NumClient";
            this.NumClient.ReadOnly = true;
            // 
            // Indirizzo
            // 
            this.Indirizzo.FillWeight = 94.23845F;
            this.Indirizzo.HeaderText = "Indirizzo";
            this.Indirizzo.Name = "Indirizzo";
            this.Indirizzo.ReadOnly = true;
            // 
            // NomeUtente
            // 
            this.NomeUtente.FillWeight = 160.0762F;
            this.NomeUtente.HeaderText = "Nome Utente";
            this.NomeUtente.Name = "NomeUtente";
            this.NomeUtente.ReadOnly = true;
            // 
            // frmServer
            // 
            this.AcceptButton = this.btnInvio;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 602);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.btnInvio);
            this.Controls.Add(this.lblChat);
            this.Controls.Add(this.lblMessaggio);
            this.Controls.Add(this.txtMessaggio);
            this.Controls.Add(this.grbFunzioni);
            this.Controls.Add(this.grbAvvio);
            this.Controls.Add(this.txtChat);
            this.Name = "frmServer";
            this.Text = "Server";
            this.grbAvvio.ResumeLayout(false);
            this.grbAvvio.PerformLayout();
            this.grbFunzioni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.GroupBox grbAvvio;
        private System.Windows.Forms.Button btnAvvio;
        private System.Windows.Forms.Label lblIPServer;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblBetweenIPandPort;
        private System.Windows.Forms.GroupBox grbFunzioni;
        private System.Windows.Forms.Button btnDisconnettiTutti;
        private System.Windows.Forms.Button btnInvio;
        private System.Windows.Forms.Label lblChat;
        private System.Windows.Forms.Label lblMessaggio;
        private System.Windows.Forms.TextBox txtMessaggio;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indirizzo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeUtente;
    }
}

