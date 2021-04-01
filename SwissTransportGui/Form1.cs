using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportGui
{
    public partial class SwissTransportGui : Form
    {
        ITransport transport = new Transport();
        private string inputStartStation;
        private string inputEndStation;
        public SwissTransportGui()
        {
            InitializeComponent();
            listBoxEndStations.Visible = false;
            listBoxStartStations.Visible = false;
            this.ActiveControl = textBoxStartStation;
            Size = new Size(898, 530);
        }

        private void TextBoxStartStation_TextChanged(object sender, EventArgs e)
        {
            AutoFillForSearch(1, textBoxStartStation.Text.Trim());
        }

        private void TextBoxEndStation_TextChanged(object sender, EventArgs e)
        {
            AutoFillForSearch(2, textBoxEndStation.Text.Trim());
        }

        private void ButtonSearchConnection_Click(object sender, EventArgs e)
        {
            try
            { 
                if (textBoxStartStation.Text != "" && textBoxEndStation.Text == "")
                {
                    SetStations();
                    DisplayStationBoard();
                    listBoxStartStations.Visible = false;
                }
                else if (textBoxStartStation.Text == "" && textBoxEndStation.Text == "")
                {
                    MessageBox.Show("Mindestens der Abfahrtsort muss ausgefüllt sein!", "Warnung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SetStations();
                    DisplayConnections();
                }
            }
            catch 
            {
                MessageBox.Show("Mindestens der Abfahrtsort muss ausgefüllt sein!", "Warnung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DisplayStationBoard()
        {
            dataGridViewConnections.Rows.Clear();
            dataGridViewConnections.Columns.Clear();
            dataGridViewConnections.Columns.Add("departureTime", "Abfahrtszeit");
            dataGridViewConnections.Columns.Add("to", "Richtung");
            dataGridViewConnections.Columns.Add("category", "Zug/Bus/Schiff Nr.");
            StationBoardRoot stationBoards = transport.GetStationBoard(inputStartStation);
            foreach (StationBoard stationBoard in stationBoards.Entries)
            {
                dataGridViewConnections.Rows.Add(
                    stationBoard.Stop.Departure.ToString("HH:mm"),
                    stationBoard.To,
                    stationBoard.Category + stationBoard.Number
                    );
            }
            dataGridViewConnections.ReadOnly = true;
            pictureBoxSendMail.Visible = false;
        }
        private void DisplayConnections()
        {
            dataGridViewConnections.Columns.Clear();
            dataGridViewConnections.Columns.Add("departureTime", "Abfahrtszeit");
            dataGridViewConnections.Columns.Add("arriveTime", "Ankunftszeit");
            dataGridViewConnections.Columns.Add("duration", "Dauer");
            dataGridViewConnections.Columns.Add("platform", "Gleis/Kante");
            dataGridViewConnections.Rows.Clear();
            Connections connections = transport.GetConnections(inputStartStation, inputEndStation);
            foreach(Connection connection in connections.ConnectionList)
            {
                dataGridViewConnections.Rows.Add(
                    connection.From.Departure,
                    connection.To.Arrival,
                    connection.Duration + " min.",
                    connection.To.Platform
                    );
            }
            dataGridViewConnections.ReadOnly = true;
            pictureBoxSendMail.Visible = true;
        }
        private void SetStations()
        {
            inputStartStation = textBoxStartStation.Text.Trim();
            inputEndStation = textBoxEndStation.Text.Trim();
        }
        private void TextBoxStation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                listBoxStations.Items.Clear();
                var stations = transport.GetStations(textBoxStation.Text);
                foreach (var station in stations.StationList)
                {
                    listBoxStations.Items.Add(station.Name);
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Es wurde keine Station gefunden!" + ex, "Fehler",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
              
            }
        }

        private void ButtonSwitchStation_Click(object sender, EventArgs e)
        {
            string cache = textBoxStartStation.Text;
            textBoxStartStation.Text = textBoxEndStation.Text;
            textBoxEndStation.Text = cache;
            ButtonSearchConnection_Click(sender, e);
        }

        private void ListBoxStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxEndStation.Text = "";
                textBoxStartStation.Text = listBoxStations.SelectedItem.ToString();
                textBoxStation.Text = listBoxStations.SelectedItem.ToString();
                ButtonSearchConnection_Click(sender, e);
            }
            catch (NullReferenceException)
            {

            }
            catch
            {

            }
        }
        private void AutoFillForSearch(int selectedObject, string searchValue)
        {
            try
            {
                if (searchValue == "")
                {
                    listBoxStartStations.Visible = false;
                    listBoxEndStations.Visible = false;
                }
                else
                {
                    var stations = transport.GetStations(searchValue);
                    switch (selectedObject)
                    {
                        case 1:
                            listBoxStartStations.Visible = true;
                            listBoxStartStations.Items.Clear();
                            foreach (var station in stations.StationList)
                            {
                                listBoxStartStations.Items.Add(station.Name);
                            }
                            break;
                        case 2:
                            listBoxEndStations.Visible = true;
                            listBoxEndStations.Items.Clear();
                            foreach (var station in stations.StationList)
                            {
                                listBoxEndStations.Items.Add(station.Name);
                            }
                            break;
                    }
                }
            }
            catch
            {

            }
        }

        private void ListBoxStartStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxStartStation.Text = listBoxStartStations.Text;
            listBoxStartStations.Visible = false;
        }

        private void ListBoxEndStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxEndStation.Text = listBoxEndStations.Text;
            listBoxEndStations.Visible = false;
        }

        private void ButtonShowMap_Click(object sender, EventArgs e)
        {
            if(textBoxStation.Text != "")
                System.Diagnostics.Process.Start("https://map.search.ch/" + textBoxStation.Text + "-haltestelle");
            else
                MessageBox.Show("Es wurde keine Station gefunden!", "Fehler",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PictureBoxSendMail_Click(object sender, EventArgs e)
        {
            groupBoxSendMail.Visible = true;
            this.ActiveControl = textBoxReceiverAddress;
            Size = new Size(898, 617);
        }

        private void ButtonSendMail_Click(object sender, EventArgs e)
        {
            if (textBoxReceiverAddress.Text.Trim() == "")
            {
                MessageBox.Show("Es wurde keine gültige Adresse eingegeben!", "Fehler",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string content = "Abfahrt am " + dataGridViewConnections.Rows[0].Cells[0].Value;
                content += " auf Gleis/Kante " + dataGridViewConnections.Rows[0].Cells[3].Value;
                content += "Ankunft am " + dataGridViewConnections.Rows[0].Cells[1].Value + "\n";
                content += "Ihre Reise dauert " + dataGridViewConnections.Rows[0].Cells[2].Value + "\n";
                Mail mail = new Mail(textBoxReceiverAddress.Text, "Gewünschte ÖV-Verbindung", content);
                Size = new Size(898, 530);
                textBoxReceiverAddress.Clear();
                groupBoxSendMail.Visible = false;
                mail.SendMail();
            }
        }

        private void TextBoxStartStation_Leave(object sender, EventArgs e)
        {
            if (this.ActiveControl != listBoxStartStations)
            {
                listBoxStartStations.Visible = false;
            }
        }
        private void TextBoxEndStation_Leave(object sender, EventArgs e)
        {
            if (this.ActiveControl != listBoxEndStations)
            {
                listBoxEndStations.Visible = false;
            }
        }
    }
}