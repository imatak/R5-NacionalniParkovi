using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;
namespace Projekt
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class ZaVoditeljeWidgetDodajTermin : Gtk.Bin
	{
		public ZaVoditeljeWidgetDodajTermin()
		{
			this.Build();
		}

		public List<Termin> termini = new List<Termin>();
		//button za dodati termin klik
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


	}
}
