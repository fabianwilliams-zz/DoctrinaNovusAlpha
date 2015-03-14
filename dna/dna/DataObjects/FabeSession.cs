using System;

namespace dna
{
	public class FabeSession
	{
		public string SessionName {get; set;}
		public string SessionDesc {
			get;
			set;
		}
		public string EventName {
			get;
			set;
		}
		public string SpeakerName {
			get;
			set;
		}

		//simple cheat way to make sure that when invoked this will return the session name
		//cheat to use complex objects as my item source for ListView Source which returns
		//a ToString method

		public override string ToString ()
		{
			return string.Format ("[FabeSession: SessionName={0}, SessionDesc={1}, EventName={2}, SpeakerName{3}]", SessionName, SessionDesc, EventName, SpeakerName);
		}
			
	}
		

}

