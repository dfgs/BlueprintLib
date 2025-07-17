using BlueprintLib.Definitions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BlueprintLib
{
	[Serializable]
	public class AttributeParameterDefinition : ObjectDefinition, INamed
	{

		[XmlAttribute]
		public string Name { get;  set; }
		[XmlAttribute]
		public string? Value { get; set; }
		[XmlAttribute]
		public bool IsString { get; set; }

		public AttributeParameterDefinition() : base()
		{
			this.Name = "Undefined";IsString = true;
		}

		public AttributeParameterDefinition( string Name, string? Value) : base()
		{
			this.Name = Name;
			this.Value = Value;
			this.IsString = true;
		}
		public override string ToString()
		{
			if (IsString) return $"{Name} = \"{Value}\"";
			else return $"{Name} = {Value}";
		}





	}
}
