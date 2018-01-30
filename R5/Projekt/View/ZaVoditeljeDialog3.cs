using System;
namespace Projekt
{
	public partial class ZaVoditeljeDialog3 : Gtk.Dialog
	{
		public ZaVoditeljeDialog3()
		{
			this.Build();
		}

		protected void OnButtonOkClicked(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
