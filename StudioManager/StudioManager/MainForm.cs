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
    public partial class MainForm : Form
    {
        private int id;
        private static MySqlConnection con = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MySql"].ConnectionString);
        private static MySqlCommand cmd = new MySqlCommand("SELECT * from Login where id = @id", con);

        public MainForm(int id)
        {
            InitializeComponent();
            this.id = id;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txt_UserInfo.Text = "Hallo " + reader.GetString(1) + "!";
                if (reader.GetString(3).Equals("Mitarbeiter"))
                {
                    btn_employees.Visible = false;
                }
            }
            con.Close();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            
        }
        
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            Environment.Exit(0);
        }

        private void btn_employees_Click(object sender, EventArgs e)
        {
            WorkersOverview wo = new WorkersOverview();
            this.Hide();
            wo.ShowDialog();
            this.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WebcamTests wt = new WebcamTests();
            this.Hide();
            wt.Show();
            this.Show();
        }
    }
}
