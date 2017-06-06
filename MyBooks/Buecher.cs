using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyBooks
{
    public partial class Buecher : Form
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataAdapter mySqlDataAdapter;

        public Buecher()
        {
            InitializeComponent();
        }

        private void btn_erfassen_Click(object sender, EventArgs e)
        {
            Buecher_erfassen erfassen = new Buecher_erfassen();
            erfassen.ShowDialog();
        }

        // MySQL Verbindung herstellen
        public void mysqlconnect()
        {
            server = "localhost";
            database = "mybooks";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //MySQL Verbindung öffnen
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //MySQL Verbindung schließen
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void Buecher_Load(object sender, EventArgs e)
        {
            // 7-Segment-Anzeige
            // sevenSegmentArray1.Value = "27.30";

            mysqlconnect();

            if (this.OpenConnection() == true)
            {
                mySqlDataAdapter = new MySqlDataAdapter("SELECT eid, titel, autor, form AS format FROM ebooks", connection);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                this.CloseConnection();
            }

        }

        private void btn_loeschen_Click(object sender, EventArgs e)
        {
            Buecher_loeschen loeschen = new Buecher_loeschen();
            loeschen.ShowDialog();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (e.EventType == System.IO.Ports.SerialData.Eof) return;
            sevenSegmentArray1.Value = serialPort1.ReadLine();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = Convert.ToString(comboBox1.SelectedItem);
                serialPort1.Open();
            }
            catch
            {
                MessageBox.Show(this, "Fehler!");
            }
        }
    }
}
