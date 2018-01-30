using System;
using System.Collections.Generic;
namespace Projekt
{
	public partial class ZaVoditeljeWindow : Gtk.Window
	{
		public ZaVoditeljeWindow() :
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
			if (entry1.Text != "admin" || entry2.Text != "123")
			{
				ZaVoditeljeDialog win1 = new ZaVoditeljeDialog();
				win1.Show();
			}

			else
			{
				ZaVoditeljeWindow2 win1 = new ZaVoditeljeWindow2();
				win1.Show();
				this.Hide();
			}
		}
*/
	}
}
