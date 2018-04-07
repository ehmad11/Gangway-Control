using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SecuritySystem
{
    public partial class shipStats : Form
    {
        public shipStats()
        {
            InitializeComponent();
        }

        private void shipStats_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = crewStatsTableAdapter1.GetData();
            dataGridView.DataSource = dt;
        }
    }
}
