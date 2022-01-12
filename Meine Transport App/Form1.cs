namespace Meine_Transport_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void HideAbfahrtstafel()
        {
            Abfahrtstafel.Hide();
            AbfahrtsplanLabel.Hide();
        }
        public void ShowAbfahrtstafel()
        {
            Abfahrtstafel.Show();
            AbfahrtsplanLabel.Show();
        }
        public void HideVerbindungsliste()
        {
            VerbindungenGrid.Hide();
            VerbindungslisteLabel.Hide();
        }
        public void ShowVerbindungsliste()
        {
            VerbindungenGrid.Show();
            VerbindungslisteLabel.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HideVerbindungsliste();
            HideAbfahrtstafel();
            UhrzeitTextBox.Text = Convert.ToString(DateTime.Now.Hour) + ":" + Convert.ToString(DateTime.Now.Minute);
        }
        private void EingabeVon_DropDown(object sender, EventArgs e)
        {
            if (EingabeVon.Text.Length >= 3)
            {
                EingabeVon.Items.Clear();
                EingabeVon.Items.Add(EingabeVon.Text);
                SwissTransport.Core.ITransport transport = new SwissTransport.Core.Transport();
                SwissTransport.Models.Stations stations = new SwissTransport.Models.Stations();
                stations = transport.GetStations(EingabeVon.Text);
                for (int i = 0; i < stations.StationList.Count; i++)
                {
                    EingabeVon.Items.Add(stations.StationList[i].Name);
                }
            }
        }
        private void EingabeNach_DropDown(object sender, EventArgs e)
        {
            if (EingabeNach.Text.Length >= 3)
            {
                EingabeNach.Items.Clear();
                EingabeNach.Items.Add(EingabeNach.Text);
                SwissTransport.Core.ITransport Transport = new SwissTransport.Core.Transport();
                SwissTransport.Models.Stations Stationen = new SwissTransport.Models.Stations();
                Stationen = Transport.GetStations(EingabeNach.Text);
                for (int i = 0; i < Stationen.StationList.Count; i++)
                {
                    EingabeNach.Items.Add(Stationen.StationList[i].Name);
                }
            }
        }
        private void SearchVerbindungen(object sender, EventArgs e)
        {
            SwissTransport.Core.ITransport Transportdaten = new SwissTransport.Core.Transport();
            SwissTransport.Models.Connections Verbindungsdaten = new SwissTransport.Models.Connections();
            if (EingabeNach.Text == "")
            {
                SwissTransport.Models.StationBoardRoot Stationstafel = new SwissTransport.Models.StationBoardRoot();
                ShowAbfahrtstafel();
                Abfahrtstafel.Rows.Clear();
                Stationstafel = Transportdaten.GetStationBoard(EingabeVon.Text, "0");
                for (int i = 0; i < Stationstafel.Entries.Count; i++)
                {
                    //Hier werden die Daten für den Abfahrtsplan geholt und eingefügt
                    string[] AbfahrtsplanGridDaten = new string[3];
                    AbfahrtsplanGridDaten[0] = Convert.ToString(Stationstafel.Station.Name);
                    AbfahrtsplanGridDaten[1] = Stationstafel.Entries[i].To;
                    AbfahrtsplanGridDaten[2] = Stationstafel.Entries[i].Stop.Departure.ToString();
                    Abfahrtstafel.Rows.Add(AbfahrtsplanGridDaten);
                }
            }
            else
            {
                VerbindungenGrid.Rows.Clear();
                ShowVerbindungsliste();
                Verbindungsdaten = Transportdaten.GetConnections(EingabeVon.Text, EingabeNach.Text);
                for (int i = 0; i < Verbindungsdaten.ConnectionList.Count; i++)
                {
                    //Hier werden die Daten für die Verbindungsliste geholt und eingefügt
                    string[] VerbindungsGridDaten = new string[4];
                    VerbindungsGridDaten[0] = Verbindungsdaten.ConnectionList[i].From.Departure.ToString();
                    VerbindungsGridDaten[1] = Verbindungsdaten.ConnectionList[i].To.Arrival.ToString();
                    VerbindungsGridDaten[2] = Convert.ToString(Verbindungsdaten.ConnectionList[i].To.Arrival - Verbindungsdaten.ConnectionList[i].From.Departure);
                    VerbindungsGridDaten[3] = Verbindungsdaten.ConnectionList[i].From.Platform;
                    VerbindungenGrid.Rows.Add(VerbindungsGridDaten);
                }
            }
        }
        private void SearchFutureVerbindungen(object sender, EventArgs e)
        {
            SwissTransport.Core.ITransport Transportdaten = new SwissTransport.Core.Transport();
            SwissTransport.Models.Connections Verbindungsdaten = new SwissTransport.Models.Connections();

            //Hier wird für die Datum und Uhrzeiteingabe ein DateTime Datentyp erstellt
            DateTime DatumUndZeit;
            try{
                string DatumUhrzeitString = DatumPicker.Value.ToString("yyyy-MM-dd ") + UhrzeitTextBox.Text;
                DatumUndZeit = DateTime.Parse(DatumUhrzeitString);
            }
            catch (Exception){
                MessageBox.Show("Das Datum ist nicht gültig, Bitte geben Sie ein Valides Datum ein");
                return;
            }
            VerbindungenGrid.Rows.Clear();
            ShowVerbindungsliste();
            //Im Unteren Teil wird wenn bei einer Verbindungssuche mit Datum und Uhrzeit Von und Nach benötigt, wenn nur Von eingegeben wird, dann wird per MessageBox eine Meldung angezeigt
            if (EingabeNach.Text == "" || EingabeVon.Text == "")
            {
                MessageBox.Show("Bitte Abfahrts- und Zielort eingeben um Verbindungen mit Zeit und Datum angezeigt zu bekommen");
            }
            else {
                Verbindungsdaten = Transportdaten.GetConnectionsWithTime(EingabeVon.Text, EingabeNach.Text, DatumUndZeit);
                for (int i = 0; i < Verbindungsdaten.ConnectionList.Count; i++)
                {
                    string[] VerbindungsGridDaten = new string[4];
                    
                    VerbindungsGridDaten[0] = Verbindungsdaten.ConnectionList[i].From.Departure.ToString();
                    VerbindungsGridDaten[1] = Verbindungsdaten.ConnectionList[i].To.Arrival.ToString();
                    VerbindungsGridDaten[2] = Convert.ToString(Verbindungsdaten.ConnectionList[i].To.Arrival - Verbindungsdaten.ConnectionList[i].From.Departure);
                    VerbindungsGridDaten[3] = Verbindungsdaten.ConnectionList[i].From.Platform;
                    VerbindungenGrid.Rows.Add(VerbindungsGridDaten);
                }
            }
            
        }
        private void Mailvorlage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sehr geehrte/r Herr/Frau\n\n" + "Ich habe hier eine Zugverbindung für Sie\n\n" +
                            "Ich wäre froh über eine Rückmeldung ob ihnen diese Zugverbindung passt\n Danke im Voraus\n\n" +
                            "(Hier Bild von angesprochener Verbindung einfügen)\n\n" + "Freundliche Grüsse\n" + "Vorname Nachname");
        }
        
    }
}


   
    
