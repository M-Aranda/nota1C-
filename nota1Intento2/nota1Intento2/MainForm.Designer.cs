/*
 * Created by SharpDevelop.
 * User: Marce
 * Date: 8/18/2018
 * Time: 3:49 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace nota1Intento2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnElegirCOmida;
		private System.Windows.Forms.Label lblNombreCliente;
		private System.Windows.Forms.Label lblDireccionCliente;
		private System.Windows.Forms.TextBox txtNombreCliente;
		private System.Windows.Forms.TextBox txtDireccionCliente;
		
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
			this.btnElegirCOmida = new System.Windows.Forms.Button();
			this.lblNombreCliente = new System.Windows.Forms.Label();
			this.lblDireccionCliente = new System.Windows.Forms.Label();
			this.txtNombreCliente = new System.Windows.Forms.TextBox();
			this.txtDireccionCliente = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnElegirCOmida
			// 
			this.btnElegirCOmida.Location = new System.Drawing.Point(61, 98);
			this.btnElegirCOmida.Name = "btnElegirCOmida";
			this.btnElegirCOmida.Size = new System.Drawing.Size(103, 23);
			this.btnElegirCOmida.TabIndex = 0;
			this.btnElegirCOmida.Text = "Elegir comida";
			this.btnElegirCOmida.UseVisualStyleBackColor = true;
			this.btnElegirCOmida.Click += new System.EventHandler(this.BtnElegirCOmidaClick);
			// 
			// lblNombreCliente
			// 
			this.lblNombreCliente.Location = new System.Drawing.Point(12, 23);
			this.lblNombreCliente.Name = "lblNombreCliente";
			this.lblNombreCliente.Size = new System.Drawing.Size(57, 23);
			this.lblNombreCliente.TabIndex = 1;
			this.lblNombreCliente.Text = "Nombre: ";
			// 
			// lblDireccionCliente
			// 
			this.lblDireccionCliente.Location = new System.Drawing.Point(12, 58);
			this.lblDireccionCliente.Name = "lblDireccionCliente";
			this.lblDireccionCliente.Size = new System.Drawing.Size(57, 23);
			this.lblDireccionCliente.TabIndex = 2;
			this.lblDireccionCliente.Text = "Dirección: ";
			// 
			// txtNombreCliente
			// 
			this.txtNombreCliente.Location = new System.Drawing.Point(75, 20);
			this.txtNombreCliente.Name = "txtNombreCliente";
			this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
			this.txtNombreCliente.TabIndex = 3;
			// 
			// txtDireccionCliente
			// 
			this.txtDireccionCliente.Location = new System.Drawing.Point(75, 55);
			this.txtDireccionCliente.Name = "txtDireccionCliente";
			this.txtDireccionCliente.Size = new System.Drawing.Size(100, 20);
			this.txtDireccionCliente.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(677, 285);
			this.Controls.Add(this.txtDireccionCliente);
			this.Controls.Add(this.txtNombreCliente);
			this.Controls.Add(this.lblDireccionCliente);
			this.Controls.Add(this.lblNombreCliente);
			this.Controls.Add(this.btnElegirCOmida);
			this.Name = "MainForm";
			this.Text = "Menu de ingreso";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
