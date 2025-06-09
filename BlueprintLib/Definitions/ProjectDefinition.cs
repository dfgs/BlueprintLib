using System;
using System.Collections.Generic;
using System.Text;

namespace BlueprintLib.Definitions
{
	public class ProjectDefinition : ObjectDefinition
	{
		public List<ClassDefinition> Classes
		{
			get;
			private set;
		}

		public ProjectDefinition()
		{
			Classes = new List<ClassDefinition>();
		}
	}
}
