using System;
using Mono.Data.Sqlite;
using System.Data;
using System.Collections.Generic;
namespace Projekt
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class RezervacijaWidget : Gtk.Bin
	{
		public RezervacijaWidget()
		{
			this.Build();
		}

		public List<Termin> termini = new List<Termin>();

		// smanji kapacitet na terminu koji je rezerviran
		protected void OnButton1NastaviRezervacijuClicked(object sender, EventArgs e)
		{
			int q = Convert.ToInt32(comboboxDjeca.ActiveText);
			int w = Convert.ToInt32(comboboxOdrasli.ActiveText);
			int r = Convert.ToInt32(label16.Text);

			if (entryOIB.Text.Length != 11 || entryIme.Text == "" || entryPrezime.Text == "" || comboboxNP.ActiveText == null || comboboxTermini.ActiveText == null || entryKreditnaKartica.Text.Length != 16 || comboboxDjeca.ActiveText + comboboxOdrasli.ActiveText == "00" || q+w>r)
			{
				RezervacijaDialog win1 = new RezervacijaDialog();
				win1.Show();
			}

			else
			{
				//dio gdje se smanji kapacitet na bazi
				int o = Convert.ToInt32(comboboxDjeca.ActiveText);
				int b = Convert.ToInt32(comboboxOdrasli.ActiveText);
				int m = Convert.ToInt32(label16.Text);
				int p = m - (o + b);

				string connectionStrin = "URI=file:bazapodataka.db";
				SqliteConnection conn = new SqliteConnection(connectionStrin);
				conn.Open();

				SqliteCommand dbInsertCm = conn.CreateCommand();
				// postavljanje SQL komande za unos
				dbInsertCm.CommandText = String.Format(@"UPDATE Termini SET Kapacitet = {0} WHERE Nacionalnipark = '{1}' AND Datum = '{2}'", p,comboboxNP.ActiveText, comboboxTermini.ActiveText);

				dbInsertCm.ExecuteNonQuery();
				dbInsertCm.Dispose();
				conn.Close();


				int l;

				l = Convert.ToInt32(label20.Text);

				RezervacijaDialog2 win1 = new RezervacijaDialog2();
				win1.Show();

				string connectionString = "URI=file:bazapodataka.db";
				SqliteConnection con = new SqliteConnection(connectionString);
				con.Open();

				SqliteCommand dbInsertCmd = con.CreateCommand();
				// postavljanje SQL komande za unos
				dbInsertCmd.CommandText = String.Format(@"INSERT INTO Rezervacije (Oib, Ime, Prezime, Destinacija, Termin, Broj_kartice, Br_karta_djeca, Br_karta_odrasli, Cijena) 
                                                                        VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", entryOIB.Text, entryIme.Text, entryPrezime.Text, comboboxNP.ActiveText, comboboxTermini.ActiveText, entryKreditnaKartica.Text, comboboxDjeca.Active, comboboxOdrasli.Active, l);

				dbInsertCmd.ExecuteNonQuery();
				dbInsertCmd.Dispose();
				con.Close();


				entryOIB.Text = String.Empty;
				entryIme.Text = String.Empty;
				entryPrezime.Text = String.Empty;
				entryKreditnaKartica.Text = string.Empty;
				label18.Text = string.Empty;
				label19.Text = string.Empty;
				label16.Text = string.Empty;
				comboboxDjeca.Sensitive = false;
				comboboxOdrasli.Sensitive = false;
				button1NastaviRezervaciju.Sensitive = false;
				label20.Text = string.Empty;
			}

		}



		protected void OnComboboxDjecaChanged(object sender, EventArgs e)
		{
			int a = int.Parse(comboboxDjeca.ActiveText);
			int b = int.Parse(comboboxOdrasli.ActiveText);
			int f = int.Parse(label18.Text);
			int g = int.Parse(label19.Text);
			int c = a * f + b * g;
			string d = c.ToString();
			label20.Text = d;

			//smanjivanje broja za kapacitet
		}

		protected void OnComboboxOdrasliChanged(object sender, EventArgs e)
		{
			int a = int.Parse(comboboxDjeca.ActiveText);
			int b = int.Parse(comboboxOdrasli.ActiveText);
			int f = int.Parse(label18.Text);
			int g = int.Parse(label19.Text);
			int c = a * f + b * g;
			string d = c.ToString();
			label20.Text = d;
		}

		protected void OnComboboxNPChanged(object sender, EventArgs e)
		{
			label18.Text = string.Empty;
			label19.Text = string.Empty;
			label16.Text = string.Empty;
			// ista stvar, kada se odabere park i povuce iz baze, crash
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

				while (x< 20)
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

				while (x<20)
				{
					comboboxTermini.RemoveText(x);
					x++;
				}
				x = 0;

				while (x< 20)
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

				while (x< 20)
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

				while (x< 20)
				{
					comboboxTermini.RemoveText(x);
					x++;
				}
				x = 0;

				while (x< 20)
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

				while (x< 20)
				{
					comboboxTermini.RemoveText(x);
					x++;
				}

				x = 0;

				while (x< 20)
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

				while (x< 20)
				{
					comboboxTermini.RemoveText(x);
					x++;
				}

				x = 0;

				while (x< 20)
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
			{	termini.Clear();
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

				while (x< 20)
				{
					comboboxTermini.RemoveText(x);
					x++;
				}
				x = 0;

				while (x< 20)
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
			{	termini.Clear();
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

		protected void OnComboboxTerminiChanged(object sender, EventArgs e)
		{
			//umjesto ovoga imamo provjeri cijene button

		}
		//dohvaćanje informacija o cijenama iz baze
		protected void OnButtonPROVJERICIJENEClicked(object sender, EventArgs e)
		{
			if (comboboxNP.ActiveText == null || comboboxTermini.ActiveText == null)
			{
				RezervacijaDialog win1 = new RezervacijaDialog();
				win1.Show();
			}
			else 
			{
				button1NastaviRezervaciju.Sensitive = true;
				comboboxDjeca.Sensitive = true;
				comboboxOdrasli.Sensitive = true;
				termini.Clear();
				string connectionString = "URI=file:bazapodataka.db";
				SqliteConnection con = new SqliteConnection(connectionString);
				con.Open();
					SqliteCommand c = con.CreateCommand();
					c.CommandText = string.Format(@"SELECT Cijena_djeca, Cijena_odrasli, Kapacitet FROM Termini WHERE Nacionalnipark = '{0}' AND Datum = '{1}'", comboboxNP.ActiveText, comboboxTermini.ActiveText);
					
					SqliteDataReader reader = c.ExecuteReader();
									while (reader.Read())
									{
									Termin a = new Termin();
									a.Cijena_djeca = (string)reader["Cijena_djeca"];
									a.Cijena_odrasli = (string)reader["Cijena_odrasli"];
									a.Kapacitet = (int)reader["Kapacitet"];
									termini.Add(a);
									}
			
									foreach (var i in termini)
										{
											label18.Text = i.Cijena_djeca;
											label19.Text = i.Cijena_odrasli;
											label16.Text = i.Kapacitet.ToString();
										}

				c.Dispose();
				con.Close();
			}
		}
	}
}

