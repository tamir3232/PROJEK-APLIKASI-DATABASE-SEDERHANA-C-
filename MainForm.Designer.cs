/*
 * Created by SharpDevelop.
 * User: tamir
 * Date: 12/1/2021
 * Time: 10:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace menu2
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btn_cutommer = new System.Windows.Forms.Button();
			this.btn_makanan = new System.Windows.Forms.Button();
			this.btn_minuman = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cEkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cEKKONEKSIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_cutommer
			// 
			this.btn_cutommer.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btn_cutommer.Location = new System.Drawing.Point(299, 139);
			this.btn_cutommer.Name = "btn_cutommer";
			this.btn_cutommer.Size = new System.Drawing.Size(172, 83);
			this.btn_cutommer.TabIndex = 0;
			this.btn_cutommer.Text = "Custommer";
			this.btn_cutommer.UseVisualStyleBackColor = false;
			this.btn_cutommer.Click += new System.EventHandler(this.Btn_cutommerClick);
			// 
			// btn_makanan
			// 
			this.btn_makanan.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btn_makanan.Location = new System.Drawing.Point(299, 228);
			this.btn_makanan.Name = "btn_makanan";
			this.btn_makanan.Size = new System.Drawing.Size(172, 87);
			this.btn_makanan.TabIndex = 1;
			this.btn_makanan.Text = "Makanan";
			this.btn_makanan.UseVisualStyleBackColor = false;
			this.btn_makanan.Click += new System.EventHandler(this.Btn_makananClick);
			// 
			// btn_minuman
			// 
			this.btn_minuman.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btn_minuman.Location = new System.Drawing.Point(299, 321);
			this.btn_minuman.Name = "btn_minuman";
			this.btn_minuman.Size = new System.Drawing.Size(172, 90);
			this.btn_minuman.TabIndex = 2;
			this.btn_minuman.Text = "Minuman";
			this.btn_minuman.UseVisualStyleBackColor = false;
			this.btn_minuman.Click += new System.EventHandler(this.Btn_minumanClick);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(335, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 29);
			this.label2.TabIndex = 3;
			this.label2.Text = "MENU";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cEkToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(764, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// cEkToolStripMenuItem
			// 
			this.cEkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cEKKONEKSIToolStripMenuItem});
			this.cEkToolStripMenuItem.Name = "cEkToolStripMenuItem";
			this.cEkToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.cEkToolStripMenuItem.Text = "Cek";
			this.cEkToolStripMenuItem.Click += new System.EventHandler(this.CEkToolStripMenuItemClick);
			// 
			// cEKKONEKSIToolStripMenuItem
			// 
			this.cEKKONEKSIToolStripMenuItem.Name = "cEKKONEKSIToolStripMenuItem";
			this.cEKKONEKSIToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.cEKKONEKSIToolStripMenuItem.Text = "CEK KONEKSI";
			this.cEKKONEKSIToolStripMenuItem.Click += new System.EventHandler(this.CEKKONEKSIToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(764, 512);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_minuman);
			this.Controls.Add(this.btn_makanan);
			this.Controls.Add(this.btn_cutommer);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "menu2";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem cEKKONEKSIToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cEkToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_minuman;
		private System.Windows.Forms.Button btn_makanan;
		private System.Windows.Forms.Button btn_cutommer;
	}
}
