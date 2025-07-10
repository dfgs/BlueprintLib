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
	public class DTO 
	{
		[XmlIgnore]
		public string Name
		{
			get; set;
		}

			


		public List<AttributeDefinition> Attributes
		{
			get;
			set;
		}

		public List<PropertyDefinition> Properties
		{
			get;
			private set;
		}

		public  DTO()
		{
			this.Name = "Undefined";
			this.Attributes = new List<AttributeDefinition>();
			this.Properties = new List<PropertyDefinition>();
		}

		/*
		public override string ToString()
		{
			return $$"""[{{string.Join(",", Attributes)}}]{{"\r\n"}}{{Name}}{{"\r\n"}}{{{"\r\n\t"}}{{string.Join("\r\n	",Properties)}}{{"\r\n"}}}""" ;
		}
		*/




	}
}
