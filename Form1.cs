using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalDB
{
    public partial class btnLocalDB : Form
    {
        public btnLocalDB()
        {
            InitializeComponent();
        }

        private void studentInformationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'modelDataSet.StudentInformation' table. You can move, or remove it, as needed.
            this.studentInformationTableAdapter.Fill(this.modelDataSet.StudentInformation);

        }

        private void courseLabel_Click(object sender, EventArgs e)
        {

        }

        private void studentInformationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
