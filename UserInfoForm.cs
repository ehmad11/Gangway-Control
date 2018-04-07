using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SecuritySystem
{
	public partial class UserInfoForm : Form
	{
        int _uID;
        DataTable dtable = new DataTable();
        DataRow dr;
        public UserInfoForm(int uID, string uName)
		{
            _uID = uID;
			InitializeComponent();

            this.ranksTableAdapter.Fill(this.dbDataSet.Ranks);
            getdata();

            string filename = @Application.StartupPath + "\\ProfileImages\\" + uName + ".Bmp";

            try
            {
                pictureBox.Image =new Bitmap( filename);
            }
            catch { }
		}


        private void getdata()
        {
            dtable = crewTableAdapter.GetDataByFDID(_uID);            
            if (dtable.Rows.Count == 1)
            {
                dr = dtable.Rows[0];
                cmbDesg.SelectedValue = dr["Rank"].ToString();
                txtNumbr.Text = dr["Contact Number"].ToString();
                txtno.Text = dr["IdentityNo"].ToString();

                

                string path;
                path = System.IO.Path.GetDirectoryName(
                   System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);

                //MessageBox.Show(path);

                try
                {
                    pictureBoxImage.Load(path + "");
                }
                catch
                {

                }

            }
            else
            {
                
                                
            }

        }


		public string UserName
		{
			get
			{
				return lblUserName.Text;
			}
			set
			{
				lblUserName.Text = value;
			}
		}

		public Image UserFingerprintImage
		{
			get
			{
				return pbUserFinger.Image;
			}
			set
			{
				pbUserFinger.Image = value;
			}
		}


        private void UserInfoForm_Load(object sender, EventArgs e)
        {                        

        }

        private void UserInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (dr == null)
            {
                crewTableAdapter.Insert(_uID, "1", Convert.ToInt32(cmbDesg.SelectedValue), txtNumbr.Text, "", txtno.Text);                
            }
            else
            {
                dr["Rank"] = cmbDesg.SelectedValue;
                dr["Contact Number"] = txtNumbr.Text;
                dr["IdentityNo"] = txtno.Text;
                crewTableAdapter.Update(dr);
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
	}
}