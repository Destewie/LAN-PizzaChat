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
            this.btnChat = new System.Windows.Forms.Button();
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnDisconnessione = new System.Windows.Forms.Button();
            this.grbConnessione = new System.Windows.Forms.GroupBox();
            this.btnConnessione = new System.Windows.Forms.Button();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.lblMessaggio = new System.Windows.Forms.Label();
            this.lblChat = new System.Windows.Forms.Label();
            this.btnInvio = new System.Windows.Forms.Button();
            this.pnlOrdina = new System.Windows.Forms.Panel();
            this.cmbBibita = new System.Windows.Forms.ComboBox();
            this.cmbIngrediente2 = new System.Windows.Forms.ComboBox();
            this.cmbIngrediente1 = new System.Windows.Forms.ComboBox();
            this.lblBibita = new System.Windows.Forms.Label();
            this.lblGusto2 = new System.Windows.Forms.Label();
            this.lblGusto1 = new System.Windows.Forms.Label();
            this.lblPizza = new System.Windows.Forms.Label();
            this.btnOrdina = new System.Windows.Forms.Button();
            this.grbFunzioni.SuspendLayout();
            this.grbConnessione.SuspendLayout();
            this.pnlOrdina.SuspendLayout();
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
            this.txtIP.Text = "192.168.1.100";
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
            this.lblBetweenIPandPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetweenIPandPort.Location = new System.Drawing.Point(118, 53);
            this.lblBetweenIPandPort.Name = "lblBetweenIPandPort";
            this.lblBetweenIPandPort.Size = new System.Drawing.Size(11, 13);
            this.lblBetweenIPandPort.TabIndex = 5;
            this.lblBetweenIPandPort.Text = ":";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(218, 50);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(178, 20);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.Text = "Des";
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
            this.grbFunzioni.Controls.Add(this.btnChat);
            this.grbFunzioni.Controls.Add(this.btnPizza);
            this.grbFunzioni.Controls.Add(this.btnDisconnessione);
            this.grbFunzioni.Location = new System.Drawing.Point(368, 111);
            this.grbFunzioni.Name = "grbFunzioni";
            this.grbFunzioni.Size = new System.Drawing.Size(153, 236);
            this.grbFunzioni.TabIndex = 8;
            this.grbFunzioni.TabStop = false;
            this.grbFunzioni.Text = "Funzioni";
            // 
            // btnChat
            // 
            this.btnChat.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChat.Location = new System.Drawing.Point(27, 145);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(97, 32);
            this.btnChat.TabIndex = 2;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnPizza
            // 
            this.btnPizza.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPizza.Location = new System.Drawing.Point(27, 183);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(97, 32);
            this.btnPizza.TabIndex = 1;
            this.btnPizza.Text = "Pizza";
            this.btnPizza.UseVisualStyleBackColor = true;
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // btnDisconnessione
            // 
            this.btnDisconnessione.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnessione.Location = new System.Drawing.Point(27, 65);
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
            // pnlOrdina
            // 
            this.pnlOrdina.Controls.Add(this.cmbBibita);
            this.pnlOrdina.Controls.Add(this.cmbIngrediente2);
            this.pnlOrdina.Controls.Add(this.cmbIngrediente1);
            this.pnlOrdina.Controls.Add(this.lblBibita);
            this.pnlOrdina.Controls.Add(this.lblGusto2);
            this.pnlOrdina.Controls.Add(this.lblGusto1);
            this.pnlOrdina.Controls.Add(this.lblPizza);
            this.pnlOrdina.Controls.Add(this.btnOrdina);
            this.pnlOrdina.Location = new System.Drawing.Point(12, 111);
            this.pnlOrdina.Name = "pnlOrdina";
            this.pnlOrdina.Size = new System.Drawing.Size(361, 351);
            this.pnlOrdina.TabIndex = 13;
            // 
            // cmbBibita
            // 
            this.cmbBibita.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBibita.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBibita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBibita.FormattingEnabled = true;
            this.cmbBibita.Items.AddRange(new object[] {
            "Acqua frizzante",
            "Acqua naturale",
            "Coca Cola",
            "Fanta",
            "Sprite"});
            this.cmbBibita.Location = new System.Drawing.Point(121, 156);
            this.cmbBibita.Name = "cmbBibita";
            this.cmbBibita.Size = new System.Drawing.Size(140, 21);
            this.cmbBibita.TabIndex = 7;
            // 
            // cmbIngrediente2
            // 
            this.cmbIngrediente2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbIngrediente2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbIngrediente2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIngrediente2.FormattingEnabled = true;
            this.cmbIngrediente2.Items.AddRange(new object[] {
            "NULL",
            "Acciughe",
            "Brie",
            "Capperi",
            "Carciofi",
            "Cipolla",
            "Funghi",
            "Olive",
            "Pancetta",
            "Patate al forno",
            "Patatine fritte",
            "Pomodorini",
            "Prosciutto cotto",
            "Prosciutto crudo",
            "Salsiccia",
            "Salamino",
            "Speck",
            "Tonno",
            "Würstel"});
            this.cmbIngrediente2.Location = new System.Drawing.Point(121, 107);
            this.cmbIngrediente2.Name = "cmbIngrediente2";
            this.cmbIngrediente2.Size = new System.Drawing.Size(140, 21);
            this.cmbIngrediente2.TabIndex = 6;
            // 
            // cmbIngrediente1
            // 
            this.cmbIngrediente1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbIngrediente1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbIngrediente1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIngrediente1.FormattingEnabled = true;
            this.cmbIngrediente1.Items.AddRange(new object[] {
            "NULL (Margherita)",
            "Acciughe",
            "Brie",
            "Capperi",
            "Carciofi",
            "Cipolla",
            "Funghi",
            "Olive",
            "Pancetta",
            "Patate al forno",
            "Patatine fritte",
            "Pomodorini",
            "Prosciutto cotto",
            "Prosciutto crudo",
            "Quattro Formaggi",
            "Salsiccia",
            "Salamino",
            "Speck",
            "Tonno",
            "Würstel"});
            this.cmbIngrediente1.Location = new System.Drawing.Point(121, 76);
            this.cmbIngrediente1.Name = "cmbIngrediente1";
            this.cmbIngrediente1.Size = new System.Drawing.Size(140, 21);
            this.cmbIngrediente1.TabIndex = 5;
            this.cmbIngrediente1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblBibita
            // 
            this.lblBibita.AutoSize = true;
            this.lblBibita.Location = new System.Drawing.Point(54, 159);
            this.lblBibita.Name = "lblBibita";
            this.lblBibita.Size = new System.Drawing.Size(36, 13);
            this.lblBibita.TabIndex = 4;
            this.lblBibita.Text = "Bibita:";
            // 
            // lblGusto2
            // 
            this.lblGusto2.AutoSize = true;
            this.lblGusto2.Location = new System.Drawing.Point(54, 110);
            this.lblGusto2.Name = "lblGusto2";
            this.lblGusto2.Size = new System.Drawing.Size(47, 13);
            this.lblGusto2.TabIndex = 3;
            this.lblGusto2.Text = "Gusto 2:";
            // 
            // lblGusto1
            // 
            this.lblGusto1.AutoSize = true;
            this.lblGusto1.Location = new System.Drawing.Point(54, 79);
            this.lblGusto1.Name = "lblGusto1";
            this.lblGusto1.Size = new System.Drawing.Size(47, 13);
            this.lblGusto1.TabIndex = 2;
            this.lblGusto1.Text = "Gusto 1:";
            // 
            // lblPizza
            // 
            this.lblPizza.AutoSize = true;
            this.lblPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizza.Location = new System.Drawing.Point(51, 28);
            this.lblPizza.Name = "lblPizza";
            this.lblPizza.Size = new System.Drawing.Size(222, 20);
            this.lblPizza.TabIndex = 1;
            this.lblPizza.Text = "COSTRUISCI LA TUA PIZZA!";
            // 
            // btnOrdina
            // 
            this.btnOrdina.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdina.Location = new System.Drawing.Point(112, 286);
            this.btnOrdina.Name = "btnOrdina";
            this.btnOrdina.Size = new System.Drawing.Size(114, 48);
            this.btnOrdina.TabIndex = 0;
            this.btnOrdina.Text = "Ordina";
            this.btnOrdina.UseVisualStyleBackColor = true;
            this.btnOrdina.Click += new System.EventHandler(this.btnOrdina_Click);
            // 
            // frmClient
            // 
            this.AcceptButton = this.btnInvio;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 466);
            this.Controls.Add(this.lblChat);
            this.Controls.Add(this.lblMessaggio);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.grbConnessione);
            this.Controls.Add(this.grbFunzioni);
            this.Controls.Add(this.txtMessaggio);
            this.Controls.Add(this.btnInvio);
            this.Controls.Add(this.pnlOrdina);
            this.Name = "frmClient";
            this.Text = "Client";
            this.grbFunzioni.ResumeLayout(false);
            this.grbConnessione.ResumeLayout(false);
            this.grbConnessione.PerformLayout();
            this.pnlOrdina.ResumeLayout(false);
            this.pnlOrdina.PerformLayout();
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
        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Panel pnlOrdina;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Button btnOrdina;
        private System.Windows.Forms.ComboBox cmbIngrediente1;
        private System.Windows.Forms.Label lblBibita;
        private System.Windows.Forms.Label lblGusto2;
        private System.Windows.Forms.Label lblGusto1;
        private System.Windows.Forms.Label lblPizza;
        private System.Windows.Forms.ComboBox cmbIngrediente2;
        private System.Windows.Forms.ComboBox cmbBibita;
    }
}

