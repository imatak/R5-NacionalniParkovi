using System;
using System.Collections.Generic;
namespace Projekt
{
	public partial class RezervacijaDialog2 : Gtk.Dialog
	{
		public RezervacijaDialog2()
		{
			this.Build();
		}

		protected void OnButtonOkClicked(object sender, EventArgs e)
		{
            this.Hide();
		}
	}
}
