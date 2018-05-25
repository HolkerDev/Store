using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Store.Data;
using System.Text;
using Store.Serialized;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MovieForm movieForm = new MovieForm();
            movieForm.MdiParent = this;
            movieForm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.MdiParent = this;
            gameForm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            AlbumForm albumForm = new AlbumForm();
            albumForm.MdiParent = this;
            albumForm.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //Close Menu->File
        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Import MovieForm
        private void movieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Import movie";
                openFileDialog.Filter = "Files format Xml (*.xml)|*.xml" +
                    "|All files (*.*)|*.*";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Movie data = MovieXmlSerialized.Deserialize(openFileDialog.FileName);
                    MovieForm movieForm = new MovieForm(data);
                    movieForm.MdiParent = this;
                    movieForm.Show();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error : " + x.Message);
            }
        }
        //Import GameForm
        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Import game";
                openFileDialog.Filter = "Files format Xml (*.xml)|*.xml" +
                    "|All files (*.*)|*.*";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Game data = GameXmlSerialized.Deserialize(openFileDialog.FileName);
                    GameForm gameForm = new GameForm(data);
                    gameForm.MdiParent = this;
                    gameForm.Show();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error : " + x.Message);
            }
        }
        //Import Album
        private void albumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Import album";
                openFileDialog.Filter = "Files format Xml (*.xml)|*.xml" +
                    "|All files (*.*)|*.*";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Album data = AlbumXmlSerialized.Deserialize(openFileDialog.FileName);
                    AlbumForm albumForm = new AlbumForm(data);
                    albumForm.MdiParent = this;
                    albumForm.Show();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error : " + x.Message);
            }
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
    }
}
