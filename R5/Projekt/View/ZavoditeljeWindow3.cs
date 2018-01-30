using System;
using Mono.Data.Sqlite;
using System.Collections.Generic;
namespace Projekt
{
	public partial class ZavoditeljeWindow3 : Gtk.Window
	{
		public ZavoditeljeWindow3() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();
		}
		public List<Termin> termini = new List<Termin>();
		public List<Rezervacija> rezervacijeizbaze = new List<Rezervacija>();
		//spremanje novog termina
		protected void OnButton225Clicked(object sender, EventArgs e)
		{
			if (comboboxNP.ActiveText == null || spinbutton1.Text == "0" || spinbutton3.Text == "0" || spinbutton2.Text == "0")
			{
			ZaVoditeljeDialog2 win1 = new ZaVoditeljeDialog2();
			win1.Show();
			}

			else 
			{
			DateTime x;
			x = calendar1.Date;
							string y;
			y = x.ToString("dd.MM.yyyy.");

							string z;
			z = comboboxNP.ActiveText;
			int u = Convert.ToInt32(spinbutton2.Text);

			string connectionString = "URI=file:bazapodataka.db";
			SqliteConnection con = new SqliteConnection(connectionString);
			con.Open();

				SqliteCommand dbInsertCmd = con.CreateCommand();
				dbInsertCmd.CommandText = String.Format(@"INSERT INTO Termini (Nacionalnipark, Datum, Cijena_djeca, Cijena_odrasli, Kapacitet) 
						                                                        VALUES('{0}', '{1}', '{2}', '{3}', {4})", comboboxNP.ActiveText, y, spinbutton1.Text, spinbutton3.Text, u);

				dbInsertCmd.ExecuteNonQuery();
				dbInsertCmd.Dispose();
			con.Close();

			ZaVoditeljeDialog3 win1 = new ZaVoditeljeDialog3();
			win1.Show();

			//dio za refresh
			termini.Clear();
			buttonIzbrisi.Sensitive = false;
			string connectionStringg = "URI=file:bazapodataka.db";
			SqliteConnection conn = new SqliteConnection(connectionStringg);
			conn.Open();
				SqliteCommand cc = conn.CreateCommand();
				cc.CommandText = string.Format(@"SELECT Nacionalnipark, Datum FROM Termini WHERE Nacionalnipark = '{0}'", comboboxNP.ActiveText);

			SqliteDataReader reader = cc.ExecuteReader();
			while (reader.Read())
			{
				Termin a = new Termin();
				a.Nacionalnipark = (string)reader["Nacionalnipark"];
				a.Datum = (string)reader["Datum"];

				termini.Add(a);
			}
			int b = 0;
			int q = 0;

			while (q< 20)
			{
				comboboxTermini.RemoveText(q);
				q++;
			}
			q = 0;
			while (q< 20)
			{
				comboboxTermini.RemoveText(u);
				q++;
			}
			comboboxTermini.RemoveText(0);
			foreach (var i in termini)
			{
				comboboxTermini.InsertText(b, i.Datum);

				b++;
			}

			cc.Dispose();
			conn.Close();
			}
		}

		protected void OnButton1Clicked(object sender, EventArgs e)
		{
			this.Hide();
		}

		protected void OnComboboxNPChanged(object sender, EventArgs e)
		{
							
			if (comboboxNP.ActiveText == "Risnjak")
			{
				termini.Clear();
				buttonIzbrisi.Sensitive = false;
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
				buttonIzbrisi.Sensitive = false;

			}
			if (comboboxNP.ActiveText == "Brijuni")
			{
				termini.Clear();
				buttonIzbrisi.Sensitive = false;
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
				buttonIzbrisi.Sensitive = false;


			}

			if (comboboxNP.ActiveText == "Mljet")
			{

				termini.Clear();
				buttonIzbrisi.Sensitive = false;
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
				buttonIzbrisi.Sensitive = false;

			}

			if (comboboxNP.ActiveText == "Krka")
			{
				termini.Clear();
				buttonIzbrisi.Sensitive = false;
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
				buttonIzbrisi.Sensitive = false;

			}

			if (comboboxNP.ActiveText == "Plitvička jezera")
			{
				termini.Clear();
				buttonIzbrisi.Sensitive = false;
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
				buttonIzbrisi.Sensitive = false;

			}

			if (comboboxNP.ActiveText == "Sjeverni Velebit")
			{
				termini.Clear();
				buttonIzbrisi.Sensitive = false;
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
				buttonIzbrisi.Sensitive = false;

			}

			if (comboboxNP.ActiveText == "Paklenica")
			{
				termini.Clear();
				buttonIzbrisi.Sensitive = false;
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
				buttonIzbrisi.Sensitive = false;
			}

			if (comboboxNP.ActiveText == "Kornati")
			{
				termini.Clear();
				buttonIzbrisi.Sensitive = false;
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
				buttonIzbrisi.Sensitive = false;
			}

		}

		protected void OnButtonIzbrisiClicked(object sender, EventArgs e)
		{
			//izbrisi termin koji ima taj datum, mora biti i koji park i koji datum
			//da li termin nema rezervacije, to se provjerava pod terminCHANGED, jer je tada button i omogucen
			string connectionString = "URI=file:bazapodataka.db";
			SqliteConnection con = new SqliteConnection(connectionString);
			con.Open();
				SqliteCommand c = con.CreateCommand();
				c.CommandText = string.Format(@"DELETE FROM Termini WHERE Nacionalnipark = '{0}' AND Datum = '{1}'", comboboxNP.ActiveText, comboboxTermini.ActiveText);
				c.ExecuteNonQuery();
			c.Dispose();
			con.Close();
			buttonIzbrisi.Sensitive = false;

			//dio za refresh
			termini.Clear();
			buttonIzbrisi.Sensitive = false;
			string connectionStringg = "URI=file:bazapodataka.db";
			SqliteConnection conn = new SqliteConnection(connectionStringg);
			conn.Open();
			SqliteCommand cc = conn.CreateCommand();
			cc.CommandText = string.Format(@"SELECT Nacionalnipark, Datum FROM Termini WHERE Nacionalnipark = '{0}'", comboboxNP.ActiveText);

			SqliteDataReader reader = cc.ExecuteReader();
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

			cc.Dispose();
			conn.Close();
			buttonIzbrisi.Sensitive = false;
			ZaVoditeljeDialog5 win2 = new ZaVoditeljeDialog5();
			win2.Show();
		}

		protected void OnComboboxTerminiChanged(object sender, EventArgs e)
		{
			//pretrazi bazu ako ima rezervacija za ovaj datum, ako nema, omogući button
			buttonIzbrisi.Sensitive = false;
			rezervacijeizbaze.Clear();	
			string connectionString = "URI=file:bazapodataka.db";
			SqliteConnection con = new SqliteConnection(connectionString);
			con.Open();
			SqliteCommand c = con.CreateCommand();
			c.CommandText = string.Format(@"SELECT Oib, Ime, Prezime, Destinacija, Termin, Broj_kartice, Br_karta_djeca, Br_karta_odrasli, Cijena FROM Rezervacije WHERE Termin = '{0}'", comboboxTermini.ActiveText);

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
			if (rezervacijeizbaze.Count == 0)
			{
				buttonIzbrisi.Sensitive = true;
			}

		}

	}
}
