using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SecuritySystem
{
    public partial class DARform : Form
    {
        public DARform()
        {
            InitializeComponent();
        }

        private void DARform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.timeLog' table. You can move, or remove it, as needed.
            this.timeLogTableAdapter.Fill(this.dbDataSet.timeLog);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
            //UserInfoForm frm = new UserInfoForm(CID, null);
            //frm.Show();
        }
    }
}
