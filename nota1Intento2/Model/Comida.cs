/*
 * Created by SharpDevelop.
 * User: Marce
 * Date: 8/18/2018
 * Time: 4:14 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Model
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class Comida
	{
		
		private String nombre;
		private int precio;
		
		public Comida(string nombre, int precio)
		{
			this.nombre = nombre;
			this.precio = precio;
			
		}
		

		public string Nombre {
			get {
				return nombre;
			}
			set {
				nombre = value;
			}
		}

		public int Precio {
			get {
				return precio;
			}
			set {
				precio = value;
			}
		}
		
		
		
		
		
	}
}