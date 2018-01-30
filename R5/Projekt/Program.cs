using System;
using Gtk;
using System.Collections.Generic;
using System.Data;
namespace Projekt
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Application.Init();
			MainWindow win = new MainWindow();
			win.Show();
			Application.Run();

		}
	}
}
