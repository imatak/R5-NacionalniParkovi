using System;
using System.Collections.Generic;
namespace Projekt
{
	public partial class RezervacijaWindow : Gtk.Window
	{
		public RezervacijaWindow() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();
		}
		/*
		//KupljenaKarta Glavna = new KupljenaKarta();
		///public List<Rezervacija> iii = new List<Rezervacija>();



		protected void OnButton3Clicked(object sender, EventArgs e)
		{
			NacionalniParkoviWindow win1 = new NacionalniParkoviWindow();
			win1.Show();
			this.Hide();
		}

		protected void OnButton4Clicked(object sender, EventArgs e)
		{
			RezervacijaWindow win1 = new RezervacijaWindow();
			win1.Show();
			this.Hide();
		}

		protected void OnButton5Clicked(object sender, EventArgs e)
		{
			PregledRezervacijaWindow win1 = new PregledRezervacijaWindow();
			win1.Show();
			this.Hide();
		}

		protected void OnButton6Clicked(object sender, EventArgs e)
		{
			ZaVoditeljeWindow win1 = new ZaVoditeljeWindow();
			win1.Show();
			this.Hide();
		}

	
		protected void OnButton1NastaviRezervacijuClicked(object sender, EventArgs e)
		{
			if (entryOIB.Text.Length !=11  || entryIme.Text == "" || entryPrezime.Text == "" || comboboxNP.ActiveText == null || comboboxTermini.ActiveText == null || entryKreditnaKartica.Text.Length !=11 || comboboxDjeca.ActiveText + comboboxOdrasli.ActiveText == "00") 
			{
				RezervacijaDialog win1 = new RezervacijaDialog();
				win1.Show();
			}

			else
			{
				string a, b, c, d, f, g;
				int l, m;
				a = entryOIB.Text;
				b = entryIme.Text;
				c = entryPrezime.Text;
				d = comboboxNP.ActiveText;
				f = comboboxTermini.ActiveText;
				g = entryKreditnaKartica.Text;
				l = comboboxDjeca.Active;
				m = comboboxOdrasli.Active;

				Rezervacija r2 = new Rezervacija(a, b, c, d, f, g, l, m);
				//r2.Oib = a;
				//r2.Ime = b;
				//r2.Prezime = c;
				//r2.Destinacija = d;
				//r2.Termin = f;
				//r2.Broj_kartice = g;
				//r2.Otkazano = false;
				//r2.Br_karta_djeca = l;
				//r2.Br_karta_odrasli = m;
				//r2.Cijena = (r2.Br_karta_djeca * 30) + (r2.Br_karta_odrasli * 40);

				//Glavna.ListaRezervacija.Add(r2);

				RezervacijaDialog2 win1 = new RezervacijaDialog2();
				win1.Show();
			}

		}



		protected void OnComboboxDjecaChanged(object sender, EventArgs e)
		{
			int a = int.Parse(comboboxDjeca.ActiveText);
			int b = int.Parse(comboboxOdrasli.ActiveText);
			int c = a*30 + b*40;
			string d = c.ToString();
			//textview1.Show();
			entry1.Text = d;
		}

		protected void OnComboboxOdrasliChanged(object sender, EventArgs e)
		{
			int a = int.Parse(comboboxDjeca.ActiveText);
			int b = int.Parse(comboboxOdrasli.ActiveText);
			int c = a*30 + b*40;
			string d = c.ToString();
			//textview1.Show();
			entry1.Text = d;
		}

		public void DodajTermin(string x) 
		{
			comboboxTermini.InsertText(1, x);
		}

		*/
	}
}
