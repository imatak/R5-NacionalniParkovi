using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;
namespace Projekt
{
	public class Rezervacija: Korisnik
	{
		

		public Rezervacija()
		{
			
		}

		private string destinacija;
		public string Destinacija
		{
			get
			{
				return this.destinacija;
			}
			set
			{
				this.destinacija = value;

			}
		}

		private string termin;
		public string Termin
		{
			get
			{
				return this.termin;
			}
			set
			{
				this.termin = value;

			}
		}

		private string broj_kartice;
		public string Broj_kartice
		{
			get
			{
				return this.broj_kartice;
			}
			set
			{
				this.broj_kartice = value;
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


		private int br_karta_odrasli;
		public int Br_karta_odrasli 
		{
			get
			{
				return this.br_karta_odrasli;
			}
			set
			{
                this.br_karta_odrasli = value;
			}
		}

		private int br_karta_djeca;
		public int Br_karta_djeca
		{
			get
			{
				return this.br_karta_djeca;
			}
			set
			{
				this.br_karta_djeca = value;
			}
		}


	}
}
