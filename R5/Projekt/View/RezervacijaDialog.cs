using System;
using System.Collections.Generic;
namespace Projekt
{
	public partial class RezervacijaDialog : Gtk.Dialog
	{
		public RezervacijaDialog()
		{
			this.Build();
		}

		protected void OnButtonOkClicked(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
