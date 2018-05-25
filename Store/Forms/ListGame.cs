using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Store.Data;
using Store.DataAccess;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.Forms
{
    public partial class ListGame : Form
    {
        public ListGame()
        {
            InitializeComponent();
            this.gameBindingSource.DataSource = DataContext.GetGameList();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.MdiParent = this;
            gameForm.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            this.gameBindingSource.ResetBindings(true);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Game game = row.DataBoundItem as Game;
                if (game != null)
                {
                    GameForm gameForm = new GameForm(game);
                    gameForm.MdiParent = this.ParentForm;
                    gameForm.Show();
                }
            }
        }
    }
}
