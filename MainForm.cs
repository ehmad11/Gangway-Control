using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Neurotec.Biometrics;
using Neurotec.Gui;

namespace SecuritySystem
{
	public partial class MainForm : Form
	{
        WebCamera.WebCam wc;

		Nffv _engine;
		string _userDatabaseFile;
		UserDatabase _userDB;

        DataTable dt;
        DataRow dr;



        private void setupCam()
        {
            //wc = null;
            wc = new WebCamera.WebCam();
            wc.Container = SecurityCam;
            wc.OpenConnection();

        }

        public void showOnBoardInfo()
        {
            DataTable dttemp;
            dttemp = timeLogTableAdapter1.GetDataByOnBoard();

            
            lblOnBoardCount.Text = dttemp.Rows.Count.ToString();

            if (dttemp.Rows.Count > 0)
            {
                DataRow dr;
                
                int i = 0;
                for (i = 0; i < dttemp.Rows.Count; i++)
                {
                    dr = dttemp.Rows[i];
                    

                    DataTable dtGetRank;
                    dtGetRank = getRanksTableAdapter1.GetData(Convert.ToInt32(dr["fdID"].ToString()));

                    if (dtGetRank.Rows.Count == 1)
                    {
                        dr = dtGetRank.Rows[0];
                        //MessageBox.Show(dr["rank"].ToString());


                        int sCount = 0;                        

                        if (dr["rank"].ToString() == "Sailor")
                        {
                            sCount++;
                        }


                        int oCount = 0;

                        if (dr["rank"].ToString() == "Officer")
                        {
                            oCount++;
                        }


                        //lblSailorCount.Text = sCount.ToString();
                        //lblOfficrCount.Text = oCount.ToString();

                    }

                }
            }
            
        }

