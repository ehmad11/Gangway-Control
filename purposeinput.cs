using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SecuritySystem
{
    public partial class purposeinput : Form
    {
        private int _id;
        int _state;
        string _rank;
        public purposeinput()
        {
            InitializeComponent();
        }


        // state1 = signing in
        // state2 = signing out

        public purposeinput(string Purp, int state, int id, string rank)
        {
            InitializeComponent();
            lblInfo.Text = Purp;
            _id = id;
            _state = state;

            _rank = rank;

            if (_state == 2)
            {
                if (_rank != "0")
                {
                    timeLogTableAdapter1.UpdateQueryTimeOut(DateTime.Now.ToString(), txtReason.Text, _id);

                    if (_rank == "1")
                        MessageBox.Show("CO Departing");


                    if (_rank == "2")
                        MessageBox.Show("EXO Departing");


                    this.Close();
                }
            }
            else
            {
                
                if (_rank != "0")
                {
                    timeLogTableAdapter1.Insert(DateTime.Now.ToString(), "_", _id, txtReason.Text, null, null);

                    if (_rank == "1")
                        MessageBox.Show("CO Arriving");


                    if (_rank == "2")
                        MessageBox.Show("EXO Arriving");

                    this.Close();
                }             
            }



        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void purposeinput_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {            
            
            if (_state == 2)
            {
                timeLogTableAdapter1.UpdateQueryTimeOut(DateTime.Now.ToString(), txtReason.Text, _id);
            }
            else
            {
                timeLogTableAdapter1.Insert(DateTime.Now.ToString(), "_", _id, txtReason.Text, null, null);
            }

            this.Close();
        }
    }
}
