using System;
using System.Collections.Generic;
using System.Text;

namespace BlueprintLib.Definitions
{
	public class ProjectDefinition : ObjectDefinition
	{
		public string AssemblyName
		{
			get;
			private set;
		}

			
		public List<ClassDefinition> Classes
		{
			get;
			private set;
		}

		public ProjectDefinition(string AssemblyName)
		{
			this.AssemblyName = AssemblyName;
			Classes = new List<ClassDefinition>();
		}
	}
}
