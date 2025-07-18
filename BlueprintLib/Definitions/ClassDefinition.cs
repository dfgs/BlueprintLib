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
	public class ClassDefinition : ObjectDefinition, IAttributeContainer,INamed
	{

		IEnumerable<AttributeDefinition> IAttributeContainer.Attributes => Attributes;
		public List<AttributeDefinition> Attributes
		{
			get;
			set;
		}

		[XmlAttribute]
		public string Namespace { get;  set; }
		[XmlAttribute]
		public string Name { get;  set; }

		public List<PropertyDefinition> Properties
		{
			get;
			private set;
		}


		public  ClassDefinition()
		{
			this.Attributes = new List<AttributeDefinition>();
			this.Properties = new List<PropertyDefinition>();
			Namespace = "Undefined";Name = "Undefined";
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
