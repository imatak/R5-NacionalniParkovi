using System;
namespace Projekt
{
	public partial class ZaVoditeljeDialog4 : Gtk.Dialog
	{
		public ZaVoditeljeDialog4()
		{
			this.Build();
		}

		protected void OnButtonOkClicked(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
