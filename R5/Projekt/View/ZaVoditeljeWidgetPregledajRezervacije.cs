using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;
namespace Projekt
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class ZaVoditeljeWidgetPregledajRezervacije : Gtk.Bin
	{
		public ZaVoditeljeWidgetPregledajRezervacije()
		{
			this.Build();
		}
		public List<Termin> termini = new List<Termin>();
		public List<Rezervacija> rezervacijeizbaze = new List<Rezervacija>();
		RezervacijaNodeStore RezervacijePresenter;
		int z = 0;

		protected void OnButton1Clicked(object sender, EventArgs e)
		{
			this.Hide();
		}


		protected void OnComboboxNPChanged(object sender, EventArgs e)
		{

			
			if (comboboxNP.ActiveText == "Risnjak")
			{
				termini.Clear();
				string connectionString = "URI=file:bazapodataka.db";
				SqliteConnection con = new SqliteConnection(connectionString);
				con.Open();
				SqliteCommand c = con.CreateCommand();
				c.CommandText = string.Format(@"SELECT Nacionalnipark, Datum FROM Termini WHERE Nacionalnipark = '{0}'", comboboxNP.ActiveText);

				SqliteDataReader reader = c.ExecuteReader();
				while (reader.Read())
				{
					Termin a = new Termin();
					a.Nacionalnipark = (string)reader["Nacionalnipark"];
					a.Datum = (string)reader["Datum"];

					termini.Add(a);
				}
				int y = 0;
				int x = 0;

				while (x < 20)
				{
					comboboxTermini.RemoveText(x);
					x++;
				}
				x = 0;

				while (x < 20)
				{
					comboboxTermini.RemoveText(x);
					x++;
				}
				comboboxTermini.RemoveText(0);
				foreach (var i in termini)
				{
					comboboxTermini.InsertText(y, i.Datum);

					y++;
				}

				c.Dispose();
				con.Close();
			}
			if (comboboxNP.ActiveText == "Brijuni")
			{
				termini.Clear();
				string connectionString = "URI=file:bazapodataka.db";
				SqliteConnection con = new SqliteConnection(connectionString);
				con.Open();
				SqliteCommand c = con.CreateCommand();
				c.CommandText = string.Format(@"SELECT Nacionalnipark, Datum FROM Termini WHERE Nacionalnipark = '{0}'", comboboxNP.ActiveText);

				SqliteDataReader reader = c.ExecuteReader();
				while (reader.Read())
				{
					Termin a = new Termin();
					a.Nacionalnipark = (string)reader["Nacionalnipark"];
					a.Datum = (string)reader["Datum"];

					termini.Add(a);
				}
				int y = 0;
				int x = 0;

				while (x < 20)
				{
					comboboxTermini.RemoveText(x);
					x++;
				}
				x = 0;

				while (x < 20)
				{
					comboboxTermini.RemoveText(x);
					x++;
				}
				comboboxTermini.RemoveText(0);
				foreach (var i in termini)
				{
					comboboxTermini.InsertText(y, i.Datum);

					y++;
				}

				c.Dispose();
				con.Close();

			}

			if (comboboxNP.ActiveText == "Mljet")
			{

				termini.Clear();
				string connectionString = "URI=file:bazapodataka.db";
				SqliteConnection con = new SqliteConnection(connectionString);
				con.Open();
				SqliteCommand c = con.CreateCommand();
				c.CommandText = string.Format(@"SELECT Nacionalnipark, Datum FROM Termini WHERE Nacionalnipark = '{0}'", comboboxNP.ActiveText);

				SqliteDataReader reader = c.ExecuteReader();
				while (reader.Read())
				{
					Termin a = new Termin();
					a.Nacionalnipark = (string)reader["Nacionalnipark"];
					a.Datum = (string)reader["Datum"];

					termini.Add(a);
				}
				int y = 0;
				int x = 0;

				while (x < 20)
				{
					comboboxTermini.RemoveText(x);
					x++;
				}
				x = 0;

				while (x < 20)
				{
					comboboxTermini.RemoveText(x);
					x++;
				}
				comboboxTermini.RemoveText(0);
				foreach (var i in termini)
				{
					comboboxTermini.InsertText(y, i.Datum);

					y++;
				}
				c.Dispose();
				con.Close();

			}

			if (comboboxNP.ActiveText == "Krka")
			{
				termini.Clear();
				string connectionString = "URI=file:bazapodataka.db";
				SqliteConnection con = new SqliteConnection(connectionString);
				con.Open();
				SqliteCommand c = con.CreateCommand();
				c.CommandText = string.Format(@"SELECT Nacionalnipark, Datum FROM Termini WHERE Nacionalnipark = '{0}'", comboboxNP.ActiveText);

				SqliteDataReader reader = c.ExecuteReader();
				while (reader.Read())
				{
					Termin a = new Termin();
					a.Nacionalnipark = (string)reader["Nacionalnipark"];
					a.Datum = (string)reader["Datum"];

					termini.Add(a);
				}
				int y = 0;
				int x = 0;

				while (x < 20)
				{
					comboboxTermini.RemoveText(x);
					x++;
				}
				x = 0;

				while (x < 20)
				{
					comboboxTermini.RemoveText(x);
					x++;
				}
				comboboxTermini.RemoveText(0);
				foreach (var i in termini)
				{
					comboboxTermini.InsertText(y, i.Datum);

					y++;
				}
				c.Dispose();
				con.Close();

			}

			if (comboboxNP.ActiveText == "Plitvička jezera")
			{
				termini.Clear();
				string connectionString = "URI=file:bazapodataka.db";
				SqliteConnection con = new SqliteConnection(connectionString);
				con.Open();
				SqliteCommand c = con.CreateCommand();
				c.CommandText = string.Format(@"SELECT Nacionalnipark, Datum FROM Termini WHERE Nacionalnipark = '{0}'", comboboxNP.ActiveText);

				SqliteDataReader reader = c.ExecuteReader();
				while (reader.Read())
				{
					Termin a = new Termin();
					a.Nacionalnipark = (string)reader["Nacionalnipark"];
					a.Datum = (string)reader["Datum"];

					termini.Add(a);
				}
				int y = 0;
				int x = 0;

				while (x < 20)
				{
					comboboxTermini.RemoveText(x);
					x++;
				}

				x = 0;

				while (x < 20)
				{
					comboboxTermini.RemoveText(x);
					x++;
				}
				comboboxTermini.RemoveText(0);
				foreach (var i in termini)
				{
					comboboxTermini.InsertText(y, i.Datum);

					y++;
				}

				c.Dispose();
				con.Close();

			}

			if (comboboxNP.ActiveText == "Sjeverni Velebit")
			{
				termini.Clear();
				string connectionString = "URI=file:bazapodataka.db";
				SqliteConnection con = new SqliteConnection(connectionString);
				con.Open();
				SqliteCommand c = con.CreateCommand();
				c.CommandText = string.Format(@"SELECT Nacionalnipark, Datum FROM Termini WHERE Nacionalnipark = '{0}'", comboboxNP.ActiveText);

				SqliteDataReader reader = c.ExecuteReader();
				while (reader.Read())
				{
					Termin a = new Termin();
					a.Nacionalnipark = (string)reader["Nacionalnipark"];
					a.Datum = (string)reader["Datum"];

					termini.Add(a);
				}
				int y = 0;
				int x = 0;

				while (x < 20)
				{
					comboboxTermini.RemoveText(x);
					x++;
				}

				x = 0;

				while (x < 20)
				{
					comboboxTermini.RemoveText(x);
					x++;
				}
				comboboxTermini.RemoveText(0);
				foreach (var i in termini)
				{
					comboboxTermini.InsertText(y, i.Datum);

					y++;
				}

				c.Dispose();
				con.Close();

			}

			if (comboboxNP.ActiveText == "Paklenica")
			{
				termini.Clear();
				string connectionString = "URI=file:bazapodataka.db";
				SqliteConnection con = new SqliteConnection(connectionString);
				con.Open();
				SqliteCommand c = con.CreateCommand();
				c.CommandText = string.Format(@"SELECT Nacionalnipark, Datum FROM Termini WHERE Nacionalnipark = '{0}'", comboboxNP.ActiveText);

				SqliteDataReader reader = c.ExecuteReader();
				while (reader.Read())
				{
					Termin a = new Termin();
					a.Nacionalnipark = (string)reader["Nacionalnipark"];
					a.Datum = (string)reader["Datum"];

					termini.Add(a);
				}
				int y = 0;
				int x = 0;

				while (x < 20)
				{
					comboboxTermini.RemoveText(x);
					x++;
				}
				x = 0;

				while (x < 20)
				{
					comboboxTermini.RemoveText(x);
					x++;
				}
				comboboxTermini.RemoveText(0);
				foreach (var i in termini)
				{
					comboboxTermini.InsertText(y, i.Datum);

					y++;
				}

				c.Dispose();
				con.Close();
			}

			if (comboboxNP.ActiveText == "Kornati")
			{
				termini.Clear();
				string connectionString = "URI=file:bazapodataka.db";
				SqliteConnection con = new SqliteConnection(connectionString);
				con.Open();
				SqliteCommand c = con.CreateCommand();
				c.CommandText = string.Format(@"SELECT Nacionalnipark, Datum FROM Termini WHERE Nacionalnipark = '{0}'", comboboxNP.ActiveText);

				SqliteDataReader reader = c.ExecuteReader();
				while (reader.Read())
				{
					Termin a = new Termin();
					a.Nacionalnipark = (string)reader["Nacionalnipark"];
					a.Datum = (string)reader["Datum"];

					termini.Add(a);
				}
				int y = 0;
				int x = 0;

				while (x < 20)
				{
					comboboxTermini.RemoveText(x);
					x++;
				}
				x = 0;
				while (x < 20)
				{
					comboboxTermini.RemoveText(x);
					x++;
				}
				comboboxTermini.RemoveText(0);
				foreach (var i in termini)
				{
					comboboxTermini.InsertText(y, i.Datum);

					y++;
				}

				c.Dispose();
				con.Close();
			}

		}






		// prikaz podataka iz baze u listi
		protected void OnButton15Clicked(object sender, EventArgs e)
		{
			if (comboboxNP.ActiveText == null || comboboxTermini.ActiveText == null)
			{
				ZaVoditeljeDialog4 win1 = new ZaVoditeljeDialog4();
				win1.Show();
			}

			else
			{
				rezervacijeizbaze.Clear();
				string connectionString = "URI=file:bazapodataka.db";
				SqliteConnection con = new SqliteConnection(connectionString);
				con.Open();
				SqliteCommand c = con.CreateCommand();
				c.CommandText = string.Format(@"SELECT Oib, Ime, Prezime, Destinacija, Termin, Broj_kartice, Br_karta_djeca, Br_karta_odrasli, Cijena FROM Rezervacije WHERE Destinacija = '{0}' AND Termin = '{1}'", comboboxNP.ActiveText, comboboxTermini.ActiveText);

				SqliteDataReader reader = c.ExecuteReader();
				while (reader.Read())
				{
					Rezervacija a = new Rezervacija();
					a.Oib = (string)reader["Oib"];
					a.Ime = (string)reader["Ime"];
					a.Prezime = (string)reader["Prezime"];
					a.Destinacija = (string)reader["Destinacija"];
					a.Termin = (string)reader["Termin"];
					a.Broj_kartice = (string)reader["Broj_kartice"];
					a.Br_karta_djeca = (int)reader["Br_karta_djeca"];
					a.Br_karta_odrasli = (int)reader["Br_karta_odrasli"];
					a.Cijena = (int)reader["Cijena"];

					rezervacijeizbaze.Add(a);
				}
				c.Dispose();
				con.Close();


				RezervacijePresenter = new RezervacijaNodeStore();
				RezervacijePresenter.Dodaj(rezervacijeizbaze);

				nodeview1.NodeStore = RezervacijePresenter;

				if (z == 0)
				{
					nodeview1.AppendColumn("Oib", new Gtk.CellRendererText(), "text", 0);
					nodeview1.AppendColumn("Ime", new Gtk.CellRendererText(), "text", 1);
					nodeview1.AppendColumn("Prezime", new Gtk.CellRendererText(), "text", 2);
					nodeview1.AppendColumn("Destinacija", new Gtk.CellRendererText(), "text", 3);
					nodeview1.AppendColumn("Termin", new Gtk.CellRendererText(), "text", 4);

					nodeview1.AppendColumn("Cijena", new Gtk.CellRendererText(), "text", 9);
					z++;
				}

			}
		}


	}
}
