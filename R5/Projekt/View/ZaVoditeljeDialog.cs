using System;
using System.Collections.Generic;
namespace Projekt
{
	public partial class ZaVoditeljeDialog : Gtk.Dialog
	{
		public ZaVoditeljeDialog()
		{
			this.Build();
		}

		protected void OnButtonOkClicked(object sender, EventArgs e)
		{
            this.Hide();
		}
	}
}
