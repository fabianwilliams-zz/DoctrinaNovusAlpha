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

		//simple cheat way to make sure that when invoked this will return the session name
		//cheat to use complex objects as my item source for ListView Source which returns
		//a ToString method
		public override string ToString ()
		{
			return SessionName;
		}
			
	}
		

}

