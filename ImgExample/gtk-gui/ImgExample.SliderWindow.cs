
// This file has been generated by the GUI designer. Do not modify.
namespace ImgExample
{
	public partial class SliderWindow
	{
		private global::Gtk.VPaned vpaned1;
		
		private global::Gtk.HScale hscale3;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ImgExample.SliderWindow
			this.WidthRequest = 200;
			this.HeightRequest = 50;
			this.Name = "ImgExample.SliderWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("SliderWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			this.AllowGrow = false;
			this.DefaultWidth = 200;
			this.DefaultHeight = 50;
			this.DestroyWithParent = true;
			// Container child ImgExample.SliderWindow.Gtk.Container+ContainerChild
			this.vpaned1 = new global::Gtk.VPaned ();
			this.vpaned1.CanFocus = true;
			this.vpaned1.Name = "vpaned1";
			this.vpaned1.Position = 39;
			// Container child vpaned1.Gtk.Paned+PanedChild
			this.hscale3 = new global::Gtk.HScale (null);
			this.hscale3.CanFocus = true;
			this.hscale3.Name = "hscale3";
			this.hscale3.Adjustment.Upper = 100D;
			this.hscale3.Adjustment.PageIncrement = 10D;
			this.hscale3.Adjustment.StepIncrement = 1D;
			this.hscale3.Adjustment.Value = 100D;
			this.hscale3.DrawValue = true;
			this.hscale3.Digits = 0;
			this.hscale3.ValuePos = ((global::Gtk.PositionType)(2));
			this.vpaned1.Add (this.hscale3);
			global::Gtk.Paned.PanedChild w1 = ((global::Gtk.Paned.PanedChild)(this.vpaned1 [this.hscale3]));
			w1.Resize = false;
			this.Add (this.vpaned1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.hscale3.ValueChanged += new global::System.EventHandler (this.change_value);
		}
	}
}
