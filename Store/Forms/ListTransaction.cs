using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Store.DataAccess;
using Store.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.Forms
{
    public partial class ListTransaction : Form
    {
        public ListTransaction()
        {
            InitializeComponent();
            this.transactionBindingSource.DataSource = DataContext.GetTransactionList();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            this.transactionBindingSource.ResetBindings(true);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            TransactionForm transForm = new TransactionForm();
            transForm.MdiParent = this.ParentForm;
            transForm.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Transaction trans = row.DataBoundItem as Transaction;
                if (trans != null)
                {
                    TransactionForm transForm = new TransactionForm(trans);
                    transForm.MdiParent = this.ParentForm;
                    transForm.Show();
                }
            }
        }
    }
}
