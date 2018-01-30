using System;
namespace Projekt
{
	public partial class ZaVoditeljeDialog2 : Gtk.Dialog
	{
		public ZaVoditeljeDialog2()
		{
			this.Build();
		}

		protected void OnButtonOkClicked(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
