using System;
using System.Collections.Generic;
namespace Projekt
{
	public class RezervacijaNodeStore : Gtk.NodeStore
	{
		public RezervacijaNodeStore() : base(typeof(RezervacijaNode))
		{
		}

		public void Add(Rezervacija a) 
		{
			this.AddNode(new RezervacijaNode(a));
		}

		public void Dodaj( List <Rezervacija> stavke) 
		{
			foreach (var a in stavke) 
			{
				this.Add(a);
			}
		}


	}
}
