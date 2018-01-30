using System;
using System.Collections.Generic;
namespace Projekt
{
	public partial class RezervacijaWindow2 : Gtk.Window
	{
		public RezervacijaWindow2() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();
		}
		/*
		protected void OnButton2RezervirajKarteClicked(object sender, EventArgs e)
		{
			if (combobox2PrvaKarta.ActiveText == null) 
			{
				RezervacijaDialog2 win1 = new RezervacijaDialog2();
				win1.Show();
			}

			if (entry2KreditnaKartica.Text.Length !=11) 
			{
				RezervacijaDialog2 win1 = new RezervacijaDialog2();
				win1.Show();
			}
		}
*/
	}
}
