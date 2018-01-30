using System;
namespace Projekt
{
	public partial class PregledRezervacijaDialog2 : Gtk.Dialog
	{
		public PregledRezervacijaDialog2()
		{
			this.Build();
		}

		protected void OnButtonOkClicked(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
