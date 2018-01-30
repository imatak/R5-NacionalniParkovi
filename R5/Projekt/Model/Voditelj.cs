using System;
using System.Collections.Generic;
namespace Projekt
{
	public class Voditelj
	{
		public Voditelj()
		{
		}

		private string korisnicko_ime;
		public string Korisnicko_ime
		{
			get
			{
				return this.korisnicko_ime;
			}
			set
			{
				this.korisnicko_ime = value;
			}
		}

		private string lozinka;
		public string Lozinka
		{
			get
			{
				return this.lozinka;
			}
			set
			{
				this.lozinka = value;
			}
		}

	}
}
