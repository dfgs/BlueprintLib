using BlueprintLib.Definitions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BlueprintLib
{
	public class ClassDefinition : ObjectDefinition
	{

		public List<AttributeDefinition> Attributes
		{
			get;
			private set;
		}
		public string Namespace { get; private set; }
		public string Name { get; private set; }

		public List<PropertyDefinition> Properties
		{
			get;
			private set;
		}

		public ClassDefinition(string Namespace,  string Name) : base()
		{
			this.Attributes = new List<AttributeDefinition>();
			this.Properties = new List<PropertyDefinition>();
			this.Namespace = Namespace; this.Name = Name;
		}
		public override string ToString()
		{
			return $$"""[{{string.Join(",", Attributes)}}]{{"\r\n"}}{{Name}}{{"\r\n"}}{{{"\r\n\t"}}{{string.Join("\r\n	",Properties)}}{{"\r\n"}}}""" ;
		}





	}
}
