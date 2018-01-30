using System;
using System.Collections.Generic;
namespace Projekt
{
	public partial class PregledRezervacijaWindow : Gtk.Window
	{
		public PregledRezervacijaWindow() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();
		}
		/*
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

		protected void OnButton1Clicked(object sender, EventArgs e)
		{
			if (entry1.Text == "" || entry1.Text.Length != 11)
			{
				PregledRezervacijaDialog win1 = new PregledRezervacijaDialog();
				win1.Show();
			}

			else 
			{
				Rezervacija x = new Rezervacija();
				x.TraziRezervacije(entry1.Text);
			}

		}

*/
	}
}
