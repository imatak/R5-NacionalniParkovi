using System;
namespace Projekt
{
	public class RezervacijaNode : Gtk.TreeNode
	{
		[Gtk.TreeNodeValue(Column = 0)]
		public String Oib;

		[Gtk.TreeNodeValue(Column = 1)]
		public String Ime;

		[Gtk.TreeNodeValue(Column = 2)]
		public String Prezime;

		[Gtk.TreeNodeValue(Column = 3)]
		public String Destinacija;

		[Gtk.TreeNodeValue(Column = 4)]
		public String Termin;

		[Gtk.TreeNodeValue(Column = 5)]
		public String Broj_kartice;

		[Gtk.TreeNodeValue(Column = 6)]
		public string Br_karta_djeca;

		[Gtk.TreeNodeValue(Column = 7)]
		public string Br_karta_odrasli;

		[Gtk.TreeNodeValue(Column = 8)]
		public string Cijena;


		public RezervacijaNode(Rezervacija a)
		{
			this.Oib = a.Oib;
			this.Ime = a.Ime;
			this.Prezime = a.Prezime;
			this.Destinacija = a.Destinacija;
			this.Termin = a.Termin;
			this.Broj_kartice = a.Broj_kartice;
			this.Br_karta_djeca = a.Br_karta_djeca.ToString();
			this.Br_karta_odrasli = a.Br_karta_odrasli.ToString();
			this.Cijena = a.Cijena.ToString("0.00 kn");
		}


	}
}
