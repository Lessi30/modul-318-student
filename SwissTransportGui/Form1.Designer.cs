namespace SwissTransportGui
{
    partial class SwissTransportGui
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwissTransportGui));
            this.pictureBoxHeader = new System.Windows.Forms.PictureBox();
            this.labelSplitHeader = new System.Windows.Forms.Label();
            this.dataGridViewConnections = new System.Windows.Forms.DataGridView();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxStartStation = new System.Windows.Forms.TextBox();
            this.listBoxStartStations = new System.Windows.Forms.ListBox();
            this.listBoxEndStations = new System.Windows.Forms.ListBox();
            this.buttonSwitchStation = new System.Windows.Forms.Button();
            this.groupBoxSearchConnections = new System.Windows.Forms.GroupBox();
            this.pictureBoxSendMail = new System.Windows.Forms.PictureBox();
            this.buttonSearchConnection = new System.Windows.Forms.Button();
            this.textBoxEndStation = new System.Windows.Forms.TextBox();
            this.textBoxStation = new System.Windows.Forms.TextBox();
            this.listBoxStations = new System.Windows.Forms.ListBox();
            this.pictureBoxSearchOnMap = new System.Windows.Forms.PictureBox();
            this.groupBoxSearchStations = new System.Windows.Forms.GroupBox();
            this.groupBoxSendMail = new System.Windows.Forms.GroupBox();
            this.buttonSendMail = new System.Windows.Forms.Button();
            this.textBoxReceiverAddress = new System.Windows.Forms.TextBox();
            this.labelReceiver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnections)).BeginInit();
            this.groupBoxSearchConnections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSendMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchOnMap)).BeginInit();
            this.groupBoxSearchStations.SuspendLayout();
            this.groupBoxSendMail.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxHeader
            // 
            resources.ApplyResources(this.pictureBoxHeader, "pictureBoxHeader");
            this.pictureBoxHeader.Name = "pictureBoxHeader";
            this.pictureBoxHeader.TabStop = false;
            // 
            // labelSplitHeader
            // 
            this.labelSplitHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.labelSplitHeader, "labelSplitHeader");
            this.labelSplitHeader.Name = "labelSplitHeader";
            // 
            // dataGridViewConnections
            // 
            this.dataGridViewConnections.AllowUserToAddRows = false;
            this.dataGridViewConnections.AllowUserToDeleteRows = false;
            this.dataGridViewConnections.AllowUserToResizeColumns = false;
            this.dataGridViewConnections.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dataGridViewConnections, "dataGridViewConnections");
            this.dataGridViewConnections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewConnections.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartTime,
            this.Ankunftszeit,
            this.time,
            this.station});
            this.dataGridViewConnections.Name = "dataGridViewConnections";
            // 
            // StartTime
            // 
            resources.ApplyResources(this.StartTime, "StartTime");
            this.StartTime.Name = "StartTime";
            // 
            // Ankunftszeit
            // 
            resources.ApplyResources(this.Ankunftszeit, "Ankunftszeit");
            this.Ankunftszeit.Name = "Ankunftszeit";
            // 
            // time
            // 
            resources.ApplyResources(this.time, "time");
            this.time.Name = "time";
            // 
            // station
            // 
            resources.ApplyResources(this.station, "station");
            this.station.Name = "station";
            // 
            // textBoxStartStation
            // 
            resources.ApplyResources(this.textBoxStartStation, "textBoxStartStation");
            this.textBoxStartStation.Name = "textBoxStartStation";
            this.textBoxStartStation.TextChanged += new System.EventHandler(this.TextBoxStartStation_TextChanged);
            this.textBoxStartStation.Leave += new System.EventHandler(this.TextBoxStartStation_Leave);
            // 
            // listBoxStartStations
            // 
            this.listBoxStartStations.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxStartStations, "listBoxStartStations");
            this.listBoxStartStations.Name = "listBoxStartStations";
            this.listBoxStartStations.TabStop = false;
            this.listBoxStartStations.SelectedIndexChanged += new System.EventHandler(this.ListBoxStartStations_SelectedIndexChanged);
            this.listBoxStartStations.DoubleClick += new System.EventHandler(this.ListBoxStartStations_SelectedIndexChanged);
            // 
            // listBoxEndStations
            // 
            this.listBoxEndStations.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxEndStations, "listBoxEndStations");
            this.listBoxEndStations.Name = "listBoxEndStations";
            this.listBoxEndStations.TabStop = false;
            this.listBoxEndStations.SelectedIndexChanged += new System.EventHandler(this.ListBoxEndStations_SelectedIndexChanged);
            // 
            // buttonSwitchStation
            // 
            resources.ApplyResources(this.buttonSwitchStation, "buttonSwitchStation");
            this.buttonSwitchStation.Name = "buttonSwitchStation";
            this.buttonSwitchStation.UseVisualStyleBackColor = true;
            this.buttonSwitchStation.Click += new System.EventHandler(this.ButtonSwitchStation_Click);
            // 
            // groupBoxSearchConnections
            // 
            this.groupBoxSearchConnections.Controls.Add(this.pictureBoxSendMail);
            this.groupBoxSearchConnections.Controls.Add(this.buttonSearchConnection);
            this.groupBoxSearchConnections.Controls.Add(this.textBoxEndStation);
            this.groupBoxSearchConnections.Controls.Add(this.buttonSwitchStation);
            this.groupBoxSearchConnections.Controls.Add(this.listBoxEndStations);
            this.groupBoxSearchConnections.Controls.Add(this.listBoxStartStations);
            this.groupBoxSearchConnections.Controls.Add(this.textBoxStartStation);
            this.groupBoxSearchConnections.Controls.Add(this.dataGridViewConnections);
            resources.ApplyResources(this.groupBoxSearchConnections, "groupBoxSearchConnections");
            this.groupBoxSearchConnections.Name = "groupBoxSearchConnections";
            this.groupBoxSearchConnections.TabStop = false;
            // 
            // pictureBoxSendMail
            // 
            resources.ApplyResources(this.pictureBoxSendMail, "pictureBoxSendMail");
            this.pictureBoxSendMail.Name = "pictureBoxSendMail";
            this.pictureBoxSendMail.TabStop = false;
            this.pictureBoxSendMail.Click += new System.EventHandler(this.PictureBoxSendMail_Click);
            // 
            // buttonSearchConnection
            // 
            resources.ApplyResources(this.buttonSearchConnection, "buttonSearchConnection");
            this.buttonSearchConnection.Name = "buttonSearchConnection";
            this.buttonSearchConnection.UseVisualStyleBackColor = true;
            this.buttonSearchConnection.Click += new System.EventHandler(this.ButtonSearchConnection_Click);
            // 
            // textBoxEndStation
            // 
            resources.ApplyResources(this.textBoxEndStation, "textBoxEndStation");
            this.textBoxEndStation.Name = "textBoxEndStation";
            this.textBoxEndStation.TextChanged += new System.EventHandler(this.TextBoxEndStation_TextChanged);
            this.textBoxEndStation.Leave += new System.EventHandler(this.TextBoxEndStation_Leave);
            // 
            // textBoxStation
            // 
            resources.ApplyResources(this.textBoxStation, "textBoxStation");
            this.textBoxStation.Name = "textBoxStation";
            this.textBoxStation.TextChanged += new System.EventHandler(this.TextBoxStation_TextChanged);
            // 
            // listBoxStations
            // 
            this.listBoxStations.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxStations, "listBoxStations");
            this.listBoxStations.Name = "listBoxStations";
            this.listBoxStations.SelectedIndexChanged += new System.EventHandler(this.ListBoxStations_SelectedIndexChanged);
            // 
            // pictureBoxSearchOnMap
            // 
            this.pictureBoxSearchOnMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pictureBoxSearchOnMap, "pictureBoxSearchOnMap");
            this.pictureBoxSearchOnMap.Name = "pictureBoxSearchOnMap";
            this.pictureBoxSearchOnMap.TabStop = false;
            this.pictureBoxSearchOnMap.Click += new System.EventHandler(this.ButtonShowMap_Click);
            // 
            // groupBoxSearchStations
            // 
            this.groupBoxSearchStations.Controls.Add(this.pictureBoxSearchOnMap);
            this.groupBoxSearchStations.Controls.Add(this.listBoxStations);
            this.groupBoxSearchStations.Controls.Add(this.textBoxStation);
            resources.ApplyResources(this.groupBoxSearchStations, "groupBoxSearchStations");
            this.groupBoxSearchStations.Name = "groupBoxSearchStations";
            this.groupBoxSearchStations.TabStop = false;
            // 
            // groupBoxSendMail
            // 
            this.groupBoxSendMail.Controls.Add(this.buttonSendMail);
            this.groupBoxSendMail.Controls.Add(this.textBoxReceiverAddress);
            this.groupBoxSendMail.Controls.Add(this.labelReceiver);
            resources.ApplyResources(this.groupBoxSendMail, "groupBoxSendMail");
            this.groupBoxSendMail.Name = "groupBoxSendMail";
            this.groupBoxSendMail.TabStop = false;
            // 
            // buttonSendMail
            // 
            resources.ApplyResources(this.buttonSendMail, "buttonSendMail");
            this.buttonSendMail.Name = "buttonSendMail";
            this.buttonSendMail.UseVisualStyleBackColor = true;
            this.buttonSendMail.Click += new System.EventHandler(this.ButtonSendMail_Click);
            // 
            // textBoxReceiverAddress
            // 
            resources.ApplyResources(this.textBoxReceiverAddress, "textBoxReceiverAddress");
            this.textBoxReceiverAddress.Name = "textBoxReceiverAddress";
            // 
            // labelReceiver
            // 
            resources.ApplyResources(this.labelReceiver, "labelReceiver");
            this.labelReceiver.Name = "labelReceiver";
            // 
            // SwissTransportGui
            // 
            this.AcceptButton = this.buttonSearchConnection;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.groupBoxSendMail);
            this.Controls.Add(this.labelSplitHeader);
            this.Controls.Add(this.groupBoxSearchStations);
            this.Controls.Add(this.pictureBoxHeader);
            this.Controls.Add(this.groupBoxSearchConnections);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SwissTransportGui";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnections)).EndInit();
            this.groupBoxSearchConnections.ResumeLayout(false);
            this.groupBoxSearchConnections.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSendMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchOnMap)).EndInit();
            this.groupBoxSearchStations.ResumeLayout(false);
            this.groupBoxSearchStations.PerformLayout();
            this.groupBoxSendMail.ResumeLayout(false);
            this.groupBoxSendMail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHeader;
        private System.Windows.Forms.Label labelSplitHeader;
        private System.Windows.Forms.DataGridView dataGridViewConnections;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn station;
        private System.Windows.Forms.TextBox textBoxStartStation;
        private System.Windows.Forms.ListBox listBoxStartStations;
        private System.Windows.Forms.ListBox listBoxEndStations;
        private System.Windows.Forms.Button buttonSwitchStation;
        private System.Windows.Forms.GroupBox groupBoxSearchConnections;
        private System.Windows.Forms.Button buttonSearchConnection;
        private System.Windows.Forms.TextBox textBoxEndStation;
        private System.Windows.Forms.TextBox textBoxStation;
        private System.Windows.Forms.ListBox listBoxStations;
        private System.Windows.Forms.PictureBox pictureBoxSearchOnMap;
        private System.Windows.Forms.GroupBox groupBoxSearchStations;
        private System.Windows.Forms.PictureBox pictureBoxSendMail;
        private System.Windows.Forms.GroupBox groupBoxSendMail;
        private System.Windows.Forms.Label labelReceiver;
        private System.Windows.Forms.TextBox textBoxReceiverAddress;
        private System.Windows.Forms.Button buttonSendMail;
    }
}

