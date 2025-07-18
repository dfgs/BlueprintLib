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
			this.Classes = new List<ClassDefinition>();
			this.References = new List<string>();
		}
		public ProjectDefinition(string AssemblyName)
		{
			this.AssemblyName = AssemblyName;
			this.Classes = new List<ClassDefinition>();
			this.References = new List<string>();
		}
		public override string ToString()
		{
			return 
				$$"""
				{{AssemblyName}}
				{
					{{string.Join("\r\n\t", Classes.SelectMany(item=>item.ToString().Split('\r','\n').Where(item=>!string.IsNullOrEmpty(item)))) }}
					References:
					{{string.Join("\r\n\t", References)}}
				}
				""";
		}

		

	}
}
