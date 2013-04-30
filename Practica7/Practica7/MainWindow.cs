using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	
	}





	protected void OnBotonterminarClicked (object sender, EventArgs e)
	{
		int puntos = 0;
		
		if(this.opcc.Active)
			puntos++;
		
		if(this.sum1.Text=="4")
			puntos++;


		if (this.argentina.Active && this.mexico.Active  )
			puntos++;

		DateTime fecha = this.calendario.GetDate();
		String fechaSeleccionada = fecha.ToShortDateString();
		if (fechaSeleccionada == "16/09/1810") 
			puntos++;
		this.entry3.Text = puntos.ToString();
		
	}
}
