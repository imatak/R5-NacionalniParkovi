using System;
namespace Projekt
{
	public partial class ZaVoditeljeDialogLogin : Gtk.Dialog
	{
		public ZaVoditeljeDialogLogin()
		{
			this.Build();
		}

		protected void OnButtonOkClicked(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
