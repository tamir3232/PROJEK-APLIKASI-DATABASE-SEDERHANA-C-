/*
 * Created by SharpDevelop.
 * User: tamir
 * Date: 12/2/2021
 * Time: 11:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace menu2
{
	partial class Form3
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.minuman = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.Nama = new System.Windows.Forms.TextBox();
            this.Harga = new System.Windows.Forms.TextBox();
            this.id_minuman = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.Stok = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makananToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.minuman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stok)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "STOK";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "HARGA";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "NAMA MINUMAN";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID ";
            // 
            // minuman
            // 
            this.minuman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.minuman.Location = new System.Drawing.Point(22, 40);
            this.minuman.Name = "minuman";
            this.minuman.Size = new System.Drawing.Size(610, 165);
            this.minuman.TabIndex = 25;
            this.minuman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MinumanCellContentClick);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Freestyle Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(429, 381);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(81, 47);
            this.update.TabIndex = 41;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.UpdateClick);
            // 
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("Freestyle Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.Location = new System.Drawing.Point(276, 381);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(87, 47);
            this.remove.TabIndex = 40;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.RemoveClick);
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.Transparent;
            this.create.Font = new System.Drawing.Font("Freestyle Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.ForeColor = System.Drawing.Color.Black;
            this.create.Location = new System.Drawing.Point(119, 381);
            this.create.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(81, 47);
            this.create.TabIndex = 39;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.CreateClick);
            // 
            // Nama
            // 
            this.Nama.Location = new System.Drawing.Point(290, 267);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(264, 20);
            this.Nama.TabIndex = 45;
            // 
            // Harga
            // 
            this.Harga.Location = new System.Drawing.Point(290, 300);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(264, 20);
            this.Harga.TabIndex = 43;
            // 
            // id_minuman
            // 
            this.id_minuman.Location = new System.Drawing.Point(290, 236);
            this.id_minuman.Name = "id_minuman";
            this.id_minuman.Size = new System.Drawing.Size(264, 20);
            this.id_minuman.TabIndex = 42;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(615, 40);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 165);
            this.vScrollBar1.TabIndex = 46;
            // 
            // Stok
            // 
            this.Stok.Location = new System.Drawing.Point(290, 331);
            this.Stok.Name = "Stok";
            this.Stok.Size = new System.Drawing.Size(264, 20);
            this.Stok.TabIndex = 47;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(659, 24);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.makananToolStripMenuItem});
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
            // makananToolStripMenuItem
            // 
            this.makananToolStripMenuItem.Name = "makananToolStripMenuItem";
            this.makananToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.makananToolStripMenuItem.Text = "Makanan";
            this.makananToolStripMenuItem.Click += new System.EventHandler(this.makananToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 462);
            this.Controls.Add(this.Stok);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.Harga);
            this.Controls.Add(this.id_minuman);
            this.Controls.Add(this.update);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.create);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minuman);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.minuman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stok)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.VScrollBar vScrollBar1;
		private System.Windows.Forms.TextBox id_minuman;
		private System.Windows.Forms.TextBox Harga;
		private System.Windows.Forms.NumericUpDown Stok;
		private System.Windows.Forms.TextBox Nama;
		private System.Windows.Forms.Button create;
		private System.Windows.Forms.Button remove;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.DataGridView minuman;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makananToolStripMenuItem;
    }
}
