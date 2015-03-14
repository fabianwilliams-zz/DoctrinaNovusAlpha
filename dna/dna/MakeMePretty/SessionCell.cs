using System;
using Xamarin.Forms;

namespace dna
{
	public class SessionCell: ViewCell
	{
		public SessionCell ()
		{
			var sessionNameLabel = new Label {
				Font = Font.SystemFontOfSize (NamedSize.Medium)
			};

			sessionNameLabel.SetBinding (Label.TextProperty, new Binding ("SessionName"));

			var sessionDescLabel = new Label {
				Font = Font.SystemFontOfSize (NamedSize.Micro)
			};
			sessionDescLabel.SetBinding (Label.TextProperty, new Binding ("SessionDesc"));

			var speakerLabel = new Label {
				Font = Font.SystemFontOfSize (NamedSize.Micro),
				XAlign = TextAlignment.End,
				HorizontalOptions = LayoutOptions.FillAndExpand
			};
			speakerLabel.SetBinding (Label.TextProperty, new Binding ("SpeakerName"));

			View = new StackLayout {
				Children = { sessionNameLabel, speakerLabel },
				Orientation = StackOrientation.Horizontal
			};
		}
	}
}
