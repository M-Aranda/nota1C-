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

using System.Reflection;
using System.Resources;

namespace nota1Intento2
{
	/// <summary>
	/// Description of MenuComida.
	/// </summary>
	public partial class MenuComida : Form
	{
		
		 Comida c1;
		 Comida c2;
		 Comida c3;
		
		 ResourceManager resources;
		 Bitmap pizzaBmp;
		 Bitmap hamburguesaBmp;
		 Bitmap pastaBmp;
		
		public MenuComida()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			cboComida.DropDownStyle=ComboBoxStyle.DropDownList;
			c1=new Comida("Pizza",2000);
			c2=new Comida("Pasta",5000);
			c3=new Comida("Hamburguesa",1000);
	
			
			List<Comida> comidasDisponibles= new List<Comida>();
			comidasDisponibles.Add(c1);
			comidasDisponibles.Add(c2);
			comidasDisponibles.Add(c3);
			
			cboComida.DataSource=comidasDisponibles;
			
			cboComida.DisplayMember = "Nombre";
            cboComida.ValueMember = "Precio";
         
       
            resources = new ResourceManager("nota1Intento2.Imagenes", Assembly.GetExecutingAssembly());
			pizzaBmp = (Bitmap)resources.GetObject("pizza");
			hamburguesaBmp = (Bitmap)resources.GetObject("hamburguesa");
			pastaBmp = (Bitmap)resources.GetObject("pasta");
			

			
			
			pbxComida.Image = pizzaBmp;
			
			
		
			

		}
		void CboComidaSelectedIndexChanged(object sender, EventArgs e)
		{
			
			
			if (cboComida.SelectedItem == c1)
			{
    			pbxComida.Image = pizzaBmp;
			}else if (cboComida.SelectedItem == c2) {
				
				pbxComida.Image = pastaBmp;
			}else if (cboComida.SelectedItem == c3) {
				
				pbxComida.Image = hamburguesaBmp;
			}
	
		}
	}
}
