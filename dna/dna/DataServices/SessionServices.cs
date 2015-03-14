using System;
using System.Collections.Generic;
namespace dna
{
	public class SessionServices
	{

		public static List<FabeSession> GetAllSessions()
		{
			var fs = new List<FabeSession> ();

			fs.Add (new FabeSession {
				SessionName = "Is SharePoint Hybrid Right for you?",
				SessionDesc = "Come learn about Hybrid from Fabian Williams",
				EventName = "SharePoint Evolutions Conference London",
				SpeakerName = "Fabian Williams"
			});

			fs.Add (new FabeSession {
				SessionName = "Explore Azure Mobile Service with Xamarin",
				SessionDesc = "Cool stuff with Xamarin and Azure",
				EventName = "SharePoint Evolutions Conference London",
				SpeakerName = "Fabian Williams"
			});

			fs.Add (new FabeSession {
				SessionName = "PreCon with William Baer and Friends",
				SessionDesc = "An end to end day of training about SharePoint Hybrid",
				EventName = "Microsoft Ignite Conference Chicago",
				SpeakerName = "William Baer, Steve Peschka, Fabian Williams, et al"
			});

			return fs;

		}



		public SessionServices ()
		{
		}
	}
}

