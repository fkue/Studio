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
    public partial class WorkersOverview : Form
    {
        public WorkersOverview()
        {
            InitializeComponent();
        }

        private void WorkersOverview_Load(object sender, EventArgs e)
        {
            this.InitializeGridView();
        }

        #region Create GridView to properly Display the Database Data. Can be Copy Pasted
        private void InitializeGridView()
        {
            using (MySqlConnection con = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MySql"].ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Workers", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dgv_OverviewWorkes.DataSource = dt;
                            
                        }
                    }
                }
            }
        }
        #endregion

        #region Dialog for "Create a new Login"
        private void btn_createNewLogin_Click(object sender, EventArgs e)
        {
            CreateLogin cl = new CreateLogin();
            cl.ShowDialog();
        }
        #endregion
    }
}
