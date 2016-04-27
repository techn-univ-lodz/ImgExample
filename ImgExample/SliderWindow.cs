using System;
using Gtk;
using ImgExample;

namespace ImgExample
{
	public partial class SliderWindow : Gtk.Window
	{

		//pole przechowujące odwołanie do funkcji
		//wywoływanej z okna głównego, zależnie
		//od funkcji suwaka
		//WAŻNE pojęcie - DELEGATY
		public delegate void SendValue(uint v);
		SendValue f = null;

		//konstruktor
		public SliderWindow () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		public void setFunction( SendValue f)
		{
			this.f = f;
		}

		//wywoływane po zmianie wartości suwakiem
		//przekazywana jest wartość ustawiona na Sliderze
		//z zakresu 1...100
		//pole Value jest typu double, dlatego konieczne jest
		//rzutowanie (uint)()
		protected void change_value (object sender, EventArgs e)
		{
			this.f ((uint)this.hscale3.Value);
		}
			
	}
}

