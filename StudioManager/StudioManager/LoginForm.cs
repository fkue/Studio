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
using System.Collections.Specialized;

namespace StudioManager {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        #region variables for the connection/command
        //private static MySqlConnection con = new MySqlConnection("server=sql11.freemysqlhosting.net; username=sql11204165; password=uNEp4qPhYs; database=sql11204165;");
        //private static MySqlConnection con = globalSettings.con; 
        private static MySqlConnection con = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MySql"].ConnectionString);
        private static MySqlCommand cmd = new MySqlCommand("SELECT * from Login where username = @usr", con);
        #endregion

        private void Form1_Load(object sender, EventArgs e) {
            #region  Login Check
            //check whether the server is online or not, in each case display a message!
            try {
                con.Open();
                con.Close();
                txt_Status.ForeColor = Color.Green;
                txt_Status.Text = "Verbindung konnte erfolgreich hergestellt werden.";
            } catch (Exception ex) {
                txt_Status.ForeColor = Color.Red;
                txt_Status.Text = "Verbindung konnte nicht hergestellt werden.";
            }
            #endregion
        }

        #region Prewritten Text in Textoboxes
        //Clear Prewritten Text in Textboxes, Add Prewritten Text, when leaving & the Boxes are empty
        private void txt_username_Click(object sender, EventArgs e) {
            txt_username.Clear();
        }
        private void txt_password_Click(object sender, EventArgs e) {
            txt_password.Clear();
        }
        private void txt_username_Leave(object sender, EventArgs e) {
            if (txt_username.Text.Equals("")) {
                txt_username.Text = "Benutzername";
            }
        }
        private void txt_password_Leave(object sender, EventArgs e) {
            if (txt_password.Text.Equals("")) {
                txt_password.Text = "Passwort";
            }
        }
        #endregion

        #region LoginButton
        private void btn_Login(object sender, EventArgs e) {

            //Checks for Username and Password. If it finds each (as a pair) in the Database, it will login, 
            //otherwise a Messagebox will pop up, telling the user, the login attempt failed.
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@usr", txt_username.Text);
            con.Open();
            //Create a Reader, who just executes the Command, it should have a User now. Hash that password and verify it with the plaintext, the user just entered.
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (BCrypt.CheckPassword(txt_password.Text, reader.GetString(2)))
                    {
                        this.Hide();

                        LoadingScreen ls = new LoadingScreen();
                        ls.Show();
                        //Reactivate after finishing
                        //System.Threading.Thread.Sleep(3000);
                        ls.Close();
                        ls.Dispose();

                        //Send the User ID (which is at Array[0]), so that the main program actually knows, who its working with.
                        MainForm mw = new MainForm(reader.GetInt32(0));
                        mw.Show();
                    } 
                }
            } else
            {
                MessageBox.Show("Falsche Login Daten", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }
        #endregion

        #region Handle Return Presses
        //When the user is in the username or password txtbox and presses Return, it performs a click on the Login Button (each)
        private void txt_password_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Return) {
                button_Login.PerformClick();
            }
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Return) {
                button_Login.PerformClick();

            }
        }
        #endregion

        #region MenuStrip Elements
        //Creates new AboutForm, Hides LoginForm meanwhile, until the User decides to close the AboutForm
        private void ueberToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutForm af = new AboutForm();
            this.Hide();
            af.ShowDialog();
            this.Show();
        }

        //Creates new HelpForm, Hides LoginForm meanwhile, until the User decides to close the HelpForm
        private void kontaktToolStripMenuItem_Click(object sender, EventArgs e) {
            HelpForm h = new HelpForm();
            this.Hide();
            h.ShowDialog();
            this.Show();
        }
        #endregion


    }
}

//MySqlConnection con = new MySqlConnection("server = sql11.freemysqlhosting.net ; username =sql11204165 ; password = uNEp4qPhYs; database =sql11204165 ;");
//MySqlCommand cmd = new MySqlCommand("SELECT * from Login where username = @usr", con);

////Checks for Username and Password. If it finds each (as a pair) in the Database, it will login, 
////otherwise a Messagebox will pop up, telling the user, the login attempt failed.
//cmd.Parameters.Clear();
           
//            cmd.Parameters.AddWithValue("@usr", "lois");
//            con.Open();
//            string salt = BCrypt.GenerateSalt();

//MySqlDataReader reader = cmd.ExecuteReader();
//RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
//Console.WriteLine("Random Salt to be stored: " + "STFU" );
//            if (reader.HasRows)
//            {
                
//                Console.WriteLine("Reader has Rows!");
//                while (reader.Read())
//                {
//                    Console.WriteLine(BCrypt.CheckPassword("lois", reader.GetString(2)));
//                    Console.WriteLine(reader.GetInt32(0) + " " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3)); 
//                    //Console.WriteLine(SimpleHash.VerifyHash("lois", "MD5", reader.GetString(2)));



//                }
//            } else
//            {
//                Console.WriteLine("Falsche Login Daten!");
//            }
//            //Hash: 67FmuX53gOInjHlnjwnJfRgpsXKi

//            reader.Close();

#region LoginButtonOriginal
//private void btn_Login(object sender, EventArgs e)
//{

//    //Checks for Username and Password. If it finds each (as a pair) in the Database, it will login, 
//    //otherwise a Messagebox will pop up, telling the user, the login attempt failed.
//    cmd.Parameters.Clear();
//    cmd.Parameters.AddWithValue("@usr", txt_username.Text);
//    cmd.Parameters.AddWithValue("@pwd", txt_password.Text);

//    con.Open();
//    if (cmd.ExecuteScalar().ToString() == "1")
//    {
//        DialogResult dialog = MessageBox.Show("Willkommen, " + txt_username.Text + "!");
//        if (dialog == DialogResult.OK)
//        {
//            this.Hide();

//            LoadingScreen ls = new LoadingScreen();
//            ls.Show();
//            System.Threading.Thread.Sleep(3000);
//            ls.Close();
//            ls.Dispose();

//            MainForm mw = new MainForm();

//            mw.Show();
//        }
//    }
//    else
//    {
//        MessageBox.Show("Falsche Login Daten");
//    }
//    con.Close();
//}
#endregion