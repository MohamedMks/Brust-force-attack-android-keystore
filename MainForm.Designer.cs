/*
 * Created by SharpDevelop.
 * User: adminpc
 * Date: 21-Mar-16
 * Time: 4:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BF
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnjar;
		private System.Windows.Forms.Button btnkey;
		private System.Windows.Forms.Button btnlist;
		private System.Windows.Forms.Button btnAttack;
		private System.Windows.Forms.OpenFileDialog openKStore;
		private System.Windows.Forms.OpenFileDialog openListFile;
		private System.Windows.Forms.Label KStorePath;
		private System.Windows.Forms.Label listPath;
		private System.Windows.Forms.Label jarfilelbl;
		private System.Windows.Forms.OpenFileDialog openJarFile;
		private System.Windows.Forms.TextBox lblResult;
		private System.Windows.Forms.ComboBox Mode;
		private System.Windows.Forms.Label lblmode;
		private System.Windows.Forms.Label versionlbl;
		private System.Windows.Forms.ComboBox Lang;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnjar = new System.Windows.Forms.Button();
			this.btnkey = new System.Windows.Forms.Button();
			this.btnlist = new System.Windows.Forms.Button();
			this.btnAttack = new System.Windows.Forms.Button();
			this.openKStore = new System.Windows.Forms.OpenFileDialog();
			this.openListFile = new System.Windows.Forms.OpenFileDialog();
			this.KStorePath = new System.Windows.Forms.Label();
			this.listPath = new System.Windows.Forms.Label();
			this.jarfilelbl = new System.Windows.Forms.Label();
			this.openJarFile = new System.Windows.Forms.OpenFileDialog();
			this.Mode = new System.Windows.Forms.ComboBox();
			this.lblmode = new System.Windows.Forms.Label();
			this.versionlbl = new System.Windows.Forms.Label();
			this.Lang = new System.Windows.Forms.ComboBox();
			this.lblResult = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnjar
			// 
			resources.ApplyResources(this.btnjar, "btnjar");
			this.btnjar.Name = "btnjar";
			this.btnjar.UseVisualStyleBackColor = true;
			this.btnjar.Click += new System.EventHandler(this.BtnjarClick);
			// 
			// btnkey
			// 
			resources.ApplyResources(this.btnkey, "btnkey");
			this.btnkey.Name = "btnkey";
			this.btnkey.UseVisualStyleBackColor = true;
			this.btnkey.Click += new System.EventHandler(this.BtnkeyClick);
			// 
			// btnlist
			// 
			resources.ApplyResources(this.btnlist, "btnlist");
			this.btnlist.Name = "btnlist";
			this.btnlist.UseVisualStyleBackColor = true;
			this.btnlist.Click += new System.EventHandler(this.BtnlistClick);
			// 
			// btnAttack
			// 
			resources.ApplyResources(this.btnAttack, "btnAttack");
			this.btnAttack.Name = "btnAttack";
			this.btnAttack.UseVisualStyleBackColor = true;
			this.btnAttack.Click += new System.EventHandler(this.BtnAttackClick);
			// 
			// openKStore
			// 
			this.openKStore.FileName = "openKStore";
			// 
			// openListFile
			// 
			this.openListFile.FileName = "openListFile";
			// 
			// KStorePath
			// 
			resources.ApplyResources(this.KStorePath, "KStorePath");
			this.KStorePath.BackColor = System.Drawing.SystemColors.ControlLight;
			this.KStorePath.Name = "KStorePath";
			// 
			// listPath
			// 
			resources.ApplyResources(this.listPath, "listPath");
			this.listPath.BackColor = System.Drawing.SystemColors.ControlLight;
			this.listPath.Name = "listPath";
			// 
			// jarfilelbl
			// 
			resources.ApplyResources(this.jarfilelbl, "jarfilelbl");
			this.jarfilelbl.BackColor = System.Drawing.SystemColors.ControlLight;
			this.jarfilelbl.Name = "jarfilelbl";
			// 
			// openJarFile
			// 
			this.openJarFile.FileName = "openJarFile";
			// 
			// Mode
			// 
			resources.ApplyResources(this.Mode, "Mode");
			this.Mode.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.Mode.FormattingEnabled = true;
			this.Mode.Items.AddRange(new object[] {
									resources.GetString("Mode.Items"),
									resources.GetString("Mode.Items1"),
									resources.GetString("Mode.Items2")});
			this.Mode.Name = "Mode";
			this.Mode.SelectedIndexChanged += new System.EventHandler(this.ModeSelectedIndexChanged);
			// 
			// lblmode
			// 
			resources.ApplyResources(this.lblmode, "lblmode");
			this.lblmode.Name = "lblmode";
			// 
			// versionlbl
			// 
			resources.ApplyResources(this.versionlbl, "versionlbl");
			this.versionlbl.Name = "versionlbl";
			// 
			// Lang
			// 
			resources.ApplyResources(this.Lang, "Lang");
			this.Lang.FormattingEnabled = true;
			this.Lang.Items.AddRange(new object[] {
									resources.GetString("Lang.Items"),
									resources.GetString("Lang.Items1")});
			this.Lang.Name = "Lang";
			this.Lang.SelectedIndexChanged += new System.EventHandler(this.LangSelectedIndexChanged);
			// 
			// lblResult
			// 
			resources.ApplyResources(this.lblResult, "lblResult");
			this.lblResult.Name = "lblResult";
			this.lblResult.ReadOnly = true;
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.Lang);
			this.Controls.Add(this.versionlbl);
			this.Controls.Add(this.lblmode);
			this.Controls.Add(this.Mode);
			this.Controls.Add(this.jarfilelbl);
			this.Controls.Add(this.listPath);
			this.Controls.Add(this.KStorePath);
			this.Controls.Add(this.btnAttack);
			this.Controls.Add(this.btnlist);
			this.Controls.Add(this.btnkey);
			this.Controls.Add(this.btnjar);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		
	}
}
