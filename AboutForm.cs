using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Diagnostics;

using Neurotec;
using Neurotec.Biometrics;

namespace SecuritySystem
{
	public partial class AboutForm : Form
	{

		public AboutForm()
		{
			InitializeComponent();

			lblCopyright1.Text = Application.ProductName + " " + Application.ProductVersion;
			lblCopyright2.Text = "Copyright © 2010 Muhammad Ahmed";

			string OSName = System.Environment.OSVersion.Platform.ToString();
			lblOS.Text = string.Format("{0}. Version {1}.{2} (Build {3})",
				OSName ?? "Windows",
				System.Environment.OSVersion.Version.Major,
				System.Environment.OSVersion.Version.Minor,
				System.Environment.OSVersion.Version.Build);

			lblServicePack.Text = System.Environment.OSVersion.ServicePack;

	
		}

	

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }
	}
}
