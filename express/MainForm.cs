/*
 * Created by SharpDevelop.
 * User: zhou.ke
 * Date: 2018/2/12
 * Time: 15:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Runtime.InteropServices;
using System.Media;
	
namespace express
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
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
		
		private void FormLoad(object sender, EventArgs e)
		{
			
		//	 axWindowsMediaPlayer.URL = "爱无反顾.mp3"; 
		
		}
		private void Button1Click(object sender, EventArgs e)
		{
			try {
			SoundPlayer player = new SoundPlayer();
			player.SoundLocation = Application.StartupPath + "\\我养你啊.wav";
			player.LoadAsync();
			player.Play();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		
		}
	}
}
