/*
 * Created by SharpDevelop.
 * User: tamir
 * Date: 12/2/2021
 * Time: 11:09 PM
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
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		MySqlConnection koneksi = new MySqlConnection("Server=localhost; uid=root; password=; database=menu;");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public Form3()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			tampildata();
			Stok.Maximum = 10000000000;		
			Stok.Minimum = 0;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void tampildata()
 		{
 			try{
				mycommand.Connection=koneksi;
				myadapter.SelectCommand=mycommand;
				mycommand.CommandText="select * from minuman";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds,"dftpesan")>0)
				{
					minuman.DataSource = ds;
 					minuman.DataMember = "dftpesan";

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
 				mycommand.CommandText= "insert into minuman values ('"+Nama.Text+"', '"+Harga.Text+"', '"+id_minuman.Text+"','"+Stok.Value+"')";
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
				mycommand.CommandText="update minuman set id_minuman='"+id_minuman.Text+"', nama_minuman ='"+Nama.Text+"',harga_minuman='"+Harga.Text+"', stok_minuman='"+Stok.Value+"'  where id_minuman='"+id_minuman.Text+"'";
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
				mycommand.CommandText="delete from minuman where id_minuman='"+id_minuman.Text+"'";
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

		void MinumanCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			id_minuman.Text = minuman.Rows[e.RowIndex].Cells[2].Value.ToString();
			Nama.Text = minuman.Rows[e.RowIndex].Cells[0].Value.ToString();
			Harga.Text = minuman.Rows[e.RowIndex].Cells[1].Value.ToString();
			Stok.Value = minuman.Rows[e.RowIndex].Cells[3].Value.GetHashCode();
		}
		
		
		
		
		
		void RemoveClick(object sender, EventArgs e)
		{
			Delete();
		}
		
		void UpdateClick(object sender, EventArgs e)
		{
			
			Update();
		}
		
		void CreateClick(object sender, EventArgs e)
		{
			Tambah();
		}

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void makananToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.Hide();
			Form2 form2 = new Form2();
			form2.ShowDialog();
		}
    }
		
}