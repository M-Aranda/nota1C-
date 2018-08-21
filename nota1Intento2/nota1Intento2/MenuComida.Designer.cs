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
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label lblPrecio;
		private System.Windows.Forms.Button btnCambiarColor;
		private System.Windows.Forms.ColorDialog cdFondo;
		
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
			this.components = new System.ComponentModel.Container();
			this.lblComida = new System.Windows.Forms.Label();
			this.cboComida = new System.Windows.Forms.ComboBox();
			this.pbxComida = new System.Windows.Forms.PictureBox();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.btnCambiarColor = new System.Windows.Forms.Button();
			this.cdFondo = new System.Windows.Forms.ColorDialog();
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
			this.pbxComida.Size = new System.Drawing.Size(788, 427);
			this.pbxComida.TabIndex = 2;
			this.pbxComida.TabStop = false;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(68, 93);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.ReadOnly = true;
			this.txtPrecio.Size = new System.Drawing.Size(121, 20);
			this.txtPrecio.TabIndex = 3;
			// 
			// lblPrecio
			// 
			this.lblPrecio.Location = new System.Drawing.Point(25, 96);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(44, 23);
			this.lblPrecio.TabIndex = 4;
			this.lblPrecio.Text = "Precio:";
			// 
			// btnCambiarColor
			// 
			this.btnCambiarColor.Location = new System.Drawing.Point(25, 136);
			this.btnCambiarColor.Name = "btnCambiarColor";
			this.btnCambiarColor.Size = new System.Drawing.Size(181, 23);
			this.btnCambiarColor.TabIndex = 5;
			this.btnCambiarColor.Text = "Quiero cambiar el color de fondo";
			this.btnCambiarColor.UseVisualStyleBackColor = true;
			this.btnCambiarColor.Click += new System.EventHandler(this.BtnCambiarColorClick);
			// 
			// MenuComida
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1032, 458);
			this.Controls.Add(this.btnCambiarColor);
			this.Controls.Add(this.lblPrecio);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.pbxComida);
			this.Controls.Add(this.cboComida);
			this.Controls.Add(this.lblComida);
			this.Name = "MenuComida";
			this.Text = "MenuComida";
			this.Load += new System.EventHandler(this.MenuComidaLoad);
			this.SizeChanged += new System.EventHandler(this.MenuComidaSizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.pbxComida)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
