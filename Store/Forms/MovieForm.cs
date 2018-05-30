using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Store.DataAccess;
using System.Text;
using Store.Data;
using Store.Serialized;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.Forms
{
    public partial class MovieForm : Form
    {
        private Movie data = new Movie();
        public MovieForm(Movie movieData)
        {
            this.data = movieData;
            InitializeComponent();
            this.movieBindingSource.DataSource = data;
        }
        public MovieForm()
        {
            InitializeComponent();
            this.movieBindingSource.DataSource = data;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Export_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Export movie album";
                saveFileDialog.Filter = "Files Xml (*.xml)|*.xml|All files (*.*)" +
                    "|*.*";
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MovieXmlSerialized.Serialize(data, saveFileDialog.FileName);
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("Error : " + x.Message);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataContext.AddOrEditMovie(data) == true)
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
