using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void ndler (object sender, EventArgs e)
	{
		throw new NotImplementedException ();
	}

	protected void OnVoteClicked (object sender, EventArgs e)
	{
		Console.WriteLine ("You clicked vote");
	}

	protected void onChooseOtherClicked (object sender, EventArgs e)
	{
		Console.WriteLine ("You clicked choose other");
	}

	protected void OnCancelClicked (object sender, EventArgs e)
	{
		Console.WriteLine ("You clicked cancel");
	}
}
