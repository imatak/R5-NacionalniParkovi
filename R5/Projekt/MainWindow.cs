using System;
using Gtk;
using System.Data;
using System.Collections.Generic;
using Projekt;
public partial class MainWindow : Gtk.Window
{
	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	protected void OnButton3Clicked(object sender, EventArgs e)
	{
		label1.Hide();
		image4.Hide();
		zavoditeljewidget1.Hide();
		rezervacijawidget1.Hide();
		pregledrezervacijawidget1.Hide();
		nacionalniparkoviwidget1.Show();
	}

	protected void OnButton4Clicked(object sender, EventArgs e)
	{
		label1.Hide();
		image4.Hide();
		zavoditeljewidget1.Hide();
		nacionalniparkoviwidget1.Hide();
		pregledrezervacijawidget1.Hide();
		rezervacijawidget1.Show();
	}

	protected void OnButton5Clicked(object sender, EventArgs e)
	{
		label1.Hide();
		image4.Hide();
		zavoditeljewidget1.Hide();
		nacionalniparkoviwidget1.Hide();
		rezervacijawidget1.Hide();
		pregledrezervacijawidget1.Show();
	}

	protected void OnButton6Clicked(object sender, EventArgs e)
	{
		label1.Hide();
		image4.Hide();
		pregledrezervacijawidget1.Hide();
		nacionalniparkoviwidget1.Hide();
		rezervacijawidget1.Hide();
		zavoditeljewidget1.Show();
	}

}



