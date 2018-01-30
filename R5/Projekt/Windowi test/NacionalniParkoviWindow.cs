using System;
using System.Collections.Generic;
namespace Projekt
{
	public partial class NacionalniParkoviWindow : Gtk.Window
	{
		public NacionalniParkoviWindow() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();
		}
		/*
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

		protected void OnButton3Clicked(object sender, EventArgs e)
		{
			NacionalniParkoviWindow win1 = new NacionalniParkoviWindow();
			win1.Show();
			this.Hide();
		}
		*/
	}
}
