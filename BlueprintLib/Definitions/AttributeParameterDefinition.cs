using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BlueprintLib
{
	[Serializable]
	public class AttributeParameterDefinition : ObjectDefinition
	{

		[XmlAttribute]
		public string Name { get;  set; }
		[XmlAttribute]
		public string? Value { get;  set; }

		public AttributeParameterDefinition() : base()
		{
			this.Name = "Undefined";
		}

		public AttributeParameterDefinition( string Name, string? Value) : base()
		{
			this.Name = Name;
			this.Value = Value;
		}
		public override string ToString()
		{
			return $"{Name} = {Value}";
		}





	}
}
