/*
 * Created by SharpDevelop.
 * User: Marce
 * Date: 8/18/2018
 * Time: 3:49 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace nota1Intento2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnElegirCOmidaClick(object sender, EventArgs e)
		{
			
			String nombreCli= txtNombreCliente.Text;
			String dirCli=txtDireccionCliente.Text;
			
			MessageBox.Show("Hola "+nombreCli+" se enviara el pedido a "+ dirCli);
			
			MenuComida mc= new MenuComida();
			mc.Show();
			
			
			
	
	
		}
	}
}
