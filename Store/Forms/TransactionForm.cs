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
    public partial class TransactionForm : Form
    {
        private Transaction data = new Transaction();
        public TransactionForm()
        {
            InitializeComponent();
        }

        public TransactionForm(Transaction transactionData)
        {
            this.data = transactionData;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int gameId = (int)this.comboBox1.SelectedValue;
                data.GameData = DataContext.GetGameList().Find(o => o.GameId == gameId);
                if (data.GameData == null)
                {
                    MessageBox.Show("Choose game");
                    return;
                }

                int movieId = (int)this.comboBox2.SelectedValue;
                data.MovieData = DataContext.GetMovieList().Find(o => o.MovieId == movieId);
                if (data.MovieData == null)
                {
                    MessageBox.Show("Choose movie");
                    return;
                }
                int albumId = (int)this.comboBox3.SelectedValue;
                data.AlbumData = DataContext.GetAlbumList().Find(o => o.AlbumId == albumId);
                if (data.AlbumData == null)
                {
                    MessageBox.Show("Choose album");
                    return;
                }
                if (DataContext.AddOrEditTransaction(data) == true)
                {
                    this.Close();
                }
            }
            catch(Exception x)
            {
                MessageBox.Show("Error : ");
            }
    }

        private void Load_Click(object sender, EventArgs e)
        {
            this.transactionBindingSource.DataSource = data;
            this.gameBindingSource.DataSource = DataContext.GetGameList();
            this.movieBindingSource.DataSource = DataContext.GetMovieList();
            this.albumBindingSource.DataSource = DataContext.GetAlbumList();

            if(data != null)
            {
                if (data.GameData != null)
                {
                    this.comboBox1.SelectedValue = data.GameData.GameId;
                }
                if (data.MovieData != null)
                {
                    this.comboBox2.SelectedValue = data.MovieData.MovieId;
                }
                if (data.AlbumData != null)
                {
                    this.comboBox3.SelectedValue = data.AlbumData.AlbumId;
                }
            }
        }
    }
}
