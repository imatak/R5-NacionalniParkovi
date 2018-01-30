using System;
namespace Projekt
{
	public partial class ZaVoditeljeDialog5 : Gtk.Dialog
	{
		public ZaVoditeljeDialog5()
		{
			this.Build();
		}

		protected void OnButtonOkClicked(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
