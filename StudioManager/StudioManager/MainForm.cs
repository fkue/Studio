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
        //Checks for the Loginname of the User with the specified ID
        private static MySqlCommand cmd = new MySqlCommand("SELECT * from Login where id = @id", con);
        
        #region Constructor
        public MainForm(int id)
        {
            InitializeComponent();
            //Saves the <param id>, so the Loginname can be displayed at the bottom.
            this.id = id;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Display Message & Checks, whether the User is "Mitarbeiter" or "Administrator"
                //In Case of a Mitarbeiter, hide specific buttons
                txt_UserInfo.Text = "Hallo " + reader.GetString(1) + "!";
                if (reader.GetString(3).Equals("Mitarbeiter"))
                {
                    btn_employees.Visible = false;
                }
            }
            con.Close();
        }
        #endregion  

        private void MainForm_Load(object sender, EventArgs e) {
            
        }
        
        
        #region Buttons
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion
    }
}
