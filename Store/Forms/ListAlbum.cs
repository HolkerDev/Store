using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Store.Data;
using System.Drawing;
using System.Linq;
using Store.DataAccess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.Forms
{
    public partial class ListAlbum : Form
    {
        public ListAlbum()
        {
            InitializeComponent();
            this.albumBindingSource.DataSource = DataContext.GetAlbumList();
        }

        private void Add_Click(object sender, EventArgs e)
        {

            AlbumForm albumForm = new AlbumForm();
            albumForm.MdiParent = this;
            albumForm.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Album album = row.DataBoundItem as Album;
                if (album != null)
                {
                    AlbumForm albumForm = new AlbumForm(album);
                    albumForm.MdiParent = this.ParentForm;
                    albumForm.Show();
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            this.albumBindingSource.ResetBindings(true);

        }
    }
}
