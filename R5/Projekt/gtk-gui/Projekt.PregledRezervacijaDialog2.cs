
// This file has been generated by the GUI designer. Do not modify.
namespace Projekt
{
	public partial class PregledRezervacijaDialog2
	{
		private global::Gtk.Label label3;

		private global::Gtk.Button buttonOk;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Projekt.PregledRezervacijaDialog2
			this.Name = "Projekt.PregledRezervacijaDialog2";
			this.Title = global::Mono.Unix.Catalog.GetString("Sustav rezervacija na nacionalne parkove RH");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			// Internal child Projekt.PregledRezervacijaDialog2.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.HeightRequest = 200;
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Rezervacija je uspješno otkazana.");
			this.label3.Wrap = true;
			w1.Add(this.label3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(w1[this.label3]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Internal child Projekt.PregledRezervacijaDialog2.ActionArea
			global::Gtk.HButtonBox w3 = this.ActionArea;
			w3.Name = "dialog1_ActionArea";
			w3.Spacing = 10;
			w3.BorderWidth = ((uint)(5));
			w3.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget(this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w4 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w3[this.buttonOk]));
			w4.Expand = false;
			w4.Fill = false;
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 401;
			this.DefaultHeight = 300;
			this.Show();
			this.buttonOk.Clicked += new global::System.EventHandler(this.OnButtonOkClicked);
		}
	}
}
