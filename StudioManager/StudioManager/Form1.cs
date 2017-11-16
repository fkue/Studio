﻿using System;
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
            //MySqlConnection con = new MySqlConnection("server=sql11.freemysqlhosting.net; username=sql11204165; password=uNEp4qPhYs; database=sql11204165;");
            MySqlConnection con = Properties.Settings.Default.Context.
            //MySqlCommand cmd = new MySqlCommand("SELECT * FROM Login WHERE username='"+txt_username.Text+"' AND password='"+ txt_password.Text + "'", con);
            MySqlCommand cmd = new MySqlCommand("SELECT count(*) as cnt from Login where username = @usr and password = @pwd", con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@usr", txt_username.Text);
            cmd.Parameters.AddWithValue("@pwd", txt_password.Text);
            
            con.Open();
            if(cmd.ExecuteScalar().ToString() == "1")
            {
                DialogResult dialog = MessageBox.Show("Willkommen, " + txt_username.Text +"!");
                if (dialog == DialogResult.OK)
                {
                    this.Hide();
                    
                    LoadingScreen ls = new LoadingScreen();
                    ls.Show();
                    System.Threading.Thread.Sleep(5000);
                    ls.Close();
                    ls.Dispose();

                    MainWindow mw = new MainWindow();
                   
                    mw.Show();
                }
            } else {
                MessageBox.Show("Falsche Login Daten");
            }
            con.Close();
        }
    }
}
