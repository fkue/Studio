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

namespace StudioManager
{
    public partial class CreateLogin : Form
    {
        public CreateLogin()
        {
            InitializeComponent();
        }

        private void CreateLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_username.Text) || string.IsNullOrWhiteSpace(txt_password.Text) || string.IsNullOrWhiteSpace(cmb_role.SelectedItem.ToString()))
            {
                MessageBox.Show("Bitte füllen Sie alle angegebenen Felder sorgfältig aus.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                MySqlConnection con = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MySql"].ConnectionString);
                String HashedPassword = BCrypt.HashPassword(txt_password.Text, BCrypt.GenerateSalt());
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `Login` (`id`, `username`, `password`, `role`) VALUES (NULL, '" + txt_username.Text + "', '" + HashedPassword + "', '" + cmb_role.SelectedItem.ToString() + "');", con);


                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ein unerwarteter Fehler ist beim Erstellen eines neuen Benutzers aufgetreten. Bitte versuchen Sie es erneut.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Handle Return Presses
        //When the user is in the username or password txtbox and presses Return, it performs a click on the Login Button (each)
        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btn_Create.PerformClick();
            }
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btn_Create.PerformClick();
            }
        }

        private void cmb_role_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btn_Create.PerformClick();
            }
        }
        #endregion


    }
}
