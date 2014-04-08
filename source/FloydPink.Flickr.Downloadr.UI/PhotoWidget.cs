﻿using System;
using FloydPink.Flickr.Downloadr.Model;

namespace FloydPink.Flickr.Downloadr
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class PhotoWidget : Gtk.Bin
	{
		string _imageUrl;

		public string ImageUrl {
			get {
				return _imageUrl;
			}
			set {
				_imageUrl = value;
				if (!string.IsNullOrEmpty (_imageUrl)) {
					imageMain.SetCachedImage (value);
				}
			}
		}

		bool _isSelected;

		public bool IsSelected {
			get {
				return _isSelected;
			}
			set {
				if (_isSelected != value) {
					_isSelected = value;
					frameLabel.LabelProp = _isSelected ? 
						"<span color=\"blue\" size=\"x-large\"><b><big> ★ </big></b></span>" :
						"<span color=\"silver\" size=\"x-large\"><b><big> ☆ </big></b></span>";
					if (_isSelected) {
						frameMain.ModifyBg (Gtk.StateType.Normal, new Gdk.Color (125, 125, 255));
					} else {
						frameMain.ModifyBg (Gtk.StateType.Normal);
					}
					if (SelectionChanged != null) {
						SelectionChanged (this, new EventArgs ());
					}
				}
			}
		}

		public Photo Photo { get; set; }

		public event EventHandler SelectionChanged;

		public PhotoWidget ()
		{
			this.Build ();
		}

		protected void imageClick (object o, Gtk.ButtonPressEventArgs args)
		{
			IsSelected = !IsSelected;
		}
	}
}
