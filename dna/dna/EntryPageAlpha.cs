using System;
using Xamarin.Forms;

namespace dna
{
	//creating a class myself that inhertis from Content Page
	//previously this was inside dna.cs but I want to extend it better
	//in its own class
	/*
	MainPage = new ContentPage {
		Content = new StackLayout {
			VerticalOptions = LayoutOptions.Center,
			Children = {
				new Label {
					XAlign = TextAlignment.Center,
					Text = "Welcome to Xamarin Forms!"
				}
			}
		}
	};
	*/

	public class EntryPageAlpha : ContentPage
	{
		public EntryPageAlpha ()
		{
			var fabianlist = new[] {
				"alpha",
				"bravo",
				"charlie",
				"delta",
				"echo"
			};

			var listview1 = new ListView ();
			listview1.ItemsSource = fabianlist;

			var label1 = new Label {
				Text = "Fabian Learning Xamarin.Forms",
				Font = Font.SystemFontOfSize(NamedSize.Medium)
			};

			var entry1 = new Entry {
				Placeholder = "You can type something here"
			};

			var button1 = new Button {
				Text = "Click Me"
			};



			button1.Clicked += (sender, e) => {
				label1.Text = "User Typed: " + entry1.Text;
			};

			Content = new StackLayout{
				//by setting padding in this way allows for using the device class which
				//permits me to only set padding for ios since it is needed at the top
				Padding = new Thickness(0,Device.OnPlatform(20,0,0),0,0),
				Spacing = 10,
				Children = {label1,entry1,button1,listview1}
			};
		}
	}
}
