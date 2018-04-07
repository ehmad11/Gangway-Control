
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SecuritySystem
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

            
            
			Neurotec.Biometrics.Nffv engine = null;            

			try
			{

                engine = new Neurotec.Biometrics.Nffv("db.dat", "pass123", "CrossMatch");
                Application.Run(new MainForm(engine, "db.xml"));
                
                
			}
			catch (Exception ex)
			{                
                

				MessageBox.Show(
					string.Format("An error has occured: {0}", ex.Message), "VMS",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (engine != null)
				{
					engine.Dispose();
				}
			}
		}
	}
}
