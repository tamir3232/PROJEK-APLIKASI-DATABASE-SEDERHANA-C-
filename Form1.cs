/*
 * Created by SharpDevelop.
 * User: tamir
 * Date: 12/2/2021
 * Time: 10:59 PM
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
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		MySqlConnection koneksi = new MySqlConnection("Server=localhost; uid=root; password=; database=menu;");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			tampildata();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void tampildata()
 		{
 			try{
				mycommand.Connection=koneksi;
				myadapter.SelectCommand=mycommand;
				mycommand.CommandText="select * from customer";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds,"dftpesan")>0)
				{
					Pelanggan.DataSource = ds;
 					Pelanggan.DataMember = "dftpesan";
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
 				mycommand.CommandText= "insert into customer values ('"+Nama.Text+"','"+Jml_Order.Text+"', '"+No_antri.Value+"')";
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
				mycommand.CommandText="update customer set nama_pelanggan='"+Nama.Text+"', jum_orderan ='"+Jml_Order.Text+"' where nomor_antrian='"+No_antri.Value+"'";
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
				mycommand.CommandText="delete from customer where nomor_antrian='"+No_antri.Value+"'";
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






		void PelangganCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Nama.Text = Pelanggan.Rows[e.RowIndex].Cells[0].Value.ToString();
			Jml_Order.Text = Pelanggan.Rows[e.RowIndex].Cells[1].Value.ToString();
			No_antri.Value = Pelanggan.Rows[e.RowIndex].Cells[2].Value.GetHashCode();
			
			
		}
		
		void NamaTextChanged(object sender, EventArgs e)
		{

			
		}
		
		void Jml_OrderTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void No_antriTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TanggalDateChanged(object sender, DateRangeEventArgs e)
		{
			
		}
		
		void createClick(object sender, EventArgs e)
		{
			Tambah();
		}
		
		void removeClick(object sender, EventArgs e)
		{
			Delete();
		}
		
		void updateClick(object sender, EventArgs e)
		{
			Update();
		}

        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.Hide();
			MainForm main = new MainForm();
			main.ShowDialog();
			
        }

        private void makananToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.Hide();
			Form2 form2 = new Form2();
			form2.ShowDialog();
		}

        private void minumanToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.Hide();
			Form3 form3 = new Form3();
			form3.ShowDialog();
		}
    }
}
