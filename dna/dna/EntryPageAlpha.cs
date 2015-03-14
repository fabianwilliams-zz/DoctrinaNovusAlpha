using System;
using System.Diagnostics;
using System.Linq;
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
				"echo",
				"foxtrot",
				"golf",
				"hotel",
				"india",
				"juliet"

			};

			var listview1 = new ListView ();
			//using the below line it will set it to everything in the array

			//listview1.ItemsSource = fabianlist;

			//using the linq query below i can filter out because ListView is an IEnumerable
			//so i can feed it a source of information and use linq query
			/*
			listview1.ItemsSource = 
				from c in fabianlist
			 	where c.Contains ("o") //this can be anything but i am picking a vowel
				select c;
			*/

			//using the below takes the simple class above by binding to a Complex type
			//which will be more that what is going to be the case. 
			listview1.ItemsSource = SessionServices.GetAllSessions();

			listview1.ItemSelected += (sender, e) => {
				Debug.WriteLine("You clicked: " + e.SelectedItem);
			};

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
