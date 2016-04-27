using System;
using Gtk;

namespace ImgExample
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();

			//wywołanie konstruktora okna z suwakiem -  SliderWindow 
			//znajduję się w kodzie okna głównego
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}
	}
}
