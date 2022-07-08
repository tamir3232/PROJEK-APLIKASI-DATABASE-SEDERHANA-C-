/*
 * Created by SharpDevelop.
 * User: tamir
 * Date: 12/5/2021
 * Time: 3:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace menu2
{
	partial class Form2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.Nama = new System.Windows.Forms.TextBox();
            this.Harga = new System.Windows.Forms.TextBox();
            this.Idmakanan = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.makanan = new System.Windows.Forms.DataGridView();
            this.Stok = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minumanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.makanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stok)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(610, 34);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 165);
            this.vScrollBar1.TabIndex = 59;
            // 
            // Nama
            // 
            this.Nama.Location = new System.Drawing.Point(285, 261);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(264, 20);
            this.Nama.TabIndex = 58;
            // 
            // Harga
            // 
            this.Harga.Location = new System.Drawing.Point(285, 294);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(264, 20);
            this.Harga.TabIndex = 56;
            // 
            // Idmakanan
            // 
            this.Idmakanan.Location = new System.Drawing.Point(285, 230);
            this.Idmakanan.Name = "Idmakanan";
            this.Idmakanan.Size = new System.Drawing.Size(264, 20);
            this.Idmakanan.TabIndex = 55;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Freestyle Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(424, 375);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(81, 47);
            this.update.TabIndex = 54;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.UpdateClick);
            // 
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("Freestyle Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.Location = new System.Drawing.Point(271, 375);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(87, 47);
            this.remove.TabIndex = 53;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.RemoveClick);
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.Transparent;
            this.create.Font = new System.Drawing.Font("Freestyle Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.ForeColor = System.Drawing.Color.Black;
            this.create.Location = new System.Drawing.Point(114, 375);
            this.create.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(81, 47);
            this.create.TabIndex = 52;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.createClick);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 51;
            this.label4.Text = "STOK";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 23);
            this.label3.TabIndex = 50;
            this.label3.Text = "HARGA";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 48;
            this.label1.Text = "ID ";
            // 
            // makanan
            // 
            this.makanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.makanan.Location = new System.Drawing.Point(17, 34);
            this.makanan.Name = "makanan";
            this.makanan.Size = new System.Drawing.Size(610, 165);
            this.makanan.TabIndex = 47;
            this.makanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MakananCellContentClick);
            // 
            // Stok
            // 
            this.Stok.Location = new System.Drawing.Point(285, 325);
            this.Stok.Name = "Stok";
            this.Stok.Size = new System.Drawing.Size(264, 20);
            this.Stok.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 23);
            this.label5.TabIndex = 62;
            this.label5.Text = "NAMA MAKANAN";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 63;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click_2);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.minumanToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // minumanToolStripMenuItem
            // 
            this.minumanToolStripMenuItem.Name = "minumanToolStripMenuItem";
            this.minumanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.minumanToolStripMenuItem.Text = "Minuman";
            this.minumanToolStripMenuItem.Click += new System.EventHandler(this.minumanToolStripMenuItem_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 456);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Stok);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.Harga);
            this.Controls.Add(this.Idmakanan);
            this.Controls.Add(this.update);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.create);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.makanan);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.makanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stok)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView makanan;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button create;
		private System.Windows.Forms.Button remove;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.TextBox Idmakanan;
		private System.Windows.Forms.TextBox Harga;
		private System.Windows.Forms.NumericUpDown Stok;
		private System.Windows.Forms.TextBox Nama;
		private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minumanToolStripMenuItem;
    }
}
