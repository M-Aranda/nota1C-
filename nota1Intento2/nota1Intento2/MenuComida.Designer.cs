/*
 * Created by SharpDevelop.
 * User: Marce
 * Date: 8/18/2018
 * Time: 4:09 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace nota1Intento2
{
	partial class MenuComida
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblComida;
		private System.Windows.Forms.ComboBox cboComida;
		private System.Windows.Forms.PictureBox pbxComida;
		
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
			this.lblComida = new System.Windows.Forms.Label();
			this.cboComida = new System.Windows.Forms.ComboBox();
			this.pbxComida = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbxComida)).BeginInit();
			this.SuspendLayout();
			// 
			// lblComida
			// 
			this.lblComida.Location = new System.Drawing.Point(25, 46);
			this.lblComida.Name = "lblComida";
			this.lblComida.Size = new System.Drawing.Size(53, 23);
			this.lblComida.TabIndex = 0;
			this.lblComida.Text = "Comida: ";
			// 
			// cboComida
			// 
			this.cboComida.FormattingEnabled = true;
			this.cboComida.Location = new System.Drawing.Point(68, 43);
			this.cboComida.Name = "cboComida";
			this.cboComida.Size = new System.Drawing.Size(121, 21);
			this.cboComida.TabIndex = 1;
			this.cboComida.SelectedIndexChanged += new System.EventHandler(this.CboComidaSelectedIndexChanged);
			// 
			// pbxComida
			// 
			this.pbxComida.Location = new System.Drawing.Point(241, 19);
			this.pbxComida.Name = "pbxComida";
			this.pbxComida.Size = new System.Drawing.Size(573, 230);
			this.pbxComida.TabIndex = 2;
			this.pbxComida.TabStop = false;
			// 
			// MenuComida
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(826, 261);
			this.Controls.Add(this.pbxComida);
			this.Controls.Add(this.cboComida);
			this.Controls.Add(this.lblComida);
			this.Name = "MenuComida";
			this.Text = "MenuComida";
			((System.ComponentModel.ISupportInitialize)(this.pbxComida)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
