using System;

using Xamarin.Forms;

namespace dna
{
	public class App : Application
	{
		public App ()
		{
			//EntryPoint
			//previously this was a void page returned
			//now you need to set the MainPage to your class if you are not defining 
			//the page inside the default class as in my case dna.cs
			MainPage =  new EntryPageAlpha();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

