/*
 * Created by SharpDevelop.
 * User: tamir
 * Date: 12/2/2021
 * Time: 10:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace menu2
{
	partial class Form1
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
            this.Jml_Order = new System.Windows.Forms.TextBox();
            this.Nama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.Pelanggan = new System.Windows.Forms.DataGridView();
            this.create = new System.Windows.Forms.Button();
            this.No_antri = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bACKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makananToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minumanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Pelanggan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.No_antri)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Jml_Order
            // 
            this.Jml_Order.Location = new System.Drawing.Point(243, 270);
            this.Jml_Order.Name = "Jml_Order";
            this.Jml_Order.Size = new System.Drawing.Size(264, 20);
            this.Jml_Order.TabIndex = 23;
            this.Jml_Order.TextChanged += new System.EventHandler(this.Jml_OrderTextChanged);
            // 
            // Nama
            // 
            this.Nama.Location = new System.Drawing.Point(243, 239);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(264, 20);
            this.Nama.TabIndex = 20;
            this.Nama.TextChanged += new System.EventHandler(this.NamaTextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "NOMOR ANTRIAN";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "JUMLAH ORDERAN";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "NAMA";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ControlLight;
            this.update.Font = new System.Drawing.Font("Freestyle Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(396, 397);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(81, 47);
            this.update.TabIndex = 15;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.updateClick);
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.SystemColors.ControlLight;
            this.remove.Font = new System.Drawing.Font("Freestyle Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.Location = new System.Drawing.Point(243, 397);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(81, 47);
            this.remove.TabIndex = 14;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.removeClick);
            // 
            // Pelanggan
            // 
            this.Pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pelanggan.Location = new System.Drawing.Point(48, 51);
            this.Pelanggan.Name = "Pelanggan";
            this.Pelanggan.ReadOnly = true;
            this.Pelanggan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Pelanggan.Size = new System.Drawing.Size(486, 150);
            this.Pelanggan.TabIndex = 13;
            this.Pelanggan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PelangganCellContentClick);
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.Transparent;
            this.create.Font = new System.Drawing.Font("Freestyle Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.ForeColor = System.Drawing.Color.Black;
            this.create.Location = new System.Drawing.Point(89, 397);
            this.create.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(81, 47);
            this.create.TabIndex = 12;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.createClick);
            // 
            // No_antri
            // 
            this.No_antri.Location = new System.Drawing.Point(243, 303);
            this.No_antri.Name = "No_antri";
            this.No_antri.Size = new System.Drawing.Size(264, 20);
            this.No_antri.TabIndex = 24;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bACKToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bACKToolStripMenuItem
            // 
            this.bACKToolStripMenuItem.Name = "bACKToolStripMenuItem";
            this.bACKToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.bACKToolStripMenuItem.Text = "BACK";
            this.bACKToolStripMenuItem.Click += new System.EventHandler(this.bACKToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makananToolStripMenuItem,
            this.minumanToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // makananToolStripMenuItem
            // 
            this.makananToolStripMenuItem.Name = "makananToolStripMenuItem";
            this.makananToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.makananToolStripMenuItem.Text = "Makanan";
            this.makananToolStripMenuItem.Click += new System.EventHandler(this.makananToolStripMenuItem_Click);
            // 
            // minumanToolStripMenuItem
            // 
            this.minumanToolStripMenuItem.Name = "minumanToolStripMenuItem";
            this.minumanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.minumanToolStripMenuItem.Text = "Minuman";
            this.minumanToolStripMenuItem.Click += new System.EventHandler(this.minumanToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 501);
            this.Controls.Add(this.No_antri);
            this.Controls.Add(this.Jml_Order);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.Pelanggan);
            this.Controls.Add(this.create);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pelanggan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.No_antri)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.NumericUpDown No_antri;
		private System.Windows.Forms.Button create;
		private System.Windows.Forms.DataGridView Pelanggan;
		private System.Windows.Forms.Button remove;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Nama;
		private System.Windows.Forms.TextBox Jml_Order;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bACKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makananToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minumanToolStripMenuItem;
    }
}
