using System;
namespace Projekt
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class ZaVoditeljeWidget : Gtk.Bin
	{
		public ZaVoditeljeWidget()
		{
			this.Build();

		}


		protected void OnButton1Clicked(object sender, EventArgs e)
		{
			Voditelj glavni = new Voditelj();
			glavni.Korisnicko_ime = "admin";
			glavni.Lozinka = "123";
				if (entry1.Text != glavni.Korisnicko_ime || entry2.Text != glavni.Lozinka)
				{
				ZaVoditeljeDialogLogin win1 = new ZaVoditeljeDialogLogin();
				win1.Show();
				}

				else
				{
				ZaVoditeljeWindow2 win1 = new ZaVoditeljeWindow2();
				win1.Show();
				}

			entry1.Text = String.Empty;
			entry2.Text = String.Empty;
		}


	}
}