        private void doVerify()
        {
            lbDatabase.Visible = false;
            while (true)
            {

                if (lbDatabase.Items.Count <= 0)
                {
                    MessageBox.Show("No entries in database yet.");
                    return;
                }
                else
                {
                    try
                    {
                        int i = 0;
                        for (i = 0; i < lbDatabase.Items.Count; i++)
                        {
                            lbDatabase.SelectedIndex = i;
                            RunWorkerCompletedEventArgs taskResult = BusyForm.RunLongTask("Waiting for fingerprint ...", new DoWorkEventHandler(doVerify),
                                false, ((CData)lbDatabase.SelectedItem).EngineUser, new EventHandler(CancelScanningHandler));
                            VerificationResult verificationResult = (VerificationResult)taskResult.Result;
                            if (verificationResult.engineStatus == NffvStatus.TemplateCreated)
                            {
                                if (verificationResult.score > 0)
                                {


                                    //MessageBox.Show(string.Format("{0} verified.\r\nFingerprints match. Score: {1}", ((CData)lbDatabase.SelectedItem).Name, verificationResult.score));
                                    lbDatabase.SelectedIndex = i;
                                    int id = ((CData)lbDatabase.SelectedItem).ID;
                                    DataTable dt;
                                    dt = timeLogTableAdapter1.GetDataByChckTimeOut(id);


                                    DataTable dtTempWidRankDet = new DataTable();
                                    dtTempWidRankDet = crewTableAdapter1.GetDataByWidRank(id);



                                    if (dt.Rows.Count == 1)
                                    {
                                        DataRow drTemp;
                                        string rank = null;
                                        
                                        //Battttiiiii
                                        if (dtTempWidRankDet.Rows.Count == 1)
                                        {
                                            
                                            drTemp = dtTempWidRankDet.Rows[0];

                                            //MessageBox.Show(drTemp["rank"].ToString());

                                            //serialPort1.Write(drTemp["Details"].ToString());
                                            rank = drTemp["Details"].ToString();


                                        }



                                        try
                                        {
                                            purposeinput Pfrm = new purposeinput("Verified, please enter below the purpose of going offboard:", 2, id, rank);
                                            Pfrm.ShowDialog();
                                        }
                                        catch { }
                                        
                                    }
                                    else
                                    {
                                        DataRow drTemp;
                                        string rank = null;

                                        //Battttiiiii
                                        if (dtTempWidRankDet.Rows.Count == 1)
                                        {
                                            
                                            drTemp = dtTempWidRankDet.Rows[0];


                                            //serialPort1.Write(drTemp["Details"].ToString());
                                            rank = drTemp["Details"].ToString();
                                        }

                                        try
                                        {
                                            purposeinput Pfrm = new purposeinput("Verified, please enter below the purpose for being onboard:", 1, id, rank);
                                            Pfrm.ShowDialog();
                                        }
                                        catch { }
                                    }


                                    showOnBoardInfo();
                                }
                                else
                                {
                                    //MessageBox.Show(string.Format("{0} not verified.\r\nFingerprints do not match. Score: {1}", ((CData)lbDatabase.SelectedItem).Name, verificationResult.score));                                  

                                    if (i == lbDatabase.Items.Count - 1)
                                    {
                                        wc.SaveImage( null);
                                        SecurityCam.Image = null;
                                        wc.OpenConnection();
                                        MessageBox.Show("Invalid User");
                                    }

                                }
                            }
                            else
                            {
                                
                                if (verificationResult.engineStatus.ToString() == "ScannerTimeout")
                                {                                    
                                    doVerify();
                                    return;
                                }


                                if (verificationResult.engineStatus.ToString() != "UserCanceled")
                                    MessageBox.Show(string.Format("Verification was not finished. Reason: {0}", verificationResult.engineStatus));


                                lbDatabase.SelectedIndex = 0;
                                return;
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    
                }

            }

            

        }



		public MainForm(Nffv engine, string userDatabaseFile)
		{
			_engine = engine;


			_userDatabaseFile = userDatabaseFile;
			try
			{
				_userDB = UserDatabase.ReadFromFile(userDatabaseFile);
			}
			catch
			{
				_userDB = new UserDatabase();
			}





			InitializeComponent();

          

            dt = appSetingsTableAdapter1.GetData();

            if (dt.Rows.Count == 1)
            {
                dr = dt.Rows[0];
                lblUnitName.Text += " " + dr["UnitName"];
                lblADDRESS.Text += " " + dr["UnitAddress"];
                lblSTRENGTH.Text += " " + dr["UnitTotalSTRENGTH"];


            }


            foreach (NffvUser engineUser in _engine.Users)
            {
                string id = engineUser.Id.ToString();
                UserRecord userRec = _userDB.Lookup(engineUser.Id);
                if (userRec != null)
                {
                    id = userRec.Name;
                }
                lbDatabase.Items.Add(new CData(engineUser, id));
            }
            if (lbDatabase.Items.Count > 0)
                lbDatabase.SelectedIndex = 0;

            lblDATE.Text = "DATE: " + DateTime.Now.ToString();

            
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
            
            setupCam();
            doVerify();
            showOnBoardInfo();


            try
            {
                serialPort1.Open();
            }
            catch
            {
            }

		}

		internal class EnrollmentResult
		{
			public NffvStatus engineStatus;
			public NffvUser engineUser;
		};

		private void btnEnroll_Click(object sender, EventArgs e)
		{
			EnrollForm enrollDlg = new EnrollForm();
			if (enrollDlg.ShowDialog() == DialogResult.OK)
			{
				try
				{
					RunWorkerCompletedEventArgs taskResult = BusyForm.RunLongTask("Waiting for fingerprint ...", new DoWorkEventHandler(doEnroll),
						false, null, new EventHandler(CancelScanningHandler));
					EnrollmentResult enrollmentResult = (EnrollmentResult)taskResult.Result;
					if (enrollmentResult.engineStatus == NffvStatus.TemplateCreated)
					{
						NffvUser engineUser = enrollmentResult.engineUser;
						string userName = enrollDlg.UserName;
						if (userName.Length <= 0)
						{
							userName = engineUser.Id.ToString();
						}

						_userDB.Add(new UserRecord(engineUser.Id, userName));
						try
						{
							_userDB.WriteToFile(_userDatabaseFile);
                            wc.SaveImage(userName.ToString());
                            SecurityCam.Image = null;
                            wc.OpenConnection();

                            
						}
						catch { }

						pbExtractedImage.Image = engineUser.GetBitmap();
						lbDatabase.Items.Add(new CData(engineUser, userName));
						lbDatabase.SelectedIndex = lbDatabase.Items.Count - 1;
                        //UserInfoForm uI = new UserInfoForm( lbDatabase.Items.Count , userName);
                        //uI.ShowDialog();
					}
					else
					{
						NffvStatus engineStatus = enrollmentResult.engineStatus;
						MessageBox.Show(string.Format("Enrollment was not finished. Reason: {0}", engineStatus));
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void doEnroll(object sender, DoWorkEventArgs args)
		{
			EnrollmentResult enrollmentResults = new EnrollmentResult();
			enrollmentResults.engineUser = _engine.Enroll(20000, out enrollmentResults.engineStatus);
			args.Result = enrollmentResults;
		}

		internal class VerificationResult
		{
			public NffvStatus engineStatus;
			public int score;
		};

		private void btnVerify_Click(object sender, EventArgs e)
		{
            doVerify();
		}

		private void doVerify(object sender, DoWorkEventArgs args)
		{
			VerificationResult verificationResult = new VerificationResult();
			verificationResult.score = _engine.Verify((NffvUser)args.Argument, 20000, out verificationResult.engineStatus);
			args.Result = verificationResult;
		}

		private void CancelScanningHandler(object sender, EventArgs e)
		{
			_engine.Cancel();
		}

		private void btnDeleteUser_Click(object sender, EventArgs e)
		{
			if (lbDatabase.SelectedIndex < 0)
			{
				MessageBox.Show("Please select a record from the database.");
			}
			else
			{
				_userDB.Remove(_userDB.Lookup(((CData)lbDatabase.SelectedItem).ID));
                crewTableAdapter1.DeleteQuery(((CData)lbDatabase.SelectedItem).ID);
				try
				{
					_userDB.WriteToFile(_userDatabaseFile);
				}
				catch { }

				_engine.Users.RemoveAt(lbDatabase.SelectedIndex);
				lbDatabase.Items.RemoveAt(lbDatabase.SelectedIndex);
				if (lbDatabase.Items.Count > 0)
					lbDatabase.SelectedIndex = 0;
			}
		}

		private void btnClearDatabase_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("All records will be deleted from database. Do you want to continue?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			_engine.Users.Clear();
			lbDatabase.Items.Clear();

			_userDB.Clear();
            crewTableAdapter1.DeleteAllQuery();
			try
			{
				_userDB.WriteToFile(_userDatabaseFile);
			}
			catch { }
		}

		private void btnSettings_Click(object sender, EventArgs e)
		{
			SettingsForm settingsForm = new SettingsForm();
			settingsForm.LoadFromEngine(_engine);
			if (settingsForm.ShowDialog() == DialogResult.OK)
			{
				settingsForm.SaveToEngine(_engine);
			}
		}

		private void btnAbout_Click(object sender, EventArgs e)
		{
			AboutForm aboutForm = new AboutForm();
			aboutForm.ShowDialog();
		}

		private void lbDatabase_DoubleClick(object sender, EventArgs e)
		{
			if (lbDatabase.SelectedItem != null)
			{
				CData userData = (CData)lbDatabase.SelectedItem;
				UserInfoForm userInfoForm = new UserInfoForm(userData.ID, userData.Name);
				userInfoForm.UserName = userData.Name;
				userInfoForm.UserFingerprintImage = userData.Image;
				userInfoForm.ShowDialog();
			}
		}

        private void lbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pbExtractedImage_Click(object sender, EventArgs e)
        {

        }

        private void DAR_Click(object sender, EventArgs e)
        {
            DARform dar = new DARform();
            dar.ShowDialog();
        }

        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void ToggleUsers_Click(object sender, EventArgs e)
        {
            lbDatabase.Visible = !lbDatabase.Visible;
        }

        private void toolStripButtonShipState_Click(object sender, EventArgs e)
        {
            shipStats st = new shipStats();
            st.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Write(txtSend.Text);
            else
                MessageBox.Show("Error!");


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



	}

	class CData : IDisposable
	{
		private NffvUser _engineUser;
		private Bitmap _image;
		private string _name;

		public CData(NffvUser engineUser, string name)
		{
			_engineUser = engineUser;
			_image = engineUser.GetBitmap();
			_name = name;
		}

		public NffvUser EngineUser
		{
			get
			{
				return _engineUser;
			}
		}

		public Bitmap Image
		{
			get
			{
				return _image;
			}
		}

		public int ID
		{
			get
			{
				return _engineUser.Id;
			}
		}

		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}

		public override string ToString()
		{
			return Name;
		}

		#region IDisposable Members

		public void Dispose()
		{
			if (_image != null)
			{
				_image.Dispose();
				_image = null;
			}
		}

		#endregion
	}
}
