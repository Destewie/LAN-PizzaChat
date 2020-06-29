namespace VisualChatClient
{
    partial class frmClient
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
            this.lblIPServer = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblBetweenIPandPort = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtMessaggio = new System.Windows.Forms.TextBox();
            this.grbFunzioni = new System.Windows.Forms.GroupBox();
            this.btnDisconnessione = new System.Windows.Forms.Button();
            this.grbConnessione = new System.Windows.Forms.GroupBox();
            this.btnConnessione = new System.Windows.Forms.Button();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.lblMessaggio = new System.Windows.Forms.Label();
            this.lblChat = new System.Windows.Forms.Label();
            this.btnInvio = new System.Windows.Forms.Button();
            this.grbFunzioni.SuspendLayout();
            this.grbConnessione.SuspendLayout();
            this.SuspendLayout();
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
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(275, 30);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 17);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
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
            this.txtPort.Text = "7979";
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
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(218, 50);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(178, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // txtMessaggio
            // 
            this.txtMessaggio.Enabled = false;
            this.txtMessaggio.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessaggio.Location = new System.Drawing.Point(12, 388);
            this.txtMessaggio.Multiline = true;
            this.txtMessaggio.Name = "txtMessaggio";
            this.txtMessaggio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessaggio.Size = new System.Drawing.Size(422, 66);
            this.txtMessaggio.TabIndex = 7;
            // 
            // grbFunzioni
            // 
            this.grbFunzioni.Controls.Add(this.btnDisconnessione);
            this.grbFunzioni.Location = new System.Drawing.Point(368, 111);
            this.grbFunzioni.Name = "grbFunzioni";
            this.grbFunzioni.Size = new System.Drawing.Size(153, 236);
            this.grbFunzioni.TabIndex = 8;
            this.grbFunzioni.TabStop = false;
            this.grbFunzioni.Text = "Funzioni";
            // 
            // btnDisconnessione
            // 
            this.btnDisconnessione.Enabled = false;
            this.btnDisconnessione.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnessione.Location = new System.Drawing.Point(26, 116);
            this.btnDisconnessione.Name = "btnDisconnessione";
            this.btnDisconnessione.Size = new System.Drawing.Size(97, 32);
            this.btnDisconnessione.TabIndex = 0;
            this.btnDisconnessione.Text = "Disconnessione";
            this.btnDisconnessione.UseVisualStyleBackColor = true;
            this.btnDisconnessione.Click += new System.EventHandler(this.btnDisconnessione_Click);
            // 
            // grbConnessione
            // 
            this.grbConnessione.Controls.Add(this.btnConnessione);
            this.grbConnessione.Controls.Add(this.lblIPServer);
            this.grbConnessione.Controls.Add(this.lblPort);
            this.grbConnessione.Controls.Add(this.txtIP);
            this.grbConnessione.Controls.Add(this.txtUsername);
            this.grbConnessione.Controls.Add(this.txtPort);
            this.grbConnessione.Controls.Add(this.lblUsername);
            this.grbConnessione.Controls.Add(this.lblBetweenIPandPort);
            this.grbConnessione.Location = new System.Drawing.Point(12, 12);
            this.grbConnessione.Name = "grbConnessione";
            this.grbConnessione.Size = new System.Drawing.Size(509, 93);
            this.grbConnessione.TabIndex = 9;
            this.grbConnessione.TabStop = false;
            this.grbConnessione.Text = "Connessione";
            // 
            // btnConnessione
            // 
            this.btnConnessione.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnessione.Location = new System.Drawing.Point(408, 30);
            this.btnConnessione.Name = "btnConnessione";
            this.btnConnessione.Size = new System.Drawing.Size(89, 40);
            this.btnConnessione.TabIndex = 13;
            this.btnConnessione.Text = "Connessione";
            this.btnConnessione.UseVisualStyleBackColor = true;
            this.btnConnessione.Click += new System.EventHandler(this.btnConnessione_Click);
            // 
            // txtChat
            // 
            this.txtChat.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChat.Location = new System.Drawing.Point(12, 139);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ReadOnly = true;
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChat.Size = new System.Drawing.Size(350, 208);
            this.txtChat.TabIndex = 10;
            // 
            // lblMessaggio
            // 
            this.lblMessaggio.AutoSize = true;
            this.lblMessaggio.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessaggio.Location = new System.Drawing.Point(12, 368);
            this.lblMessaggio.Name = "lblMessaggio";
            this.lblMessaggio.Size = new System.Drawing.Size(86, 17);
            this.lblMessaggio.TabIndex = 7;
            this.lblMessaggio.Text = "Messaggio:";
            // 
            // lblChat
            // 
            this.lblChat.AutoSize = true;
            this.lblChat.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChat.Location = new System.Drawing.Point(12, 119);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(42, 17);
            this.lblChat.TabIndex = 11;
            this.lblChat.Text = "Chat:";
            // 
            // btnInvio
            // 
            this.btnInvio.Enabled = false;
            this.btnInvio.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvio.Location = new System.Drawing.Point(440, 388);
            this.btnInvio.Name = "btnInvio";
            this.btnInvio.Size = new System.Drawing.Size(81, 66);
            this.btnInvio.TabIndex = 12;
            this.btnInvio.Text = "Invia";
            this.btnInvio.UseVisualStyleBackColor = true;
            this.btnInvio.Click += new System.EventHandler(this.btnInvio_Click);
            // 
            // frmClient
            // 
            this.AcceptButton = this.btnInvio;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 466);
            this.Controls.Add(this.btnInvio);
            this.Controls.Add(this.lblChat);
            this.Controls.Add(this.lblMessaggio);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.grbConnessione);
            this.Controls.Add(this.grbFunzioni);
            this.Controls.Add(this.txtMessaggio);
            this.Name = "frmClient";
            this.Text = "Client";
            this.grbFunzioni.ResumeLayout(false);
            this.grbConnessione.ResumeLayout(false);
            this.grbConnessione.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIPServer;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblBetweenIPandPort;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtMessaggio;
        private System.Windows.Forms.GroupBox grbFunzioni;
        private System.Windows.Forms.GroupBox grbConnessione;
        private System.Windows.Forms.Button btnDisconnessione;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Label lblMessaggio;
        private System.Windows.Forms.Label lblChat;
        private System.Windows.Forms.Button btnInvio;
        private System.Windows.Forms.Button btnConnessione;
    }
}

