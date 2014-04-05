
// This file has been generated by the GUI designer. Do not modify.
namespace FloydPink.Flickr.Downloadr
{
	public partial class BrowserWindow
	{
		private global::Gtk.VBox vbox3;
		private global::Gtk.ScrolledWindow scrolledwindowPhotosContainer;
		private global::Gtk.TreeView treeviewPhotos;
		private global::Gtk.HBox hbox1;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Button buttonBack;
		private global::Gtk.ToggleButton togglebuttonShowAllPhotos;
		private global::Gtk.HBox hbox5;
		private global::Gtk.Button buttonSelectAll;
		private global::Gtk.Button buttonUnSelectAll;
		private global::Gtk.Alignment alignment1;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Button buttonFirstPage;
		private global::Gtk.Button buttonPreviousPage;
		private global::Gtk.VBox vbox4;
		private global::Gtk.Label labelPhotos;
		private global::Gtk.Label labelPages;
		private global::Gtk.Button buttonNextPage;
		private global::Gtk.Button buttonLastPage;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Label label1;
		private global::Gtk.Button buttonDownloadSelection;
		private global::Gtk.Button buttonDownloadThisPage;
		private global::Gtk.Button buttonDownloadAllPages;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget FloydPink.Flickr.Downloadr.BrowserWindow
			this.WidthRequest = 950;
			this.HeightRequest = 600;
			this.Name = "FloydPink.Flickr.Downloadr.BrowserWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("Photo Browser - flickr downloadr");
			this.Icon = global::Gdk.Pixbuf.LoadFromResource ("FloydPink.Flickr.Downloadr.Assets.icon.png");
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			this.Resizable = false;
			this.AllowGrow = false;
			// Container child FloydPink.Flickr.Downloadr.BrowserWindow.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			this.vbox3.BorderWidth = ((uint)(10));
			// Container child vbox3.Gtk.Box+BoxChild
			this.scrolledwindowPhotosContainer = new global::Gtk.ScrolledWindow ();
			this.scrolledwindowPhotosContainer.Name = "scrolledwindowPhotosContainer";
			this.scrolledwindowPhotosContainer.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindowPhotosContainer.Gtk.Container+ContainerChild
			this.treeviewPhotos = new global::Gtk.TreeView ();
			this.treeviewPhotos.CanFocus = true;
			this.treeviewPhotos.Name = "treeviewPhotos";
			this.treeviewPhotos.HeadersVisible = false;
			this.scrolledwindowPhotosContainer.Add (this.treeviewPhotos);
			this.vbox3.Add (this.scrolledwindowPhotosContainer);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.scrolledwindowPhotosContainer]));
			w2.Position = 0;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Homogeneous = true;
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonBack = new global::Gtk.Button ();
			this.buttonBack.WidthRequest = 75;
			this.buttonBack.CanFocus = true;
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.UseUnderline = true;
			this.buttonBack.Label = global::Mono.Unix.Catalog.GetString ("Back");
			this.hbox2.Add (this.buttonBack);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.buttonBack]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.togglebuttonShowAllPhotos = new global::Gtk.ToggleButton ();
			this.togglebuttonShowAllPhotos.CanFocus = true;
			this.togglebuttonShowAllPhotos.Name = "togglebuttonShowAllPhotos";
			this.togglebuttonShowAllPhotos.UseUnderline = true;
			this.togglebuttonShowAllPhotos.Inconsistent = true;
			this.togglebuttonShowAllPhotos.Label = global::Mono.Unix.Catalog.GetString ("Show All Photos");
			this.hbox2.Add (this.togglebuttonShowAllPhotos);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.togglebuttonShowAllPhotos]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.buttonSelectAll = new global::Gtk.Button ();
			this.buttonSelectAll.WidthRequest = 35;
			this.buttonSelectAll.CanFocus = true;
			this.buttonSelectAll.Name = "buttonSelectAll";
			this.buttonSelectAll.UseUnderline = true;
			this.buttonSelectAll.Label = global::Mono.Unix.Catalog.GetString ("☑");
			this.hbox5.Add (this.buttonSelectAll);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.buttonSelectAll]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.buttonUnSelectAll = new global::Gtk.Button ();
			this.buttonUnSelectAll.WidthRequest = 35;
			this.buttonUnSelectAll.CanFocus = true;
			this.buttonUnSelectAll.Name = "buttonUnSelectAll";
			this.buttonUnSelectAll.UseUnderline = true;
			this.buttonUnSelectAll.Label = global::Mono.Unix.Catalog.GetString ("☒");
			this.hbox5.Add (this.buttonUnSelectAll);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.buttonUnSelectAll]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.hbox5.Add (this.alignment1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.alignment1]));
			w7.Position = 2;
			this.hbox2.Add (this.hbox5);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.hbox5]));
			w8.Position = 2;
			this.hbox1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.hbox2]));
			w9.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonFirstPage = new global::Gtk.Button ();
			this.buttonFirstPage.WidthRequest = 35;
			this.buttonFirstPage.CanFocus = true;
			this.buttonFirstPage.Name = "buttonFirstPage";
			this.buttonFirstPage.UseUnderline = true;
			this.buttonFirstPage.Label = global::Mono.Unix.Catalog.GetString ("| <<");
			this.hbox3.Add (this.buttonFirstPage);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.buttonFirstPage]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonPreviousPage = new global::Gtk.Button ();
			this.buttonPreviousPage.WidthRequest = 35;
			this.buttonPreviousPage.CanFocus = true;
			this.buttonPreviousPage.Name = "buttonPreviousPage";
			this.buttonPreviousPage.UseUnderline = true;
			this.buttonPreviousPage.Label = global::Mono.Unix.Catalog.GetString ("<");
			this.hbox3.Add (this.buttonPreviousPage);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.buttonPreviousPage]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.labelPhotos = new global::Gtk.Label ();
			this.labelPhotos.Name = "labelPhotos";
			this.labelPhotos.LabelProp = global::Mono.Unix.Catalog.GetString ("<small>1  -  25  of  626  Photos</small>");
			this.labelPhotos.UseMarkup = true;
			this.vbox4.Add (this.labelPhotos);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.labelPhotos]));
			w12.Position = 0;
			// Container child vbox4.Gtk.Box+BoxChild
			this.labelPages = new global::Gtk.Label ();
			this.labelPages.Name = "labelPages";
			this.labelPages.LabelProp = global::Mono.Unix.Catalog.GetString ("<small>1  of  26  Pages</small>");
			this.labelPages.UseMarkup = true;
			this.vbox4.Add (this.labelPages);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.labelPages]));
			w13.Position = 1;
			this.hbox3.Add (this.vbox4);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.vbox4]));
			w14.Position = 2;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonNextPage = new global::Gtk.Button ();
			this.buttonNextPage.WidthRequest = 35;
			this.buttonNextPage.CanFocus = true;
			this.buttonNextPage.Name = "buttonNextPage";
			this.buttonNextPage.UseUnderline = true;
			this.buttonNextPage.Label = global::Mono.Unix.Catalog.GetString (">");
			this.hbox3.Add (this.buttonNextPage);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.buttonNextPage]));
			w15.Position = 3;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonLastPage = new global::Gtk.Button ();
			this.buttonLastPage.WidthRequest = 35;
			this.buttonLastPage.CanFocus = true;
			this.buttonLastPage.Name = "buttonLastPage";
			this.buttonLastPage.UseUnderline = true;
			this.buttonLastPage.Label = global::Mono.Unix.Catalog.GetString (">> |");
			this.hbox3.Add (this.buttonLastPage);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.buttonLastPage]));
			w16.Position = 4;
			w16.Expand = false;
			w16.Fill = false;
			this.hbox1.Add (this.hbox3);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.hbox3]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Download</b>");
			this.label1.UseMarkup = true;
			this.hbox4.Add (this.label1);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label1]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonDownloadSelection = new global::Gtk.Button ();
			this.buttonDownloadSelection.WidthRequest = 75;
			this.buttonDownloadSelection.CanFocus = true;
			this.buttonDownloadSelection.Name = "buttonDownloadSelection";
			this.buttonDownloadSelection.UseUnderline = true;
			this.buttonDownloadSelection.Label = global::Mono.Unix.Catalog.GetString ("Selection");
			this.hbox4.Add (this.buttonDownloadSelection);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.buttonDownloadSelection]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonDownloadThisPage = new global::Gtk.Button ();
			this.buttonDownloadThisPage.WidthRequest = 75;
			this.buttonDownloadThisPage.CanFocus = true;
			this.buttonDownloadThisPage.Name = "buttonDownloadThisPage";
			this.buttonDownloadThisPage.UseUnderline = true;
			this.buttonDownloadThisPage.Label = global::Mono.Unix.Catalog.GetString ("This Page");
			this.hbox4.Add (this.buttonDownloadThisPage);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.buttonDownloadThisPage]));
			w20.Position = 2;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonDownloadAllPages = new global::Gtk.Button ();
			this.buttonDownloadAllPages.WidthRequest = 75;
			this.buttonDownloadAllPages.CanFocus = true;
			this.buttonDownloadAllPages.Name = "buttonDownloadAllPages";
			this.buttonDownloadAllPages.UseUnderline = true;
			this.buttonDownloadAllPages.Label = global::Mono.Unix.Catalog.GetString ("All Pages");
			this.hbox4.Add (this.buttonDownloadAllPages);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.buttonDownloadAllPages]));
			w21.Position = 3;
			w21.Expand = false;
			w21.Fill = false;
			this.hbox1.Add (this.hbox4);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.hbox4]));
			w22.Position = 2;
			w22.Fill = false;
			this.vbox3.Add (this.hbox1);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox1]));
			w23.Position = 1;
			w23.Expand = false;
			w23.Fill = false;
			this.Add (this.vbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 950;
			this.DefaultHeight = 600;
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.buttonBack.Clicked += new global::System.EventHandler (this.buttonBackClick);
		}
	}
}