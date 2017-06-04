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
    public partial class Buecher_erfassen : Form
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        private MySqlCommand command;
        // private MySqlDataAdapter mySqlDataAdapter;

        public Buecher_erfassen()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_speichern_Click(object sender, EventArgs e)
        {
            add_books();
            this.Close();
        }

        // MySQL Verbindung herstellen
        public void mysqlconnect()
        {
            server   = "localhost";
            database = "mybooks";
            uid      = "root";
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

        private void add_books()
        {
            try
            {
                mysqlconnect();

                String titel  = tb_titel.Text;
                String autor  = tb_autor.Text;
                String format = cb_format.Text;

                if (this.OpenConnection() == true)
                {
                    command = new MySqlCommand();
                    
                    // command = connection.CreateCommand();
                    command.Connection = connection;

                    command.CommandText = "INSERT INTO ebooks(titel, autor, form) VALUES(@titel,@autor,@format);";

                    // leer
                    command.Prepare();

                    command.Parameters.AddWithValue("@titel", titel);
                    command.Parameters.AddWithValue("@autor", autor);
                    command.Parameters.AddWithValue("@format", format);
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
