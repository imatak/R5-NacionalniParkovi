using System;
using System.Collections.Generic;
namespace Projekt
{
	public partial class PregledRezervacijaDialog : Gtk.Dialog
	{
		public PregledRezervacijaDialog()
		{
			this.Build();
		}

		protected void OnButtonOkClicked(object sender, EventArgs e)
		{
            this.Hide();
		}
	}
}
