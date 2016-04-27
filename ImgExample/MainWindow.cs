using System;
using Gtk;
using Gdk;
using ImgExample;

public partial class MainWindow: Gtk.Window
{
	//ładowanie obrazka z zasobów
	Gtk.Image img = Gtk.Image.LoadFromResource ("ImgExample.a.jpg");

	//okno do regulacji jasności
	SliderWindow sb = new SliderWindow ();

	//okno do regulacji rozmiaru 
	SliderWindow ss = new SliderWindow ();

	//konstruktor klasy MainWindow
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();

		sb.Title = "Jasność";
		ss.Title = "Rozmiar";

		//ukrycie i pokazanie okien SliderWindow
		//aby nie było przykryte przez okno MainWindow
		//zastanówcie się, czy da się to zrobić inaczej?
		sb.Hide ();
		sb.Show ();

		ss.Hide ();
		ss.Show ();

		//delegowanie funkcji
		ss.setFunction (this.set_size);
		sb.setFunction (this.set_brithness);

		//załadowanie obrazka
		this.image.Pixbuf = img.Pixbuf;
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	public void set_brithness (uint b)
	{
		//ponieważ C# korzysta z referencji
		//proste przypisanie (znak = ) skutkowało 
		//by tylko przypisaniem adresu do 
		//obrazka załadowanego na początku musimy 
		//wykorzystać metodę Copy()
		////////////////////////////////////////////////
		//warto sprawdzić co się stanie, gdy ją usuniemy
		Pixbuf tmp = this.img.Pixbuf.Copy();

		//a tutaj sprytne przyciemnianie do wykorzystania
		//w programie z żarówką
		////////////////////////////////////////////////
		//funkcja SaturateAndPixelate() operuję na obiekcie
		//Pixbuf i umożliwia zmianę nasycenia kolorów
		//zmiana drugiego parametru w zakresie od 0...1 
		//powoduje stworzenie obrazu czarnobiałego
		///////////////////////////////////////////////
		//wykorzystanie właściwości "pixalete" pozwala
		//na symulowanie wygaszenia żarówki
		//jest to jedną z możliwych rozwiązań

		if(b > 5)
			tmp.SaturateAndPixelate (tmp, (b / 100.0f), false);
		else
			tmp.SaturateAndPixelate (tmp, (b / 100.0f), true);

		this.image.Pixbuf = tmp;
	}

	public void set_size(uint s) 
	{
		//skalowanie
		int new_width = (int)(s * this.img.Pixbuf.Width)/100;
		int new_height = (int)(s * this.img.Pixbuf.Height)/100;
		this.image.Pixbuf = this.img.Pixbuf.ScaleSimple (new_width, new_height, InterpType.Nearest);
	}
}
