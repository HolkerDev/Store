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

        private void Export_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Export game album";
                saveFileDialog.Filter = "Files Xml (*.xml)|*.xml|All files (*.*)" +
                    "|*.*";
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    GameXmlSerialized.Serialize(data, saveFileDialog.FileName);
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("Error : " + x.Message);
            }
        }
        void gameReferenceEdit_InvalidNumberEvent(object sender, string text)
        {
            MessageBox.Show(String.Format("Wrong reference number: {0}. The number can only contain digits", text));
        }
        void gameReferenceEdit_InvalidSerialEvent(object sender, string text)
        {
            MessageBox.Show(String.Format("Wrong serial reference: {0}. Serial can contain only letters A-E", text));
        }
    }
}
