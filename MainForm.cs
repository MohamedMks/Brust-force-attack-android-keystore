/*
 * Created by SharpDevelop.
 * User: adminpc
 * Date: 21-Mar-16
 * Time: 4:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace BF
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnjarClick(object sender, EventArgs e)
		{
	
			openJarFile.Filter = "JAR Files (JAR)|*.JAR";
			DialogResult result = openJarFile.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {

            }
            Console.WriteLine(result); // <-- For debugging use.
			jarfilelbl.Text= openJarFile.FileName;
		}
		
		void BtnkeyClick(object sender, EventArgs e)
		{
			openKStore.Filter = "Key Store Files (JKS,KEYSTORE)|*.JKS;*.KEYSTORE";
			DialogResult result = openKStore.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
            	//KStorePath.Text= "OK";
            }  
            	
            KStorePath.Text= openKStore.FileName;
            Console.WriteLine(result); // <-- For debugging use.                  
		}
		
		void BtnlistClick(object sender, EventArgs e)
		{
			openListFile.Filter = "TXT Files (TXT)|*.TXT";
			DialogResult result = openListFile.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {

            }
            Console.WriteLine(result); // <-- For debugging use.
            listPath.Text= openListFile.FileName;
		}


		void BtnAttackClick(object sender, EventArgs e)
		{
			
            string txt1 = "\""+jarfilelbl.Text+"\"";
			string txt2 = "\""+KStorePath.Text+"\"";
			string txt3 = "\""+listPath.Text+"\"";
			
			switch (Mode.Text)
            {
                case "Word list mode":
                    string strCmdText2;   
                    strCmdText2= "/K java -jar "+txt1+" -m 2 -k "+txt2+" -d "+txt3;
                    System.Diagnostics.Process.Start("CMD.exe",strCmdText2);
                    lblResult.Text= "Please check result in CMD";

                    break;
                case "Smart word list mode":
                    string strCmdText3;   
                    strCmdText3= "/K java -jar "+txt1+" -m 3 -k "+txt2+" -d "+txt3;
                    System.Diagnostics.Process.Start("CMD.exe",strCmdText3);
                    lblResult.Text= "Please check result in CMD";
            
                    break;
                    
               case "test":
                   // string strCmdText3;   
                    strCmdText3= "/K java -jar "+txt1+" -m 3 -k "+txt2+" -d "+txt3;
                    //System.Diagnostics.Process.Start("CMD.exe",strCmdText3);
                    ProcessStartInfo psi = new ProcessStartInfo("adb","-help");
                    psi.UseShellExecute = false;
                    psi.RedirectStandardOutput = true;
                    psi.CreateNoWindow = true;
                    var proc = Process.Start(psi);
                    
                    lblResult.Text= proc.StandardOutput.ReadToEnd();
            
                    break;
                default:
                    break;
            }
			
			
			
			
		}
		void ModeSelectedIndexChanged(object sender, EventArgs e)
		{
			switch (Mode.Text)
            {
                case "Word list mode":

                    lblmode.Text= "This mode will try to get password from given passwords in the list";

                    break;
                case "Smart word list mode":
                    lblmode.Text= "This mode will try to get password with a smart way";
            
                    break;
                    
                    case "test":
                    lblmode.Text= "This test mode ";
            
                    break;
                default:
                    break;
            }
	
		}
		void LangSelectedIndexChanged(object sender, EventArgs e)
		{
			/*
			switch (Lang.Text)
            {
                case "Default":

                    break;
                case "العربية":
                    
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("ar");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar");

                    break;
                case "English":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");

                    break;
                default:
                    break;
            }
            */
	
		}


		
	}
}
