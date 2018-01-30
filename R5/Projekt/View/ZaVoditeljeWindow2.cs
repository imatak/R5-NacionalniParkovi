using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;
namespace Projekt
{
	public partial class ZaVoditeljeWindow2 : Gtk.Window
	{
		public ZaVoditeljeWindow2() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();
		}

		protected void OnButton3Clicked(object sender, EventArgs e)
		{
			this.Hide();
		}

		protected void OnButton73Clicked(object sender, EventArgs e)
		{
			ZaVoditeljeWindow4 win1 = new ZaVoditeljeWindow4();
			win1.Show();
		}

		protected void OnButton74Clicked(object sender, EventArgs e)
		{
			ZavoditeljeWindow3 win1 = new ZavoditeljeWindow3();
			win1.Show();

		}
	}
}
