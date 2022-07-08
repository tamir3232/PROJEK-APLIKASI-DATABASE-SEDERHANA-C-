/*
 * Created by SharpDevelop.
 * User: tamir
 * Date: 12/1/2021
 * Time: 10:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace menu2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Form1 form1 = new Form1();
		Form2 form2 = new Form2();
		Form3 form3 = new Form3();
		MySqlConnection koneksi = new MySqlConnection("Server=localhost; uid=root; password=; database=menu;");
	
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
		
		public bool dbOpen(){
			try{
				koneksi.Open();
			}
			catch{
				MessageBox.Show("tidak terhubung");
				return false;

			}
			return true;
		}
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void Btn_cutommerClick(object sender, EventArgs e)
		{
			if(dbOpen()){
				this.Hide();
				form1.ShowDialog();
				koneksi.Close();
				this.Close();
				
			}
		}
		
		void Btn_makananClick(object sender, EventArgs e)
		{
			if(dbOpen()){
				this.Hide();
				form2.ShowDialog();
				koneksi.Close();
				this.Close();
			}
		}
		
		void Btn_minumanClick(object sender, EventArgs e)
		{
			if(dbOpen()){
				this.Hide();
				form3.ShowDialog();
				koneksi.Close();
				
			}
		}
		
		void CEkToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void CEKKONEKSIToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dbOpen()){
				MessageBox.Show("Terhubung Ke Database");
				koneksi.Close();
			}
		}
	}
}
