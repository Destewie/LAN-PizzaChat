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
            this.grbAvvio = new System.Windows.Forms.GroupBox();
            this.btnAvvio = new System.Windows.Forms.Button();
            this.lblIPServer = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblBetweenIPandPort = new System.Windows.Forms.Label();
            this.grbVistePrincipali = new System.Windows.Forms.GroupBox();
            this.btnChat = new System.Windows.Forms.Button();
            this.btnGestione = new System.Windows.Forms.Button();
            this.btnDisconnettiTutti = new System.Windows.Forms.Button();
            this.btnHost = new System.Windows.Forms.Button();
            this.btnPizze = new System.Windows.Forms.Button();
            this.dgvHost = new System.Windows.Forms.DataGridView();
            this.NumHost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeUtente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SocketClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPagamenti = new System.Windows.Forms.Panel();
            this.grbGestioneHost = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbGestHost = new System.Windows.Forms.ComboBox();
            this.grbGestioneOrdine = new System.Windows.Forms.GroupBox();
            this.btnEliminaTuttiOrdini = new System.Windows.Forms.Button();
            this.lblNomeOrdine = new System.Windows.Forms.Label();
            this.txtNomeOrdine = new System.Windows.Forms.TextBox();
            this.lblLuogo = new System.Windows.Forms.Label();
            this.lblOraOrdine = new System.Windows.Forms.Label();
            this.lblScuolaOrdine = new System.Windows.Forms.Label();
            this.txtOraOrdine = new System.Windows.Forms.TextBox();
            this.txtScuolaOrdine = new System.Windows.Forms.TextBox();
            this.btnPagato = new System.Windows.Forms.Button();
            this.btnEliminaOrdine = new System.Windows.Forms.Button();
            this.cmbGestPizze = new System.Windows.Forms.ComboBox();
            this.btnStampa = new System.Windows.Forms.Button();
            this.btnInvio = new System.Windows.Forms.Button();
            this.lblChat = new System.Windows.Forms.Label();
            this.lblMessaggio = new System.Windows.Forms.Label();
            this.txtMessaggio = new System.Windows.Forms.TextBox();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.grbVisualizzazioneDGV = new System.Windows.Forms.GroupBox();
            this.lblHostPizze = new System.Windows.Forms.Label();
            this.dgvPizze = new System.Windows.Forms.DataGridView();
            this.NumOrdine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PizzaClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BibitaClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDM = new System.Windows.Forms.Button();
            this.grbAvvio.SuspendLayout();
            this.grbVistePrincipali.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHost)).BeginInit();
            this.pnlPagamenti.SuspendLayout();
            this.grbGestioneHost.SuspendLayout();
            this.grbGestioneOrdine.SuspendLayout();
            this.grbVisualizzazioneDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizze)).BeginInit();
            this.SuspendLayout();
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
            this.txtIP.Text = "192.168.1.31";
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
            // grbVistePrincipali
            // 
            this.grbVistePrincipali.Controls.Add(this.btnChat);
            this.grbVistePrincipali.Controls.Add(this.btnGestione);
            this.grbVistePrincipali.Enabled = false;
            this.grbVistePrincipali.Location = new System.Drawing.Point(390, 18);
            this.grbVistePrincipali.Name = "grbVistePrincipali";
            this.grbVistePrincipali.Size = new System.Drawing.Size(303, 93);
            this.grbVistePrincipali.TabIndex = 13;
            this.grbVistePrincipali.TabStop = false;
            this.grbVistePrincipali.Text = "Viste principali";
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(48, 30);
            this.btnChat.Margin = new System.Windows.Forms.Padding(2);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(99, 40);
            this.btnChat.TabIndex = 2;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnGestione
            // 
            this.btnGestione.Location = new System.Drawing.Point(161, 31);
            this.btnGestione.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestione.Name = "btnGestione";
            this.btnGestione.Size = new System.Drawing.Size(99, 40);
            this.btnGestione.TabIndex = 1;
            this.btnGestione.Text = "Gestione Pizze/Host";
            this.btnGestione.UseVisualStyleBackColor = true;
            this.btnGestione.Click += new System.EventHandler(this.btnGestione_Click);
            // 
            // btnDisconnettiTutti
            // 
            this.btnDisconnettiTutti.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnettiTutti.Location = new System.Drawing.Point(29, 193);
            this.btnDisconnettiTutti.Name = "btnDisconnettiTutti";
            this.btnDisconnettiTutti.Size = new System.Drawing.Size(231, 37);
            this.btnDisconnettiTutti.TabIndex = 0;
            this.btnDisconnettiTutti.Text = "Disconnetti tutti gli host";
            this.btnDisconnettiTutti.UseVisualStyleBackColor = true;
            this.btnDisconnettiTutti.Click += new System.EventHandler(this.btnDisconnettiTutti_Click);
            // 
            // btnHost
            // 
            this.btnHost.Location = new System.Drawing.Point(261, 31);
            this.btnHost.Name = "btnHost";
            this.btnHost.Size = new System.Drawing.Size(99, 39);
            this.btnHost.TabIndex = 21;
            this.btnHost.Text = "ONLINE HOSTS";
            this.btnHost.UseVisualStyleBackColor = true;
            this.btnHost.Click += new System.EventHandler(this.btnHost_Click);
            // 
            // btnPizze
            // 
            this.btnPizze.Location = new System.Drawing.Point(94, 30);
            this.btnPizze.Name = "btnPizze";
            this.btnPizze.Size = new System.Drawing.Size(99, 40);
            this.btnPizze.TabIndex = 20;
            this.btnPizze.Text = "ORDINI";
            this.btnPizze.UseVisualStyleBackColor = true;
            this.btnPizze.Click += new System.EventHandler(this.btnPizze_Click);
            // 
            // dgvHost
            // 
            this.dgvHost.AllowUserToAddRows = false;
            this.dgvHost.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumHost,
            this.NomeUtente,
            this.SocketClient});
            this.dgvHost.Location = new System.Drawing.Point(14, 119);
            this.dgvHost.Name = "dgvHost";
            this.dgvHost.ReadOnly = true;
            this.dgvHost.RowHeadersVisible = false;
            this.dgvHost.Size = new System.Drawing.Size(410, 440);
            this.dgvHost.TabIndex = 19;
            // 
            // NumHost
            // 
            this.NumHost.FillWeight = 39.56813F;
            this.NumHost.HeaderText = "N";
            this.NumHost.Name = "NumHost";
            this.NumHost.ReadOnly = true;
            // 
            // NomeUtente
            // 
            this.NomeUtente.FillWeight = 159.7698F;
            this.NomeUtente.HeaderText = "Nome Utente";
            this.NomeUtente.Name = "NomeUtente";
            this.NomeUtente.ReadOnly = true;
            // 
            // SocketClient
            // 
            this.SocketClient.FillWeight = 154.9767F;
            this.SocketClient.HeaderText = "Socket";
            this.SocketClient.Name = "SocketClient";
            this.SocketClient.ReadOnly = true;
            // 
            // pnlPagamenti
            // 
            this.pnlPagamenti.Controls.Add(this.grbGestioneHost);
            this.pnlPagamenti.Controls.Add(this.grbGestioneOrdine);
            this.pnlPagamenti.Location = new System.Drawing.Point(32, 117);
            this.pnlPagamenti.Name = "pnlPagamenti";
            this.pnlPagamenti.Size = new System.Drawing.Size(661, 473);
            this.pnlPagamenti.TabIndex = 29;
            // 
            // grbGestioneHost
            // 
            this.grbGestioneHost.Controls.Add(this.btnDM);
            this.grbGestioneHost.Controls.Add(this.button1);
            this.grbGestioneHost.Controls.Add(this.btnDisconnettiTutti);
            this.grbGestioneHost.Controls.Add(this.cmbGestHost);
            this.grbGestioneHost.Location = new System.Drawing.Point(358, 20);
            this.grbGestioneHost.Margin = new System.Windows.Forms.Padding(2);
            this.grbGestioneHost.Name = "grbGestioneHost";
            this.grbGestioneHost.Padding = new System.Windows.Forms.Padding(2);
            this.grbGestioneHost.Size = new System.Drawing.Size(282, 440);
            this.grbGestioneHost.TabIndex = 41;
            this.grbGestioneHost.TabStop = false;
            this.grbGestioneHost.Text = "Gestione host";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 114);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 37);
            this.button1.TabIndex = 48;
            this.button1.Text = "Disconnetti questo host";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbGestHost
            // 
            this.cmbGestHost.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGestHost.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGestHost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGestHost.FormattingEnabled = true;
            this.cmbGestHost.Location = new System.Drawing.Point(29, 57);
            this.cmbGestHost.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGestHost.Name = "cmbGestHost";
            this.cmbGestHost.Size = new System.Drawing.Size(231, 21);
            this.cmbGestHost.TabIndex = 39;
            // 
            // grbGestioneOrdine
            // 
            this.grbGestioneOrdine.Controls.Add(this.btnEliminaTuttiOrdini);
            this.grbGestioneOrdine.Controls.Add(this.lblNomeOrdine);
            this.grbGestioneOrdine.Controls.Add(this.txtNomeOrdine);
            this.grbGestioneOrdine.Controls.Add(this.lblLuogo);
            this.grbGestioneOrdine.Controls.Add(this.lblOraOrdine);
            this.grbGestioneOrdine.Controls.Add(this.lblScuolaOrdine);
            this.grbGestioneOrdine.Controls.Add(this.txtOraOrdine);
            this.grbGestioneOrdine.Controls.Add(this.txtScuolaOrdine);
            this.grbGestioneOrdine.Controls.Add(this.btnPagato);
            this.grbGestioneOrdine.Controls.Add(this.btnEliminaOrdine);
            this.grbGestioneOrdine.Controls.Add(this.cmbGestPizze);
            this.grbGestioneOrdine.Controls.Add(this.btnStampa);
            this.grbGestioneOrdine.Location = new System.Drawing.Point(28, 20);
            this.grbGestioneOrdine.Margin = new System.Windows.Forms.Padding(2);
            this.grbGestioneOrdine.Name = "grbGestioneOrdine";
            this.grbGestioneOrdine.Padding = new System.Windows.Forms.Padding(2);
            this.grbGestioneOrdine.Size = new System.Drawing.Size(306, 440);
            this.grbGestioneOrdine.TabIndex = 40;
            this.grbGestioneOrdine.TabStop = false;
            this.grbGestioneOrdine.Text = "Gestione ordine pizze";
            // 
            // btnEliminaTuttiOrdini
            // 
            this.btnEliminaTuttiOrdini.Location = new System.Drawing.Point(32, 132);
            this.btnEliminaTuttiOrdini.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminaTuttiOrdini.Name = "btnEliminaTuttiOrdini";
            this.btnEliminaTuttiOrdini.Size = new System.Drawing.Size(244, 37);
            this.btnEliminaTuttiOrdini.TabIndex = 47;
            this.btnEliminaTuttiOrdini.Text = "Elimina tutti gli ordini";
            this.btnEliminaTuttiOrdini.UseVisualStyleBackColor = true;
            this.btnEliminaTuttiOrdini.Click += new System.EventHandler(this.btnEliminaTuttiOrdini_Click);
            // 
            // lblNomeOrdine
            // 
            this.lblNomeOrdine.AutoSize = true;
            this.lblNomeOrdine.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeOrdine.Location = new System.Drawing.Point(20, 341);
            this.lblNomeOrdine.Name = "lblNomeOrdine";
            this.lblNomeOrdine.Size = new System.Drawing.Size(52, 17);
            this.lblNomeOrdine.TabIndex = 45;
            this.lblNomeOrdine.Text = "Nome:";
            // 
            // txtNomeOrdine
            // 
            this.txtNomeOrdine.Location = new System.Drawing.Point(78, 341);
            this.txtNomeOrdine.Name = "txtNomeOrdine";
            this.txtNomeOrdine.Size = new System.Drawing.Size(78, 20);
            this.txtNomeOrdine.TabIndex = 46;
            this.txtNomeOrdine.Text = "De Santi";
            // 
            // lblLuogo
            // 
            this.lblLuogo.AutoSize = true;
            this.lblLuogo.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuogo.Location = new System.Drawing.Point(15, 307);
            this.lblLuogo.Name = "lblLuogo";
            this.lblLuogo.Size = new System.Drawing.Size(144, 20);
            this.lblLuogo.TabIndex = 44;
            this.lblLuogo.Text = "Dove ve le porto?";
            // 
            // lblOraOrdine
            // 
            this.lblOraOrdine.AutoSize = true;
            this.lblOraOrdine.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOraOrdine.Location = new System.Drawing.Point(35, 393);
            this.lblOraOrdine.Name = "lblOraOrdine";
            this.lblOraOrdine.Size = new System.Drawing.Size(37, 17);
            this.lblOraOrdine.TabIndex = 43;
            this.lblOraOrdine.Text = "Ora:";
            // 
            // lblScuolaOrdine
            // 
            this.lblScuolaOrdine.AutoSize = true;
            this.lblScuolaOrdine.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScuolaOrdine.Location = new System.Drawing.Point(16, 367);
            this.lblScuolaOrdine.Name = "lblScuolaOrdine";
            this.lblScuolaOrdine.Size = new System.Drawing.Size(56, 17);
            this.lblScuolaOrdine.TabIndex = 14;
            this.lblScuolaOrdine.Text = "Scuola:";
            // 
            // txtOraOrdine
            // 
            this.txtOraOrdine.Location = new System.Drawing.Point(78, 393);
            this.txtOraOrdine.Name = "txtOraOrdine";
            this.txtOraOrdine.Size = new System.Drawing.Size(78, 20);
            this.txtOraOrdine.TabIndex = 42;
            this.txtOraOrdine.Text = "13:10";
            // 
            // txtScuolaOrdine
            // 
            this.txtScuolaOrdine.Location = new System.Drawing.Point(78, 367);
            this.txtScuolaOrdine.Name = "txtScuolaOrdine";
            this.txtScuolaOrdine.Size = new System.Drawing.Size(78, 20);
            this.txtScuolaOrdine.TabIndex = 14;
            this.txtScuolaOrdine.Text = "ITST Kennedy";
            // 
            // btnPagato
            // 
            this.btnPagato.Location = new System.Drawing.Point(32, 82);
            this.btnPagato.Margin = new System.Windows.Forms.Padding(2);
            this.btnPagato.Name = "btnPagato";
            this.btnPagato.Size = new System.Drawing.Size(114, 37);
            this.btnPagato.TabIndex = 40;
            this.btnPagato.Text = "Ha pagato";
            this.btnPagato.UseVisualStyleBackColor = true;
            // 
            // btnEliminaOrdine
            // 
            this.btnEliminaOrdine.Location = new System.Drawing.Point(165, 82);
            this.btnEliminaOrdine.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminaOrdine.Name = "btnEliminaOrdine";
            this.btnEliminaOrdine.Size = new System.Drawing.Size(111, 37);
            this.btnEliminaOrdine.TabIndex = 41;
            this.btnEliminaOrdine.Text = "Elimina singolo ordine";
            this.btnEliminaOrdine.UseVisualStyleBackColor = true;
            // 
            // cmbGestPizze
            // 
            this.cmbGestPizze.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGestPizze.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGestPizze.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGestPizze.FormattingEnabled = true;
            this.cmbGestPizze.Location = new System.Drawing.Point(32, 57);
            this.cmbGestPizze.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGestPizze.Name = "cmbGestPizze";
            this.cmbGestPizze.Size = new System.Drawing.Size(244, 21);
            this.cmbGestPizze.TabIndex = 39;
            // 
            // btnStampa
            // 
            this.btnStampa.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStampa.Location = new System.Drawing.Point(186, 307);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(101, 115);
            this.btnStampa.TabIndex = 38;
            this.btnStampa.Text = "Stampa ordine complessivo";
            this.btnStampa.UseVisualStyleBackColor = true;
            this.btnStampa.Click += new System.EventHandler(this.btnStampa_Click);
            // 
            // btnInvio
            // 
            this.btnInvio.Enabled = false;
            this.btnInvio.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvio.Location = new System.Drawing.Point(591, 491);
            this.btnInvio.Name = "btnInvio";
            this.btnInvio.Size = new System.Drawing.Size(81, 86);
            this.btnInvio.TabIndex = 37;
            this.btnInvio.Text = "Invia";
            this.btnInvio.UseVisualStyleBackColor = true;
            this.btnInvio.Click += new System.EventHandler(this.btnInvio_Click);
            // 
            // lblChat
            // 
            this.lblChat.AutoSize = true;
            this.lblChat.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChat.Location = new System.Drawing.Point(35, 128);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(42, 17);
            this.lblChat.TabIndex = 36;
            this.lblChat.Text = "Chat:";
            // 
            // lblMessaggio
            // 
            this.lblMessaggio.AutoSize = true;
            this.lblMessaggio.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessaggio.Location = new System.Drawing.Point(35, 471);
            this.lblMessaggio.Name = "lblMessaggio";
            this.lblMessaggio.Size = new System.Drawing.Size(86, 17);
            this.lblMessaggio.TabIndex = 34;
            this.lblMessaggio.Text = "Messaggio:";
            // 
            // txtMessaggio
            // 
            this.txtMessaggio.Enabled = false;
            this.txtMessaggio.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessaggio.Location = new System.Drawing.Point(38, 491);
            this.txtMessaggio.Multiline = true;
            this.txtMessaggio.Name = "txtMessaggio";
            this.txtMessaggio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessaggio.Size = new System.Drawing.Size(547, 86);
            this.txtMessaggio.TabIndex = 35;
            // 
            // txtChat
            // 
            this.txtChat.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChat.Location = new System.Drawing.Point(38, 148);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ReadOnly = true;
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChat.Size = new System.Drawing.Size(634, 300);
            this.txtChat.TabIndex = 33;
            // 
            // grbVisualizzazioneDGV
            // 
            this.grbVisualizzazioneDGV.Controls.Add(this.lblHostPizze);
            this.grbVisualizzazioneDGV.Controls.Add(this.btnPizze);
            this.grbVisualizzazioneDGV.Controls.Add(this.btnHost);
            this.grbVisualizzazioneDGV.Controls.Add(this.dgvPizze);
            this.grbVisualizzazioneDGV.Controls.Add(this.dgvHost);
            this.grbVisualizzazioneDGV.Enabled = false;
            this.grbVisualizzazioneDGV.Location = new System.Drawing.Point(702, 18);
            this.grbVisualizzazioneDGV.Name = "grbVisualizzazioneDGV";
            this.grbVisualizzazioneDGV.Size = new System.Drawing.Size(439, 572);
            this.grbVisualizzazioneDGV.TabIndex = 23;
            this.grbVisualizzazioneDGV.TabStop = false;
            this.grbVisualizzazioneDGV.Text = "Visualizzazione DGV";
            // 
            // lblHostPizze
            // 
            this.lblHostPizze.AutoSize = true;
            this.lblHostPizze.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostPizze.Location = new System.Drawing.Point(11, 99);
            this.lblHostPizze.Name = "lblHostPizze";
            this.lblHostPizze.Size = new System.Drawing.Size(89, 17);
            this.lblHostPizze.TabIndex = 22;
            this.lblHostPizze.Text = "Host / Pizze";
            // 
            // dgvPizze
            // 
            this.dgvPizze.AllowUserToAddRows = false;
            this.dgvPizze.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPizze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPizze.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumOrdine,
            this.NomeClient,
            this.PizzaClient,
            this.BibitaClient,
            this.Pagato});
            this.dgvPizze.Location = new System.Drawing.Point(14, 119);
            this.dgvPizze.Name = "dgvPizze";
            this.dgvPizze.ReadOnly = true;
            this.dgvPizze.RowHeadersVisible = false;
            this.dgvPizze.Size = new System.Drawing.Size(410, 440);
            this.dgvPizze.TabIndex = 23;
            // 
            // NumOrdine
            // 
            this.NumOrdine.FillWeight = 48.22335F;
            this.NumOrdine.HeaderText = "N";
            this.NumOrdine.Name = "NumOrdine";
            this.NumOrdine.ReadOnly = true;
            // 
            // NomeClient
            // 
            this.NomeClient.FillWeight = 112.0079F;
            this.NomeClient.HeaderText = "Nome";
            this.NomeClient.Name = "NomeClient";
            this.NomeClient.ReadOnly = true;
            // 
            // PizzaClient
            // 
            this.PizzaClient.FillWeight = 164.0475F;
            this.PizzaClient.HeaderText = "Pizza";
            this.PizzaClient.Name = "PizzaClient";
            this.PizzaClient.ReadOnly = true;
            // 
            // BibitaClient
            // 
            this.BibitaClient.FillWeight = 106.9228F;
            this.BibitaClient.HeaderText = "Bibita";
            this.BibitaClient.Name = "BibitaClient";
            this.BibitaClient.ReadOnly = true;
            // 
            // Pagato
            // 
            this.Pagato.FillWeight = 68.79847F;
            this.Pagato.HeaderText = "Pagato";
            this.Pagato.Name = "Pagato";
            this.Pagato.ReadOnly = true;
            // 
            // btnDM
            // 
            this.btnDM.Location = new System.Drawing.Point(149, 114);
            this.btnDM.Margin = new System.Windows.Forms.Padding(2);
            this.btnDM.Name = "btnDM";
            this.btnDM.Size = new System.Drawing.Size(111, 37);
            this.btnDM.TabIndex = 49;
            this.btnDM.Text = "Messaggio privato";
            this.btnDM.UseVisualStyleBackColor = true;
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 602);
            this.Controls.Add(this.pnlPagamenti);
            this.Controls.Add(this.grbVisualizzazioneDGV);
            this.Controls.Add(this.btnInvio);
            this.Controls.Add(this.lblChat);
            this.Controls.Add(this.lblMessaggio);
            this.Controls.Add(this.txtMessaggio);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.grbVistePrincipali);
            this.Controls.Add(this.grbAvvio);
            this.Name = "frmServer";
            this.Text = "Server";
            this.grbAvvio.ResumeLayout(false);
            this.grbAvvio.PerformLayout();
            this.grbVistePrincipali.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHost)).EndInit();
            this.pnlPagamenti.ResumeLayout(false);
            this.grbGestioneHost.ResumeLayout(false);
            this.grbGestioneOrdine.ResumeLayout(false);
            this.grbGestioneOrdine.PerformLayout();
            this.grbVisualizzazioneDGV.ResumeLayout(false);
            this.grbVisualizzazioneDGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbAvvio;
        private System.Windows.Forms.Button btnAvvio;
        private System.Windows.Forms.Label lblIPServer;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblBetweenIPandPort;
        private System.Windows.Forms.GroupBox grbVistePrincipali;
        private System.Windows.Forms.Button btnDisconnettiTutti;
        private System.Windows.Forms.DataGridView dgvHost;
        private System.Windows.Forms.Button btnHost;
        private System.Windows.Forms.Button btnPizze;
        private System.Windows.Forms.Panel pnlPagamenti;
        private System.Windows.Forms.Button btnStampa;
        private System.Windows.Forms.Button btnInvio;
        private System.Windows.Forms.Label lblChat;
        private System.Windows.Forms.Label lblMessaggio;
        private System.Windows.Forms.TextBox txtMessaggio;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.GroupBox grbVisualizzazioneDGV;
        private System.Windows.Forms.Button btnGestione;
        private System.Windows.Forms.ComboBox cmbGestPizze;
        private System.Windows.Forms.GroupBox grbGestioneHost;
        private System.Windows.Forms.ComboBox cmbGestHost;
        private System.Windows.Forms.GroupBox grbGestioneOrdine;
        private System.Windows.Forms.Button btnEliminaOrdine;
        private System.Windows.Forms.Button btnPagato;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Label lblHostPizze;
        private System.Windows.Forms.DataGridView dgvPizze;
        private System.Windows.Forms.Label lblLuogo;
        private System.Windows.Forms.Label lblOraOrdine;
        private System.Windows.Forms.Label lblScuolaOrdine;
        private System.Windows.Forms.TextBox txtOraOrdine;
        private System.Windows.Forms.TextBox txtScuolaOrdine;
        private System.Windows.Forms.Label lblNomeOrdine;
        private System.Windows.Forms.TextBox txtNomeOrdine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEliminaTuttiOrdini;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumHost;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeUtente;
        private System.Windows.Forms.DataGridViewTextBoxColumn SocketClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOrdine;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn PizzaClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn BibitaClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagato;
        private System.Windows.Forms.Button btnDM;
    }
}

