
// This file has been generated by the GUI designer. Do not modify.
namespace Projekt
{
	public partial class RezervacijaWindow
	{
		private global::Gtk.VBox vbox7;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Button button3;

		private global::Gtk.Button button4;

		private global::Gtk.Button button5;

		private global::Gtk.Button button6;

		private global::Gtk.Label label1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label label2;

		private global::Gtk.Entry entryOIB;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label label3;

		private global::Gtk.Entry entryIme;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label label4;

		private global::Gtk.Entry entryPrezime;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Label label5;

		private global::Gtk.ComboBox comboboxNP;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Label label6;

		private global::Gtk.ComboBox comboboxTermini;

		private global::Gtk.Label label12;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Label label7;

		private global::Gtk.ComboBox comboboxDjeca;

		private global::Gtk.Label label11;

		private global::Gtk.HBox hbox9;

		private global::Gtk.Label label8;

		private global::Gtk.ComboBox comboboxOdrasli;

		private global::Gtk.Label label10;

		private global::Gtk.Entry entry1;

		private global::Gtk.HBox hbox10;

		private global::Gtk.Label label9;

		private global::Gtk.Entry entryKreditnaKartica;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Button button1NastaviRezervaciju;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Projekt.RezervacijaWindow
			this.Name = "Projekt.RezervacijaWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("Sustav rezervacija za nacionalne parkove RH");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Projekt.RezervacijaWindow.Gtk.Container+ContainerChild
			this.vbox7 = new global::Gtk.VBox();
			this.vbox7.WidthRequest = 600;
			this.vbox7.HeightRequest = 400;
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.button3 = new global::Gtk.Button();
			this.button3.WidthRequest = 135;
			this.button3.CanFocus = true;
			this.button3.Name = "button3";
			this.button3.UseUnderline = true;
			this.button3.Label = global::Mono.Unix.Catalog.GetString("Nacionalni parkovi");
			this.hbox2.Add(this.button3);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.button3]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.button4 = new global::Gtk.Button();
			this.button4.WidthRequest = 135;
			this.button4.CanFocus = true;
			this.button4.Name = "button4";
			this.button4.UseUnderline = true;
			this.button4.Label = global::Mono.Unix.Catalog.GetString("Rezervacija");
			this.hbox2.Add(this.button4);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.button4]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.button5 = new global::Gtk.Button();
			this.button5.WidthRequest = 135;
			this.button5.CanFocus = true;
			this.button5.Name = "button5";
			this.button5.UseUnderline = true;
			this.button5.Label = global::Mono.Unix.Catalog.GetString("Pregled rezervacija");
			this.hbox2.Add(this.button5);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.button5]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.button6 = new global::Gtk.Button();
			this.button6.WidthRequest = 135;
			this.button6.CanFocus = true;
			this.button6.Name = "button6";
			this.button6.UseUnderline = true;
			this.button6.Label = global::Mono.Unix.Catalog.GetString("Za voditelje");
			this.hbox2.Add(this.button6);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.button6]));
			w4.Position = 3;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox7.Add(this.hbox2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.hbox2]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Rezervacija");
			this.vbox7.Add(this.label1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.label1]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.WidthRequest = 0;
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.WidthRequest = 75;
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("OIB:");
			this.hbox1.Add(this.label2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label2]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entryOIB = new global::Gtk.Entry();
			this.entryOIB.WidthRequest = 1;
			this.entryOIB.CanFocus = true;
			this.entryOIB.Name = "entryOIB";
			this.entryOIB.IsEditable = true;
			this.entryOIB.InvisibleChar = '●';
			this.hbox1.Add(this.entryOIB);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.entryOIB]));
			w8.Position = 1;
			this.vbox7.Add(this.hbox1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.hbox1]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.WidthRequest = 75;
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Ime:");
			this.hbox3.Add(this.label3);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label3]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.entryIme = new global::Gtk.Entry();
			this.entryIme.CanFocus = true;
			this.entryIme.Name = "entryIme";
			this.entryIme.IsEditable = true;
			this.entryIme.InvisibleChar = '●';
			this.hbox3.Add(this.entryIme);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.entryIme]));
			w11.Position = 1;
			this.vbox7.Add(this.hbox3);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.hbox3]));
			w12.Position = 3;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.WidthRequest = 75;
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Prezime:");
			this.hbox4.Add(this.label4);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label4]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.entryPrezime = new global::Gtk.Entry();
			this.entryPrezime.CanFocus = true;
			this.entryPrezime.Name = "entryPrezime";
			this.entryPrezime.IsEditable = true;
			this.entryPrezime.InvisibleChar = '●';
			this.hbox4.Add(this.entryPrezime);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.entryPrezime]));
			w14.Position = 1;
			this.vbox7.Add(this.hbox4);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.hbox4]));
			w15.Position = 4;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.WidthRequest = 75;
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Destinacija:");
			this.hbox5.Add(this.label5);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.label5]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.comboboxNP = global::Gtk.ComboBox.NewText();
			this.comboboxNP.AppendText(global::Mono.Unix.Catalog.GetString("Krka"));
			this.comboboxNP.AppendText(global::Mono.Unix.Catalog.GetString("Risnjak"));
			this.comboboxNP.AppendText(global::Mono.Unix.Catalog.GetString("Brijuni"));
			this.comboboxNP.AppendText(global::Mono.Unix.Catalog.GetString("Kornati"));
			this.comboboxNP.AppendText(global::Mono.Unix.Catalog.GetString("Sjeverni Velebit"));
			this.comboboxNP.AppendText(global::Mono.Unix.Catalog.GetString("Paklenica"));
			this.comboboxNP.AppendText(global::Mono.Unix.Catalog.GetString("Mljet"));
			this.comboboxNP.AppendText(global::Mono.Unix.Catalog.GetString("Plitvička jezera"));
			this.comboboxNP.WidthRequest = 125;
			this.comboboxNP.Name = "comboboxNP";
			this.hbox5.Add(this.comboboxNP);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.comboboxNP]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.vbox7.Add(this.hbox5);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.hbox5]));
			w18.Position = 5;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.WidthRequest = 75;
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Termini:");
			this.hbox6.Add(this.label6);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.label6]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.comboboxTermini = global::Gtk.ComboBox.NewText();
			this.comboboxTermini.AppendText(global::Mono.Unix.Catalog.GetString("23.6.2018."));
			this.comboboxTermini.AppendText(global::Mono.Unix.Catalog.GetString("30.6.2018."));
			this.comboboxTermini.AppendText(global::Mono.Unix.Catalog.GetString("15.7.2018."));
			this.comboboxTermini.WidthRequest = 125;
			this.comboboxTermini.Name = "comboboxTermini";
			this.hbox6.Add(this.comboboxTermini);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.comboboxTermini]));
			w20.Position = 1;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.label12 = new global::Gtk.Label();
			this.label12.WidthRequest = 300;
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString("Cijena karte za odrasle: 40 kn");
			this.hbox6.Add(this.label12);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.label12]));
			w21.Position = 2;
			w21.Expand = false;
			w21.Fill = false;
			this.vbox7.Add(this.hbox6);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.hbox6]));
			w22.Position = 6;
			w22.Expand = false;
			w22.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label();
			this.label7.WidthRequest = 75;
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Dječje karte:");
			this.hbox8.Add(this.label7);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.label7]));
			w23.Position = 0;
			w23.Expand = false;
			w23.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.comboboxDjeca = global::Gtk.ComboBox.NewText();
			this.comboboxDjeca.AppendText(global::Mono.Unix.Catalog.GetString("0"));
			this.comboboxDjeca.AppendText(global::Mono.Unix.Catalog.GetString("1"));
			this.comboboxDjeca.AppendText(global::Mono.Unix.Catalog.GetString("2"));
			this.comboboxDjeca.AppendText(global::Mono.Unix.Catalog.GetString("3"));
			this.comboboxDjeca.AppendText(global::Mono.Unix.Catalog.GetString("4"));
			this.comboboxDjeca.AppendText(global::Mono.Unix.Catalog.GetString("5"));
			this.comboboxDjeca.WidthRequest = 125;
			this.comboboxDjeca.Name = "comboboxDjeca";
			this.comboboxDjeca.Active = 0;
			this.hbox8.Add(this.comboboxDjeca);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.comboboxDjeca]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label();
			this.label11.WidthRequest = 300;
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Cijena karte za djecu: 30 kn");
			this.hbox8.Add(this.label11);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.label11]));
			w25.Position = 2;
			w25.Expand = false;
			w25.Fill = false;
			this.vbox7.Add(this.hbox8);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.hbox8]));
			w26.Position = 7;
			w26.Expand = false;
			w26.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label();
			this.label8.WidthRequest = 75;
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Odrasle karte:");
			this.hbox9.Add(this.label8);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.label8]));
			w27.Position = 0;
			w27.Expand = false;
			w27.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.comboboxOdrasli = global::Gtk.ComboBox.NewText();
			this.comboboxOdrasli.AppendText(global::Mono.Unix.Catalog.GetString("0"));
			this.comboboxOdrasli.AppendText(global::Mono.Unix.Catalog.GetString("1"));
			this.comboboxOdrasli.AppendText(global::Mono.Unix.Catalog.GetString("2"));
			this.comboboxOdrasli.AppendText(global::Mono.Unix.Catalog.GetString("3"));
			this.comboboxOdrasli.AppendText(global::Mono.Unix.Catalog.GetString("4"));
			this.comboboxOdrasli.AppendText(global::Mono.Unix.Catalog.GetString("5"));
			this.comboboxOdrasli.WidthRequest = 125;
			this.comboboxOdrasli.Name = "comboboxOdrasli";
			this.comboboxOdrasli.Active = 0;
			this.hbox9.Add(this.comboboxOdrasli);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.comboboxOdrasli]));
			w28.Position = 1;
			w28.Expand = false;
			w28.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.label10 = new global::Gtk.Label();
			this.label10.WidthRequest = 100;
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Ukupna cijena:");
			this.label10.Justify = ((global::Gtk.Justification)(2));
			this.hbox9.Add(this.label10);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.label10]));
			w29.Position = 2;
			w29.Expand = false;
			w29.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.entry1 = new global::Gtk.Entry();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = false;
			this.entry1.InvisibleChar = '●';
			this.hbox9.Add(this.entry1);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.entry1]));
			w30.Position = 3;
			this.vbox7.Add(this.hbox9);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.hbox9]));
			w31.Position = 8;
			w31.Expand = false;
			w31.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox10 = new global::Gtk.HBox();
			this.hbox10.Name = "hbox10";
			this.hbox10.Spacing = 6;
			// Container child hbox10.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label();
			this.label9.WidthRequest = 75;
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("Broj kreditne kartice:");
			this.label9.Wrap = true;
			this.hbox10.Add(this.label9);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.label9]));
			w32.Position = 0;
			w32.Expand = false;
			w32.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.entryKreditnaKartica = new global::Gtk.Entry();
			this.entryKreditnaKartica.WidthRequest = 1;
			this.entryKreditnaKartica.CanFocus = true;
			this.entryKreditnaKartica.Name = "entryKreditnaKartica";
			this.entryKreditnaKartica.IsEditable = true;
			this.entryKreditnaKartica.InvisibleChar = '●';
			this.hbox10.Add(this.entryKreditnaKartica);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.entryKreditnaKartica]));
			w33.Position = 1;
			this.vbox7.Add(this.hbox10);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.hbox10]));
			w34.Position = 9;
			w34.Expand = false;
			w34.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.button1NastaviRezervaciju = new global::Gtk.Button();
			this.button1NastaviRezervaciju.WidthRequest = 100;
			this.button1NastaviRezervaciju.CanFocus = true;
			this.button1NastaviRezervaciju.Name = "button1NastaviRezervaciju";
			this.button1NastaviRezervaciju.UseUnderline = true;
			this.button1NastaviRezervaciju.Label = global::Mono.Unix.Catalog.GetString("Nastavi");
			this.hbox7.Add(this.button1NastaviRezervaciju);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.button1NastaviRezervaciju]));
			w35.Position = 0;
			w35.Expand = false;
			w35.Fill = false;
			this.vbox7.Add(this.hbox7);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.hbox7]));
			w36.Position = 10;
			w36.Expand = false;
			w36.Fill = false;
			this.Add(this.vbox7);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 600;
			this.DefaultHeight = 400;
			this.Show();
		}
	}
}
