using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Store.DataAccess;
using System.Drawing;
using System.Linq;
using Store.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.Forms
{
    public partial class ListMovie : Form
    {
        public ListMovie()
        {
            InitializeComponent();
            this.movieBindingSource.DataSource = DataContext.GetMovieList();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            MovieForm movieForm = new MovieForm();
            movieForm.MdiParent = this.ParentForm;
            movieForm.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Movie movie = row.DataBoundItem as Movie;
                if (movie != null)
                {
                    MovieForm movieForm = new MovieForm(movie);
                    movieForm.MdiParent = this.ParentForm;
                    movieForm.Show();
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            this.movieBindingSource.ResetBindings(true);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
