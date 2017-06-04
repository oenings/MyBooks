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
    public partial class Buecher_loeschen : Form
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataAdapter mySqlDataAdapter;

        public Buecher_loeschen()
        {
            InitializeComponent();
        }

        private void btn_loeschen_Click(object sender, EventArgs e)
        {
            delete_books();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Buecher_loeschen_Load(object sender, EventArgs e)
        {
            mysqlconnect();
            if (this.OpenConnection() == true)
            {
                // ComboBox Titel füllen
                mySqlDataAdapter = new MySqlDataAdapter("SELECT eid, titel FROM ebooks order by eid", connection);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    String rowz = String.Format("{0}: {1}", row.ItemArray[0], row.ItemArray[1]);
                    cb_titel.Items.Add(rowz);
                }
                this.connection.Close();
            }
        }

        // Bücher löschen
        private void delete_books()
        {
            try
            {
                mysqlconnect();

                String titel = cb_titel.Text;

                String[] eid = titel.Split(':');

                if (this.OpenConnection() == true)
                {
                    command = new MySqlCommand();

                    // command = connection.CreateCommand();
                    command.Connection = connection;

                    command.CommandText = "DELETE FROM ebooks WHERE eid = @eid;";

                    // leer
                    command.Prepare();

                    command.Parameters.AddWithValue("@eid", eid[0]);
                    command.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: \n" + ex);
            }
        }

    }
}
