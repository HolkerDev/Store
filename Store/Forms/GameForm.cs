using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Store.Data;
using Store.Serialized;
using System.Linq;
using Store.DataAccess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.Forms
{
    public partial class GameForm : Form
    {
        Game data = new Game();
        public GameForm(Game gameData)
        {
            this.data = gameData;
            InitializeComponent();
            this.gameBindingSource.DataSource = data;
        }
        public GameForm()
        {
            InitializeComponent();
            this.gameBindingSource.DataSource = data;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataContext.AddOrEditGame(data) == true)
                {
                    this.Close();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error : " + x.Message);
            }
        }
    }
}
