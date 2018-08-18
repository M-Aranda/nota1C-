/*
 * Created by SharpDevelop.
 * User: Marce
 * Date: 8/18/2018
 * Time: 4:09 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Model;
using System.Collections.Generic; //se necesita este import para usar listas

namespace nota1Intento2
{
	/// <summary>
	/// Description of MenuComida.
	/// </summary>
	public partial class MenuComida : Form
	{
		public MenuComida()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			cboComida.DropDownStyle=ComboBoxStyle.DropDownList;
			Comida c1=new Comida("Pizza",2000);
			Comida c2=new Comida("Pasta",5000);
			Comida c3=new Comida("Hamburguesa",1000);
	
			
			List<Comida> comidasDisponibles= new List<Comida>();
			comidasDisponibles.Add(c1);
			comidasDisponibles.Add(c2);
			comidasDisponibles.Add(c3);
			
			cboComida.DataSource=comidasDisponibles;
			
			cboComida.DisplayMember = "Nombre";
            cboComida.ValueMember = "Precio";
			

		}
	}
}
