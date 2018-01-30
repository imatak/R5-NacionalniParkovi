using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;
namespace Projekt
{
	public class Termin
	{

		public Termin()
		{
		}

		private string datum;
		public string Datum
		{
			get
			{
				return this.datum;
			}
			set
			{
				this.datum = value;
			}
		}

		private string nacionalnipark;
		public string Nacionalnipark
		{
			get
			{
				return this.nacionalnipark;
			}

			set
			{
				this.nacionalnipark = value;
			}

		}

		private string cijena_djeca;
		public string Cijena_djeca
		{
			get
			{
				return this.cijena_djeca;
			}
			set
			{
				this.cijena_djeca = value;

			}
		}

		private string cijena_odrasli;
		public string Cijena_odrasli
		{
			get
			{
				return this.cijena_odrasli;
			}
			set
			{
				this.cijena_odrasli = value;

			}
		}

		private int kapacitet;
		public int Kapacitet
		{
			get
			{
				return this.kapacitet;
			}
			set
			{
				this.kapacitet = value;
			}
		}
	}
}

