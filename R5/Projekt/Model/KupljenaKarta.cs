using System;
using System.Collections.Generic;
namespace Projekt
{
	public class KupljenaKarta
	{
		public KupljenaKarta()
		{
		}

		//public List<Rezervacija> ListaRezervacija = new List<Rezervacija>();
		private string kod_karte;
		public string Kod_karte
		{
			get
			{
				return this.kod_karte;
			}
			set
			{
				this.kod_karte = value;
			}
		}

		//private float cijena;
		//public float Cijena
		//{
		//	get
		//	{
		//		return this.cijena;
		//	}
		//	set
		//	{
		//		this.cijena = value;
		//	}
		//}

		private string vrsta;
		public string Vrsta
		{
			get
			{
				return this.vrsta;
			}
			set
			{
				this.vrsta = value;
			}
		}


		public void DODAJULISTUUUUUU(Rezervacija a) 
		{
		
		
		}
	}
}
