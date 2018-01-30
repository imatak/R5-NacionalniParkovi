using System;
using System.Collections.Generic;
namespace Projekt
{
	public class VrsteKarte
	{
		public VrsteKarte()
		{
		}

		private string opis_karte;
		public string Opis_karte
		{
			get
			{
				return this.Opis_karte;
			}
			set
			{
				this.opis_karte = value;
			}
		}
		private float cijena;
		public float Cijena
		{
			get
			{
				return this.cijena;
			}
			set
			{
				this.cijena = value;
			}
		}

		public VrsteKarte(string a, float b)
		{
			this.Opis_karte = a;
			this.Cijena = b;
		}
	}
}
