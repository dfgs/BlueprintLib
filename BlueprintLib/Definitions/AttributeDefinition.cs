using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BlueprintLib
{
	[Serializable]
	public class AttributeDefinition : ObjectDefinition
	{
		public List<AttributeParameterDefinition> Parameters
		{
			get;
			private set;
		}
		[XmlAttribute]
		public string Name { get;  set; }

		public AttributeDefinition( ) : base()
		{
			this.Parameters = new List<AttributeParameterDefinition>();
			this.Name = "Undefined";
		}
		public AttributeDefinition( string Name) : base()
		{
			this.Parameters = new List<AttributeParameterDefinition>();
			this.Name = Name;
		}
		public override string ToString()
		{
			return $$"""{{Name}}({{string.Join(", ",Parameters)}})""";
		}





	}
}
