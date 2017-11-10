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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=sql11.freemysqlhosting.net; username=sql11204165; password=uNEp4qPhYs; database=sql11204165;");
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT (*) AS cnt FROM Login WHERE username=@usr AND password=@pwd");
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@usr", txt_username.Text);
            cmd.Parameters.AddWithValue("@pwd", txt_password.Text);

            con.Open();
            MessageBox.Show(con.State.ToString());
            MessageBox.Show(cmd.ExecuteScalar().ToString());
            con.Close();
        }
    }
}
