using System;
using System.Collections.Generic;
namespace Projekt
{
	public class Korisnik
	{
		public Korisnik()
		{
		}


		private string oib;
		public string Oib
		{
			get
			{
				return this.oib;
			}
			set
			{
				this.oib = value;
			}
		}


		private string ime;
		public string Ime
		{
			get
			{
				return this.ime;
			}
			set
			{
				this.ime = value;
			}
		}


		private string prezime;
		public string Prezime
		{
			get
			{
				return this.prezime;
			}
			set
			{
				this.prezime = value;
			}
		}
	
	}
}
