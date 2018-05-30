using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Store.Data;
using Store.Serialized;
using Store.Serialized;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.Forms
{
    public partial class AlbumForm : Form
    {
        Album data = new Album();
        public AlbumForm(Album albumData)
        {
            this.data = albumData;
            InitializeComponent();
            this.albumBindingSource.DataSource = data;
        }
        public AlbumForm()
        {
            InitializeComponent();
            this.albumBindingSource.DataSource = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Export album album";
                saveFileDialog.Filter = "Files Xml (*.xml)|*.xml|All files (*.*)" +
                    "|*.*";
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    AlbumXmlSerialized.Serialize(data, saveFileDialog.FileName);
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("Error : " + x.Message);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
