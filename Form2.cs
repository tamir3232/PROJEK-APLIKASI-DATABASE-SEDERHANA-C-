/*
 * Created by SharpDevelop.
 * User: tamir
 * Date: 12/5/2021
 * Time: 3:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Data;
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace menu2
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		MySqlConnection koneksi = new MySqlConnection("Server=localhost; uid=root; password=; database=menu;");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			tampildata();	
			Stok.Maximum = 10000000000;		
			Stok.Minimum = 0;//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		void tampildata()
 		{
 			try{
				mycommand.Connection=koneksi;
				myadapter.SelectCommand=mycommand;
				mycommand.CommandText="select * from makanan";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds,"dftpesan")>0)
				{
					makanan.DataSource = ds;
 					makanan.DataMember = "dftpesan";

				}
 				koneksi.Close();
 			}
 			catch (Exception ex)
 			{
			MessageBox.Show(ex.ToString());
 			}
 		}

		 void Tambah()
 		{
 			try{
 				koneksi.Open();
 				mycommand.Connection= koneksi;
 				mycommand.CommandText= "insert into makanan values ('"+Nama.Text+"', '"+Harga.Text+"', '"+Idmakanan.Text+"','"+Stok.Value+"')";
 				myadapter.SelectCommand = mycommand;
				if(mycommand.ExecuteNonQuery()==1)
				{
					MessageBox.Show("Data berhasil dimasukkan","Informasi", MessageBoxButtons.OK,MessageBoxIcon.Information); 
					tampildata();
				}
					koneksi.Close();
 			}
 			catch (Exception ex)
 			{
 				MessageBox.Show(ex.ToString());
 				koneksi.Close();
 			}
 		} 
		 void Update()
		{
			try {
				koneksi.Open();
				mycommand.CommandText="update makanan set id_makanan='"+Idmakanan.Text+"', nama_makanan ='"+Nama.Text+"',harga_makanan='"+Harga.Text+"', stok_makanan='"+Stok.Value+"'  where id_makanan='"+Idmakanan.Text+"'";
				myadapter.SelectCommand=mycommand;
				mycommand.ExecuteNonQuery();
				tampildata(); 
				koneksi.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				koneksi.Close();
			}
		}
		void Delete()
		{
			try{
				koneksi.Open();
				mycommand.CommandText="delete from makanan where id_makanan='"+Idmakanan.Text+"'";
				myadapter.SelectCommand = mycommand;
				mycommand.ExecuteNonQuery();
				tampildata();
				koneksi.Close();
				}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				koneksi.Close();
			}
		}

		
		
		
		void createClick(object sender, EventArgs e)
		{
			Tambah();
		}
		
		
		void MakananCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Idmakanan.Text = makanan.Rows[e.RowIndex].Cells[2].Value.ToString();
			Nama.Text = makanan.Rows[e.RowIndex].Cells[0].Value.ToString();
			Harga.Text = makanan.Rows[e.RowIndex].Cells[1].Value.ToString();
			Stok.Value = makanan.Rows[e.RowIndex].Cells[3].Value.GetHashCode();

		}
		
		void RemoveClick(object sender, EventArgs e)
		{
			Delete();
		}
		
		void UpdateClick(object sender, EventArgs e)
		{
			
			Update();
		}

        private void makananToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void minumanToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.Hide();
			Form3 form3 = new Form3();
			form3.ShowDialog();
		}

        
       

        private void backToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
			this.Hide();
			MainForm main = new MainForm();
			main.ShowDialog();
		}

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.Hide();
			Form1 form1 = new Form1();
			form1.ShowDialog();
		}

        private void minumanToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
			this.Hide();
			Form3 form3 = new Form3();
			form3.ShowDialog();
		}
    }

	
}
