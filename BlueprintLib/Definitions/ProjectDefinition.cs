using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BlueprintLib.Definitions
{
	[Serializable]
	public class ProjectDefinition : ObjectDefinition
	{
		[XmlAttribute]
		public string AssemblyName
		{
			get;
			set;
		}

			
		public List<ClassDefinition> Classes
		{
			get;
			set;
		}

		public List<string> References
		{
			get;
			set;
		}

		public ProjectDefinition()
		{
			this.AssemblyName = "Undefined";
			Classes = new List<ClassDefinition>();
			References = new List<string>();
		}
		public ProjectDefinition(string AssemblyName)
		{
			this.AssemblyName = AssemblyName;
			Classes = new List<ClassDefinition>();
			References = new List<string>();
		}
		public override string ToString()
		{
			return $$"""{{AssemblyName}}{{"\r\n"}}{{{"\r\n\t"}}{{string.Join("\r\n	", Classes)}}{{"\r\n"}}}{{string.Join("\r\n	", References)}}""";
		}

	}
}
