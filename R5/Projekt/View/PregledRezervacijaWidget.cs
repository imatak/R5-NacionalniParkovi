using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;
namespace Projekt
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class PregledRezervacijaWidget : Gtk.Bin
	{
		public PregledRezervacijaWidget()
		{
			this.Build();
		}

		public List<Rezervacija> rezervacijeizbaze = new List<Rezervacija>();
		RezervacijaNodeStore RezervacijePresenter;
		int z = 0;
		//button za pretraživanje
		protected void OnButton1Clicked(object sender, EventArgs e)
		{
			if (entry1.Text == "" || entry1.Text.Length != 11)
			{
				PregledRezervacijaDialog win1 = new PregledRezervacijaDialog();
				win1.Show();
			}

			else
			{
				button10.Sensitive = true;
				rezervacijeizbaze.Clear();	
			
				string connectionString = "URI=file:bazapodataka.db";
				SqliteConnection con = new SqliteConnection(connectionString);
				con.Open();
						SqliteCommand c = con.CreateCommand();
						c.CommandText = string.Format(@"SELECT Oib, Ime, Prezime, Destinacija, Termin, Broj_kartice, Br_karta_djeca, Br_karta_odrasli, Cijena FROM Rezervacije WHERE Oib = {0}", entry1.Text);

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

					nodeview1.AppendColumn("Cijena", new Gtk.CellRendererText(), "text", 8);
					z++;
				}
				nodeview1.NodeSelection.Changed += this.RowSelected;

			}
		}

		protected void RowSelected(object sender, EventArgs e)
		{
			var selectedRezervacija = (RezervacijaNode)nodeview1.NodeSelection.SelectedNode;
		}
		//button za brisanje klik
		protected void OnButton10Clicked(object sender, EventArgs e)
		{
			var zabrisanje = (RezervacijaNode)nodeview1.NodeSelection.SelectedNode;
			if (zabrisanje == null) 
			{
			PregledRezervacijaDialog win1 = new PregledRezervacijaDialog();
			win1.Show();	
			}

			else if (zabrisanje.Broj_kartice == entry2.Text)
			{
				
				string x = zabrisanje.Broj_kartice;

				//brisanje rezervacije iz baze
				string connectionString = "URI=file:bazapodataka.db";
				SqliteConnection con = new SqliteConnection(connectionString);
				con.Open();
					SqliteCommand c = con.CreateCommand();
					c.CommandText = string.Format(@"DELETE FROM Rezervacije WHERE Broj_kartice = {0} AND Termin = '{1}' AND Destinacija = '{2}' AND Br_karta_djeca = {3} AND Br_karta_odrasli = {4}", x, zabrisanje.Termin, zabrisanje.Destinacija, zabrisanje.Br_karta_djeca, zabrisanje.Br_karta_odrasli);
					c.ExecuteNonQuery();
				c.Dispose();
				con.Close();

				// dodavanje mjesta od izbrisane rezervacije
				int u = Convert.ToInt32(zabrisanje.Br_karta_djeca);
				int o = Convert.ToInt32(zabrisanje.Br_karta_odrasli);
				int r = o + u;
				string connectionStrin = "URI=file:bazapodataka.db";
				SqliteConnection conn = new SqliteConnection(connectionStrin);
				conn.Open();
								SqliteCommand ci = conn.CreateCommand();
								ci.CommandText = string.Format(@"UPDATE Termini SET Kapacitet = Kapacitet + {0} WHERE Nacionalnipark = '{1}' AND Datum = '{2}'", r, zabrisanje.Destinacija, zabrisanje.Termin);
				//crash kod execute, vjerojatno zbog nodeview-a
								ci.ExecuteNonQuery();
				ci.Dispose();
				conn.Close();

				PregledRezervacijaDialog2 win1 = new PregledRezervacijaDialog2();
				win1.Show();

				//dio gdje je automatski refresh
				rezervacijeizbaze.Clear();	
			
				string connectionStringg = "URI=file:bazapodataka.db";
SqliteConnection connn = new SqliteConnection(connectionStringg);
connn.Open();
						SqliteCommand cc = connn.CreateCommand();
cc.CommandText = string.Format(@"SELECT Oib, Ime, Prezime, Destinacija, Termin, Broj_kartice, Br_karta_djeca, Br_karta_odrasli, Cijena FROM Rezervacije WHERE Oib = {0}", entry1.Text);

SqliteDataReader readerr = cc.ExecuteReader();
									while (readerr.Read())
									{
										Rezervacija a = new Rezervacija();
										a.Oib = (string)readerr["Oib"];
										a.Ime = (string)readerr["Ime"];
										a.Prezime = (string)readerr["Prezime"];
										a.Destinacija = (string)readerr["Destinacija"];
										a.Termin = (string)readerr["Termin"];
										a.Broj_kartice = (string)readerr["Broj_kartice"];
										a.Br_karta_djeca = (int)readerr["Br_karta_djeca"];
										a.Br_karta_odrasli = (int)readerr["Br_karta_odrasli"];
										a.Cijena = (int)readerr["Cijena"];

										rezervacijeizbaze.Add(a);
									}
				cc.Dispose();
				connn.Close();


				RezervacijePresenter = new RezervacijaNodeStore();
				RezervacijePresenter.Dodaj(rezervacijeizbaze);

				nodeview1.NodeStore = RezervacijePresenter;
				nodeview1.NodeSelection.Changed += this.RowSelected;
				entry2.Text = string.Empty;
				entry1.Text = string.Empty;
			}

			else 
			{
				PregledRezervacijaDialog win1 = new PregledRezervacijaDialog();
				win1.Show();
			}
		}
	}
}
