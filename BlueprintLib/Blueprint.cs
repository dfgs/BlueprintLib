using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace BlueprintLib
{
	public class Blueprint
	{
		public string FileName
		{
			get;
			private set ;
		}

		public  string Content
		{
			get;
			private set;
		}

		private Blueprint()
		{
			FileName= string.Empty;
			Content= string.Empty;
		}

		public Blueprint(string FileName, string Content)
		{
			this.FileName = FileName;
			this.Content = Content;
		}
	}

}
